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
	[Register ("cFactor_socialCommunities")]
	partial class cFactor_socialCommunities
	{
		[Outlet]
		MonoTouch.UIKit.UIView buttomView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton filterBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIPickerView filterPicker { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView midView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton refreshBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView topView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (topView != null) {
				topView.Dispose ();
				topView = null;
			}

			if (buttomView != null) {
				buttomView.Dispose ();
				buttomView = null;
			}

			if (filterBtn != null) {
				filterBtn.Dispose ();
				filterBtn = null;
			}

			if (refreshBtn != null) {
				refreshBtn.Dispose ();
				refreshBtn = null;
			}

			if (midView != null) {
				midView.Dispose ();
				midView = null;
			}

			if (filterPicker != null) {
				filterPicker.Dispose ();
				filterPicker = null;
			}
		}
	}
}
