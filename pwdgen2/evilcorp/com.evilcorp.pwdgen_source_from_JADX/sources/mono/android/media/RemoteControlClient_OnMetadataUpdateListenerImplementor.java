package mono.android.media;

import android.media.RemoteControlClient.OnMetadataUpdateListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class RemoteControlClient_OnMetadataUpdateListenerImplementor implements IGCUserPeer, OnMetadataUpdateListener {
    public static final String __md_methods = "n_onMetadataUpdate:(ILjava/lang/Object;)V:GetOnMetadataUpdate_ILjava_lang_Object_Handler:Android.Media.RemoteControlClient/IOnMetadataUpdateListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onMetadataUpdate(int i, Object obj);

    static {
        Runtime.register("Android.Media.RemoteControlClient+IOnMetadataUpdateListenerImplementor, Mono.Android", RemoteControlClient_OnMetadataUpdateListenerImplementor.class, __md_methods);
    }

    public RemoteControlClient_OnMetadataUpdateListenerImplementor() {
        if (getClass() == RemoteControlClient_OnMetadataUpdateListenerImplementor.class) {
            TypeManager.Activate("Android.Media.RemoteControlClient+IOnMetadataUpdateListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onMetadataUpdate(int i, Object obj) {
        n_onMetadataUpdate(i, obj);
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
