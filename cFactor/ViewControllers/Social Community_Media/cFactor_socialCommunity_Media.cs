using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Media : UIViewController
	{
		public event EventHandler fullScreenClicked;
		cFactor_socialCommunity_Media_AllAlbums allAlbums;
		public Boolean _fullS = false;
		UINavigationController _navi;
		public cFactor_socialCommunity_Media (UINavigationController n) : base ("cFactor_socialCommunity_Media", null)
		{
			_navi = n;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			var layout = new UICollectionViewFlowLayout (){

			};
			layout.ItemSize = new SizeF (80, 120);
			allAlbums = new cFactor_socialCommunity_Media_AllAlbums (layout,_navi,WebServiceRequest.sharedRequest.getCommunityMediaAlbums());
			allAlbums.View.Frame = new RectangleF (0,0,320,collectionView.Frame.Height);
			collectionView.Add (allAlbums.View);

			fullBtn.TouchUpInside += (object sender, EventArgs e) => {
				if(_fullS){
					fullScrren();
				}else{
					smallScreen();
				}
			};
			fullBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("fullscreen.png"));
			refreshBtn.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile("refresh_button_inactive.png"));

			addBtn.TouchUpInside += (object sender, EventArgs e) => {
//				allAlbums.extra ++;
//				allAlbums.CollectionView.ReloadData();
//
			};

		}

		private void smallScreen(){
			collectionView.Frame = new RectangleF(0,55,320,513);
			_fullS = true;
			if(fullScreenClicked != null){
				fullScreenClicked(this,EventArgs.Empty);
			}
		}
		private void fullScrren (){
			_fullS = false;
			if(fullScreenClicked != null){
				fullScreenClicked(this,EventArgs.Empty);
			}
		}
		public void changeToSmallScreen()
		{
			_fullS = false;
		}

		public class cFactor_socialCommunity_Media_AllAlbums : UICollectionViewController{

			public int extra{ set; get;}
			int index =0;

			JObject _obj;
			int count = 0;
			UINavigationController _navi;
			public cFactor_socialCommunity_Media_AllAlbums (UICollectionViewLayout layout, UINavigationController n, JObject o) : base (layout) {

				_obj = o;
				_navi = n;

			}


			public override void ViewDidLoad ()
			{
				base.ViewDidLoad ();
				CollectionView.RegisterClassForCell(typeof(cFactor_socialCommunity_Media_AllAlbumsCell),cFactor_socialCommunity_Media_AllAlbumsCell.Key);
				CollectionView.BackgroundColor = UIColor.White;

			}

			public override int NumberOfSections (UICollectionView collectionView)
			{
				return 1;
			}

			public override int GetItemsCount (UICollectionView collectionView, int section)
			{
				index = 0;
				count = 0;
				foreach (var i in _obj["feed"]){
					count++;
				}
				return count+extra;
			}

			public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
			{
				var cell = (cFactor_socialCommunity_Media_AllAlbumsCell)collectionView.DequeueReusableCell (cFactor_socialCommunity_Media_AllAlbumsCell.Key,indexPath);
				cell.BackgroundColor = UIColor.LightGray;

				if (index < 2) {
					cell.setName (_obj ["feed"] [indexPath.Row] ["name"].ToString ());
					cell.setClickDelegate (_navi, true);
					index++;
				} else {
					cell.setName ("New Albums");
					//cell.setClickDelegate (_navi,false);
				}
				return cell;
			}

		}



	}
}

