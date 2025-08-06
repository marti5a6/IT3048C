namespace KIM.Views;

public partial class FridgeItemDetail : ContentPage
{
	public FridgeItemDetail()
	{
		InitializeComponent();
	}

    private void Btn_Edit(object sender, EventArgs e)
    {
        // Edit + Delete Logic
    }

    private void Btn_Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}