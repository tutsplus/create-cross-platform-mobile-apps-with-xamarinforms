using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace XamarinFormsViews
{
	public class App : Application
	{
		private SampleBuilder _builder = new SampleBuilder();

		public App ()
		{
			NavigationPage _nav = null;

			var listView = new ListView ();

			listView.ItemsSource = _builder.BuildSamples ();
			listView.ItemTemplate = new DataTemplate (typeof(TextCell));
			listView.ItemTemplate.SetBinding (TextCell.TextProperty, "Name");
			listView.ItemTemplate.SetBinding (TextCell.DetailProperty, "Name");

			listView.ItemSelected += async (sender, e) => {
				var sample = (ViewSample)e.SelectedItem;
				var samplePage = new ViewSamplePage(sample);
				await _nav.PushAsync(samplePage);
			};

			var root = new ContentPage {
				Title = "Common Controls",
				Content = listView
			};

			_nav = new NavigationPage (root);

			// The root page of your application
			MainPage = _nav;
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

