using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.FacebookSlim.iOS
{
	[Static]
	partial interface FacebookProxyConstants
	{
		// extern double FacebookProxyVersionNumber;
		[Field ("FacebookProxyVersionNumber", "__Internal")]
		double VersionNumber { get; }

		// extern const unsigned char[] FacebookProxyVersionString;
		[Field ("FacebookProxyVersionString", "__Internal")]
		NSString VersionString { get; }
	}

	// @interface CoreKitManagerSlim : NSObject
	[BaseType (typeof(NSObject))]
	interface CoreKitManagerSlim
	{
		// @property (readonly, nonatomic, strong, class) CoreKitManagerSlim * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		CoreKitManagerSlim Shared { get; }

		// -(void)enableLoggingBehaviorWithApploggingBehavior:(enum LoggingBehaviorEnum)apploggingBehavior;
		[Export ("enableLoggingBehaviorWithApploggingBehavior:")]
		void EnableLoggingBehavior (LoggingBehaviorEnum apploggingBehavior);

		// @property (nonatomic) BOOL isAdvertiserTrackingEnabled;
		[Export ("isAdvertiserTrackingEnabled")]
		bool IsAdvertiserTrackingEnabled { get; set; }

		// @property (nonatomic) BOOL isAdvertiserIdCollectionEnabled;
		[Export ("isAdvertiserIdCollectionEnabled")]
		bool IsAdvertiserIdCollectionEnabled { get; set; }

		// -(void)logEventWithAppEventName:(enum AppEventNameEnum)appEventName appparameters:(NSDictionary * _Nonnull)appparameters;
		[Export ("logEventWithAppEventName:appparameters:")]
		void LogEvent (AppEventNameEnum appEventName, NSDictionary appparameters);

		// @property (copy, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export ("userId")]
		string UserId { get; set; }

		// -(void)setUserWithUserEmail:(NSString * _Nonnull)userEmail firstName:(NSString * _Nonnull)firstName lastName:(NSString * _Nonnull)lastName phone:(NSString * _Nonnull)phone dateOfBirth:(NSString * _Nonnull)dateOfBirth gender:(NSString * _Nonnull)gender city:(NSString * _Nonnull)city state:(NSString * _Nonnull)state zip:(NSString * _Nonnull)zip country:(NSString * _Nonnull)country;
		[Export ("setUserWithUserEmail:firstName:lastName:phone:dateOfBirth:gender:city:state:zip:country:")]
		void SetUser (string userEmail, string firstName, string lastName, string phone, string dateOfBirth, string gender, string city, string state, string zip, string country);

		// -(NSString * _Nonnull)anonymousId __attribute__((warn_unused_result("")));
		[Export ("anonymousId")]
		string AnonymousId { get; }

		// -(void)activateApp;
		[Export ("activateApp")]
		void ActivateApp ();

		// -(void)logEventCustomWithAppEventName:(NSString * _Nonnull)appEventName appparameters:(NSDictionary * _Nonnull)appparameters;
		[Export ("logEventCustomWithAppEventName:appparameters:")]
		void LogEvent (string appEventName, NSDictionary appparameters);

		// -(void)initializeSdk;
		[Export ("initializeSdk")]
		void InitializeSdk ();

		// -(BOOL)finishedLaunchingWithApp:(UIApplication * _Nonnull)app options:(NSDictionary<UIApplicationLaunchOptionsKey,id> * _Nonnull)options __attribute__((warn_unused_result("")));
		[Export ("finishedLaunchingWithApp:options:")]
		bool FinishedLaunching (UIApplication app, NSDictionary<NSString, NSObject> options);

		// -(BOOL)openUrlWithApp:(UIApplication * _Nonnull)app url:(NSURL * _Nonnull)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> * _Nonnull)options __attribute__((warn_unused_result("")));
		[Export ("openUrlWithApp:url:options:")]
		bool OpenUrl (UIApplication app, NSUrl url, NSDictionary<NSString, NSObject> options);
	}

	// @interface LoginManagerSlim : NSObject
	[BaseType (typeof(NSObject))]
	interface LoginManagerSlim
	{
		// @property (readonly, nonatomic, strong, class) LoginManagerSlim * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		LoginManagerSlim Shared { get; }

		// -(void)loginWithPermissions:(NSArray<NSString *> * _Nonnull)permissions viewController:(UIViewController * _Nonnull)viewController onCompleted:(void (^ _Nonnull)(enum LoginResultEnum, LoginResult * _Nullable, NSError * _Nullable))onCompleted;
		[Export ("loginWithPermissions:viewController:onCompleted:")]
		void Login (string[] permissions, UIViewController viewController, Action<LoginResultEnum, LoginResult, NSError> onCompleted);

		// -(void)logout;
		[Export ("logout")]
		void Logout ();
	}

	// @interface LoginResult : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13FacebookProxy11LoginResult")]
	interface LoginResult
	{
		// @property (copy, nonatomic) NSString * _Nonnull token;
		[Export ("token")]
		string Token { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull authenticationToken;
		[Export ("authenticationToken")]
		string AuthenticationToken { get; set; }

		// @property (copy, nonatomic) NSSet<NSString *> * _Nonnull grantedPermissions;
		[Export ("grantedPermissions", ArgumentSemantic.Copy)]
		NSSet<NSString> GrantedPermissions { get; set; }

		// @property (copy, nonatomic) NSSet<NSString *> * _Nonnull declinedPermissions;
		[Export ("declinedPermissions", ArgumentSemantic.Copy)]
		NSSet<NSString> DeclinedPermissions { get; set; }
	}
}
