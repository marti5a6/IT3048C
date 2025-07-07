using Module8ExtendingNewsApp.Models;
using Module8ExtendingNewsApp.Services;

namespace Module8ExtendingNewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article selectedArticle)
	{
		InitializeComponent();
		ArticleImage.Source = selectedArticle.Image;
        ArticleContent.Text = selectedArticle.Content;
    }

    private void BtnGoBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void BtnRestart_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}