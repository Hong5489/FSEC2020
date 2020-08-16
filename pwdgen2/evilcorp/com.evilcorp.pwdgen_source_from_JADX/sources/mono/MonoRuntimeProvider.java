package mono;

import android.content.ContentProvider;
import android.content.ContentValues;
import android.database.Cursor;
import android.net.Uri;

public class MonoRuntimeProvider extends ContentProvider {
    public boolean onCreate() {
        return true;
    }

    /* JADX WARNING: Removed duplicated region for block: B:9:0x0023  */
    /* Code decompiled incorrectly, please refer to instructions dump. */
    public void attachInfo(android.content.Context r7, android.content.pm.ProviderInfo r8) {
        /*
            r6 = this;
            android.content.pm.ApplicationInfo r0 = r7.getApplicationInfo()
            int r1 = android.os.Build.VERSION.SDK_INT
            r2 = 0
            r3 = 1
            r4 = 21
            if (r1 < r4) goto L_0x0020
            java.lang.String[] r1 = r0.splitPublicSourceDirs
            if (r1 == 0) goto L_0x0020
            int r4 = r1.length
            if (r4 <= 0) goto L_0x0020
            int r4 = r1.length
            int r4 = r4 + r3
            java.lang.String[] r4 = new java.lang.String[r4]
            java.lang.String r5 = r0.sourceDir
            r4[r2] = r5
            int r5 = r1.length
            java.lang.System.arraycopy(r1, r2, r4, r3, r5)
            goto L_0x0021
        L_0x0020:
            r4 = 0
        L_0x0021:
            if (r4 != 0) goto L_0x0029
            java.lang.String[] r4 = new java.lang.String[r3]
            java.lang.String r1 = r0.sourceDir
            r4[r2] = r1
        L_0x0029:
            mono.MonoPackageManager.LoadApplication(r7, r0, r4)
            super.attachInfo(r7, r8)
            return
        */
        throw new UnsupportedOperationException("Method not decompiled: mono.MonoRuntimeProvider.attachInfo(android.content.Context, android.content.pm.ProviderInfo):void");
    }

    public Cursor query(Uri uri, String[] strArr, String str, String[] strArr2, String str2) {
        throw new RuntimeException("This operation is not supported.");
    }

    public String getType(Uri uri) {
        throw new RuntimeException("This operation is not supported.");
    }

    public Uri insert(Uri uri, ContentValues contentValues) {
        throw new RuntimeException("This operation is not supported.");
    }

    public int delete(Uri uri, String str, String[] strArr) {
        throw new RuntimeException("This operation is not supported.");
    }

    public int update(Uri uri, ContentValues contentValues, String str, String[] strArr) {
        throw new RuntimeException("This operation is not supported.");
    }
}
