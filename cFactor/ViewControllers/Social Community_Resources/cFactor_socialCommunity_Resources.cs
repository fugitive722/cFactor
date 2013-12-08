using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Resources : UIViewController
	{
		public event EventHandler fullScreenClicked;
		public Boolean _fullS = false;
		UINavigationController _navi;
		public cFactor_socialCommunity_Resources (UINavigationController n) : base ("cFactor_socialCommunity_Resources", null)
		{
			_navi = n;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			fullBtn.TouchUpInside += (object sender, EventArgs e) => {

				if(_fullS){
					fullScreen();
				}else{
					smallScreen();
				}
			};

			var dvc = new cFactor_socialCommunity_Resource_DVC (_navi);
			this.dvcView.Add (dvc.View);

			fullBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("fullscreen.png"));
			refBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("refresh_button_inactive.png"));

		}

		private void smallScreen(){
			dvcView.Frame = new RectangleF(0,55,320,513);
			//fullBtn.SetTitle("Small",UIControlState.Normal);
			_fullS = true;
			if(fullScreenClicked != null){
				fullScreenClicked(this,EventArgs.Empty);
			}
		}

		private void fullScreen(){
			//fullBtn.SetTitle("Lagre",UIControlState.Normal);
			_fullS = false;
			if(fullScreenClicked != null){
				fullScreenClicked(this,EventArgs.Empty);
			}
		}

		public void changeToSmallScreen()
		{
			//fullBtn.SetTitle("Lagre",UIControlState.Normal);
			_fullS = false;
		}


	}
}

