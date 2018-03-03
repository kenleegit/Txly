using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Txly
{
    public partial class AboutPage : ContentPage
    {
        enum TypesOfPage { url, local };

        public AboutPage()
        {
            InitializeComponent();
        }

        void OnBtnClicked(object sender, System.EventArgs e)
        {
            //2018-01-12 Open pages according to buttons clicked.

            string urlToOpen = "https://m.729ly.net/"; //Default page to open.
            var button = (Button)sender;
            int typeOfPage = -1;
           
            switch (button.Text)
            {
                case "關於我們":
                    urlToOpen = "https://m.729ly.net/";
                    typeOfPage = (int)TypesOfPage.url;
                    break;
            }
            if (typeOfPage == (int)TypesOfPage.url)
            {
                var modalPage = new ModalWebPage(urlToOpen);
                Navigation.PushModalAsync(modalPage);
            }
            else
            {
                switch (button.Text)
                {
                    case "联络我们":
                        var modalPage = new ContactLYPage();
                        Navigation.PushModalAsync(modalPage);
                        break;
                }
            }

        }
    }
}
