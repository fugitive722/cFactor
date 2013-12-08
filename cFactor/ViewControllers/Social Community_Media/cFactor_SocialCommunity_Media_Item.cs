using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace cFactor
{
	public partial class cFactor_SocialCommunity_Media_Item : UIViewController
	{
		cFactor_socialCommunity_Media_Item_CollectionVIew _itemV;

		public cFactor_SocialCommunity_Media_Item () : base ("cFactor_SocialCommunity_Media_Item", null)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var layout = new UICollectionViewFlowLayout (){

			};
			layout.ItemSize = new SizeF (320, 400);
			layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
			if(_itemV == null){
				_itemV = new cFactor_socialCommunity_Media_Item_CollectionVIew (layout,WebServiceRequest.sharedRequest.getCommunityMediaItem());
				View.Add (_itemV.View);
			}

		}

		public class cFactor_socialCommunity_Media_Item_CollectionVIew : UICollectionViewController{

			List <JObject> _obj;
			//int count = 0;
			//UINavigationController _navi;
			public cFactor_socialCommunity_Media_Item_CollectionVIew (UICollectionViewLayout layout, List<JObject> o) : base (layout) {

				_obj = o;
				//_navi = n;
			}

			public override void ViewDidLoad ()
			{
				base.ViewDidLoad ();
				CollectionView.RegisterClassForCell(typeof(cFactor_socialCommunity_Media_Item_CollectionVIewCell),cFactor_socialCommunity_Media_Item_CollectionVIewCell.Key);
				CollectionView.BackgroundColor = UIColor.White;

			}

			public override int NumberOfSections (UICollectionView collectionView)
			{
				return 1 ;
			}

			public override int GetItemsCount (UICollectionView collectionView, int section)
			{


				return _obj.Count;
			}

			public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
			{
				var cell = (cFactor_socialCommunity_Media_Item_CollectionVIewCell)collectionView.DequeueReusableCell (cFactor_socialCommunity_Media_Item_CollectionVIewCell.Key,indexPath);
				cell.BackgroundColor = UIColor.Clear;

				cell.setTitle (_obj[indexPath.Row]["title"].ToString());
				cell.setDescriptionView (_obj[indexPath.Row]["description"].ToString()+"\n"+_obj[indexPath.Row]["date"].ToString());
				if (_obj [indexPath.Row] ["ratingValue"].ToString() == "1") {
					cell.setImage ("pizza.jpeg");
				} else {
					cell.setImage ("pizza-junction-and-snack.jpg");
				}
				return cell;
			}

		}
	}
}

