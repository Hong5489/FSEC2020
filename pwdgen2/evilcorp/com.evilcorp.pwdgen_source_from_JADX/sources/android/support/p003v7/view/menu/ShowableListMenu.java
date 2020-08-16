package android.support.p003v7.view.menu;

import android.widget.ListView;

/* renamed from: android.support.v7.view.menu.ShowableListMenu */
public interface ShowableListMenu {
    void dismiss();

    ListView getListView();

    boolean isShowing();

    void show();
}
