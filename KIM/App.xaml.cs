using KIM.Views;

namespace KIM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FridgeItemList());
        }
    }
}