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
	[Register ("cFactor_socialCommunity_BlogCell")]
	partial class cFactor_socialCommunity_BlogCell
	{
		[Outlet]
		public MonoTouch.UIKit.UIImageView authorImage { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIWebView blogWeb { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIButton funtionBtn { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel timeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (timeLabel != null) {
				timeLabel.Dispose ();
				timeLabel = null;
			}

			if (authorImage != null) {
				authorImage.Dispose ();
				authorImage = null;
			}

			if (blogWeb != null) {
				blogWeb.Dispose ();
				blogWeb = null;
			}

			if (funtionBtn != null) {
				funtionBtn.Dispose ();
				funtionBtn = null;
			}
		}
	}
}
