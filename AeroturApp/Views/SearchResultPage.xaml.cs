namespace AeroturApp.Views;

public partial class SearchResultPage : ContentPage
{
	public List<string> searchResults { get; set; }
	public SearchResultPage()
	{
		searchResults = null;
		InitializeComponent();
		ResultsView.BindingContext = this;
		ResultsView.ItemsSource = searchResults;
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("///MainPage");
    }
}