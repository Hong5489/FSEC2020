package mono;

import android.app.Application;
import android.content.Context;
import android.content.IntentFilter;
import android.content.pm.ApplicationInfo;
import android.os.Build;
import android.os.Build.VERSION;
import android.os.Environment;
import java.io.File;
import java.util.Locale;
import mono.android.BuildConfig;
import mono.android.DebugRuntime;
import mono.android.Runtime;
import mono.android.app.ApplicationRegistration;
import mono.android.app.NotifyTimeZoneChanges;

public class MonoPackageManager {
    static Context Context = null;
    static final int FLAG_EXTRACT_NATIVE_LIBS = 268435456;
    static boolean initialized;
    static Object lock = new Object();

    public static void setContext(Context context) {
    }

    public static void LoadApplication(Context context, ApplicationInfo applicationInfo, String[] strArr) {
        Context context2 = context;
        synchronized (lock) {
            if (context2 instanceof Application) {
                Context = context2;
            }
            if (!initialized) {
                context2.registerReceiver(new NotifyTimeZoneChanges(), new IntentFilter("android.intent.action.TIMEZONE_CHANGED"));
                Locale locale = Locale.getDefault();
                StringBuilder sb = new StringBuilder();
                sb.append(locale.getLanguage());
                sb.append("-");
                sb.append(locale.getCountry());
                String sb2 = sb.toString();
                String absolutePath = context.getFilesDir().getAbsolutePath();
                String absolutePath2 = context.getCacheDir().getAbsolutePath();
                String nativeLibraryPath = getNativeLibraryPath(context);
                ClassLoader classLoader = context.getClassLoader();
                File externalStorageDirectory = Environment.getExternalStorageDirectory();
                StringBuilder sb3 = new StringBuilder();
                sb3.append("Android/data/");
                sb3.append(context.getPackageName());
                sb3.append("/files/.__override__");
                String absolutePath3 = new File(externalStorageDirectory, sb3.toString()).getAbsolutePath();
                StringBuilder sb4 = new StringBuilder();
                sb4.append("../legacy/Android/data/");
                sb4.append(context.getPackageName());
                sb4.append("/files/.__override__");
                String absolutePath4 = new File(externalStorageDirectory, sb4.toString()).getAbsolutePath();
                boolean z = (applicationInfo.flags & FLAG_EXTRACT_NATIVE_LIBS) == 0;
                String nativeLibraryPath2 = getNativeLibraryPath(applicationInfo);
                String[] strArr2 = {absolutePath, absolutePath2, nativeLibraryPath};
                String[] strArr3 = {absolutePath3, absolutePath4};
                if (BuildConfig.Debug) {
                    System.loadLibrary("xamarin-debug-app-helper");
                    DebugRuntime.init(strArr, nativeLibraryPath2, strArr2, strArr3, VERSION.SDK_INT, z);
                } else {
                    System.loadLibrary("monosgen-2.0");
                }
                System.loadLibrary("xamarin-app");
                System.loadLibrary("monodroid");
                Runtime.initInternal(sb2, strArr, nativeLibraryPath2, strArr2, classLoader, strArr3, MonoPackageManager_Resources.Assemblies, VERSION.SDK_INT, z, isEmulator());
                ApplicationRegistration.registerApplications();
                initialized = true;
            }
        }
    }

    static boolean isEmulator() {
        String str = Build.HARDWARE;
        return str.contains("ranchu") || str.contains("goldfish");
    }

    static String getNativeLibraryPath(Context context) {
        return getNativeLibraryPath(context.getApplicationInfo());
    }

    static String getNativeLibraryPath(ApplicationInfo applicationInfo) {
        if (VERSION.SDK_INT >= 9) {
            return applicationInfo.nativeLibraryDir;
        }
        StringBuilder sb = new StringBuilder();
        sb.append(applicationInfo.dataDir);
        sb.append("/lib");
        return sb.toString();
    }

    public static String[] getAssemblies() {
        return MonoPackageManager_Resources.Assemblies;
    }

    public static String[] getDependencies() {
        return MonoPackageManager_Resources.Dependencies;
    }

    public static String getApiPackageName() {
        return MonoPackageManager_Resources.ApiPackageName;
    }
}
