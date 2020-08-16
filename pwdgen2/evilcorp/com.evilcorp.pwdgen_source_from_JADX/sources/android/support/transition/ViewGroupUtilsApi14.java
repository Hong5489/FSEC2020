package android.support.transition;

import android.animation.LayoutTransition;
import android.util.Log;
import android.view.ViewGroup;
import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;

class ViewGroupUtilsApi14 implements ViewGroupUtilsImpl {
    private static final int LAYOUT_TRANSITION_CHANGING = 4;
    private static final String TAG = "ViewGroupUtilsApi14";
    private static Method sCancelMethod;
    private static boolean sCancelMethodFetched;
    private static LayoutTransition sEmptyLayoutTransition;
    private static Field sLayoutSuppressedField;
    private static boolean sLayoutSuppressedFieldFetched;

    ViewGroupUtilsApi14() {
    }

    public ViewGroupOverlayImpl getOverlay(ViewGroup viewGroup) {
        return ViewGroupOverlayApi14.createFrom(viewGroup);
    }

    /* JADX WARNING: Removed duplicated region for block: B:34:0x0085  */
    /* JADX WARNING: Removed duplicated region for block: B:37:0x0092  */
    /* JADX WARNING: Removed duplicated region for block: B:40:? A[RETURN, SYNTHETIC] */
    /* Code decompiled incorrectly, please refer to instructions dump. */
    public void suppressLayout(android.view.ViewGroup r6, boolean r7) {
        /*
            r5 = this;
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            r1 = 1
            r2 = 0
            r3 = 0
            if (r0 != 0) goto L_0x002a
            android.support.transition.ViewGroupUtilsApi14$1 r0 = new android.support.transition.ViewGroupUtilsApi14$1
            r0.<init>()
            sEmptyLayoutTransition = r0
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            r4 = 2
            r0.setAnimator(r4, r3)
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            r0.setAnimator(r2, r3)
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            r0.setAnimator(r1, r3)
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            r4 = 3
            r0.setAnimator(r4, r3)
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            r4 = 4
            r0.setAnimator(r4, r3)
        L_0x002a:
            if (r7 == 0) goto L_0x004a
            android.animation.LayoutTransition r7 = r6.getLayoutTransition()
            if (r7 == 0) goto L_0x0044
            boolean r0 = r7.isRunning()
            if (r0 == 0) goto L_0x003b
            cancelLayoutTransition(r7)
        L_0x003b:
            android.animation.LayoutTransition r0 = sEmptyLayoutTransition
            if (r7 == r0) goto L_0x0044
            int r0 = android.support.transition.C0111R.C0113id.transition_layout_save
            r6.setTag(r0, r7)
        L_0x0044:
            android.animation.LayoutTransition r7 = sEmptyLayoutTransition
            r6.setLayoutTransition(r7)
            goto L_0x009a
        L_0x004a:
            r6.setLayoutTransition(r3)
            boolean r7 = sLayoutSuppressedFieldFetched
            java.lang.String r0 = "ViewGroupUtilsApi14"
            if (r7 != 0) goto L_0x006a
            java.lang.Class<android.view.ViewGroup> r7 = android.view.ViewGroup.class
            java.lang.String r4 = "mLayoutSuppressed"
            java.lang.reflect.Field r7 = r7.getDeclaredField(r4)     // Catch:{ NoSuchFieldException -> 0x0063 }
            sLayoutSuppressedField = r7     // Catch:{ NoSuchFieldException -> 0x0063 }
            java.lang.reflect.Field r7 = sLayoutSuppressedField     // Catch:{ NoSuchFieldException -> 0x0063 }
            r7.setAccessible(r1)     // Catch:{ NoSuchFieldException -> 0x0063 }
            goto L_0x0068
        L_0x0063:
            java.lang.String r7 = "Failed to access mLayoutSuppressed field by reflection"
            android.util.Log.i(r0, r7)
        L_0x0068:
            sLayoutSuppressedFieldFetched = r1
        L_0x006a:
            java.lang.reflect.Field r7 = sLayoutSuppressedField
            if (r7 == 0) goto L_0x0083
            boolean r7 = r7.getBoolean(r6)     // Catch:{ IllegalAccessException -> 0x007e }
            if (r7 == 0) goto L_0x007c
            java.lang.reflect.Field r1 = sLayoutSuppressedField     // Catch:{ IllegalAccessException -> 0x007a }
            r1.setBoolean(r6, r2)     // Catch:{ IllegalAccessException -> 0x007a }
            goto L_0x007c
        L_0x007a:
            r2 = r7
            goto L_0x007e
        L_0x007c:
            r2 = r7
            goto L_0x0083
        L_0x007e:
            java.lang.String r7 = "Failed to get mLayoutSuppressed field by reflection"
            android.util.Log.i(r0, r7)
        L_0x0083:
            if (r2 == 0) goto L_0x0088
            r6.requestLayout()
        L_0x0088:
            int r7 = android.support.transition.C0111R.C0113id.transition_layout_save
            java.lang.Object r7 = r6.getTag(r7)
            android.animation.LayoutTransition r7 = (android.animation.LayoutTransition) r7
            if (r7 == 0) goto L_0x009a
            int r0 = android.support.transition.C0111R.C0113id.transition_layout_save
            r6.setTag(r0, r3)
            r6.setLayoutTransition(r7)
        L_0x009a:
            return
        */
        throw new UnsupportedOperationException("Method not decompiled: android.support.transition.ViewGroupUtilsApi14.suppressLayout(android.view.ViewGroup, boolean):void");
    }

    private static void cancelLayoutTransition(LayoutTransition layoutTransition) {
        boolean z = sCancelMethodFetched;
        String str = "Failed to access cancel method by reflection";
        String str2 = TAG;
        if (!z) {
            try {
                sCancelMethod = LayoutTransition.class.getDeclaredMethod("cancel", new Class[0]);
                sCancelMethod.setAccessible(true);
            } catch (NoSuchMethodException unused) {
                Log.i(str2, str);
            }
            sCancelMethodFetched = true;
        }
        Method method = sCancelMethod;
        if (method != null) {
            try {
                method.invoke(layoutTransition, new Object[0]);
            } catch (IllegalAccessException unused2) {
                Log.i(str2, str);
            } catch (InvocationTargetException unused3) {
                Log.i(str2, "Failed to invoke cancel method by reflection");
            }
        }
    }
}
