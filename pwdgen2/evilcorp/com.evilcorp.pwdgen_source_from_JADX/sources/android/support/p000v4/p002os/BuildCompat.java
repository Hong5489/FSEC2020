package android.support.p000v4.p002os;

import android.os.Build.VERSION;

/* renamed from: android.support.v4.os.BuildCompat */
public class BuildCompat {
    private BuildCompat() {
    }

    @Deprecated
    public static boolean isAtLeastN() {
        return VERSION.SDK_INT >= 24;
    }

    @Deprecated
    public static boolean isAtLeastNMR1() {
        return VERSION.SDK_INT >= 25;
    }

    @Deprecated
    public static boolean isAtLeastO() {
        return VERSION.SDK_INT >= 26;
    }

    @Deprecated
    public static boolean isAtLeastOMR1() {
        return VERSION.SDK_INT >= 27;
    }

    public static boolean isAtLeastP() {
        return VERSION.CODENAME.equals("P");
    }
}
