package mono.android.preference;

import android.content.Intent;
import android.preference.PreferenceManager.OnActivityResultListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class PreferenceManager_OnActivityResultListenerImplementor implements IGCUserPeer, OnActivityResultListener {
    public static final String __md_methods = "n_onActivityResult:(IILandroid/content/Intent;)Z:GetOnActivityResult_IILandroid_content_Intent_Handler:Android.Preferences.PreferenceManager/IOnActivityResultListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native boolean n_onActivityResult(int i, int i2, Intent intent);

    static {
        Runtime.register("Android.Preferences.PreferenceManager+IOnActivityResultListenerImplementor, Mono.Android", PreferenceManager_OnActivityResultListenerImplementor.class, __md_methods);
    }

    public PreferenceManager_OnActivityResultListenerImplementor() {
        if (getClass() == PreferenceManager_OnActivityResultListenerImplementor.class) {
            TypeManager.Activate("Android.Preferences.PreferenceManager+IOnActivityResultListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public boolean onActivityResult(int i, int i2, Intent intent) {
        return n_onActivityResult(i, i2, intent);
    }

    public void monodroidAddReference(Object obj) {
        if (this.refList == null) {
            this.refList = new ArrayList();
        }
        this.refList.add(obj);
    }

    public void monodroidClearReferences() {
        ArrayList arrayList = this.refList;
        if (arrayList != null) {
            arrayList.clear();
        }
    }
}