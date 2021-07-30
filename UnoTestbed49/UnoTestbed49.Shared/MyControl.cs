using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoTestbed49
{
	public partial class MyControl : ContentControl
	{
		public MyControl()
		{
			Loaded += OnLoaded;
		}

		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			Content = ApplyContent();
		}

		private object ApplyContent()
		{
			switch (MyContent)
			{
				case SizeContent sizeContent:
					if (!double.IsNaN(sizeContent.Size))
					{
						return sizeContent.Size;
					}
					break;
			}

			return null;
		}

		public ContentBase MyContent
		{
			get { return (ContentBase)GetValue(MyContentProperty); }
			set { SetValue(MyContentProperty, value); }
		}

		// Using a DependencyProperty as the backing store for MyContent.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MyContentProperty =
			DependencyProperty.Register("MyContent", typeof(ContentBase), typeof(MyControl), new PropertyMetadata(null));
	}
}
