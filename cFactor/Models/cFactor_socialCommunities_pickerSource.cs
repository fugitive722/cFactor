using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace cFactor
{
	public class cFactor_socialCommunities_pickerSource : UIPickerViewModel
	{
		List<string> _subject;
		public event EventHandler valueChanged;
		public string selectedSuject;

		public cFactor_socialCommunities_pickerSource ()
		{
			_subject = new List<string> ();
			_subject.Add ("Most Reccent Post");
			_subject.Add ("Most Active/Contribution");
			_subject.Add ("Featured");
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

