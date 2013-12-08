using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace cFactor
{
	public partial class cFactor_socialCommunity_BlogCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("cFactor_socialCommunity_BlogCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("cFactor_socialCommunity_BlogCell");

		public cFactor_socialCommunity_BlogCell (IntPtr handle) : base (handle)
		{
		}

		public static cFactor_socialCommunity_BlogCell Create ()
		{
			return (cFactor_socialCommunity_BlogCell)Nib.Instantiate (null, null) [0];
		}
	}
}

