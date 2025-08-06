using KIM.Models;
using KIM.Models.ViewModels;

namespace KIM.Views;

public partial class FridgeItemList : ContentPage
{
    private FridgeItemListViewModel fridgeItemViewModel;
    public FridgeItemList()
	{
		InitializeComponent();
        fridgeItemViewModel = new FridgeItemListViewModel();
        BindingContext = fridgeItemViewModel;
    }

    private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var fridgeItem = e.Item as FridgeItem;
        var fridgeItemViewModel = new FridgeItemDetailViewModel { FridgeItem = fridgeItem };
        var fridgeItemDetail = new FridgeItemDetail();
        fridgeItemDetail.BindingContext = fridgeItemViewModel;
        Navigation.PushAsync(fridgeItemDetail);
    }

    private void Btn_Add(object sender, EventArgs e)
    {
        var addFridgeItem = new AddFridgeItem();
        addFridgeItem.BindingContext = fridgeItemViewModel;
        Navigation.PushAsync(addFridgeItem);
    }
}