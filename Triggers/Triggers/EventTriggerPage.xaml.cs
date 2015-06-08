using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Triggers
{
	public partial class EventTriggerPage : ContentPage
	{
		public EventTriggerPage ()
		{
			InitializeComponent ();
		}
	}


	public class IntegerValidationTriggerAction : TriggerAction<Entry> {
		protected override void Invoke (Entry sender)
		{
			int result;

			var isValid = int.TryParse (sender.Text, out result);
			sender.TextColor = isValid ? Color.Default : Color.Red;
		}
	}
}

