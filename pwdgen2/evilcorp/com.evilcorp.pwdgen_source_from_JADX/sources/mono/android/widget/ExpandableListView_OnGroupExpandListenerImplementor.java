package mono.android.widget;

import android.widget.ExpandableListView.OnGroupExpandListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class ExpandableListView_OnGroupExpandListenerImplementor implements IGCUserPeer, OnGroupExpandListener {
    public static final String __md_methods = "n_onGroupExpand:(I)V:GetOnGroupExpand_IHandler:Android.Widget.ExpandableListView/IOnGroupExpandListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onGroupExpand(int i);

    static {
        Runtime.register("Android.Widget.ExpandableListView+IOnGroupExpandListenerImplementor, Mono.Android", ExpandableListView_OnGroupExpandListenerImplementor.class, __md_methods);
    }

    public ExpandableListView_OnGroupExpandListenerImplementor() {
        if (getClass() == ExpandableListView_OnGroupExpandListenerImplementor.class) {
            TypeManager.Activate("Android.Widget.ExpandableListView+IOnGroupExpandListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onGroupExpand(int i) {
        n_onGroupExpand(i);
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
