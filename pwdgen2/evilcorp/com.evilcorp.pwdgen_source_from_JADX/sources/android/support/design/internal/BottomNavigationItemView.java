package android.support.design.internal;

import android.content.Context;
import android.content.res.ColorStateList;
import android.content.res.Resources;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.Drawable.ConstantState;
import android.support.design.C0019R;
import android.support.p000v4.content.ContextCompat;
import android.support.p000v4.graphics.drawable.DrawableCompat;
import android.support.p000v4.view.PointerIconCompat;
import android.support.p000v4.view.ViewCompat;
import android.support.p003v7.view.menu.MenuItemImpl;
import android.support.p003v7.view.menu.MenuView.ItemView;
import android.support.p003v7.widget.TooltipCompat;
import android.util.AttributeSet;
import android.view.LayoutInflater;
import android.widget.FrameLayout;
import android.widget.FrameLayout.LayoutParams;
import android.widget.ImageView;
import android.widget.TextView;

public class BottomNavigationItemView extends FrameLayout implements ItemView {
    private static final int[] CHECKED_STATE_SET = {16842912};
    public static final int INVALID_ITEM_POSITION = -1;
    private final int mDefaultMargin;
    private ImageView mIcon;
    private ColorStateList mIconTint;
    private MenuItemImpl mItemData;
    private int mItemPosition;
    private final TextView mLargeLabel;
    private final float mScaleDownFactor;
    private final float mScaleUpFactor;
    private final int mShiftAmount;
    private boolean mShiftingMode;
    private final TextView mSmallLabel;

    public boolean prefersCondensedTitle() {
        return false;
    }

    public void setShortcut(boolean z, char c) {
    }

    public boolean showsIcon() {
        return true;
    }

    public BottomNavigationItemView(Context context) {
        this(context, null);
    }

    public BottomNavigationItemView(Context context, AttributeSet attributeSet) {
        this(context, attributeSet, 0);
    }

    public BottomNavigationItemView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.mItemPosition = -1;
        Resources resources = getResources();
        int dimensionPixelSize = resources.getDimensionPixelSize(C0019R.dimen.design_bottom_navigation_text_size);
        int dimensionPixelSize2 = resources.getDimensionPixelSize(C0019R.dimen.design_bottom_navigation_active_text_size);
        this.mDefaultMargin = resources.getDimensionPixelSize(C0019R.dimen.design_bottom_navigation_margin);
        this.mShiftAmount = dimensionPixelSize - dimensionPixelSize2;
        float f = (float) dimensionPixelSize2;
        float f2 = (float) dimensionPixelSize;
        this.mScaleUpFactor = (f * 1.0f) / f2;
        this.mScaleDownFactor = (f2 * 1.0f) / f;
        LayoutInflater.from(context).inflate(C0019R.layout.design_bottom_navigation_item, this, true);
        setBackgroundResource(C0019R.C0020drawable.design_bottom_navigation_item_background);
        this.mIcon = (ImageView) findViewById(C0019R.C0021id.icon);
        this.mSmallLabel = (TextView) findViewById(C0019R.C0021id.smallLabel);
        this.mLargeLabel = (TextView) findViewById(C0019R.C0021id.largeLabel);
    }

    public void initialize(MenuItemImpl menuItemImpl, int i) {
        this.mItemData = menuItemImpl;
        setCheckable(menuItemImpl.isCheckable());
        setChecked(menuItemImpl.isChecked());
        setEnabled(menuItemImpl.isEnabled());
        setIcon(menuItemImpl.getIcon());
        setTitle(menuItemImpl.getTitle());
        setId(menuItemImpl.getItemId());
        setContentDescription(menuItemImpl.getContentDescription());
        TooltipCompat.setTooltipText(this, menuItemImpl.getTooltipText());
    }

    public void setItemPosition(int i) {
        this.mItemPosition = i;
    }

    public int getItemPosition() {
        return this.mItemPosition;
    }

    public void setShiftingMode(boolean z) {
        this.mShiftingMode = z;
    }

    public MenuItemImpl getItemData() {
        return this.mItemData;
    }

    public void setTitle(CharSequence charSequence) {
        this.mSmallLabel.setText(charSequence);
        this.mLargeLabel.setText(charSequence);
    }

    public void setCheckable(boolean z) {
        refreshDrawableState();
    }

    public void setChecked(boolean z) {
        TextView textView = this.mLargeLabel;
        textView.setPivotX((float) (textView.getWidth() / 2));
        TextView textView2 = this.mLargeLabel;
        textView2.setPivotY((float) textView2.getBaseline());
        TextView textView3 = this.mSmallLabel;
        textView3.setPivotX((float) (textView3.getWidth() / 2));
        TextView textView4 = this.mSmallLabel;
        textView4.setPivotY((float) textView4.getBaseline());
        if (this.mShiftingMode) {
            if (z) {
                LayoutParams layoutParams = (LayoutParams) this.mIcon.getLayoutParams();
                layoutParams.gravity = 49;
                layoutParams.topMargin = this.mDefaultMargin;
                this.mIcon.setLayoutParams(layoutParams);
                this.mLargeLabel.setVisibility(0);
                this.mLargeLabel.setScaleX(1.0f);
                this.mLargeLabel.setScaleY(1.0f);
            } else {
                LayoutParams layoutParams2 = (LayoutParams) this.mIcon.getLayoutParams();
                layoutParams2.gravity = 17;
                layoutParams2.topMargin = this.mDefaultMargin;
                this.mIcon.setLayoutParams(layoutParams2);
                this.mLargeLabel.setVisibility(4);
                this.mLargeLabel.setScaleX(0.5f);
                this.mLargeLabel.setScaleY(0.5f);
            }
            this.mSmallLabel.setVisibility(4);
        } else if (z) {
            LayoutParams layoutParams3 = (LayoutParams) this.mIcon.getLayoutParams();
            layoutParams3.gravity = 49;
            layoutParams3.topMargin = this.mDefaultMargin + this.mShiftAmount;
            this.mIcon.setLayoutParams(layoutParams3);
            this.mLargeLabel.setVisibility(0);
            this.mSmallLabel.setVisibility(4);
            this.mLargeLabel.setScaleX(1.0f);
            this.mLargeLabel.setScaleY(1.0f);
            this.mSmallLabel.setScaleX(this.mScaleUpFactor);
            this.mSmallLabel.setScaleY(this.mScaleUpFactor);
        } else {
            LayoutParams layoutParams4 = (LayoutParams) this.mIcon.getLayoutParams();
            layoutParams4.gravity = 49;
            layoutParams4.topMargin = this.mDefaultMargin;
            this.mIcon.setLayoutParams(layoutParams4);
            this.mLargeLabel.setVisibility(4);
            this.mSmallLabel.setVisibility(0);
            this.mLargeLabel.setScaleX(this.mScaleDownFactor);
            this.mLargeLabel.setScaleY(this.mScaleDownFactor);
            this.mSmallLabel.setScaleX(1.0f);
            this.mSmallLabel.setScaleY(1.0f);
        }
        refreshDrawableState();
    }

    public void setEnabled(boolean z) {
        super.setEnabled(z);
        this.mSmallLabel.setEnabled(z);
        this.mLargeLabel.setEnabled(z);
        this.mIcon.setEnabled(z);
        if (z) {
            ViewCompat.setPointerIcon(this, PointerIconCompat.getSystemIcon(getContext(), PointerIconCompat.TYPE_HAND));
        } else {
            ViewCompat.setPointerIcon(this, null);
        }
    }

    public int[] onCreateDrawableState(int i) {
        int[] onCreateDrawableState = super.onCreateDrawableState(i + 1);
        MenuItemImpl menuItemImpl = this.mItemData;
        if (menuItemImpl != null && menuItemImpl.isCheckable() && this.mItemData.isChecked()) {
            mergeDrawableStates(onCreateDrawableState, CHECKED_STATE_SET);
        }
        return onCreateDrawableState;
    }

    public void setIcon(Drawable drawable) {
        if (drawable != null) {
            ConstantState constantState = drawable.getConstantState();
            if (constantState != null) {
                drawable = constantState.newDrawable();
            }
            drawable = DrawableCompat.wrap(drawable).mutate();
            DrawableCompat.setTintList(drawable, this.mIconTint);
        }
        this.mIcon.setImageDrawable(drawable);
    }

    public void setIconTintList(ColorStateList colorStateList) {
        this.mIconTint = colorStateList;
        MenuItemImpl menuItemImpl = this.mItemData;
        if (menuItemImpl != null) {
            setIcon(menuItemImpl.getIcon());
        }
    }

    public void setTextColor(ColorStateList colorStateList) {
        this.mSmallLabel.setTextColor(colorStateList);
        this.mLargeLabel.setTextColor(colorStateList);
    }

    public void setItemBackground(int i) {
        ViewCompat.setBackground(this, i == 0 ? null : ContextCompat.getDrawable(getContext(), i));
    }
}
