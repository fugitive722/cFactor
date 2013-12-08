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
	[Register ("cFactor_socialCommunity_Resources")]
	partial class cFactor_socialCommunity_Resources
	{
		[Outlet]
		public MonoTouch.UIKit.UIView dvcView { get; private set; }

		[Outlet]
		MonoTouch.UIKit.UIButton fullBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton refBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView topView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dvcView != null) {
				dvcView.Dispose ();
				dvcView = null;
			}

			if (fullBtn != null) {
				fullBtn.Dispose ();
				fullBtn = null;
			}

			if (topView != null) {
				topView.Dispose ();
				topView = null;
			}

			if (refBtn != null) {
				refBtn.Dispose ();
				refBtn = null;
			}
		}
	}
}
