using Module10ContactListUsingMVVM.Views;

namespace Module10ContactListUsingMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}