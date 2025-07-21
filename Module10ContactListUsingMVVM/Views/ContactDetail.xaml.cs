namespace Module10ContactListUsingMVVM.Views;

public partial class ContactDetail : ContentPage
{
	public ContactDetail()
	{
		InitializeComponent();
	}

	private void Button_Clicked (object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}