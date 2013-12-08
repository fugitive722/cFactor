// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace cFactor
{
	[Register ("cFactor_socialProfile")]
	partial class cFactor_socialProfile
	{
		[Outlet]
		MonoTouch.UIKit.UIView botView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView detailTextView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton followBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView headerView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton naviBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIPickerView naviPicker { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView topView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView userImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView webView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (botView != null) {
				botView.Dispose ();
				botView = null;
			}

			if (detailTextView != null) {
				detailTextView.Dispose ();
				detailTextView = null;
			}

			if (followBtn != null) {
				followBtn.Dispose ();
				followBtn = null;
			}

			if (headerView != null) {
				headerView.Dispose ();
				headerView = null;
			}

			if (naviPicker != null) {
				naviPicker.Dispose ();
				naviPicker = null;
			}

			if (topView != null) {
				topView.Dispose ();
				topView = null;
			}

			if (userImage != null) {
				userImage.Dispose ();
				userImage = null;
			}

			if (webView != null) {
				webView.Dispose ();
				webView = null;
			}

			if (naviBtn != null) {
				naviBtn.Dispose ();
				naviBtn = null;
			}
		}
	}
}
