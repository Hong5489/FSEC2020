package mono.android.location;

import android.location.GpsStatus.Listener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class GpsStatus_ListenerImplementor implements IGCUserPeer, Listener {
    public static final String __md_methods = "n_onGpsStatusChanged:(I)V:GetOnGpsStatusChanged_IHandler:Android.Locations.GpsStatus/IListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onGpsStatusChanged(int i);

    static {
        Runtime.register("Android.Locations.GpsStatus+IListenerImplementor, Mono.Android", GpsStatus_ListenerImplementor.class, __md_methods);
    }

    public GpsStatus_ListenerImplementor() {
        if (getClass() == GpsStatus_ListenerImplementor.class) {
            TypeManager.Activate("Android.Locations.GpsStatus+IListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onGpsStatusChanged(int i) {
        n_onGpsStatusChanged(i);
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
