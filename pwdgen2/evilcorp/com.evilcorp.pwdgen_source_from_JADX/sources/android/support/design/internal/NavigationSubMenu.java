package android.support.design.internal;

import android.content.Context;
import android.support.p003v7.view.menu.MenuBuilder;
import android.support.p003v7.view.menu.MenuItemImpl;
import android.support.p003v7.view.menu.SubMenuBuilder;

public class NavigationSubMenu extends SubMenuBuilder {
    public NavigationSubMenu(Context context, NavigationMenu navigationMenu, MenuItemImpl menuItemImpl) {
        super(context, navigationMenu, menuItemImpl);
    }

    public void onItemsChanged(boolean z) {
        super.onItemsChanged(z);
        ((MenuBuilder) getParentMenu()).onItemsChanged(z);
    }
}
