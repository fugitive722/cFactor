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
	[Register ("cFactor_socialCommunity_Content")]
	partial class cFactor_socialCommunity_Content
	{
		[Outlet]
		MonoTouch.UIKit.UIButton actionBtn { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIView bodyView { get; private set; }

		[Outlet]
		MonoTouch.UIKit.UITableView contentTableView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton filterBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIPickerView filterPicker { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton fullBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView midView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView pickerView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton refreshBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton searchBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView topView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (actionBtn != null) {
				actionBtn.Dispose ();
				actionBtn = null;
			}

			if (bodyView != null) {
				bodyView.Dispose ();
				bodyView = null;
			}

			if (contentTableView != null) {
				contentTableView.Dispose ();
				contentTableView = null;
			}

			if (filterBtn != null) {
				filterBtn.Dispose ();
				filterBtn = null;
			}

			if (filterPicker != null) {
				filterPicker.Dispose ();
				filterPicker = null;
			}

			if (fullBtn != null) {
				fullBtn.Dispose ();
				fullBtn = null;
			}

			if (midView != null) {
				midView.Dispose ();
				midView = null;
			}

			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}

			if (refreshBtn != null) {
				refreshBtn.Dispose ();
				refreshBtn = null;
			}

			if (topView != null) {
				topView.Dispose ();
				topView = null;
			}

			if (searchBtn != null) {
				searchBtn.Dispose ();
				searchBtn = null;
			}
		}
	}
}
