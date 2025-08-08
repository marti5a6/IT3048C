using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace KIM.Models.ViewModels;

partial class FridgeItemListViewModel : ObservableObject
{
    // Create Observable Collection of "FridgeItem" objects
    [ObservableProperty]
    private ObservableCollection<FridgeItem> fridgeItems = new();

    // Instantiate observable object for data injection
    [ObservableProperty]
    private FridgeItem fridgeItem = new();

    // Command to add item to Observable Collection "fridgeItems"
    [RelayCommand]
    private void Add()
    {
        FridgeItems.Add(FridgeItem);
        FridgeItem = new();
    }

    // Command to remove item from Observable Collection "FridgeItems"
    [RelayCommand]
    private void Delete(FridgeItem item)
    {
        // Null Check before deleting
        if (item != null)
        {
            FridgeItems.Remove(item);
        }
    }
}