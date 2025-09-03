#import "ARKitSupportChecker.h"
#if __IPHONE_OS_VERSION_MAX_ALLOWED >= 11000
#import <ARKit/ARKit.h>
#endif

bool ARKitSupportCheck() {
#if __IPHONE_OS_VERSION_MAX_ALLOWED >= 11000
    return ARConfiguration.isSupported;
#else
    return false;
#endif
}