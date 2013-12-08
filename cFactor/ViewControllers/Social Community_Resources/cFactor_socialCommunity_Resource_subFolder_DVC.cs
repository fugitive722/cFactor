using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Resource_subFolder_DVC : DialogViewController
	{
		public Section secF;
		public Section secD;
		UINavigationController _navi;
		string _add;
		public cFactor_socialCommunity_Resource_subFolder_DVC (string add, UINavigationController n) : base (UITableViewStyle.Grouped, null)
		{
			_add = add;
			_navi = n;
			Root = new RootElement ("cFactor_socialCommunity_Resource_subFolder_DVC");
			secF = new Section ("Folder");
			secD = new Section ("Documentation");

			Root.Add (secF);
			Root.Add (secD);
		}

		public void createNewFolder (){

			var sub = new StyledStringElement ("New Folder", ""){
				Image = UIImage.FromFile("generic_folder.png"),
			};
			sub.Tapped += () => {
				var s = new cFactor_socialCommunity_Resource_Folder (_add,WebServiceRequest.sharedRequest.getCommunityResouceFolder(),_navi);
				//Console.Out.WriteLine(_navi.ToString());
				_navi.PushViewController (s, true);
			};
			secF.Add (sub);
			this.Root.Reload (secF,UITableViewRowAnimation.Fade);
		}

		public void createNewDoc (){
			secD.Add  (new StyledStringElement("New Upload Doc",""){
				Image = UIImage.FromFile("application_vnd_ms_word.png"),
			});

			this.Root.Reload (secD,UITableViewRowAnimation.Fade);
		}


	}
}
