using System;

using Xamarin.Forms;

namespace Txly
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page txlyPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    txlyPage = new NavigationPage(new TxlyPage())
                    {
                        Title = "第五空间"
                    };
                    /*
                    storiesPage = new NavigationPage(new StoriesPage())
                    {
                        Title = "聽眾故事"
                    };
                    bookItemsPage = new NavigationPage(new BookItemsPage())
                    {
                        Title = "收藏"
                    };
                    */
                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "其他"
                    };
                    txlyPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";

                    break;
                default:
                    txlyPage = new TxlyPage()
                    {
                        Title = "第五空間"
                    };
                    /*
                    storiesPage = new StoriesPage()
                    {
                        Title = "聽眾故事"
                    };
                    bookItemsPage = new BookItemsPage()
                    {
                        Title = "收藏"
                    };*/
                    aboutPage = new AboutPage()
                    {
                        Title = "其他"
                    };
                    break;
            }

            Children.Add(txlyPage);
            //Children.Add(storiesPage);
            //Children.Add(bookItemsPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}

