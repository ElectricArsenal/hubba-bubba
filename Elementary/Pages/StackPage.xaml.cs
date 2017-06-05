using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Elementary.Pages
{
    public partial class StackPage : BasePage
    {
        public StackPage()
        {
            InitializeComponent();
            //LoadStackLayout();
        }

        // Same layout as XAML created in code.
        void LoadStackLayout()
        {
            var layout = new StackLayout
            {
                Spacing = 20,
                Padding = 40,
                Orientation = StackOrientation.Vertical,
                BackgroundColor = new Color(0,255,0),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            layout.Children.Add(new Label { BackgroundColor = new Color(0, 0, 255), Text = "Label One" });
            layout.Children.Add(new Label { BackgroundColor = new Color(0, 0, 255), Text = "Label Two" });
            layout.Children.Add(new Label { BackgroundColor = new Color(0, 0, 255), Text = "Label Three" });
            Content = layout;
        }
    }
}
