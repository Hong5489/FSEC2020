package mono.android.incrementaldeployment;

import android.util.Log;
import dalvik.system.BaseDexClassLoader;
import java.io.File;
import java.lang.reflect.Field;
import java.util.List;

public class IncrementalClassLoader extends ClassLoader {
    private final DelegateClassLoader delegateClassLoader;

    private static class DelegateClassLoader extends BaseDexClassLoader {
        private DelegateClassLoader(String str, File file, String str2, ClassLoader classLoader) {
            super(str, file, str2, classLoader);
        }

        public Class<?> findClass(String str) throws ClassNotFoundException {
            return super.findClass(str);
        }
    }

    public IncrementalClassLoader(ClassLoader classLoader, String str, File file, String str2, List<String> list) {
        super(classLoader.getParent());
        this.delegateClassLoader = createDelegateClassLoader(file, str2, list, classLoader);
    }

    public Class<?> findClass(String str) throws ClassNotFoundException {
        return this.delegateClassLoader.findClass(str);
    }

    private static DelegateClassLoader createDelegateClassLoader(File file, String str, List<String> list, ClassLoader classLoader) {
        StringBuilder sb = new StringBuilder();
        boolean z = true;
        for (String str2 : list) {
            if (z) {
                z = false;
            } else {
                sb.append(File.pathSeparator);
            }
            sb.append(str2);
        }
        StringBuilder sb2 = new StringBuilder();
        sb2.append("Incremental dex path is ");
        sb2.append(sb);
        String str3 = "IncrementalClassLoader";
        Log.v(str3, sb2.toString());
        StringBuilder sb3 = new StringBuilder();
        sb3.append("Native lib dir is ");
        sb3.append(str);
        Log.v(str3, sb3.toString());
        DelegateClassLoader delegateClassLoader2 = new DelegateClassLoader(sb.toString(), file, str, classLoader);
        return delegateClassLoader2;
    }

    private static void setParent(ClassLoader classLoader, ClassLoader classLoader2) {
        try {
            Field declaredField = ClassLoader.class.getDeclaredField("parent");
            declaredField.setAccessible(true);
            declaredField.set(classLoader, classLoader2);
        } catch (IllegalArgumentException e) {
            throw new RuntimeException(e);
        } catch (IllegalAccessException e2) {
            throw new RuntimeException(e2);
        } catch (NoSuchFieldException e3) {
            throw new RuntimeException(e3);
        }
    }

    public static void inject(ClassLoader classLoader, String str, File file, String str2, List<String> list) {
        IncrementalClassLoader incrementalClassLoader = new IncrementalClassLoader(classLoader, str, file, str2, list);
        setParent(classLoader, incrementalClassLoader);
    }
}
