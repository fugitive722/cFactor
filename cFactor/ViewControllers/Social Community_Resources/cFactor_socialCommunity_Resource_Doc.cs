using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using Newtonsoft.Json.Linq;
using ElementPack;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Resource_Doc : DialogViewController
	{
		JObject _obj;
		UINavigationController _navi;
		UIBarButtonItem _downloandBtn;
		public cFactor_socialCommunity_Resource_Doc ( UINavigationController n) : base (UITableViewStyle.Grouped, null)
		{
			_navi = n;
			this.Pushing = true;

			var button = UIButton.FromType(UIButtonType.Custom);
			button.Frame = new System.Drawing.RectangleF (0,0,25,25);
			button.SetImage (UIImage.FromFile ("down.png"), UIControlState.Normal);
			_downloandBtn = new UIBarButtonItem (button);
			_downloandBtn.Clicked +=(s, e) => {
				//this.NavigationController.PushViewController(new cFactor_socialProfile(null),true);

			};
			this.NavigationItem.RightBarButtonItem = _downloandBtn;

			_obj = WebServiceRequest.sharedRequest.getCommunityResourceDocument();

			Root = new RootElement ("Community Resource Doc");

			var au = new StyledStringElement ("Author", _obj ["author"].ToString ()) {
				Image = UIImage.FromFile ("blogauthor.jpeg"),
			};
			au.Tapped += () => {
				_navi.PushViewController (new cFactor_socialProfile (null), true);
			};

			var basicS = new Section ()
			{
				new StringElement ("Title",_obj["type"].ToString()),
				new SimpleMultilineEntryElement ("",_obj["description"].ToString()){
					Editable =  false,
				},
				new StringElement ("Date",_obj["date"].ToString()),

			};
			basicS.Add (au);


			Root.Add (basicS);



			var rateS = new Section ("Rating"){
				new StringElement ("Rating Type",_obj["ratingType"].ToString()),
				new StringElement ("Rating Value",_obj["ratingValue"].ToString()),
			};

			Root.Add (rateS);

			var tagS = new Section ("Tags"){
				new StringElement("",_obj["tags"][0]["1"].ToString()),
			};

			Root.Add (tagS);

			var actionS = new Section ("Actions");
			var a = _obj["actions"];
			foreach( var i in a){
				actionS.Add (new StringElement("",i["name"].ToString()));
			}

			Root.Add (actionS);

		}
	}
}
