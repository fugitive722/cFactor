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
	[Register ("cFactor_socialCommunity_Resource_Folder")]
	partial class cFactor_socialCommunity_Resource_Folder
	{
		[Outlet]
		MonoTouch.UIKit.UIButton actionBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView addressTextView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel descriptionLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView folderView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (actionBtn != null) {
				actionBtn.Dispose ();
				actionBtn = null;
			}

			if (addressTextView != null) {
				addressTextView.Dispose ();
				addressTextView = null;
			}

			if (descriptionLabel != null) {
				descriptionLabel.Dispose ();
				descriptionLabel = null;
			}

			if (folderView != null) {
				folderView.Dispose ();
				folderView = null;
			}
		}
	}
}
