using Module10ContactListUsingMVVM.Models.ViewModels;

namespace Module10ContactListUsingMVVM.Views;

public partial class ContactsList : ContentPage
{
	public ContactsList()
	{
		InitializeComponent();
	}

	private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var contact = e.Item as Models.Contact;
		var contactViewModel = new ContactsDetailViewModel { Contact = contact };
		var contactDetail = new ContactDetail();
		contactDetail.BindingContext = contactViewModel;
		Navigation.PushAsync(contactDetail);
	}
}
