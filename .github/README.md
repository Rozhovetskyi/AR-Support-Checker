# AR Support Checker [![openupm](https://img.shields.io/npm/v/com.rozhovetskyi.arsupportchecker?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.rozhovetskyi.arsupportchecker/) [![Codacy Badge](https://app.codacy.com/project/badge/Grade/93de627138984685b1eeb5d1e24a0ae1)](https://www.codacy.com/gh/Rozhovetskyi/AR-Support-Checker/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Rozhovetskyi/AR-Support-Checker&amp;utm_campaign=Badge_Grade)

Unity plugin for AR supported (ARCore, ARKit, AR Foundation) devices detection.

## How to use

Add plugin using one of the following ways:

*   Import [ARSupportChecker.package](https://github.com/Rozhovetskyi/AR-Support-Checker/releases/download/1.0.0/ARSupportChecker.unitypackage) to your project 
*   Via <i>Package Manager / + / Add package from git URL...</i> `https://github.com/Rozhovetskyi/AR-Support-Checker.git`
*   Via OpenUPM command: `openupm add com.rozhovetskyi.arsupportchecker`

Use `ARSupportChecker.IsSupported()` method to check if ARKit / ARCore  is supported on the device.

## How it works

### Android

As [Google Play Services for AR](https://play.google.com/store/apps/details?id=com.google.ar.core) is automatically installed and updated on supported devices it will return `true` if `com.google.ar.core` package is installed on the device.

### iOS

Uses `ARWorldTrackingConfiguration.isSupported` property to detect if the device supports [ARWorldTrackingConfiguration](https://developer.apple.com/documentation/arkit/arworldtrackingconfiguration) session configuration class.

As ARKit requires iOS 11.0 or later for versions lower than that it returns `false`.

### Editor

In Unity Editor it always returns `false`.

## License
MIT (c) Yevhen Rozhovetskyi
