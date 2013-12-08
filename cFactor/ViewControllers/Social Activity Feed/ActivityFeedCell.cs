using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace cFactorMockup
{
	public partial class ActivityFeedCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("ActivityFeedCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("ActivityFeedCell");

		public ActivityFeedCell (IntPtr handle) : base (handle)
		{
		}


		public static ActivityFeedCell Create ()
		{
			return (ActivityFeedCell)Nib.Instantiate (null, null) [0];

		}

	}
}

