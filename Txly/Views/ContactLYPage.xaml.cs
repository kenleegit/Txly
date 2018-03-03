using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Txly
{
    public partial class ContactLYPage : ContentPage
    {
        public ContactLYPage()
        {
            InitializeComponent();

            // Accomodate iPhone status bar.
            Padding = PagePadding;
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
