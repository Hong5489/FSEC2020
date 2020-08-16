package android.support.p003v7.util;

import android.support.p003v7.util.ThreadUtil.BackgroundCallback;
import android.support.p003v7.util.ThreadUtil.MainThreadCallback;
import android.support.p003v7.util.TileList.Tile;
import android.util.Log;
import android.util.SparseBooleanArray;
import android.util.SparseIntArray;

/* renamed from: android.support.v7.util.AsyncListUtil */
public class AsyncListUtil<T> {
    static final boolean DEBUG = false;
    static final String TAG = "AsyncListUtil";
    boolean mAllowScrollHints;
    private final BackgroundCallback<T> mBackgroundCallback = new BackgroundCallback<T>() {
        private int mFirstRequiredTileStart;
        private int mGeneration;
        private int mItemCount;
        private int mLastRequiredTileStart;
        final SparseBooleanArray mLoadedTiles = new SparseBooleanArray();
        private Tile<T> mRecycledRoot;

        public void refresh(int i) {
            this.mGeneration = i;
            this.mLoadedTiles.clear();
            this.mItemCount = AsyncListUtil.this.mDataCallback.refreshData();
            AsyncListUtil.this.mMainThreadProxy.updateItemCount(this.mGeneration, this.mItemCount);
        }

        public void updateRange(int i, int i2, int i3, int i4, int i5) {
            if (i <= i2) {
                int tileStart = getTileStart(i);
                int tileStart2 = getTileStart(i2);
                this.mFirstRequiredTileStart = getTileStart(i3);
                this.mLastRequiredTileStart = getTileStart(i4);
                if (i5 == 1) {
                    requestTiles(this.mFirstRequiredTileStart, tileStart2, i5, true);
                    requestTiles(tileStart2 + AsyncListUtil.this.mTileSize, this.mLastRequiredTileStart, i5, false);
                } else {
                    requestTiles(tileStart, this.mLastRequiredTileStart, i5, false);
                    requestTiles(this.mFirstRequiredTileStart, tileStart - AsyncListUtil.this.mTileSize, i5, true);
                }
            }
        }

        private int getTileStart(int i) {
            return i - (i % AsyncListUtil.this.mTileSize);
        }

        private void requestTiles(int i, int i2, int i3, boolean z) {
            int i4 = i;
            while (i4 <= i2) {
                AsyncListUtil.this.mBackgroundProxy.loadTile(z ? (i2 + i) - i4 : i4, i3);
                i4 += AsyncListUtil.this.mTileSize;
            }
        }

        public void loadTile(int i, int i2) {
            if (!isTileLoaded(i)) {
                Tile acquireTile = acquireTile();
                acquireTile.mStartPosition = i;
                acquireTile.mItemCount = Math.min(AsyncListUtil.this.mTileSize, this.mItemCount - acquireTile.mStartPosition);
                AsyncListUtil.this.mDataCallback.fillData(acquireTile.mItems, acquireTile.mStartPosition, acquireTile.mItemCount);
                flushTileCache(i2);
                addTile(acquireTile);
            }
        }

        public void recycleTile(Tile<T> tile) {
            AsyncListUtil.this.mDataCallback.recycleData(tile.mItems, tile.mItemCount);
            tile.mNext = this.mRecycledRoot;
            this.mRecycledRoot = tile;
        }

        private Tile<T> acquireTile() {
            Tile<T> tile = this.mRecycledRoot;
            if (tile == null) {
                return new Tile<>(AsyncListUtil.this.mTClass, AsyncListUtil.this.mTileSize);
            }
            this.mRecycledRoot = tile.mNext;
            return tile;
        }

        private boolean isTileLoaded(int i) {
            return this.mLoadedTiles.get(i);
        }

        private void addTile(Tile<T> tile) {
            this.mLoadedTiles.put(tile.mStartPosition, true);
            AsyncListUtil.this.mMainThreadProxy.addTile(this.mGeneration, tile);
        }

        private void removeTile(int i) {
            this.mLoadedTiles.delete(i);
            AsyncListUtil.this.mMainThreadProxy.removeTile(this.mGeneration, i);
        }

        private void flushTileCache(int i) {
            int maxCachedTiles = AsyncListUtil.this.mDataCallback.getMaxCachedTiles();
            while (this.mLoadedTiles.size() >= maxCachedTiles) {
                int keyAt = this.mLoadedTiles.keyAt(0);
                SparseBooleanArray sparseBooleanArray = this.mLoadedTiles;
                int keyAt2 = sparseBooleanArray.keyAt(sparseBooleanArray.size() - 1);
                int i2 = this.mFirstRequiredTileStart - keyAt;
                int i3 = keyAt2 - this.mLastRequiredTileStart;
                if (i2 > 0 && (i2 >= i3 || i == 2)) {
                    removeTile(keyAt);
                } else if (i3 <= 0) {
                    return;
                } else {
                    if (i2 < i3 || i == 1) {
                        removeTile(keyAt2);
                    } else {
                        return;
                    }
                }
            }
        }

        private void log(String str, Object... objArr) {
            StringBuilder sb = new StringBuilder();
            sb.append("[BKGR] ");
            sb.append(String.format(str, objArr));
            Log.d(AsyncListUtil.TAG, sb.toString());
        }
    };
    final BackgroundCallback<T> mBackgroundProxy;
    final DataCallback<T> mDataCallback;
    int mDisplayedGeneration = 0;
    int mItemCount = 0;
    private final MainThreadCallback<T> mMainThreadCallback = new MainThreadCallback<T>() {
        public void updateItemCount(int i, int i2) {
            if (isRequestedGeneration(i)) {
                AsyncListUtil asyncListUtil = AsyncListUtil.this;
                asyncListUtil.mItemCount = i2;
                asyncListUtil.mViewCallback.onDataRefresh();
                AsyncListUtil asyncListUtil2 = AsyncListUtil.this;
                asyncListUtil2.mDisplayedGeneration = asyncListUtil2.mRequestedGeneration;
                recycleAllTiles();
                AsyncListUtil asyncListUtil3 = AsyncListUtil.this;
                asyncListUtil3.mAllowScrollHints = false;
                asyncListUtil3.updateRange();
            }
        }

        public void addTile(int i, Tile<T> tile) {
            if (!isRequestedGeneration(i)) {
                AsyncListUtil.this.mBackgroundProxy.recycleTile(tile);
                return;
            }
            Tile addOrReplace = AsyncListUtil.this.mTileList.addOrReplace(tile);
            if (addOrReplace != null) {
                StringBuilder sb = new StringBuilder();
                sb.append("duplicate tile @");
                sb.append(addOrReplace.mStartPosition);
                Log.e(AsyncListUtil.TAG, sb.toString());
                AsyncListUtil.this.mBackgroundProxy.recycleTile(addOrReplace);
            }
            int i2 = tile.mStartPosition + tile.mItemCount;
            int i3 = 0;
            while (i3 < AsyncListUtil.this.mMissingPositions.size()) {
                int keyAt = AsyncListUtil.this.mMissingPositions.keyAt(i3);
                if (tile.mStartPosition > keyAt || keyAt >= i2) {
                    i3++;
                } else {
                    AsyncListUtil.this.mMissingPositions.removeAt(i3);
                    AsyncListUtil.this.mViewCallback.onItemLoaded(keyAt);
                }
            }
        }

        public void removeTile(int i, int i2) {
            if (isRequestedGeneration(i)) {
                Tile removeAtPos = AsyncListUtil.this.mTileList.removeAtPos(i2);
                if (removeAtPos == null) {
                    StringBuilder sb = new StringBuilder();
                    sb.append("tile not found @");
                    sb.append(i2);
                    Log.e(AsyncListUtil.TAG, sb.toString());
                    return;
                }
                AsyncListUtil.this.mBackgroundProxy.recycleTile(removeAtPos);
            }
        }

        private void recycleAllTiles() {
            for (int i = 0; i < AsyncListUtil.this.mTileList.size(); i++) {
                AsyncListUtil.this.mBackgroundProxy.recycleTile(AsyncListUtil.this.mTileList.getAtIndex(i));
            }
            AsyncListUtil.this.mTileList.clear();
        }

        private boolean isRequestedGeneration(int i) {
            return i == AsyncListUtil.this.mRequestedGeneration;
        }
    };
    final MainThreadCallback<T> mMainThreadProxy;
    final SparseIntArray mMissingPositions = new SparseIntArray();
    final int[] mPrevRange = new int[2];
    int mRequestedGeneration = this.mDisplayedGeneration;
    private int mScrollHint = 0;
    final Class<T> mTClass;
    final TileList<T> mTileList;
    final int mTileSize;
    final int[] mTmpRange = new int[2];
    final int[] mTmpRangeExtended = new int[2];
    final ViewCallback mViewCallback;

    /* renamed from: android.support.v7.util.AsyncListUtil$DataCallback */
    public static abstract class DataCallback<T> {
        public abstract void fillData(T[] tArr, int i, int i2);

        public int getMaxCachedTiles() {
            return 10;
        }

        public void recycleData(T[] tArr, int i) {
        }

        public abstract int refreshData();
    }

    /* renamed from: android.support.v7.util.AsyncListUtil$ViewCallback */
    public static abstract class ViewCallback {
        public static final int HINT_SCROLL_ASC = 2;
        public static final int HINT_SCROLL_DESC = 1;
        public static final int HINT_SCROLL_NONE = 0;

        public abstract void getItemRangeInto(int[] iArr);

        public abstract void onDataRefresh();

        public abstract void onItemLoaded(int i);

        public void extendRangeInto(int[] iArr, int[] iArr2, int i) {
            int i2 = (iArr[1] - iArr[0]) + 1;
            int i3 = i2 / 2;
            iArr2[0] = iArr[0] - (i == 1 ? i2 : i3);
            int i4 = iArr[1];
            if (i != 2) {
                i2 = i3;
            }
            iArr2[1] = i4 + i2;
        }
    }

    /* access modifiers changed from: 0000 */
    public void log(String str, Object... objArr) {
        StringBuilder sb = new StringBuilder();
        sb.append("[MAIN] ");
        sb.append(String.format(str, objArr));
        Log.d(TAG, sb.toString());
    }

    public AsyncListUtil(Class<T> cls, int i, DataCallback<T> dataCallback, ViewCallback viewCallback) {
        this.mTClass = cls;
        this.mTileSize = i;
        this.mDataCallback = dataCallback;
        this.mViewCallback = viewCallback;
        this.mTileList = new TileList<>(this.mTileSize);
        MessageThreadUtil messageThreadUtil = new MessageThreadUtil();
        this.mMainThreadProxy = messageThreadUtil.getMainThreadProxy(this.mMainThreadCallback);
        this.mBackgroundProxy = messageThreadUtil.getBackgroundProxy(this.mBackgroundCallback);
        refresh();
    }

    private boolean isRefreshPending() {
        return this.mRequestedGeneration != this.mDisplayedGeneration;
    }

    public void onRangeChanged() {
        if (!isRefreshPending()) {
            updateRange();
            this.mAllowScrollHints = true;
        }
    }

    public void refresh() {
        this.mMissingPositions.clear();
        BackgroundCallback<T> backgroundCallback = this.mBackgroundProxy;
        int i = this.mRequestedGeneration + 1;
        this.mRequestedGeneration = i;
        backgroundCallback.refresh(i);
    }

    public T getItem(int i) {
        if (i < 0 || i >= this.mItemCount) {
            StringBuilder sb = new StringBuilder();
            sb.append(i);
            sb.append(" is not within 0 and ");
            sb.append(this.mItemCount);
            throw new IndexOutOfBoundsException(sb.toString());
        }
        T itemAt = this.mTileList.getItemAt(i);
        if (itemAt == null && !isRefreshPending()) {
            this.mMissingPositions.put(i, 0);
        }
        return itemAt;
    }

    public int getItemCount() {
        return this.mItemCount;
    }

    /* access modifiers changed from: 0000 */
    public void updateRange() {
        this.mViewCallback.getItemRangeInto(this.mTmpRange);
        int[] iArr = this.mTmpRange;
        if (iArr[0] <= iArr[1] && iArr[0] >= 0 && iArr[1] < this.mItemCount) {
            if (!this.mAllowScrollHints) {
                this.mScrollHint = 0;
            } else {
                int i = iArr[0];
                int[] iArr2 = this.mPrevRange;
                if (i > iArr2[1] || iArr2[0] > iArr[1]) {
                    this.mScrollHint = 0;
                } else if (iArr[0] < iArr2[0]) {
                    this.mScrollHint = 1;
                } else if (iArr[0] > iArr2[0]) {
                    this.mScrollHint = 2;
                }
            }
            int[] iArr3 = this.mPrevRange;
            int[] iArr4 = this.mTmpRange;
            iArr3[0] = iArr4[0];
            iArr3[1] = iArr4[1];
            this.mViewCallback.extendRangeInto(iArr4, this.mTmpRangeExtended, this.mScrollHint);
            int[] iArr5 = this.mTmpRangeExtended;
            iArr5[0] = Math.min(this.mTmpRange[0], Math.max(iArr5[0], 0));
            int[] iArr6 = this.mTmpRangeExtended;
            iArr6[1] = Math.max(this.mTmpRange[1], Math.min(iArr6[1], this.mItemCount - 1));
            BackgroundCallback<T> backgroundCallback = this.mBackgroundProxy;
            int[] iArr7 = this.mTmpRange;
            int i2 = iArr7[0];
            int i3 = iArr7[1];
            int[] iArr8 = this.mTmpRangeExtended;
            backgroundCallback.updateRange(i2, i3, iArr8[0], iArr8[1], this.mScrollHint);
        }
    }
}
