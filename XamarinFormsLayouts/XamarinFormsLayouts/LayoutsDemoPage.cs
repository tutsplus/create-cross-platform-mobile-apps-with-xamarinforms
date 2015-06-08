using System;

using Xamarin.Forms;

namespace XamarinFormsLayouts
{
	public class LayoutsDemoPage : TabbedPage
	{
		public LayoutsDemoPage ()
		{
			Children.Add (new StackLayoutDemo());
			Children.Add (new AbsoluteLayoutDemo ());
			Children.Add (new RelativeLayoutDemo ());
			Children.Add (new GridLayoutDemo ());
			Children.Add (new ContentViewLayoutDemo ());
			Children.Add (new ScrollViewLayoutDemo ());
			Children.Add (new FrameLayoutDemo ());
		}
	}

	public class StackLayoutDemo : ContentPage {
		public StackLayoutDemo ()
		{
			var button = new Button {
				Text = "I'm a Button",
			};
			var label = new Label {
				Text = "I'm a Label",
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var stack = new StackLayout {
				Children = { button, label }
			};

			Title = "Stack";
			Padding = 20;
			Content = stack;

		}
	}

	public class AbsoluteLayoutDemo : ContentPage {
		public AbsoluteLayoutDemo ()
		{
			var redBox = new BoxView {
				Color = Color.Red
			};
			var blueBox = new BoxView {
				Color = Color.Blue
			};
			var yellowBox = new BoxView {
				Color = Color.Yellow
			};
			var purpleBox = new BoxView {
				Color = Color.Purple
			};
			var greenBox = new BoxView {
				Color = Color.Green
			};

			AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0, 0, 0.25, 0.25));
			AbsoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(blueBox, new Rectangle(0.15, 0.15, 0.25, 0.25));
			AbsoluteLayout.SetLayoutFlags(yellowBox, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(yellowBox, new Rectangle(0.30, 0.30, 0.25, 0.25));
			AbsoluteLayout.SetLayoutFlags(purpleBox, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(purpleBox, new Rectangle(0.45, 0.45, 0.25, 0.25));
			AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.All);
			AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(0.60, 0.60, 0.25, 0.25));

			Title = "Absolute";
			Content = new AbsoluteLayout {
				Children = {redBox, blueBox, yellowBox, purpleBox, greenBox}
			};
		}
	}

	public class RelativeLayoutDemo : ContentPage {
		public RelativeLayoutDemo ()
		{
			var redBox = new BoxView {
				Color = Color.Red
			};
			var blueBox = new BoxView {
				Color = Color.Blue
			};
			var yellowBox = new BoxView {
				Color = Color.Yellow
			};
			var purpleBox = new BoxView {
				Color = Color.Purple
			};
			var relativeLayout = new RelativeLayout( );

			relativeLayout.Children.Add(redBox, 
										Constraint.Constant(0), 
										Constraint.Constant(0) );
			
			relativeLayout.Children.Add(blueBox, 
										Constraint.RelativeToParent((parent) => parent.Width - 40 ),
										Constraint.RelativeToParent((parent) => parent.Height - 40 ));
			
			relativeLayout.Children.Add(yellowBox,
										Constraint.RelativeToParent(parent => parent.Width / 3),
										Constraint.RelativeToParent(parent => parent.Height / 3),
										Constraint.RelativeToParent(parent => parent.Width / 3),
										Constraint.RelativeToParent(parent => parent.Height / 3) );
			
			relativeLayout.Children.Add(purpleBox,
										Constraint.RelativeToView(yellowBox, (parent, sibling) => sibling.X),
										Constraint.RelativeToView(yellowBox, (parent, sibling) => sibling.Y),
										Constraint.RelativeToView(yellowBox, (parent, sibling) => sibling.Width / 3),
										Constraint.RelativeToView(yellowBox, (parent, sibling) => sibling.Height / 3));

			Title = "Relative";
			Content = relativeLayout;
		}
	}

	public class GridLayoutDemo : ContentPage {
		public GridLayoutDemo ()
		{
			var grid = new Grid {
				RowDefinitions = new RowDefinitionCollection {
					new RowDefinition {Height = new GridLength( 1, GridUnitType.Star )},
					new RowDefinition {Height = new GridLength( 1, GridUnitType.Star )},
					new RowDefinition {Height = new GridLength( 1, GridUnitType.Star )},
				},
				ColumnDefinitions = new ColumnDefinitionCollection {
					new ColumnDefinition {Width = new GridLength( 1, GridUnitType.Star )},
					new ColumnDefinition {Width = new GridLength( 1, GridUnitType.Star )},
					new ColumnDefinition {Width = new GridLength( 1, GridUnitType.Star )},
				}
			};

			var label1 = new Label {
				Text = "Cell 0, 0",
				BackgroundColor = Color.Red,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var label2 = new Label {
				Text = "Cell 2, 2",
				BackgroundColor = Color.Blue,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var label3 = new Label
			{
				Text = "Cell 1, 0 With Span",
				BackgroundColor = Color.Yellow,
				TextColor = Color.Black,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};

			grid.Children.Add(label1, 0, 0);
			grid.Children.Add(label2, 2, 2);
			grid.Children.Add (label3, 0, 1);
			Grid.SetColumnSpan (label3, 3);

			Title = "Grid";
			Content = grid;
		}
	}

	public class ContentViewLayoutDemo : ContentPage {
		public ContentViewLayoutDemo ()
		{
			var contentView = new ContentView {
				Content = new Label {
					Text = "Hi, I'm a simple Label inside of a simple ContentView",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				}
			};

			Title = "ContentView";
			Content = contentView;
		}
	}

	public class ScrollViewLayoutDemo : ContentPage {
		public ScrollViewLayoutDemo ()
		{
			var scrollView = new ScrollView {
				Content = new Label {
					Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus bibendum ex sit amet tellus tempus cursus. Vivamus rhoncus quam tellus, eget cursus ante dictum vitae. Duis tempus sollicitudin dolor, eget facilisis ex fermentum non. Nulla vel augue non ligula finibus pellentesque vel non augue. Pellentesque augue odio, ullamcorper at magna nec, scelerisque sollicitudin massa. Nullam consectetur arcu non mattis cursus. Praesent semper consequat odio at luctus. Nullam pretium id libero eu mattis. Proin non ipsum quam. Vestibulum bibendum egestas eros at cursus. Sed faucibus accumsan lacus, sed facilisis justo semper vitae. Curabitur vulputate sapien ut erat porta sagittis. Morbi justo ligula, mattis nec metus sed, tempus porta arcu. Aliquam maximus, ligula in aliquam porttitor, diam quam cursus sapien, ut lobortis lorem risus eget libero. Mauris sollicitudin interdum mauris, at rhoncus velit ornare eu.\n\nSed a pulvinar purus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec lobortis porttitor ultricies. Aliquam erat volutpat. Pellentesque finibus sollicitudin quam, eget tincidunt ex lobortis ut. Sed maximus semper leo, sed consequat quam dapibus et. Quisque posuere ipsum non augue efficitur semper.\n\nMauris ut est pellentesque, cursus massa eget, consequat velit. Fusce sed enim magna. Fusce tempor neque in elit iaculis commodo fermentum eu elit. In hac habitasse platea dictumst. Quisque venenatis diam id scelerisque sodales. Suspendisse tellus nibh, malesuada in ipsum eu, aliquet bibendum turpis. Quisque aliquam neque non dictum sollicitudin. Integer facilisis a nisl sed dignissim.\n\nSed pretium cursus placerat. Duis vestibulum laoreet sem ut malesuada. Proin eget porta magna. Morbi id purus purus. Maecenas ullamcorper cursus nunc, sit amet tincidunt odio eleifend vitae. Phasellus ultrices tortor fermentum imperdiet molestie. Ut dapibus id eros et fermentum.\n\nProin in tellus a nulla suscipit sagittis non et elit. Sed ullamcorper quis nulla a volutpat. Suspendisse potenti. Nulla sollicitudin dictum aliquam. Proin mattis ligula felis, eget tempus lectus placerat a. Sed auctor posuere viverra. In sit amet sem a sem rhoncus sagittis eu ac ipsum. Nullam sollicitudin nibh risus, condimentum auctor justo malesuada vel. Mauris enim lorem, laoreet vitae accumsan eget, mollis placerat erat. Proin porttitor nulla ac erat aliquet, sed porta ipsum venenatis."
				}
			};

			Title = "Scroll";
			Content = scrollView;
		}
	}

	public class FrameLayoutDemo : ContentPage {
		public FrameLayoutDemo ()
		{
			var frameView = new Frame {
				Content = new Label {
					Text = "I've been framed!",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				},
				OutlineColor = Color.Red
			};

			Title = "Frame";
			Content = frameView;
		}
	}
}


