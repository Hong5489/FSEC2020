package android.support.p000v4.view.accessibility;

import android.accessibilityservice.AccessibilityServiceInfo;
import android.os.Build.VERSION;
import android.view.accessibility.AccessibilityManager;
import java.util.List;

/* renamed from: android.support.v4.view.accessibility.AccessibilityManagerCompat */
public final class AccessibilityManagerCompat {

    @Deprecated
    /* renamed from: android.support.v4.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListener */
    public interface AccessibilityStateChangeListener {
        @Deprecated
        void onAccessibilityStateChanged(boolean z);
    }

    @Deprecated
    /* renamed from: android.support.v4.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListenerCompat */
    public static abstract class AccessibilityStateChangeListenerCompat implements AccessibilityStateChangeListener {
    }

    /* renamed from: android.support.v4.view.accessibility.AccessibilityManagerCompat$AccessibilityStateChangeListenerWrapper */
    private static class AccessibilityStateChangeListenerWrapper implements android.view.accessibility.AccessibilityManager.AccessibilityStateChangeListener {
        AccessibilityStateChangeListener mListener;

        AccessibilityStateChangeListenerWrapper(AccessibilityStateChangeListener accessibilityStateChangeListener) {
            this.mListener = accessibilityStateChangeListener;
        }

        public int hashCode() {
            return this.mListener.hashCode();
        }

        public boolean equals(Object obj) {
            if (this == obj) {
                return true;
            }
            if (obj == null || getClass() != obj.getClass()) {
                return false;
            }
            return this.mListener.equals(((AccessibilityStateChangeListenerWrapper) obj).mListener);
        }

        public void onAccessibilityStateChanged(boolean z) {
            this.mListener.onAccessibilityStateChanged(z);
        }
    }

    /* renamed from: android.support.v4.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener */
    public interface TouchExplorationStateChangeListener {
        void onTouchExplorationStateChanged(boolean z);
    }

    /* renamed from: android.support.v4.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListenerWrapper */
    private static class TouchExplorationStateChangeListenerWrapper implements android.view.accessibility.AccessibilityManager.TouchExplorationStateChangeListener {
        final TouchExplorationStateChangeListener mListener;

        TouchExplorationStateChangeListenerWrapper(TouchExplorationStateChangeListener touchExplorationStateChangeListener) {
            this.mListener = touchExplorationStateChangeListener;
        }

        public int hashCode() {
            return this.mListener.hashCode();
        }

        public boolean equals(Object obj) {
            if (this == obj) {
                return true;
            }
            if (obj == null || getClass() != obj.getClass()) {
                return false;
            }
            return this.mListener.equals(((TouchExplorationStateChangeListenerWrapper) obj).mListener);
        }

        public void onTouchExplorationStateChanged(boolean z) {
            this.mListener.onTouchExplorationStateChanged(z);
        }
    }

    @Deprecated
    public static boolean addAccessibilityStateChangeListener(AccessibilityManager accessibilityManager, AccessibilityStateChangeListener accessibilityStateChangeListener) {
        if (accessibilityStateChangeListener == null) {
            return false;
        }
        return accessibilityManager.addAccessibilityStateChangeListener(new AccessibilityStateChangeListenerWrapper(accessibilityStateChangeListener));
    }

    @Deprecated
    public static boolean removeAccessibilityStateChangeListener(AccessibilityManager accessibilityManager, AccessibilityStateChangeListener accessibilityStateChangeListener) {
        if (accessibilityStateChangeListener == null) {
            return false;
        }
        return accessibilityManager.removeAccessibilityStateChangeListener(new AccessibilityStateChangeListenerWrapper(accessibilityStateChangeListener));
    }

    @Deprecated
    public static List<AccessibilityServiceInfo> getInstalledAccessibilityServiceList(AccessibilityManager accessibilityManager) {
        return accessibilityManager.getInstalledAccessibilityServiceList();
    }

    @Deprecated
    public static List<AccessibilityServiceInfo> getEnabledAccessibilityServiceList(AccessibilityManager accessibilityManager, int i) {
        return accessibilityManager.getEnabledAccessibilityServiceList(i);
    }

    @Deprecated
    public static boolean isTouchExplorationEnabled(AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    public static boolean addTouchExplorationStateChangeListener(AccessibilityManager accessibilityManager, TouchExplorationStateChangeListener touchExplorationStateChangeListener) {
        if (VERSION.SDK_INT < 19 || touchExplorationStateChangeListener == null) {
            return false;
        }
        return accessibilityManager.addTouchExplorationStateChangeListener(new TouchExplorationStateChangeListenerWrapper(touchExplorationStateChangeListener));
    }

    public static boolean removeTouchExplorationStateChangeListener(AccessibilityManager accessibilityManager, TouchExplorationStateChangeListener touchExplorationStateChangeListener) {
        if (VERSION.SDK_INT < 19 || touchExplorationStateChangeListener == null) {
            return false;
        }
        return accessibilityManager.removeTouchExplorationStateChangeListener(new TouchExplorationStateChangeListenerWrapper(touchExplorationStateChangeListener));
    }

    private AccessibilityManagerCompat() {
    }
}
