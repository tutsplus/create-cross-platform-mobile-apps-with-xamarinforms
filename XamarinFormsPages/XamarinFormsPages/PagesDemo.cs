using System;

using Xamarin.Forms;

namespace XamarinFormsPages
{
	public class PagesDemo : TabbedPage
	{
		public PagesDemo ()
		{
			var rootLabel = new Label { Text = "Root Page" };
			var anotherLabel = new Label {Text = "Another Label"};
			var button = new Button {
				Text = "Next Page"
			};

			var stackLayout = new StackLayout {
				Children = {rootLabel, button}
			};
			var newPage = new ContentPage {
				Title = "New Page",
				Content = anotherLabel
			};
			var navPage = new NavigationPage (new ContentPage {
				Title = "Root",
				Content = stackLayout
			}){ Title = "Navigation Page" };

			button.Clicked += ( sender, args ) => navPage.PushAsync( newPage );

			Title = "Tabbed Page";
			Children.Add (new ContentDemo ());
			Children.Add (new MasterDetailDemo ());
			Children.Add (navPage);
			Children.Add (new CarouselDemo ());
		}
	}

	public class ContentDemo : ContentPage {
		public ContentDemo ()
		{
			var label = new Label {
				Text = "This is a simple ContentPage",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			Title = "ContentPage";
			Content = label;
		}
	}

	public class MasterDetailDemo : MasterDetailPage {
		public MasterDetailDemo ()
		{
			Title = "MasterDetail Page";
			Master = new ContentPage {
				Title = "Master",
				Content = new Label {
					Text = "This is the Master page.",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				}
			};

			Detail = new ContentPage {
				Title = "Detail",
				BackgroundColor = Color.White,
				Content = new Label {
					Text = "This is the Detail page.",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				}
			};
		}
	}

	public class NavigationDemo : NavigationPage {
		public NavigationDemo(Page root) : base(root)
		{
			 
		}
	}

	public class CarouselDemo : CarouselPage {
		public CarouselDemo ()
		{
			var page1 = new ContentPage {
				Content = new Label {
					Text = "Hi, I'm Page1!",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				}
			};
			var page2 = new ContentPage {
				Content = new Label {
					Text = "Hi, I'm Page2!",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				}
			};

			Title = "Carousel";
			Children.Add (page1);
			Children.Add (page2);

		}
	}
}


