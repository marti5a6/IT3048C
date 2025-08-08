using KIM.Models.ViewModels;

namespace KIM.Views;

public partial class AddFridgeItem : ContentPage
{
    public AddFridgeItem()
	{
		InitializeComponent();
    }

    // Create Button executes command in viewmodel and goes back to FridgeItemList
	private void Btn_Create(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

    // Back Button simply goes to the previous page which is always FridgeItemList
    private void Btn_Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}