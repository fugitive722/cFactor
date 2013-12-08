using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_socialCommunity : UIViewController
	{
		Boolean _fullS =false;
		Boolean isContent = false;
		Boolean isMedia = false;
		Boolean isResource = false;
		JObject _jsonSource;
		cFactor_socialCommunity_Content _contentVC;
		cFactor_socialCommunity_Resources _resourcesVC;
		cFactor_socialCommunity_Media _mediaVC;



		public cFactor_socialCommunity () : base ("cFactor_socialCommunity", null)
		{
			this.Title = "Social Community";

		}

		public override void ViewDidLoad ()
		{




			base.ViewDidLoad ();
			_jsonSource = WebServiceRequest.sharedRequest.getCommunity ();
			initUI ();
			// view controls
			pickerView.Hidden = true;

			//user profile
			var userProfile = new UIBarButtonItem (
				UIImage.FromFile("User info.png"),
				UIBarButtonItemStyle.Plain,
				(s, e) => {
					this.NavigationController.PushViewController(new cFactor_socialProfile(null),true);
				}
			);
			NavigationItem.RightBarButtonItem = userProfile;

			//userProfile.Image.Size = new SizeF (25, 25);
			this.NavigationItem.RightBarButtonItem = userProfile;



			//set up navi picker
			var navPickerModel = new cFactor_socialCommunity_naviPickSource (_jsonSource);
			navPickerModel.valueChanged += (object sender, EventArgs e) => {
				naviBtn.SetTitle(navPickerModel.selectedNavi,UIControlState.Normal);

				switch (navPickerModel.selectedNavi){

				case "Home" :

					//this.NavigationController.PopToRootViewController(true);
					//bodyView = new UIView (bodyView.Frame);
					pickerView.Hidden = true;
					bodyView.Hidden = true;

					break;
				case "Content":
					if(_contentVC == null)
					{
						_contentVC = new cFactor_socialCommunity_Content(this.NavigationController);
						_contentVC.fullScreenClicked += (object s, EventArgs ea) => {
							if(!_fullS){
								fullScreen();
							}else{
								smallScreen(_contentVC);
							}

						};
					}
					isContent = true;
					isResource = false;
					isMedia = false;

					bodyView.Add(_contentVC.View);
					pickerView.Hidden = true;
					bodyView.Hidden = false;
					break;

				case "Resources":
					if(_resourcesVC == null){
						_resourcesVC = new cFactor_socialCommunity_Resources(this.NavigationController);
						_resourcesVC.fullScreenClicked += (object ss, EventArgs eea) => {
							if(!_fullS){
								fullScreen();

							}else{
								smallScreen(_resourcesVC);
							}

						};
					}
					isContent = false;
					isMedia = false;
					isResource = true;

					bodyView.Add(_resourcesVC.View);
					pickerView.Hidden = true;
					bodyView.Hidden = false;
					break;

				case "Medias" : 
					if(_mediaVC == null){
						_mediaVC = new cFactor_socialCommunity_Media(this.NavigationController);
						_mediaVC.fullScreenClicked += (object sss, EventArgs eeea) => {
							if(!_fullS){
								fullScreen();

							}else{
								smallScreen(_mediaVC);
							}

						};
					}
					isMedia =true;
					isContent = false;
					isResource = false;

					bodyView.Add(_mediaVC.View);
					pickerView.Hidden = true;
					bodyView.Hidden = false;

					break;


				}



			};
			naviPicker.Model = navPickerModel;

			naviBtn.TouchUpInside += (object sender, EventArgs e) => {

				if(_fullS){
					if(isContent){
						smallScreen(_contentVC);
					}else if (isResource){
						smallScreen(_resourcesVC);
					}else if (isMedia){
						smallScreen(_mediaVC);

					}
				}

				if(_fullS){
					topView.Hidden = true;
				}

				pickerView.Hidden = false;
				bodyView.Hidden = true;
			};

			actionBtn.TouchUpInside += (object sender, EventArgs e) => {

				var actionMenu = new cFactor_socialCommunity_actionMenu();
				this.NavigationController.PushViewController(actionMenu,true);

			};

		}


		private void fullScreen()
		{
			Console.Out.WriteLine("full screen");
			UIView.BeginAnimations("C fullscreen");
			UIView.SetAnimationDuration(1);


			RectangleF fBodyF = new RectangleF(0,120,View.Window.Frame.Width,View.Window.Frame.Height-65f-28f);
			RectangleF fBarF = new RectangleF (0,92,View.Window.Frame.Width,28f);

			barView.Frame = fBarF;
			bodyView.Frame = fBodyF;
			UIView.CommitAnimations();

			_fullS = true;
		}

		private void smallScreen(UIViewController vc){
			Console.Out.WriteLine("originalScreen screen");
			UIView.BeginAnimations("C originalScreen");
			UIView.SetAnimationDuration(1);
			RectangleF fBodyF = new RectangleF(0,258,View.Window.Frame.Width,311f);
			RectangleF fBarF = new RectangleF (0,230,View.Window.Frame.Width,28f);

			barView.Frame = fBarF;
			bodyView.Frame = fBodyF;

			if(isContent){
				var content = (cFactor_socialCommunity_Content)vc;
				content.bodyView.Frame = new RectangleF(0,55,320,249);
				content.changeToSmallScreen ();
				//isContent = false;
			}else if(isResource){
				var resource = (cFactor_socialCommunity_Resources)vc;
				resource.dvcView.Frame = new RectangleF(0,55,320,249);
				resource.changeToSmallScreen ();
				//isResource = false;
			}else if(isMedia){
				var media = (cFactor_socialCommunity_Media)vc;
				media.collectionView.Frame = new RectangleF(0,55,320,249);
				media.changeToSmallScreen ();
				//isMedia = false;
			}

		
			UIView.CommitAnimations();

			_fullS = false;
		}
		public void initUI()
		{
			photoView.Image = UIImage.FromFile ("cfactor.jpg");
			nameLabel.Text = _jsonSource["name"].ToString();
			decriptionText.Text = _jsonSource["description"].ToString();
			decriptionText.Editable = false;
		
			topView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("images.jpeg"));

			actionBtn.Layer.BorderWidth = 0.5f;
			actionBtn.Layer.BorderColor = UIColor.LightGray.CGColor;

			naviBtn.Layer.BorderColor = UIColor.LightGray.CGColor;
			naviBtn.Layer.BorderWidth = 0.5f;
		}
	}
}

