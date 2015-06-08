using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinFormsViews
{
	public class SampleBuilder
	{
		public SampleBuilder ()
		{
			
		}

		public IEnumerable<ViewSample> BuildSamples() {
			var activityIndicator = new ActivityIndicator {
				IsEnabled = true,
				IsRunning = true
			};

			var boxView = new BoxView {
				Color = Color.Red
			};

			var button = new Button {
				Text = "Click Me"
			};
			var buttonLabel = new Label {
				Text = ""
			};
			button.Clicked += (sender, e) => {
				buttonLabel.Text = "I've been clicked!";
			};
			var buttonStack = new StackLayout {
				Children = { button, buttonLabel }
			};

			var datePicker = new DatePicker ();

			var editor = new Editor {
				Text = "You can edit multiple lines of text here!"
			};
			var entry = new Entry {
				Placeholder = "Enter a single line of text"
			};

			var image = new Image {
				Source = ImageSource.FromUri(new Uri("http://placehold.it/350x150"))
			};

			var label = new Label {
				Text = "Hello, I'm a label!"
			};

			var picker = new Picker ();
			picker.Items.Add ("Red");
			picker.Items.Add ("Green");
			picker.Items.Add ("Purple");
			picker.Items.Add ("Grey");
			picker.Items.Add ("Black");

			var progressBar = new ProgressBar {
				Progress = 0	
			};
			var progressButton = new Button {
				Text = "Start Progressing"
			};
			progressButton.Clicked += async (sender, e) => {
				await progressBar.ProgressTo(1.0, 500, Easing.Linear);
			};

			var progressStack = new StackLayout {
				Children = { progressBar, progressButton }
			};

			var searchBar = new SearchBar ();

			var slider = new Slider ();

			var stepper = new Stepper ();

			var @switch = new Switch ();

			var timePicker = new TimePicker ();

			var webView = new WebView {
				Source = new UrlWebViewSource {
					Url = "https://tutsplus.com/"
				},
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			return new List<ViewSample> {
				new ViewSample {
					Name = "ActivityIndicator",
					View = activityIndicator
				},
				new ViewSample {
					Name = "BoxView",
					View = boxView
				},
				new ViewSample {
					Name = "Button",
					View = buttonStack
				},
				new ViewSample {
					Name = "DatePicker",
					View = datePicker
				},
				new ViewSample {
					Name = "Editor",
					View = editor
				},
				new ViewSample {
					Name = "Entry",
					View = entry
				},
				new ViewSample {
					Name = "Image",
					View = image
				},
				new ViewSample {
					Name = "Label",
					View = label
				},
				new ViewSample {
					Name = "Picker",
					View = picker
				},
				new ViewSample {
					Name = "ProgressBar",
					View = progressStack
				},
				new ViewSample {
					Name = "SearchBar",
					View = searchBar
				},
				new ViewSample {
					Name = "Slider",
					View = slider
				},
				new ViewSample {
					Name = "Stepper",
					View = stepper
				},
				new ViewSample {
					Name = "Switch",
					View = @switch
				},
				new ViewSample {
					Name = "TimePicker",
					View = timePicker
				},
				new ViewSample {
					Name = "WebView",
					View = webView
				}
			};
		}
	}
}

