using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace cFactor
{
	public class cFactor_socialCommunity_Content_filterSource : UIPickerViewModel
	{
		List<string> _subject;
		public event EventHandler valueChanged;
		public string selectedSuject;

		public cFactor_socialCommunity_Content_filterSource ()
		{
			_subject = new List<string> ();
			_subject.Add ("Newest");
			_subject.Add ("Rating");
			_subject.Add ("Most Popluar");
			_subject.Add ("Trending");

		}

		public override int GetRowsInComponent (UIPickerView picker, int component)
		{
			return _subject.Count;
		}

		public override int GetComponentCount (UIPickerView picker)
		{
			return 1;
		}

		public override string GetTitle (UIPickerView picker, int row, int component)
		{
			return _subject [row];
		}

		public override void Selected (UIPickerView picker, int row, int component)
		{
			selectedSuject = _subject [row];
			if(valueChanged != null){
				valueChanged (this, EventArgs.Empty);
			}
		}
	}
}

