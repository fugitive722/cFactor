using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using cFactorMockup;
using System;

namespace cFactor
{
	public class cFactor_socialCommunity_Content_Blog_tableViewSource : UITableViewSource
	{
		public event EventHandler functionClicked;
		public JObject blog;
		List<JObject> _blogs;
		public cFactor_socialCommunity_Content_Blog_tableViewSource (List<JObject> blogs)
		{
			_blogs = new List<JObject> ();
			_blogs = blogs;

		}
		#region implemented abstract members of UITableViewSource

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _blogs.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("Cell") as cFactor_socialCommunity_BlogCell;
			if (cell == null) {
				var cellViews = NSBundle.MainBundle.LoadNib ("cFactor_socialCommunity_BlogCell",tableView,null);
				cell = Runtime.GetNSObject (cellViews.ValueAt(0)) as cFactor_socialCommunity_BlogCell;
			}

			cell.ContentView.Layer.BorderWidth = 0.5f;
			cell.ContentView.Layer.BorderColor = UIColor.Gray.CGColor;
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;

			cell.timeLabel.Text = _blogs[indexPath.Row]["date"].ToString();
			cell.authorImage.Image = UIImage.FromFile ("blogauthor.jpeg");
			cell.blogWeb.LoadRequest (new NSUrlRequest (new NSUrl ("http://www.cfactorworks.com")));
			cell.blogWeb.ScalesPageToFit = true;
		
			cell.funtionBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("starBtn.png"));
			cell.funtionBtn.TouchUpInside += (object sender, EventArgs e) => {
				if(functionClicked != null){
					blog = new JObject ();
					blog = _blogs[indexPath.Row];
					functionClicked(sender,EventArgs.Empty);
				}
			};


			return cell;

		}

		#endregion

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 260f;

		}
	}
}

