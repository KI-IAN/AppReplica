﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppReplica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ReplicatedUI.WhatsApp.UIPages.SplashScreen();
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
