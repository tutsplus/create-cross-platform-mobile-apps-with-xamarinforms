using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Styles
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();
			MainPage = new MyPageXAML ();
		}
	}
}

