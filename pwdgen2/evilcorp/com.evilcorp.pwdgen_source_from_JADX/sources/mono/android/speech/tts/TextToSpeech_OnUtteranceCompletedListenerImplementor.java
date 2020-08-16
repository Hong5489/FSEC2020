package mono.android.speech.tts;

import android.speech.tts.TextToSpeech.OnUtteranceCompletedListener;
import java.util.ArrayList;
import mono.android.IGCUserPeer;
import mono.android.Runtime;
import mono.android.TypeManager;

public class TextToSpeech_OnUtteranceCompletedListenerImplementor implements IGCUserPeer, OnUtteranceCompletedListener {
    public static final String __md_methods = "n_onUtteranceCompleted:(Ljava/lang/String;)V:GetOnUtteranceCompleted_Ljava_lang_String_Handler:Android.Speech.Tts.TextToSpeech/IOnUtteranceCompletedListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n";
    private ArrayList refList;

    private native void n_onUtteranceCompleted(String str);

    static {
        Runtime.register("Android.Speech.Tts.TextToSpeech+IOnUtteranceCompletedListenerImplementor, Mono.Android", TextToSpeech_OnUtteranceCompletedListenerImplementor.class, __md_methods);
    }

    public TextToSpeech_OnUtteranceCompletedListenerImplementor() {
        if (getClass() == TextToSpeech_OnUtteranceCompletedListenerImplementor.class) {
            TypeManager.Activate("Android.Speech.Tts.TextToSpeech+IOnUtteranceCompletedListenerImplementor, Mono.Android", "", this, new Object[0]);
        }
    }

    public void onUtteranceCompleted(String str) {
        n_onUtteranceCompleted(str);
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