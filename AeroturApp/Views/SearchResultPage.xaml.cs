using AeroturApp.Models.ViewModels;

namespace AeroturApp.Views;

public partial class SearchResultPage : ContentPage
{

	public SearchResultPage(SearchResultsViewModel model)
	{
        InitializeComponent();
		BindingContext = model;
    }
	
}