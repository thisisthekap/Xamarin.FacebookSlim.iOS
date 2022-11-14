using Foundation;
using NativeLibrary;
using System;
using UIKit;

namespace iosSample
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();


            var btn = UIButton.FromType(UIButtonType.RoundedRect);

            btn.Frame = new CoreGraphics.CGRect(20, 100, 150, 50);
            btn.SetTitle("Test", UIControlState.Normal);
            btn.TouchUpInside += TouchUpInsideHandler;
            this.View.AddSubview(btn);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void TouchUpInsideHandler(object sender, EventArgs e)
        {
            var logonManager = LoginProxyManager.Shared;
            logonManager.LoginWithViewController(this);
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
