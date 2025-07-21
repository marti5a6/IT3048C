using CommunityToolkit.Mvvm.ComponentModel;

namespace Module10ContactListUsingMVVM.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private Contact contact;
}
