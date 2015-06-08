using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Globalization;

namespace Triggers
{
	public partial class MultiTriggerPage : ContentPage
	{
		public MultiTriggerPage ()
		{
			InitializeComponent ();
		}
	}


	public class MultiTriggerConverter : IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			if ((int)value > 0) {
				return true;
			} else {
				return false;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			throw new NotSupportedException ();
		}
	}
}

