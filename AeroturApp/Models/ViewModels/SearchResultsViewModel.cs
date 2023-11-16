using AeroturApp.Models.DataModels;
using AeroturApp.Services;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AeroturApp.Models.ViewModels;

[QueryProperty("searchParams", "SearchParams")]
public partial class SearchResultsViewModel : ObservableObject
{
    public SearchParams searchParams { get; set; }

    private SearchReturn results;

    private List<Variant> variants = new();

    [ObservableProperty]
    public string debugInfo="no info";

    [ObservableProperty]
    private bool isBusy = false;
    
    [ObservableProperty]
    private ObservableCollection<Variant> _flights = new();

    [ObservableProperty]
    private Variant _flight = new();

    private WebAPIClient _client;

    public SearchResultsViewModel(WebAPIClient client)
    {
        _client = client;
        searchParams = new SearchParams()
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
            date1 = DateTime.Now.AddDays(1).ToString("yyyy'-'MM'-'dd"),
            date2 = null,
            asGrouped = 0
        };
        GetSearchForFlights(searchParams);
        //AddPartToCollection(8);
    }

    [RelayCommand]
    Task ReturnToPrevious() => Shell.Current.GoToAsync($"..");

    //[RelayCommand]
    //void LoadMoreItems() => AddPartToCollection();

    [RelayCommand]
    void RetrySearch() => GetSearchForFlights(searchParams);

    public async void GetSearchForFlights(SearchParams pars)
    {
        IsBusy = true;
        var res = await _client.SearchForFlights(pars);
        //if (res != null)
        //{
        //    throw new Exception("Null in results");
        //}
        //results = res;
        if (!res.is_valid || res.variants == null) 
        {
            DebugInfo="";
            IsBusy = false;
            return;
        }
        variants = new List<Variant>(res.variants);
        Flights = new ObservableCollection<Variant>(variants);

        await Task.Yield();
        IsBusy = false;     
    }
    public void AddPartToCollection()
    {
        if (variants != null)
        {
            var length = variants.Count;
            var len = (int)length / 4;
            if (len <= 0) { return; }
            var part = variants[0..^len];
            variants.RemoveRange(0, len);
            foreach (var item in part)
            {
                Flights.Add(item);
            }
        }
    }
    public void AddPartToCollection(int partSize)
    {
        if (variants != null)
        {
            var length = variants.Count;
            var len = (int)length / partSize;
            if (len <= 0) { return; }
            var part = variants[0..^len];
            variants.RemoveRange(0, len);
            foreach (var item in part)
            {
                Flights.Add(item);
            }
        }
    }

    
}

