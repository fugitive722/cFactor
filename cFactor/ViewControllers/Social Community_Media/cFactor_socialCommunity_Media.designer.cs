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
	[Register ("cFactor_socialCommunity_Media")]
	partial class cFactor_socialCommunity_Media
	{
		[Outlet]
		MonoTouch.UIKit.UIButton addBtn { get; set; }

		[Outlet]
		public MonoTouch.UIKit.UIView collectionView { get; private set; }

		[Outlet]
		MonoTouch.UIKit.UIButton fullBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton refreshBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addBtn != null) {
				addBtn.Dispose ();
				addBtn = null;
			}

			if (collectionView != null) {
				collectionView.Dispose ();
				collectionView = null;
			}

			if (fullBtn != null) {
				fullBtn.Dispose ();
				fullBtn = null;
			}

			if (refreshBtn != null) {
				refreshBtn.Dispose ();
				refreshBtn = null;
			}
		}
	}
}
