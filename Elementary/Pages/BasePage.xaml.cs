using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Elementary.Pages
{
    public partial class BasePage : ContentPage
    {
        public BasePage()
        {
            InitializeComponent();

            // Moved to Property Elements in XAML
            // Control device specific ContentPage parameters.
            switch(Device.RuntimePlatform){
                case Device.iOS:
					// Because iOS has a transparent status bar that the view is behind. We add some padding to avoid a content overlap.
                    // Padding = new Thickness(0, 20, 0, 0);
                    break;
                 default:
                    break;
            }
        }
    }
}
