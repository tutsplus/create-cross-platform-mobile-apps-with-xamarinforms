using System;

using Xamarin.Forms;

namespace NativeAPIs
{
	public class NetworkStatusPage : ContentPage
	{
		public NetworkStatusPage ()
		{
			var networkLabel = new Label {
				Text = "Network Status",
				YAlign = TextAlignment.Center
			};
			var networkBox = new BoxView {
				Color = Color.White,
				HeightRequest = 25,
				WidthRequest = 25
			};

			var networkStack = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Padding = 15,
				Spacing = 25,
				Children = { networkLabel, networkBox }
			};

			var button = new Button {
				Text = "Update Status",
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			button.Clicked += (sender, e) => {
				var service = DependencyService.Get<INetworkService>();
				var isConnected = service.IsConnected();

				networkBox.Color = isConnected ? Color.Green : Color.Red;
			};

			Content = new StackLayout { 
				Children = { networkStack, button }
			};
		}
	}
}


