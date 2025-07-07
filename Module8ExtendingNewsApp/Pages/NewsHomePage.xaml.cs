using Module8ExtendingNewsApp.Models;

namespace Module8ExtendingNewsApp.Pages;

public partial class NewsHomePage : ContentPage
{
    public List<Category> CategoryList = new List<Category>()
    {
        new Category(){Name="World", ImageUrl = "world.png"},
        new Category(){Name = "Nation" , ImageUrl="nation.png"},
        new Category(){Name = "Business" , ImageUrl="business.png"},
        new Category(){Name = "Technology" , ImageUrl="technology.png"},
        new Category(){Name = "Entertainment", ImageUrl = "entertainment.png"},
        new Category(){Name = "Sports" , ImageUrl="sports.png"},
        new Category(){Name = "Science", ImageUrl= "science.png"},
        new Category(){Name = "Health", ImageUrl="health.png"},
    };

    public NewsHomePage()
	{
        InitializeComponent();
        CvCategories.ItemsSource = CategoryList;
    }

    private void CategorySelected(object sender, SelectionChangedEventArgs e)
    {
        var selection = e.CurrentSelection.FirstOrDefault() as Category;
        if (selection == null) return;
        Navigation.PushAsync(new NewsListPage(selection));
        ((CollectionView)sender).SelectedItems = null;
    }
}