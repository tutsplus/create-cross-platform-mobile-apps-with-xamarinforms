using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomControls;
using CustomControls.Droid;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]

namespace CustomControls.Droid
{
	public class MyLabelRenderer : LabelRenderer
	{
		public MyLabelRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.Rotation = 180.0f;
			}
		}
	}
}

