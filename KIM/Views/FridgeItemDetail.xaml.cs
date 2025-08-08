namespace KIM.Views;

public partial class FridgeItemDetail : ContentPage
{
	public FridgeItemDetail()
	{
		InitializeComponent();
	}

    private void Btn_Delete(object sender, EventArgs e)
    {
        // Delete Logic
    }

    private void Btn_Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}