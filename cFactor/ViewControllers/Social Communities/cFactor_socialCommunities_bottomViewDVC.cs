using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace cFactor
{
	public partial class cFactor_socialCommunities_bottomViewDVC : DialogViewController
	{
		UINavigationController _parentNavi;
		public cFactor_socialCommunities_bottomViewDVC (UINavigationController unavi) : base (UITableViewStyle.Grouped, null)
		{
			_parentNavi = unavi;
			this.TableView.RowHeight = 60f;

			Root = new RootElement ("cFactor_socialCommunities_bottomViewDVC");

			var _source = WebServiceRequest.sharedRequest.getCommunities ();
			var _section = new Section ();

			foreach (var e in _source) {

				var element = new StyledStringElement (e["name"].ToString(),"Details ... ...",UITableViewCellStyle.Subtitle){ 
					Image = UIImage.FromFile("cfactor.jpg"),
				};
				element.Tapped += () => {
					Console.Out.WriteLine("Go to \" Community \" !");

					var community = new cFactor_socialCommunity();
					_parentNavi.PushViewController(community,true);
					//_parentNavi.PushViewController(new cFactor_socialCommunity_Media(_parentNavi),true);
				};
				_section.Add (element);
			}
			Root.Add (_section);
		}


	}
}
