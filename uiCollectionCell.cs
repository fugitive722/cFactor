using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace uicollectionView
{
	public partial class uiCollectionCell : UICollectionViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("uiCollectionCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("uiCollectionCell");

		public uiCollectionCell (IntPtr handle) : base (handle)
		{
		}

		public static uiCollectionCell Create ()
		{
			return (uiCollectionCell)Nib.Instantiate (null, null) [0];
		}
	}
}

