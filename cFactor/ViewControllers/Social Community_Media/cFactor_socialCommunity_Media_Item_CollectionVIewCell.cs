using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Media_Item_CollectionVIewCell : UICollectionViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("cFactor_socialCommunity_Media_Item_CollectionVIewCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("cFactor_socialCommunity_Media_Item_CollectionVIewCell");

		UITextView descriptionText;
		UIImageView imageView;
		UIButton ratingBtn;
		UIButton commentsBtn;
		UIButton tagsBtn;
		UIButton actionBtn;
		UILabel  title;


		public cFactor_socialCommunity_Media_Item_CollectionVIewCell (IntPtr handle) : base (handle)
		{


			title = new UILabel ();
			title.Frame = new RectangleF (0,0,320,20);
			title.TextAlignment = UITextAlignment.Center;

			descriptionText = new UITextView ();
			descriptionText.Frame = new RectangleF (0,20,320,80);

			//descriptionText.Text = "Hello World ";



			imageView = new UIImageView ();
			imageView.Frame = new RectangleF (0,100,320,200);


			ratingBtn = new UIButton ();
			ratingBtn.Frame = new RectangleF (0,350,72,30);
			ratingBtn.SetTitleColor(UIColor.Black,UIControlState.Normal);
			ratingBtn.SetTitle ("Rating", UIControlState.Normal);
			ratingBtn.TouchUpInside += (object sender, EventArgs e) => {
				new UIAlertView ("Rating", "Thanks for tapping!", null, "Continue").Show (); 
			};

			commentsBtn = new UIButton ();
			commentsBtn.Frame = new RectangleF (72,350,100,30);
			commentsBtn.SetTitleColor( UIColor.Black,UIControlState.Normal);
			commentsBtn.SetTitle ("Comments", UIControlState.Normal);
			commentsBtn.TouchUpInside += (object sender, EventArgs e) => {
				new UIAlertView ("Comments", "Thanks for tapping!", null, "Continue").Show (); 
			};

			tagsBtn = new UIButton ();
			tagsBtn.Frame = new RectangleF (170,350,72,30);
			tagsBtn.SetTitleColor( UIColor.Black,UIControlState.Normal);
			tagsBtn.SetTitle ("Tags", UIControlState.Normal);

			tagsBtn.TouchUpInside += (object sender, EventArgs e) => {
				new UIAlertView ("Tags", "Thanks for tapping!", null, "Continue").Show (); 
			};

			actionBtn = new  UIButton ();
			actionBtn.Frame = new RectangleF (255,350,65,30);
			actionBtn.SetTitleColor( UIColor.Black,UIControlState.Normal);
			actionBtn.SetTitle ("Actions", UIControlState.Normal);
			actionBtn.TouchUpInside += (object sender, EventArgs e) => {
				new UIAlertView ("Action", "Thanks for tapping!", null, "Continue").Show (); 
			};

			ContentView.Add (title);
			ContentView.Add (descriptionText);
			ContentView.Add (imageView);
			ContentView.Add (ratingBtn);
			ContentView.Add (commentsBtn);
			ContentView.Add (tagsBtn);
			ContentView.Add (actionBtn);
		}

		public static cFactor_socialCommunity_Media_Item_CollectionVIewCell Create ()
		{
			return (cFactor_socialCommunity_Media_Item_CollectionVIewCell)Nib.Instantiate (null, null) [0];
		}

		public void setTitle (string t){
			title.Text = t;
		}

		public void setDescriptionView (string d){
			descriptionText.Text = d;
			descriptionText.Editable = false;
		}

		public void setImage (string n) {
			imageView.Image = UIImage.FromFile (n);
		}
	}
}

