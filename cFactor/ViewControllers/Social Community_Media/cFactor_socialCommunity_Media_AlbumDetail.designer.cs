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
	[Register ("cFactor_socialCommunity_Media_AlbumDetail")]
	partial class cFactor_socialCommunity_Media_AlbumDetail
	{
		[Outlet]
		MonoTouch.UIKit.UIView albumFilesView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView descriptionView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView topView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (albumFilesView != null) {
				albumFilesView.Dispose ();
				albumFilesView = null;
			}

			if (topView != null) {
				topView.Dispose ();
				topView = null;
			}

			if (descriptionView != null) {
				descriptionView.Dispose ();
				descriptionView = null;
			}
		}
	}
}
