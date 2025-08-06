using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using KIM.Models.ViewModels;

namespace KIM.Models.ViewModels;

partial class FridgeItemDetailViewModel : ObservableObject
{
    [ObservableProperty]
    private FridgeItem fridgeItem;
}
