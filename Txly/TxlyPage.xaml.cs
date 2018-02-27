using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace Txly
{
    public partial class TxlyPage : ContentPage
    {
        MediaPlayerViewModel viewModel;

        public TxlyPage()
        {
            InitializeComponent();

            //Fix iPhone X notch https://stackoverflow.com/questions/47779937/how-to-allow-for-ios-status-bar-and-iphone-x-notch-in-xamarin-forms?noredirect=1&lq=1
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            BindingContext = viewModel = new MediaPlayerViewModel();
            Padding = PagePadding;

            viewModel.Init();
            viewModel.MediaPlayer.Play();
            label1.Text = "同行频道APP测试版";
            //label2.Text = viewModel.MediaPlayer.MediaExtractor.ToString();

            var url = new UrlWebViewSource
            {
                Url = "https://www7.cbox.ws/box/?boxid=828515&boxtag=PaHjHJ"
            };
            webView.Source = url;

            //These flows errors on Android.
            //label3.Text = viewModel.MediaPlayer.Duration.ToString();
            //label4.Text = viewModel.MediaPlayer.Position.ToString();

            //SimpleAudioPlayer Reference https://blog.xamarin.com/adding-sound-xamarin-forms-app/
            //var player = CrossSimpleAudioPlayer.Current;
            //player.Load("wang04.mp3");
            //player.Play();
        }

        void OnBtnPauseClicked(object sender, System.EventArgs e)
        {
            //Toggle play status
            //System.Console.WriteLine("B4 Status: " + viewModel.MediaPlayer.Status.ToString());
            if ( viewModel.MediaPlayer.Status.ToString().Equals("Playing") ){
                viewModel.MediaPlayer.PlaybackController.Pause();
                BtnPause.Text = "播放";
            } else {
                viewModel.MediaPlayer.PlaybackController.Play();
                BtnPause.Text = "暂停";
            }
            //System.Console.WriteLine("AF Status: " + viewModel.MediaPlayer.Status.ToString());
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
