﻿using System;
//using System.Collections.Generic;

using Xamarin.Forms;

namespace Txly
{
    public partial class ModalWebPage : ContentPage
    {
        public ModalWebPage(string urlString)
        {
            InitializeComponent();

            // Accomodate iPhone status bar.
            //this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Padding = PagePadding;

            var url = new UrlWebViewSource
            {
                Url = urlString
            };
            webView.Source = url;
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        public static readonly Thickness PagePadding = GetPagePadding();

        private static Thickness GetPagePadding()
        {
            double topPadding;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    topPadding = 20;
                    break;
                default:
                    topPadding = 0;
                    break;
            }

            return new Thickness(5, topPadding, 5, 0);
        }
    }
}
