using AeroturApp.Models.DataModels;
using AeroturApp.Models.ViewModels;
using AeroturApp.Services;

namespace AeroturApp.Views;
//[QueryProperty(nameof(SearchParams),nameof(SearchParams))]
public partial class SearchResultPage : ContentPage
{
    //SearchResultsViewModel model;
    // SearchParams SearchParams { set; get; }
	public SearchResultPage(SearchResultsViewModel model)
	{
        InitializeComponent();
		ResultsView.BindingContext = model;
    }

}