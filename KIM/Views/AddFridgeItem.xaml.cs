using KIM.Models.ViewModels;

namespace KIM.Views;

public partial class AddFridgeItem : ContentPage
{
    public AddFridgeItem()
	{
		InitializeComponent();
    }

	private void Btn_Create(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}

    private void Btn_Back(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}