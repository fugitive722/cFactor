using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace cFactor
{
	public partial class cFactor_socialProfile : UIViewController
	{
		JObject _user;
		Boolean _isFollow = false;
		public cFactor_socialProfile (JObject user) : base ("cFactor_socialProfile", null)
		{

			_user = new JObject ();
			_user = WebServiceRequest.sharedRequest.getProfile ();

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			initUI ();

			var naviSubject = _user["navigation"];
			var naviList = new List<string>();

			foreach(var i in naviSubject){

				naviList.Add (i["name"].ToString());
			}

			var pickerModel = new cFactor_soicalProfile_NaviModel (naviList);
			pickerModel.valueChanged += (object sender, EventArgs e) => {
				naviBtn.SetTitle(pickerModel.selectedSuject,UIControlState.Normal);

				foreach(var i in naviSubject){
					if(i["name"].ToString().Equals(pickerModel.selectedSuject)){

						webView.LoadRequest(new NSUrlRequest (new NSUrl ("http://www.cfactorworks.com")));
						webView.ScalesPageToFit = true;
						break;
					}
				}
				botView.Hidden = true;
			};
			naviPicker.Model = pickerModel;

			naviBtn.TouchUpInside += (object sender, EventArgs e) => {

				botView.Hidden = false;
			};
		}

		private void initUI(){
			Title = _user["name"].ToString();
			userImage.Image = UIImage.FromFile ("blogauthor.jpeg");
			detailTextView.Text = _user["details"].ToString();
			detailTextView.Editable = false;
			//topView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromBundle("coverPage.png"));

			followBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Star_off.png"));

			followBtn.TouchUpInside += (object sender, EventArgs e) => {

				if(_isFollow){
					followBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Star_off.png"));
					_isFollow = false;

				}else{
					followBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Star_on.png"));
					_isFollow = true;
				}
			};

		}
	}
}

