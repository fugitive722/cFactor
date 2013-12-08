using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Resource_Folder : UIViewController
	{
		string _address;
		JObject _obj;
		cFactor_socialCommunity_Resource_subFolder_DVC _sub;
		UINavigationController _nav;
		public cFactor_socialCommunity_Resource_Folder (string address, JObject obj,UINavigationController n) : base ("cFactor_socialCommunity_Resource_Folder", null)
		{
			_address = address;
			_obj = new JObject ();
			_obj = obj;

			_nav = n;

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			addressTextView.Text = "Address: "+@"\"+ _address+@"\";
			addressTextView.Editable = false;
			descriptionLabel.Text =  _obj["description"].ToString().Trim();
			descriptionLabel.Lines = 0;
			descriptionLabel.LineBreakMode = UILineBreakMode.WordWrap;

			_sub= new cFactor_socialCommunity_Resource_subFolder_DVC (_address+@"\New Folder",_nav);
			folderView.Add (_sub.View);


			actionBtn.TouchUpInside += (object sender, EventArgs e) => {
				var actionSheet = new UIActionSheet ("Actions");
				foreach(var i in _obj["actions"]){
					actionSheet.AddButton(i["name"].ToString());
				}

				actionSheet.Clicked += (object s, UIButtonEventArgs ea) => {

					//new UIAlertView (_obj["actions"][ea.ButtonIndex].ToString(), "Thanks for tapping!", null, "Continue").Show (); 
				
					if (ea.ButtonIndex == 2){

						_sub.createNewFolder();
					}else if (ea.ButtonIndex == 3){
						_sub.createNewDoc();
					}
				};
				actionSheet.ShowInView(View);

			};
		
			
		}
	}
}

