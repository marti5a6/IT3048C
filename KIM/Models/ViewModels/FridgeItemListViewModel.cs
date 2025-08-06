using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace KIM.Models.ViewModels;

partial class FridgeItemListViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<FridgeItem> fridgeItems = new();

    [ObservableProperty]
    private FridgeItem fridgeItem = new();

    [RelayCommand]
    private void Add()
    {
        FridgeItems.Add(FridgeItem);
        FridgeItem = new();
    }
}