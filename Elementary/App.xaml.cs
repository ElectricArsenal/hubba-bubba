﻿using Xamarin.Forms;
using Elementary.Pages;

namespace Elementary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
