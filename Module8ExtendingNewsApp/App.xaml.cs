using Module8ExtendingNewsApp.Pages;

namespace Module8ExtendingNewsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewsHomePage());
        }
    }
}