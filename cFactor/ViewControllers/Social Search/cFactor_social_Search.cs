using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_social_Search : UIViewController
	{
		UITableViewSource _source;
		List<JObject> _originalSouce;
		public cFactor_social_Search (UITableViewSource source) : base ("cFactor_social_Search", null)
		{
			_source = source;

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var tableSource = (cFactor_socialCommunity_Content_tableViewSource)_source;
			_originalSouce = tableSource.getSouce ();

			tableView.Source = _source;

			cancelBtn.TouchUpInside += (object sender, EventArgs e) => {
				this.NavigationController.PopViewControllerAnimated(true);
			};

			searchBar.SearchButtonClicked += (object sender, EventArgs e) => {
				search();
				searchBar.ResignFirstResponder ();
			};


			searchBar.TextChanged += (object sender, UISearchBarTextChangedEventArgs e) => {
				tableSource.searchSouce (_originalSouce);
				tableView.ReloadData();
				search();
			};

			searchBar.ListButtonClicked += (object sender, EventArgs e) => {
				tableSource.searchSouce (_originalSouce);
			};


		}

		public void search (){
		
			var tableSource = (cFactor_socialCommunity_Content_tableViewSource)_source;
			var key = searchBar.Text;

			var rlist = new List<JObject> ();
			foreach (var i in tableSource.getSouce()){
				if (i["title"].ToString().ToLowerInvariant().Contains(key)){
					rlist.Add (i);
				}
			}
			tableSource.searchSouce (rlist);
			tableView.ReloadData ();


		}

		public override void ViewWillAppear (bool animated)
		{

			base.ViewWillAppear (animated);
			//this.NavigationController. = true;
			this.NavigationController.NavigationBarHidden = true;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.NavigationBarHidden = false;

		}
	}
}

