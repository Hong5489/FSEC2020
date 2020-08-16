package android.support.p000v4.view;

import android.content.res.ColorStateList;
import android.graphics.PorterDuff.Mode;

/* renamed from: android.support.v4.view.TintableBackgroundView */
public interface TintableBackgroundView {
    ColorStateList getSupportBackgroundTintList();

    Mode getSupportBackgroundTintMode();

    void setSupportBackgroundTintList(ColorStateList colorStateList);

    void setSupportBackgroundTintMode(Mode mode);
}
