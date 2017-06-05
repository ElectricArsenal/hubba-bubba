using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Elementary.Pages
{
    public partial class WelcomePage : BasePage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        void Handle_Login_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Login pressed!", "All good.", "Close");
        }
		void Handle_Register_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Register pressed!", "All good.", "Close");
		}
    }
}
