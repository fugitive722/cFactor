using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public partial class cFactor_socialCommunity_Media_AlbumDetail : UIViewController
	{
		UINavigationController _navi;
		JObject _obj;
		cFactor_socialCommunity_Media_AllAlbum album;
		public cFactor_socialCommunity_Media_AlbumDetail (JObject o, UINavigationController n) : base ("cFactor_socialCommunity_Media_AlbumDetail", null)
		{
			_obj = o;
			_navi = n;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.Title = _obj["name"].ToString();
			this.descriptionView.Text = _obj ["description"].ToString ();

			var layout = new UICollectionViewFlowLayout (){

			};
			layout.ItemSize = new SizeF (80, 120);
			album = new cFactor_socialCommunity_Media_AllAlbum (layout,_navi,WebServiceRequest.sharedRequest.getCommunityMediaAlbum());
			album.View.Frame = new RectangleF (0,0,320,albumFilesView.Frame.Height);
			albumFilesView.Add (album.View);


		}


		public class cFactor_socialCommunity_Media_AllAlbum : UICollectionViewController{

			JObject _obj;
			int count = 0;
			UINavigationController _navi;
			public cFactor_socialCommunity_Media_AllAlbum (UICollectionViewLayout layout, UINavigationController n, JObject o) : base (layout) {

				_obj = o;
				_navi = n;
			}

			public override void ViewDidLoad ()
			{
				base.ViewDidLoad ();
				CollectionView.RegisterClassForCell(typeof(cFactor_socialCommunity_Media_AlbumDetailCell),cFactor_socialCommunity_Media_AlbumDetailCell.Key);
				CollectionView.BackgroundColor = UIColor.White;

			}

			public override int NumberOfSections (UICollectionView collectionView)
			{
				return 1;
			}

			public override int GetItemsCount (UICollectionView collectionView, int section)
			{
				count = 0;
				foreach (var i in _obj["feed"]){
					count++;
				}

				return count;
			}

			public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
			{
				var cell = (cFactor_socialCommunity_Media_AlbumDetailCell)collectionView.DequeueReusableCell (cFactor_socialCommunity_Media_AlbumDetailCell.Key,indexPath);
				cell.BackgroundColor = UIColor.LightGray;
				try{
					cell.setName (_obj["feed"][indexPath.Row]["name"].ToString());
					cell.setClickDelegate (_navi,true);
				}catch{
					cell.setName ("New Albums");
					cell.setClickDelegate (_navi,false);
				}
				//cell.setClickDelegate (_navi,null);
				return cell;
			}

		}
	}
}

