using System;

using Xamarin.Forms;

namespace Styles
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					new Label { Text = "Hello ContentPage",
								XAlign = TextAlignment.Center,
								Style = (Style)Application.Current.Resources["LabelStyle"]
					}
				}
			};
		}
	}
}


