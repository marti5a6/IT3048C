namespace KIM.Views;

public partial class FridgeItemDetail : ContentPage
{
	public FridgeItemDetail()
	{
		InitializeComponent();
	}

    // Placeholder for future - Need to create edit command in detail viewmodel
    private void Btn_Edit(object sender, EventArgs e)
    {
        // Edit Logic
    }

    // Back Button simply goes to the previous page which is always FridgeItemList
    private void Btn_Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}