﻿using System;
using Foundation;
using ObjCRuntime;
using SkiaSharp;
using SkiaSharp.Views.iOS;
using UIKit;
using Xamarin.FacebookSlim.iOS;

namespace Sample
{
    public partial class ViewController : UIViewController
    {
        private SKBitmap _bitmap;

        public ViewController(NativeHandle handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var image = new UIImageView
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            Add(image);

            UIButton button = AddButton("Placeholder");

            button.TouchUpInside += (s, e) =>
            {
                var logonManager = LoginManagerSlim.Shared;
                logonManager.Login(new[] { "email", "profile" }, this, delegateHandler);
            };

            var skiaView = new SKCanvasView
            {
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            skiaView.PaintSurface += OnPaintSurface;
            Add(skiaView);

            UIButton button2 = AddButton("Login Test");

            button2.TouchUpInside += (s, e) =>
            {
                var logonManager = LoginManagerSlim.Shared;
                logonManager.Login(new[] { "email", "profile" }, this, delegateHandler);
            };

            AddConstraints(image, button, button2, skiaView);
        }

        private void delegateHandler(LoginResultEnum enumt, LoginResult result, NSError error)
        {
        }

        private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            if (_bitmap == null)
                return;

            e.Surface.Canvas.DrawBitmap(_bitmap, SKPoint.Empty);
        }

        private void AddConstraints(UIImageView image, UIButton button, UIButton button2, SKCanvasView skiaView)
        {
            image.WidthAnchor.ConstraintEqualTo(View.WidthAnchor).Active = true;
            image.HeightAnchor.ConstraintEqualTo(View.WidthAnchor).Active = true;
            image.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor).Active = true;
            image.TopAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.TopAnchor).Active = true;

            button.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor, 16).Active = true;
            button.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor, -16).Active = true;
            button.BottomAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.BottomAnchor, -20).Active = true;

            button2.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor, 16).Active = true;
            button2.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor, -16).Active = true;
            button2.BottomAnchor.ConstraintEqualTo(button.TopAnchor, -20).Active = true;

            skiaView.TopAnchor.ConstraintEqualTo(image.BottomAnchor, 10).Active = true;
            skiaView.LeadingAnchor.ConstraintEqualTo(View.LeadingAnchor, 16).Active = true;
            skiaView.TrailingAnchor.ConstraintEqualTo(View.TrailingAnchor, -16).Active = true;
            skiaView.BottomAnchor.ConstraintEqualTo(button2.TopAnchor, -16).Active = true;
        }

        private UIButton AddButton(string title)
        {
            var button = new UIButton
            {
                TranslatesAutoresizingMaskIntoConstraints = false,
                BackgroundColor = UIColor.Orange
            };
            button.SetTitleColor(UIColor.Black, UIControlState.Normal);
            button.SetTitle(title, UIControlState.Normal);

            Add(button);
            return button;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}