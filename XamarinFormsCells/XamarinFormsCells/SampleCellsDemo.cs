using System;

using Xamarin.Forms;

namespace XamarinFormsCells
{
	public class SampleCellsDemo : TabbedPage
	{
		public SampleCellsDemo ()
		{
			Children.Add (new EntryCellDemo ());
			Children.Add (new SwitchCellDemo ());
			Children.Add (new TextCellDemo ());
			Children.Add (new ImageCellDemo ());
		}
	}

	public class EntryCellDemo : ContentPage {
		public EntryCellDemo ()
		{
			var tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot {
					new TableSection {
						new EntryCell {
							Label = "Entry Cell:",
							Placeholder = "Enter some data",

						}
					}
				}
			};

			Title = "Entry";
			Content = tableView;
		}
	}

	public class SwitchCellDemo : ContentPage {
		public SwitchCellDemo ()
		{
			var tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot {
					new TableSection {
						new SwitchCell {
							Text = "Switch Cell:"
						}
					}
				}
			};

			Title = "Switch";
			Content = tableView;
		}
	}

	public class TextCellDemo : ContentPage {
		public TextCellDemo ()
		{
			var tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot {
					new TableSection {
						new TextCell {
							Text = "Primary Text",
							Detail = "Secondary Text"
						}
					}
				}
			};

			Title = "Text";
			Content = tableView;
		}
	}

	public class ImageCellDemo : ContentPage {
		public ImageCellDemo ()
		{
			var tableView = new TableView {
				Intent = TableIntent.Form,
				Root = new TableRoot {
					new TableSection {
						new ImageCell {
							ImageSource = ImageSource.FromUri(new Uri("http://placehold.it/50x50")),
							Text = "Primary Text",
							Detail = "Secondary Text"
						}
					}
				}
			};

			Title = "Image";
			Content = tableView;
		}
	}
}


