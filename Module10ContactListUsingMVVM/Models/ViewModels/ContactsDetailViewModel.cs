using CommunityToolkit.Mvvm.ComponentModel;

namespace Module10ContactListUsingMVVM.Models.ViewModels;

partial class ContactsDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}
