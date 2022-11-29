using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.FacebookSlim
{

    // @interface CoreKitManagerSlim : NSObject
    [BaseType(typeof(NSObject))]
    interface CoreKitManagerSlim
    {
        // @property (readonly, nonatomic, strong, class) CoreKitManagerSlim * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        CoreKitManagerSlim Shared { get; }

        // -(void)enableLoggingBehaviorWithApploggingBehavior:(enum ProxyLoggingBehavior)apploggingBehavior;
        [Export("enableLoggingBehaviorWithApploggingBehavior:")]
        void EnableLoggingBehaviorWithApploggingBehavior(ProxyLoggingBehavior apploggingBehavior);

        // -(void)IsAdvertiserTrackingEnabledWithEnabled:(BOOL)enabled;
        [Export("IsAdvertiserTrackingEnabledWithEnabled:")]
        void IsAdvertiserTrackingEnabledWithEnabled(bool enabled);

        // -(BOOL)isAdvertiserTrackingEnabled __attribute__((warn_unused_result("")));
        [Export("isAdvertiserTrackingEnabled")]
        bool IsAdvertiserTrackingEnabled { get; }

        // -(void)IsAdvertiserIdCollectionEnabledWithEnabled:(BOOL)enabled;
        [Export("IsAdvertiserIdCollectionEnabledWithEnabled:")]
        void IsAdvertiserIdCollectionEnabledWithEnabled(bool enabled);

        // -(BOOL)isAdvertiserIdCollectionEnabled __attribute__((warn_unused_result("")));
        [Export("isAdvertiserIdCollectionEnabled")]
        bool IsAdvertiserIdCollectionEnabled { get; }

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

    // @interface LoginManagerSlim : NSObject
    [BaseType(typeof(NSObject))]
    interface LoginManagerSlim
    {
        // @property (readonly, nonatomic, strong, class) LoginManagerSlim * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        LoginManagerSlim Shared { get; }

        // -(void)loginWithViewController:(UIViewController * _Nonnull)viewController onCompleted:(void (^ _Nonnull)(enum loginResultEnum, LoginResult * _Nullable))onCompleted;
        [Export("loginWithViewController:onCompleted:")]
        void LoginWithViewController(UIViewController viewController, Action<LoginResultEnum, LoginResult> onCompleted);

        // -(void)logout;
        [Export("logout")]
        void Logout();
    }

    // @interface LoginResult : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC13FacebookProxy11LoginResult")]
    interface LoginResult
    {
        // @property (copy, nonatomic) NSString * _Nonnull token;
        [Export("token")]
        string Token { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull authenticationToken;
        [Export("authenticationToken")]
        string AuthenticationToken { get; set; }

        // @property (copy, nonatomic) NSSet<NSString *> * _Nonnull grantedPermissions;
        [Export("grantedPermissions", ArgumentSemantic.Copy)]
        NSSet<NSString> GrantedPermissions { get; set; }

        // @property (copy, nonatomic) NSSet<NSString *> * _Nonnull declinedPermissions;
        [Export("declinedPermissions", ArgumentSemantic.Copy)]
        NSSet<NSString> DeclinedPermissions { get; set; }
    }
}
