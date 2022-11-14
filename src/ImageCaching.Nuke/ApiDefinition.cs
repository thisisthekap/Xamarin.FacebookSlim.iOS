using System;
using FacebookProxy;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FacebookProxy
{

    // @interface ImagePipeline : NSObject
    [BaseType(typeof(NSObject))]
    interface CoreKitProxyManager
    {
        // @property (readonly, nonatomic, strong, class) CoreKitProxyManager * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        CoreKitProxyManager Shared { get; }

        // -(void)enableLoggingBehaviorWithApploggingBehavior:(enum ProxyLoggingBehavior)apploggingBehavior;
        [Export("enableLoggingBehaviorWithApploggingBehavior:")]
        void EnableLoggingBehaviorWithApploggingBehavior(ProxyLoggingBehavior apploggingBehavior);

        // -(void)setAdvertiserTrackingEnabledWithEnabled:(BOOL)enabled;
        [Export("setAdvertiserTrackingEnabledWithEnabled:")]
        void SetAdvertiserTrackingEnabledWithEnabled(bool enabled);

        // -(void)setAdvertiserIdCollectionEnabledWithEnabled:(BOOL)enabled;
        [Export("setAdvertiserIdCollectionEnabledWithEnabled:")]
        void SetAdvertiserIdCollectionEnabledWithEnabled(bool enabled);

        // -(void)logEventWithAppEventName:(enum AppEventNameEnum)appEventName appparameters:(NSDictionary * _Nonnull)appparameters;
        [Export("logEventWithAppEventName:appparameters:")]
        void LogEventWithAppEventName(AppEventNameEnum appEventName, NSDictionary appparameters);

        // -(void)logEventCustomWithAppEventName:(NSString * _Nonnull)appEventName appparameters:(NSDictionary * _Nonnull)appparameters;
        [Export("logEventCustomWithAppEventName:appparameters:")]
        void LogEventCustomWithAppEventName(string appEventName, NSDictionary appparameters);

        // -(void)initializeSdk;
        [Export("initializeSdk")]
        void InitializeSdk();
    }

    [BaseType(typeof(NSObject))]
    interface LoginProxyManager
    {
        // @property (readonly, nonatomic, strong, class) LoginProxyManager * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        LoginProxyManager Shared { get; }

        // -(void)loginWithViewController:(UIViewController * _Nonnull)viewController onCompleted:(void (^ _Nonnull)(enum loginResultEnum, LoginResult * _Nullable))onCompleted;
        [Export("loginWithViewController:onCompleted:")]
        void LoginWithViewController(UIViewController viewController, Action<loginResultEnum, LoginResult> onCompleted);

        // -(void)logout;
        [Export("logout")]
        void Logout();
    }

    [BaseType(typeof(NSObject), Name = "_TtC13FacebookProxy11LoginResult")]
    interface LoginResult
    {
    }
}
