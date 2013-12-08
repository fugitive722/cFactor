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
	[Register ("cFactor_socialCommunity_Blog")]
	partial class cFactor_socialCommunity_Blog
	{
		[Outlet]
		MonoTouch.UIKit.UITableView blogTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (blogTableView != null) {
				blogTableView.Dispose ();
				blogTableView = null;
			}
		}
	}
}
