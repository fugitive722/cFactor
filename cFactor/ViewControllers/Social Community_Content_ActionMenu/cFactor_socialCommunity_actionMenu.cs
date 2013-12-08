using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace cFactor
{
	public partial class cFactor_socialCommunity_actionMenu : DialogViewController
	{
		public cFactor_socialCommunity_actionMenu () : base (UITableViewStyle.Grouped, null)
		{
			this.Pushing = true;
			Root = new RootElement ("Action Menu") {
				new Section () {
					new StringElement ("Blog", () => {
						//new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
						this.NavigationController.PushViewController(new cFactor_socialCommunity_Blog(),true);
					}),
					new StringElement ("Forums", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new StringElement ("Ideas", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new StringElement ("Wiki", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
				},

			};
		}
	}
}
