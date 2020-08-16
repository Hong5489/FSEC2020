package android.support.p003v7.widget;

import android.os.Build.VERSION;
import android.view.View;

/* renamed from: android.support.v7.widget.TooltipCompat */
public class TooltipCompat {
    private static final ViewCompatImpl IMPL;

    /* renamed from: android.support.v7.widget.TooltipCompat$Api26ViewCompatImpl */
    private static class Api26ViewCompatImpl implements ViewCompatImpl {
        private Api26ViewCompatImpl() {
        }

        public void setTooltipText(View view, CharSequence charSequence) {
            view.setTooltipText(charSequence);
        }
    }

    /* renamed from: android.support.v7.widget.TooltipCompat$BaseViewCompatImpl */
    private static class BaseViewCompatImpl implements ViewCompatImpl {
        private BaseViewCompatImpl() {
        }

        public void setTooltipText(View view, CharSequence charSequence) {
            TooltipCompatHandler.setTooltipText(view, charSequence);
        }
    }

    /* renamed from: android.support.v7.widget.TooltipCompat$ViewCompatImpl */
    private interface ViewCompatImpl {
        void setTooltipText(View view, CharSequence charSequence);
    }

    static {
        if (VERSION.SDK_INT >= 26) {
            IMPL = new Api26ViewCompatImpl();
        } else {
            IMPL = new BaseViewCompatImpl();
        }
    }

    public static void setTooltipText(View view, CharSequence charSequence) {
        IMPL.setTooltipText(view, charSequence);
    }

    private TooltipCompat() {
    }
}
