using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace cFactor
{
	public class cFactor_socialCommunity_naviPickSource : UIPickerViewModel
	{
		public event EventHandler valueChanged;
		public string selectedNavi;
		JObject _source;


		public cFactor_socialCommunity_naviPickSource (JObject source)
		{
			_source = source;
		}

		public override int GetRowsInComponent (UIPickerView picker, int component)
		{
			int count = 0;
			var arr =_source["navigation"];

			foreach( var e in arr){
				count++;
			}
			return count;
		}

		public override int GetComponentCount (UIPickerView picker)
		{
			return 1;
		}

		public override string GetTitle (UIPickerView picker, int row, int component)
		{
			return _source["navigation"][row]["name"].ToString();
		}

		public override void Selected (UIPickerView picker, int row, int component)
		{
			selectedNavi = _source["navigation"][row]["name"].ToString();
			if(valueChanged != null){
				valueChanged (this, EventArgs.Empty);
			}
		}
	}
}

