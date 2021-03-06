package mono.android.media;

import android.media.SoundPool;
import android.media.SoundPool.OnLoadCompleteListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class SoundPool_OnLoadCompleteListenerImplementor implements IGCUserPeer, OnLoadCompleteListener {
    public static final String __md_methods = "n_onLoadComplete:(Landroid/media/SoundPool;II)V:GetOnLoadComplete_Landroid_media_SoundPool_IIHandler:Android.Media.SoundPool/IOnLoadCompleteListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onLoadComplete(SoundPool soundPool, int i, int i2);

    static {
        Runtime.register("Android.Media.SoundPool+IOnLoadCompleteListenerImplementor, Mono.Android", SoundPool_OnLoadCompleteListenerImplementor.class, __md_methods);
    }

    public SoundPool_OnLoadCompleteListenerImplementor() {
        if (getClass() == SoundPool_OnLoadCompleteListenerImplementor.class) {
            TypeManager.Activate("Android.Media.SoundPool+IOnLoadCompleteListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onLoadComplete(SoundPool soundPool, int i, int i2) {
        n_onLoadComplete(soundPool, i, i2);
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
