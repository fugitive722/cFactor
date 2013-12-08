using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using ElementPack;

namespace cFactor
{
	public partial class cFactor_SocialCommunity_Blog_Add : DialogViewController
	{
		EntryElement _title;
		BooleanElement _rating;
		BooleanElement _tag;
		BooleanElement _comment;
		RadioGroup _ratingMethod;
		//List<string> tagList;
		SimpleMultilineEntryElement _blog;
		public cFactor_SocialCommunity_Blog_Add () : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;

			//	tagList = new List<string> ();
			Root = new RootElement ("Post New Blog");

			var basicS = new Section ("Title");
			StringElement type = new StringElement ("Type", "BlogPost");
			StringElement date = new StringElement ("Date", DateTime.Now.ToString ());

			_title = new EntryElement ("Title", null, "");

			basicS.Add (type);
			basicS.Add (date);
			basicS.Add (_title);


			var ratingS = new Section ("Rating Option");
			_rating = new BooleanElement ("Rating Allowed", false);
			_rating.ValueChanged += (object sender, EventArgs e) => {
				if (_rating.Value) {

					while (ratingS.Elements.Count > 1) {
						ratingS.Elements.RemoveAt (1);
					}
					_ratingMethod = new RadioGroup (0);
					var ratingMethodS = new Section () {
						new RadioElement ("Thumb up"),
					};
					var ratingMethodR = new RootElement ("Rating Method", _ratingMethod);
					ratingMethodR.Add (ratingMethodS);

					ratingS.Add (ratingMethodR);
				} else {
					while (ratingS.Elements.Count > 1) {
						ratingS.Elements.RemoveAt (1);
					}
				}

				this.Root.Reload (ratingS, UITableViewRowAnimation.None);

			};
			ratingS.Add (_rating);

				
			var tagS = new Section ("Tags Option");
			_tag = new BooleanElement ("Tag Allowed", false);
			_tag.ValueChanged += (object sender, EventArgs e) => {
				if (_tag.Value) {

					var t = new EntryElement ("tag", null, "");
					t.ShouldReturn += () => {
						return SRFunc(tagS);
					};

					tagS.Add (t);
				} else {
					while (tagS.Elements.Count > 1) {
						tagS.Elements.RemoveAt (1);
					}
				}
				this.Root.Reload (tagS, UITableViewRowAnimation.None);
			};
			tagS.Add (_tag);


			var commentS = new Section ("Comment Option");
			_comment = new BooleanElement ("Comment Allowed", false);

			commentS.Add (_comment);

			var blogS = new Section ("Blog");
			_blog = new SimpleMultilineEntryElement ("", "") {
				Editable = true,
			};

			blogS.Add (_blog);


			Root.Add (basicS);
			Root.Add (ratingS);
			Root.Add (tagS);
			Root.Add (commentS);
			Root.Add (blogS);

		}

		public bool SRFunc (Section tags)
		{
			var ee = new EntryElement ("tag", null, null);
			tags.Add (ee);
			ee.ShouldReturn += () => {
				return SRFunc (tags);
			};
			return true;
		}
	}
}
