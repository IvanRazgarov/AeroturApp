using AeroturApp.Models.DataModels;
using AeroturApp.Models.ViewModels;
using AeroturApp.Services;

namespace AeroturApp.Views;
//[QueryProperty(nameof(SearchParams),nameof(SearchParams))]
public partial class SearchResultPage : ContentPage
{
    //SearchResultsViewModel model;
	//private SearchParams SearchParams { set; get; }
	public SearchResultPage(SearchResultsViewModel model)
	{
        /*SearchParams searchParams = new()
        {
            locale = "RU",
            instance = "aerotur.aero.dev",
            adults = 1,
            children = 0,
            infants = 0,
            infants_seat = 0,
            flight_class = "Economy",
            from = "LED",
            fromType = "city",
            to = "OSS",
            toType = "city",
            date1 = "2023-11-3",
            date2 = null,
            asGrouped = 0
        };*/

        InitializeComponent();
		ResultsView.BindingContext = model;
        //this.model = model;
        //model.SearchForFlights(searchParams);
    }

    async void Return_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
    async void Retry_Clicked(object sender, EventArgs e)
    {
        //model.SearchForFlights(SearchParams);
    }
    async void ItemsTresholdReached(object sender, EventArgs e)
    {
        //model.AddPartToCollection(); 
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}