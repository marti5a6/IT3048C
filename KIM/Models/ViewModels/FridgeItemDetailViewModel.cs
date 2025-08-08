using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using KIM.Models.ViewModels;

namespace KIM.Models.ViewModels;

partial class FridgeItemDetailViewModel : ObservableObject
{
    // Bind selected "fridgeItem" object from Observable Collection for detail view
    [ObservableProperty]
    private FridgeItem fridgeItem;
}
