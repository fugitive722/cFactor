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
	[Register ("cFactor_social_Search")]
	partial class cFactor_social_Search
	{
		[Outlet]
		MonoTouch.UIKit.UIButton cancelBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton filterBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISearchBar searchBar { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView tableView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIView topView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (topView != null) {
				topView.Dispose ();
				topView = null;
			}

			if (filterBtn != null) {
				filterBtn.Dispose ();
				filterBtn = null;
			}

			if (searchBar != null) {
				searchBar.Dispose ();
				searchBar = null;
			}

			if (cancelBtn != null) {
				cancelBtn.Dispose ();
				cancelBtn = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}
		}
	}
}
