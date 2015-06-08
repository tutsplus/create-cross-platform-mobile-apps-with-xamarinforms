using System;
using Xamarin.Forms;

namespace XamarinFormsViews
{
	public class ViewSamplePage : ContentPage
	{
		public ViewSamplePage (ViewSample sample)
		{
			Title = sample.Name;
			sample.View.HorizontalOptions = LayoutOptions.FillAndExpand;
			Content = new StackLayout {
				Padding = 20,
				Orientation = StackOrientation.Vertical,
				Children = { sample.View }
			};
		}
	}
}

