//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Xamarin.Nuke {
	[Register("ImagePipeline", true)]
	public unsafe partial class ImagePipeline : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ImagePipeline");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ImagePipeline () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ImagePipeline (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ImagePipeline (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loadDataWithUrl:onCompleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadDataWithUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSData, NSUrlResponse> onCompleted)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (onCompleted is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onCompleted));
			BlockLiteral *block_ptr_onCompleted;
			BlockLiteral block_onCompleted;
			block_onCompleted = new BlockLiteral ();
			block_ptr_onCompleted = &block_onCompleted;
			block_onCompleted.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, onCompleted);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadDataWithUrl:onCompleted:"), url__handle__, (IntPtr) block_ptr_onCompleted);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadDataWithUrl:onCompleted:"), url__handle__, (IntPtr) block_ptr_onCompleted);
			}
			block_ptr_onCompleted->CleanupBlock ();
		}
		[Export ("loadDataWithUrl:imageIdKey:reloadIgnoringCachedData:onCompleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadDataWithUrl (NSUrl url, string? imageIdKey, bool reloadIgnoringCachedData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSData, NSUrlResponse> onCompleted)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (onCompleted is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onCompleted));
			var nsimageIdKey = CFString.CreateNative (imageIdKey);
			BlockLiteral *block_ptr_onCompleted;
			BlockLiteral block_onCompleted;
			block_onCompleted = new BlockLiteral ();
			block_ptr_onCompleted = &block_onCompleted;
			block_onCompleted.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, onCompleted);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("loadDataWithUrl:imageIdKey:reloadIgnoringCachedData:onCompleted:"), url__handle__, nsimageIdKey, reloadIgnoringCachedData, (IntPtr) block_ptr_onCompleted);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadDataWithUrl:imageIdKey:reloadIgnoringCachedData:onCompleted:"), url__handle__, nsimageIdKey, reloadIgnoringCachedData, (IntPtr) block_ptr_onCompleted);
			}
			CFString.ReleaseNative (nsimageIdKey);
			block_ptr_onCompleted->CleanupBlock ();
		}
		[Export ("loadImageWithUrl:onCompleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadImageWithUrl (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<global::UIKit.UIImage, NSString> onCompleted)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (onCompleted is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (onCompleted));
			BlockLiteral *block_ptr_onCompleted;
			BlockLiteral block_onCompleted;
			block_onCompleted = new BlockLiteral ();
			block_ptr_onCompleted = &block_onCompleted;
			block_onCompleted.SetupBlockUnsafe (Trampolines.SDActionArity2V1.Handler, onCompleted);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadImageWithUrl:onCompleted:"), url__handle__, (IntPtr) block_ptr_onCompleted);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadImageWithUrl:onCompleted:"), url__handle__, (IntPtr) block_ptr_onCompleted);
			}
			block_ptr_onCompleted->CleanupBlock ();
		}
		[Export ("loadImageWithUrl:placeholder:errorImage:into:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadImageWithUrl (NSUrl url, global::UIKit.UIImage? placeholder, global::UIKit.UIImage? errorImage, global::UIKit.UIImageView into)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var placeholder__handle__ = placeholder.GetHandle ();
			var errorImage__handle__ = errorImage.GetHandle ();
			var into__handle__ = into!.GetNonNullHandle (nameof (into));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadImageWithUrl:placeholder:errorImage:into:"), url__handle__, placeholder__handle__, errorImage__handle__, into__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadImageWithUrl:placeholder:errorImage:into:"), url__handle__, placeholder__handle__, errorImage__handle__, into__handle__);
			}
		}
		[Export ("loadImageWithUrl:imageIdKey:placeholder:errorImage:into:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadImageWithUrl (NSUrl url, string imageIdKey, global::UIKit.UIImage? placeholder, global::UIKit.UIImage? errorImage, global::UIKit.UIImageView into)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (imageIdKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (imageIdKey));
			var placeholder__handle__ = placeholder.GetHandle ();
			var errorImage__handle__ = errorImage.GetHandle ();
			var into__handle__ = into!.GetNonNullHandle (nameof (into));
			var nsimageIdKey = CFString.CreateNative (imageIdKey);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadImageWithUrl:imageIdKey:placeholder:errorImage:into:"), url__handle__, nsimageIdKey, placeholder__handle__, errorImage__handle__, into__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("loadImageWithUrl:imageIdKey:placeholder:errorImage:into:"), url__handle__, nsimageIdKey, placeholder__handle__, errorImage__handle__, into__handle__);
			}
			CFString.ReleaseNative (nsimageIdKey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ImagePipeline Shared {
			[Export ("shared", ArgumentSemantic.Retain)]
			get {
				ImagePipeline? ret;
				ret =  Runtime.GetNSObject<ImagePipeline> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("shared")))!;
				return ret!;
			}
		}
	} /* class ImagePipeline */
}
