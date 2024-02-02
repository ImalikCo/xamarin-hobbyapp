﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casus_Fysiek
{
    public partial class App : Application
    {
        public static string ConnectionString;

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
        public App(string connectionString)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            ConnectionString = connectionString;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
