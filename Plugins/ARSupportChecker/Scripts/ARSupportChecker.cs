namespace ARSupportCheck
{
    public static class ARSupportChecker
    {
        public static bool IsSupported()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return IOSARSupportChecker.IsSupported();
#endif
#if UNITY_ANDROID && !UNITY_EDITOR
            return AndroidARSupportChecker.IsSupported();
#endif
            return false;
        }
    }
}