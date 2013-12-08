using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace cFactor
{
	public partial class cFactor_socialCommunities : UIViewController
	{
		cFactor_socialCommunities_bottomViewDVC _cardInterfaceDVC;

		//UINavigationController _navi;
		public cFactor_socialCommunities () : base ("cFactor_socialCommunities", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// initialize

			_cardInterfaceDVC = new cFactor_socialCommunities_bottomViewDVC (this.NavigationController);
			//_navi = new UINavigationController (_cardInterfaceDVC);
			buttomView.Add (_cardInterfaceDVC.View);

			// control views appeare order
			buttomView.Hidden = true;

			// setup filter picker 
			var filterPickerModel = new cFactor_socialCommunities_pickerSource ();
			filterPickerModel.valueChanged += (object sender, EventArgs e) => {
				filterBtn.SetTitle(filterPickerModel.selectedSuject,UIControlState.Normal);
				midView.Hidden = true;
				buttomView.Hidden = false;
			};
			filterPicker.Model = filterPickerModel;


			// set up filter button clicked
			filterBtn.TouchUpInside += (object sender, EventArgs e) => {
				buttomView.Hidden = true;
				midView.Hidden = false;
			};

			refreshBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("refresh_button_inactive.png"));

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, true);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, true);
		}
	}
}

