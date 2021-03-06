package mono.android.app;

import android.app.SearchManager.OnCancelListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class SearchManager_OnCancelListenerImplementor implements IGCUserPeer, OnCancelListener {
    public static final String __md_methods = "n_onCancel:()V:GetOnCancelHandler:Android.App.SearchManager/IOnCancelListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onCancel();

    static {
        Runtime.register("Android.App.SearchManager+IOnCancelListenerImplementor, Mono.Android", SearchManager_OnCancelListenerImplementor.class, __md_methods);
    }

    public SearchManager_OnCancelListenerImplementor() {
        if (getClass() == SearchManager_OnCancelListenerImplementor.class) {
            TypeManager.Activate("Android.App.SearchManager+IOnCancelListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onCancel() {
        n_onCancel();
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
