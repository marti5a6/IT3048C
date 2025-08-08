using KIM.Models;
using KIM.Models.ViewModels;

namespace KIM.Views;

public partial class FridgeItemList : ContentPage
{
    // Create the List viewmodel for use later
    private FridgeItemListViewModel fridgeItemViewModel;

    // Instantiate the ItemList view and bind data
    public FridgeItemList()
	{
		InitializeComponent();
        fridgeItemViewModel = new FridgeItemListViewModel();
        BindingContext = fridgeItemViewModel;
    }

    // When an item from the ListView is tapped or clicked, create a FridgeItemDetailViewModel with the selected fridgeItem binded, then open the FridgeItemDetailView
    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var fridgeItem = e.Item as FridgeItem;
        var fridgeItemViewModel = new FridgeItemDetailViewModel { FridgeItem = fridgeItem };
        var fridgeItemDetail = new FridgeItemDetail();
        fridgeItemDetail.BindingContext = fridgeItemViewModel;
        Navigation.PushAsync(fridgeItemDetail);
    }

    // When the Add Item button is pressed, bind the FridgeItemListViewModel to the new AddFridgeItem view, and push it to the stack
    private void Btn_Add(object sender, EventArgs e)
    {
        var addFridgeItem = new AddFridgeItem();
        addFridgeItem.BindingContext = fridgeItemViewModel;
        Navigation.PushAsync(addFridgeItem);
    }
}