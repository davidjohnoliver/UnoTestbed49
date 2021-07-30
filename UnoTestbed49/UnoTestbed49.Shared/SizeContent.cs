using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;

namespace UnoTestbed49
{
	public class SizeContent : ContentBase
	{
		public double Size
		{
			get { return (double)GetValue(SizeProperty); }
			set { SetValue(SizeProperty, value); }
		}

		public static readonly DependencyProperty SizeProperty =
			DependencyProperty.Register("Size", typeof(double), typeof(SizeContent), new PropertyMetadata(double.NaN));
	}
}
