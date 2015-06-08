using System;

using Xamarin.Forms;

namespace XamarinFormsTableView
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new TableView {
					Intent = TableIntent.Settings,
					Root = new TableRoot {
						new TableSection (" ") {
							new SwitchCell {Text = "Wifi"},
							new SwitchCell {Text = "Bluetooth"}
						},
						new TableSection (" ") {
							new EntryCell { Label="Login", Placeholder = "username" },
							new EntryCell { Label="Password", Placeholder = "password" }
						},
						new TableSection ("Silent") {
							new SwitchCell { Text = "Vibrate" },
							new ViewCell { View = new Slider() }
						},

						new TableSection ("Play Sound For") {
							new SwitchCell {Text = "New Voice Mail"},
							new SwitchCell {Text = "New SMS", On = true}
						},
					},
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

