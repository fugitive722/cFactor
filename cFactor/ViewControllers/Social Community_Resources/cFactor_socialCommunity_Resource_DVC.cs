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
	public partial class cFactor_socialCommunity_Resource_DVC : DialogViewController
	{
		JObject resourceObj;
		UINavigationController _navi;
		public cFactor_socialCommunity_Resource_DVC (UINavigationController n) : base (UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("Resource Tree");
			var treeS = new Section ("");
			//var optionS = new Section ("Option");
			_navi = n;


			resourceObj = WebServiceRequest.sharedRequest.getCommunityResources();
			foreach (var i in resourceObj["feed"]){

				switch(i ["type"].ToString ()){
				case "resourceFolder":
					var folderS = new Section ("Folder");
					var el = new StyledStringElement (i ["name"].ToString (), "") {
						Image = UIImage.FromFile ("generic_folder.png"),
					};

					var jObject = WebServiceRequest.sharedRequest.getCommunityResouceFolder ();
					if (jObject["title"].ToString() == i["name"].ToString() ){
						el.Tapped += () => {


							var sub = new cFactor_socialCommunity_Resource_Folder (i ["name"].ToString (),jObject ,_navi);
							//Console.Out.WriteLine(_navi.ToString());
							_navi.PushViewController (sub, true);

						};
					}

					folderS.Add (el);
					Root.Add (folderS);
					break;
				case "resourceDocument":
					var docS = new Section ("Resource Document");
					docS.Add (new StyledStringElement (i ["name"].ToString (), () => {
						_navi.PushViewController(new cFactor_socialCommunity_Resource_Doc (_navi),true);
					}) {
						Image = UIImage.FromFile ("application_vnd_ms_word.png"),
					});
					Root.Add (docS);
					ReloadData();
					break;

				}

			}

			Root.Add (treeS);
			//Root.Add (optionS);
		}
	}
}
