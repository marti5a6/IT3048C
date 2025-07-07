using Module8ExtendingNewsApp.Models;
using Module8ExtendingNewsApp.Services;

namespace Module8ExtendingNewsApp.Pages;

public partial class NewsListPage : ContentPage
{
    public List<Article> ArticleList;
    public NewsListPage(Category SelectedCategory)
	{
		InitializeComponent();
        string cat = SelectedCategory.Name;
        CategoryTitle.Text = cat;
        ArticleList = new List<Article>();
        GetBreakingNews(cat);
    }

    private async Task GetBreakingNews(string category)
    {
        var apiService = new ApiService();
        var newsResult = await apiService.GetNews(category);
        foreach (var item in newsResult.Articles)
        {
            ArticleList.Add(item);
        }
        CvNews.ItemsSource = ArticleList;
    }

    private void ArticleSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedArticle = e.CurrentSelection.FirstOrDefault() as Article;
        if (selectedArticle == null) return;
        Navigation.PushAsync(new NewsDetailPage(selectedArticle));
        ((CollectionView)sender).SelectedItem = null;
    }

    private void BtnGoBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}