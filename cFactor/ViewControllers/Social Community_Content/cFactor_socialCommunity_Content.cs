using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading.Tasks;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Content : UIViewController
	{
		public Boolean _fullS = false;
		public event EventHandler fullScreenClicked;
		cFactor_socialCommunity_Content_filterSource _model;
		//cFactor_social_Search _search;
		UINavigationController _navi;
		cFactor_socialCommunity_Content_tableViewSource defaultTableSource;
		public cFactor_socialCommunity_Content (UINavigationController n) : base ("cFactor_socialCommunity_Content", null)
		{
			_navi = n;
		}


		private void smallScreen()
		{
			bodyView.Frame = new RectangleF(0,55,320,513);
			//fullBtn.SetTitle("Small",UIControlState.Normal);
			_fullS = true;
			if(fullScreenClicked != null){
				fullScreenClicked(this,EventArgs.Empty);
			}
		}

		private void fullScreen()
		{
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
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// set up full screen button
			fullBtn.TouchUpInside += (object sender, EventArgs e) => {

				if(_fullS){

					fullScreen();

				}else{
					smallScreen();
				}
			};

			// set up filter function
			pickerView.Hidden = true;
			_model = new cFactor_socialCommunity_Content_filterSource ();
			_model.valueChanged += (object sender, EventArgs e) => {
				filterBtn.SetTitle(_model.selectedSuject,UIControlState.Normal);
				pickerView.Hidden = true;

				var tableSource = new cFactor_socialCommunity_Content_tableViewSource (_model.selectedSuject, WebServiceRequest.sharedRequest.getActivityFeed ());
				contentTableView.Source = tableSource;
				//contentTableView.RowHeight = 75;
				contentTableView.ReloadData();

			};
			filterPicker.Model = _model;

			defaultTableSource = new cFactor_socialCommunity_Content_tableViewSource ("", WebServiceRequest.sharedRequest.getActivityFeed ());
			contentTableView.Source = defaultTableSource;

			refreshBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("refresh_button_inactive.png"));
			fullBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("fullscreen.png"));

			filterBtn.TouchUpInside += (object sender, EventArgs e) => {
				pickerView.Hidden = false;
			};

			searchBtn.TouchUpInside += (object sender, EventArgs e) => {

				var	_search = new cFactor_social_Search (defaultTableSource);
				
				_navi.PushViewController(_search,true);
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			//this.NavigationController.NavigationBarHidden = true;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			//this.NavigationController.NavigationBarHidden = false;
		}
	}
}

