#if UNITY_IOS && !UNITY_EDITOR
using System.Runtime.InteropServices;

namespace ARSupportCheck
{
    public static class IOSARSupportChecker
    {
        [DllImport("__Internal")]
        private static extern bool ARKitSupportCheck();

        public static bool IsSupported()
        {
            return ARKitSupportCheck();
        }
    }
}
#endif