package android.support.transition;

import android.graphics.Matrix;
import android.view.View;
import android.view.ViewGroup;

interface GhostViewImpl {

    public interface Creator {
        GhostViewImpl addGhost(View view, ViewGroup viewGroup, Matrix matrix);

        void removeGhost(View view);
    }

    void reserveEndViewTransition(ViewGroup viewGroup, View view);

    void setVisibility(int i);
}
