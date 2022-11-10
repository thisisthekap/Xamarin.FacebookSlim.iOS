using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{
    [BaseType(typeof(NSObject))]
    interface LoginProxyManager
    {
        // @property (readonly, nonatomic, strong, class) ImagePipeline * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        LoginProxyManager Shared { get; }

        // -(void)loadImageWithUrl:(NSURL * _Nonnull)url onCompleted:(void (^ _Nonnull)(UIImage * _Nullable, NSString * _Nonnull))onCompleted;
        [Export("LoginWithViewController:")]
        void LoginWithViewController(UIViewController viewController);

        [Export("Login:")]
        void LoginController(UIViewController viewController);
    }
}


