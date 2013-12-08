// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace cFactorMockup
{
	[Register ("ActivityFeedCell")]
	partial class ActivityFeedCell
	{
		[Outlet]
		public MonoTouch.UIKit.UIImageView authorImage { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UILabel authorName { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIButton commentBtn { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIImageView iconImage { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIButton ratingBtn { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UITextView summaryText { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIButton titleBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (titleBtn != null) {
				titleBtn.Dispose ();
				titleBtn = null;
			}

			if (iconImage != null) {
				iconImage.Dispose ();
				iconImage = null;
			}

			if (summaryText != null) {
				summaryText.Dispose ();
				summaryText = null;
			}

			if (ratingBtn != null) {
				ratingBtn.Dispose ();
				ratingBtn = null;
			}

			if (commentBtn != null) {
				commentBtn.Dispose ();
				commentBtn = null;
			}

			if (authorName != null) {
				authorName.Dispose ();
				authorName = null;
			}

			if (authorImage != null) {
				authorImage.Dispose ();
				authorImage = null;
			}
		}
	}
}
