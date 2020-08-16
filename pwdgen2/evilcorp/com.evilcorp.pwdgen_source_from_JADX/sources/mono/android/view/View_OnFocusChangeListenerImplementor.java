package mono.android.view;

import android.view.View;
import android.view.View.OnFocusChangeListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class View_OnFocusChangeListenerImplementor implements IGCUserPeer, OnFocusChangeListener {
    public static final String __md_methods = "n_onFocusChange:(Landroid/view/View;Z)V:GetOnFocusChange_Landroid_view_View_ZHandler:Android.Views.View/IOnFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onFocusChange(View view, boolean z);

    static {
        Runtime.register("Android.Views.View+IOnFocusChangeListenerImplementor, Mono.Android", View_OnFocusChangeListenerImplementor.class, __md_methods);
    }

    public View_OnFocusChangeListenerImplementor() {
        if (getClass() == View_OnFocusChangeListenerImplementor.class) {
            TypeManager.Activate("Android.Views.View+IOnFocusChangeListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onFocusChange(View view, boolean z) {
        n_onFocusChange(view, z);
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
