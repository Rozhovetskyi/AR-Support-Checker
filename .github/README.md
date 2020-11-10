# AR Support Checker

Unity plugin for AR (Android ARCore, iOS ARKit, Unity AR Fondation, Vuforia Platform Enablers) support devices detection.

# How to use

1. Import **ARSupportChecker.package** to your project.
2. Use `ARSupportChecker.IsSupported()` method to check if device is supported.

# Documentation

```csharp
bool ARSupportChecker.IsSupported();
```

Returns `true`  if either ARKit or ARCore is supported on current device.

# How it works

### Android runtime

As [Google Play Services for AR](https://play.google.com/store/apps/details?id=com.google.ar.core) is automatically installed and updated on supported devices it will return `true` if `com.google.ar.core` package is installed on the device.

### iOS runtime

Uses `ARWorldTrackingConfiguration.isSupported` property to detect if the device supports [ARWorldTrackingConfiguration](https://developer.apple.com/documentation/arkit/arworldtrackingconfiguration) session configuration class.

As ARKit requires iOS 11.0 or later for versions lower than that it returns `false`.

### Editor

In Unity Editor it always returns `false`.