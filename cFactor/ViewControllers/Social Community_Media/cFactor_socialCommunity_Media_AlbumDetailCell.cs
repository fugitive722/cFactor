using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Media_AlbumDetailCell : UICollectionViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("cFactor_socialCommunity_Media_AlbumDetailCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("cFactor_socialCommunity_Media_AlbumDetailCell");

		UIButton clickBtn;

		public cFactor_socialCommunity_Media_AlbumDetailCell (IntPtr handle) : base (handle)
		{
			clickBtn = new UIButton (UIButtonType.Custom);
			clickBtn.Frame = new RectangleF (0,0,this.Frame.Width,this.Frame.Height);
			clickBtn.TitleLabel.TextAlignment = UITextAlignment.Center;
			clickBtn.TitleLabel.LineBreakMode = UILineBreakMode.WordWrap;
			ContentView.Add (clickBtn);
		}

		public static cFactor_socialCommunity_Media_AlbumDetailCell Create ()
		{
			return (cFactor_socialCommunity_Media_AlbumDetailCell)Nib.Instantiate (null, null) [0];
		}

		public void setName (string name){
//			this.nameLabel.Text = name;
			clickBtn.SetTitle (name,UIControlState.Normal);
		}

		public void setClickDelegate(UINavigationController n, Boolean t){
			if(t){
				clickBtn.TouchUpInside+= (object sender, EventArgs e) => {
					Console.Out.WriteLine(clickBtn.Title(UIControlState.Normal));
					//n.PushViewController(new cFactor_socialCommunity_Media_AlbumDetail(WebServiceRequest.sharedRequest.getCommunityMediaAlbum(),n),true);
					n.PushViewController(new cFactor_SocialCommunity_Media_Item(),true);
				};
			}

		}
	}
}

