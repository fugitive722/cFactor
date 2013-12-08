using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Json;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Blog : UIViewController
	{
		JObject _blog = new JObject();

		public cFactor_socialCommunity_Blog () : base ("cFactor_socialCommunity_Blog", null)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			var addBtn = new UIBarButtonItem (UIBarButtonSystemItem.Add);
			addBtn.Clicked += (object sender, EventArgs e) => {
				this.NavigationController.PushViewController(new cFactor_SocialCommunity_Blog_Add(), true);
			};
			NavigationItem.RightBarButtonItem = addBtn;

			var tableViewSource = new cFactor_socialCommunity_Content_Blog_tableViewSource (WebServiceRequest.sharedRequest.getBlogComments ());
			tableViewSource.functionClicked += (object sender, EventArgs e) => {
			
				_blog = tableViewSource.blog;
				var actionSheet = new UIActionSheet ("Options");

				foreach(var i in _blog["actions"]){
					actionSheet.AddButton(i["name"].ToString());
				}

				actionSheet.Clicked += (object s, UIButtonEventArgs ea) => {

					new UIAlertView (_blog["actions"][ea.ButtonIndex].ToString(), "Thanks for tapping!", null, "Continue").Show (); 
				};
				actionSheet.ShowInView(View);

			};
			blogTableView.Source = tableViewSource;


		}
	}
}

