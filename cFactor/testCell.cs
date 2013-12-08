using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace cFactor
{
	public partial class testCell : UICollectionViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("testCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("testCell");

		public testCell (IntPtr handle) : base (handle)
		{
		}

		public static testCell Create ()
		{
			return (testCell)Nib.Instantiate (null, null) [0];
		}
	}
}

