# AR Support Checker

Unity plugin for AR supported (ARCore, ARKit, AR Foundation) devices detection.

## How to use

1.  Import [ARSupportChecker.package](https://github.com/Rozhovetskyi/ARSupportChecker/blob/main/.github/ARSupportChecker.unitypackage?raw=true) to your project. 
2.  Use `ARSupportChecker.IsSupported()` method to check if ARKit / ARCore  is supported on the device.

## How it works

### Android

As [Google Play Services for AR](https://play.google.com/store/apps/details?id=com.google.ar.core) is automatically installed and updated on supported devices it will return `true` if `com.google.ar.core` package is installed on the device.

### iOS

Uses `ARWorldTrackingConfiguration.isSupported` property to detect if the device supports [ARWorldTrackingConfiguration](https://developer.apple.com/documentation/arkit/arworldtrackingconfiguration) session configuration class.

As ARKit requires iOS 11.0 or later for versions lower than that it returns `false`.

### Editor

In Unity Editor it always returns `false`.

## License
MIT (c) Yevhen Rozhovetskyi (<https://github.com/Rozhovetskyi>), see [LICENSE](https://github.com/Rozhovetskyi/AR-Support-Checker/blob/master/LICENSE) file.
