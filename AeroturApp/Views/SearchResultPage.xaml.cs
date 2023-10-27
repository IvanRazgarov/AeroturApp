using AeroturApp.Models.ViewModels;

namespace AeroturApp.Views;

public partial class SearchResultPage : ContentPage
{
	public SearchResultPage()
	{
		InitializeComponent();
		ResultsView.BindingContext = new SearchResultsViewModel();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("///MainPage");
    }
}