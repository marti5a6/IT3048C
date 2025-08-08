using KIM.Views;

namespace KIM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Setup navigation and make FridgeItemList the Home Page
            MainPage = new NavigationPage(new FridgeItemList());
        }
    }
}