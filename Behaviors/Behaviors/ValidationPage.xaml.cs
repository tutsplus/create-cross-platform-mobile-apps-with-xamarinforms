using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Behaviors
{
	public partial class ValidationPage : ContentPage
	{
		public ValidationPage ()
		{
			InitializeComponent ();
		}
	}

	public class IntegerValidationBehavior : Behavior<Entry> {
		protected override void OnAttachedTo (Entry bindable)
		{
			bindable.TextChanged += OnTextChanged;
			base.OnAttachedTo (bindable);
		}

		protected override void OnDetachingFrom (Entry bindable)
		{
			bindable.TextChanged -= OnTextChanged;
			base.OnDetachingFrom (bindable);
		}

		void OnTextChanged(object sender, TextChangedEventArgs args) {
			int result;

			var isValid = int.TryParse (args.NewTextValue, out result);

			((Entry)sender).BackgroundColor = isValid ? Color.Default : Color.Red;
		}
	}
}

