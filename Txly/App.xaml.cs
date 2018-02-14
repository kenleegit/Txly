using Xamarin.Forms;

namespace Txly
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TxlyPage();
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
