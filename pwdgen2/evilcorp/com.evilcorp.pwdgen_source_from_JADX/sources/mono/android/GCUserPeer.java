package mono.android;

import java.util.ArrayList;

class GCUserPeer implements IGCUserPeer {
    private ArrayList refList = null;

    GCUserPeer() {
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
