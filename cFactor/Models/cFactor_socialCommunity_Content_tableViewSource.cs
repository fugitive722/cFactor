using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using cFactorMockup;
using System;


namespace cFactor
{
	public class cFactor_socialCommunity_Content_tableViewSource : UITableViewSource
	{
		public List<JObject> _source;

		public cFactor_socialCommunity_Content_tableViewSource (string method, List<JObject> source)
		{
			_source = new List<JObject> ();
			switch (method) {
			case "Newest":
				sortByNewest ();
				break;
			case "Rating":
				sortByRating ();
				break;
			case "Most Popluar":
				sortByPopluar ();
				break;
			case "Trending":
				sortByTrending ();
				break;
			default:
				_source = source;
				break;
			}
		}


		private void cleanSource (){

			while (_source.Count > 0) {
				_source.RemoveAt (0);
			}

		}
		private void sortByAll(){
		
			_source = WebServiceRequest.sharedRequest.getActivityFeed ();
		}
		private void sortByNewest()
		{
			cleanSource ();
			_source = WebServiceRequest.sharedRequest.getActivityFeed ();

		}

		private void sortByRating()
		{
			cleanSource ();
			_source = WebServiceRequest.sharedRequest.getActivityFeed ();
		
		}

		private void sortByPopluar()
		{
			cleanSource ();
			_source = WebServiceRequest.sharedRequest.getActivityFeed ();

		}

		private void sortByTrending()
		{
			cleanSource ();
			_source = WebServiceRequest.sharedRequest.getActivityFeed ();

		}

		public List<JObject> getSouce()
		{
			return _source;
		}

		public void searchSouce (List<JObject> o){
			_source = o;
		}
		#region implemented abstract members of UITableViewSource

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _source.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("Cell") as ActivityFeedCell;
			if (cell == null){
				var cellViews = NSBundle.MainBundle.LoadNib ("ActivityFeedCell",tableView,null);
				cell = Runtime.GetNSObject (cellViews.ValueAt(0)) as ActivityFeedCell;
			}
//			cell.Layer.BorderWidth = 0.2f;
//			cell.Layer.BorderColor = UIColor.Blue.CGColor;
			cell.ContentView.Layer.BorderWidth = 0.5f;
			cell.ContentView.Layer.BorderColor = UIColor.Gray.CGColor;

			cell.summaryText.Text = _source [indexPath.Row]["summary"].ToString();
			cell.summaryText.Editable = false;
			try{
				cell.authorName.Text = _source [indexPath.Row]["author"].ToString();
			}catch{
				cell.authorName.Text = "None";
			}

			cell.iconImage.Image = UIImage.FromFile ("cfactor.jpg");;
			cell.authorImage.Image = UIImage.FromFile ("blogauthor.jpeg");
			//cell.authorImage.
			cell.titleBtn.TitleLabel.TextAlignment = UITextAlignment.Center;
			cell.titleBtn.TitleLabel.LineBreakMode = UILineBreakMode.WordWrap;
			cell.titleBtn.SetTitle (_source [indexPath.Row]["title"].ToString(),UIControlState.Normal);

			cell.titleBtn.TouchUpInside += (object sender, EventArgs e) => {
				new UIAlertView ("Title Clicked ","Going to Detail", null, "Ok", null).Show ();
			};

			cell.ratingBtn.TouchUpInside += (object sender, EventArgs e) => {
				//Console.Out.WriteLine("Rating touched !! ");
				new UIAlertView ("Rating Clicked ","Going to Rating Page", null, "Ok", null).Show ();
			};
			cell.commentBtn.TouchUpInside += (object sender, EventArgs e) => {
				//Console.Out.WriteLine("Comment touched !!");
				new UIAlertView ("Comment Clicked ","Going to Comment Page", null, "Ok", null).Show ();
			};

			return cell;
		}

		#endregion

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 200f;

		}
	}
}

