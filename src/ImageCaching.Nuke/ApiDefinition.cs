using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.Nuke
{

    // @interface ImagePipeline : NSObject
    [BaseType (typeof(NSObject))]
	interface LoginProxyManager
    {
		// @property (readonly, nonatomic, strong, class) ImagePipeline * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
        LoginProxyManager Shared { get; }

        // -(void)loadImageWithUrl:(NSURL * _Nonnull)url onCompleted:(void (^ _Nonnull)(UIImage * _Nullable, NSString * _Nonnull))onCompleted;
        [Export ("LoginWithViewController:")]
		void LoginWithViewController(UIViewController viewController);
	}
}
