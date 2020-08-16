package android.support.transition;

import android.animation.Animator;
import android.animation.AnimatorListenerAdapter;

class AnimatorUtilsApi19 implements AnimatorUtilsImpl {
    AnimatorUtilsApi19() {
    }

    public void addPauseListener(Animator animator, AnimatorListenerAdapter animatorListenerAdapter) {
        animator.addPauseListener(animatorListenerAdapter);
    }

    public void pause(Animator animator) {
        animator.pause();
    }

    public void resume(Animator animator) {
        animator.resume();
    }
}
