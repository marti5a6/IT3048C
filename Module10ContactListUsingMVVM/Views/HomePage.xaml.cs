using Module10ContactListUsingMVVM.Models.ViewModels;

namespace Module10ContactListUsingMVVM.Views;

public partial class HomePage : ContentPage
{
	private ContactsListViewModel contactsViewModel;
	public HomePage()
	{
		InitializeComponent();
		contactsViewModel = new ContactsListViewModel();
		BindingContext = contactsViewModel;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var contactList = new ContactsList();
		contactList.BindingContext = contactsViewModel;
		Navigation.PushAsync(contactList);
	}
}