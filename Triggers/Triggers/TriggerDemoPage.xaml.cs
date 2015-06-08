using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Triggers
{
	public partial class TriggerDemoPage : TabbedPage
	{
		public TriggerDemoPage ()
		{
			InitializeComponent ();
			Children.Add (new TriggerPage{ Title = "Trigger" });
			Children.Add (new DataTriggerPage{ Title = "DataTrigger" });
			Children.Add (new EventTriggerPage{ Title = "EventTrigger" });
			Children.Add (new MultiTriggerPage{ Title = "MultiTrigger" });
		}
	}
}

