using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Media_AllAlbumsCell : UICollectionViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("cFactor_socialCommunity_Media_AllAlbumsCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("cFactor_socialCommunity_Media_AllAlbumsCell");

//		UILabel nameLabel;
		UIButton clickBtn;
		public cFactor_socialCommunity_Media_AllAlbumsCell (IntPtr handle) : base (handle)
		{
//			nameLabel = new UILabel (new RectangleF (5,15,80,80));
//			nameLabel.LineBreakMode = UILineBreakMode.WordWrap;
//			nameLabel.Lines = 0;
//			//nameLabel.Text = "Wen";
//			ContentView.Add (nameLabel);


			clickBtn = new UIButton (UIButtonType.Custom);
			clickBtn.Frame = new RectangleF (0,0,this.Frame.Width,this.Frame.Height);
			clickBtn.TitleLabel.TextAlignment = UITextAlignment.Center;
			clickBtn.TitleLabel.LineBreakMode = UILineBreakMode.WordWrap;
			ContentView.Add (clickBtn);
		}

		public static cFactor_socialCommunity_Media_AllAlbumsCell Create ()
		{
			return (cFactor_socialCommunity_Media_AllAlbumsCell)Nib.Instantiate (null, null) [0];
		}

		public void setName (string name){
//			this.nameLabel.Text = name;
			clickBtn.SetTitle (name,UIControlState.Normal);
		}

		public void setClickDelegate(UINavigationController n,Boolean t){

			if(t){
				clickBtn.TouchUpInside+= (object sender, EventArgs e) => {
					Console.Out.WriteLine(clickBtn.Title(UIControlState.Normal));
					n.PushViewController(new cFactor_socialCommunity_Media_AlbumDetail(WebServiceRequest.sharedRequest.getCommunityMediaAlbum(),n),true);
				};
			}
		
		}
	}
}

