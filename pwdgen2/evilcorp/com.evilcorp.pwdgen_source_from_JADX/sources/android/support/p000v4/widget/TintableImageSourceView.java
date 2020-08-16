package android.support.p000v4.widget;

import android.content.res.ColorStateList;
import android.graphics.PorterDuff.Mode;

/* renamed from: android.support.v4.widget.TintableImageSourceView */
public interface TintableImageSourceView {
    ColorStateList getSupportImageTintList();

    Mode getSupportImageTintMode();

    void setSupportImageTintList(ColorStateList colorStateList);

    void setSupportImageTintMode(Mode mode);
}
