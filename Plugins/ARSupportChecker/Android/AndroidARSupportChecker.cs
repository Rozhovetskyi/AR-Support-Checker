#if UNITY_ANDROID && !UNITY_EDITOR
using UnityEngine;

namespace ARSupportCheck
{
    public static class AndroidARSupportChecker
    {
        private const string ARCorePackageName = "com.google.ar.core";
    
        public static bool IsSupported()
        {
            var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            var context = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            var packageManager = context.Call<AndroidJavaObject>("getPackageManager");
            AndroidJavaObject packageInfo = null;
            try
            {
                packageInfo = packageManager.Call<AndroidJavaObject>("getPackageInfo", ARCorePackageName, 0);
            }
            catch
            {
    
            }
            if (packageInfo != null)
                return true;
            else
                return false;
        }
    }
}
#endif