using AeroturApp.Models.DataModels;
using AeroturApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AeroturApp.Models.ViewModels;

//[QueryProperty(nameof(DebugInfo), nameof(DebugInfo))]
public partial class SearchResultsViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private SearchParams searchParams;
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        SearchParams = query[nameof(SearchParams)] as SearchParams;
        Task.Run(() => GetSearchForFlights(SearchParams));
    }

    //private SearchReturn results;

    //public void ApplyQueryAttributes(IDictionary<string, object> query)
    //{
    //    DebugInfo = query[nameof(DebugInfo)].ToString();
    //    OnPropertyChanged(nameof(DebugInfo));
    //}

    private List<Variant> variants = new();

    [ObservableProperty]
    public string debugInfo = "No debug info";

    [ObservableProperty]
    private bool isBusy = false;

    [ObservableProperty]
    private ObservableCollection<Variant> _flights;

    [ObservableProperty]
    private Variant _flight = new();

    private WebAPIClient _client;

    public SearchResultsViewModel(WebAPIClient client)
    {
        _client = client;
        /*searchParams = new SearchParams()
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
        AddPartToCollection(8);*/
    }

    [RelayCommand]
    Task ReturnToPrevious() => Shell.Current.GoToAsync($"..");

    //[RelayCommand]
    //void LoadMoreItems() => AddPartToCollection();

    [RelayCommand]
    Task RetrySearch() => GetSearchForFlights(SearchParams);

    [RelayCommand]
    Task NavigateToSelected(string link)
        => Shell.Current.GoToAsync($"PaymentPage", new Dictionary<string, object>()
        {
            ["link"]=link
        }); 

    public async Task GetSearchForFlights(SearchParams pars)
    {
        IsBusy = true;
        var res = await _client.SearchForFlights(pars);

        if (!res.is_valid || res.variants == null) 
        {
            DebugInfo=res.error_msg;
            IsBusy = false;
            return;
        }
        variants = new List<Variant>(res.variants);
        Flights = new ObservableCollection<Variant>(variants);

        IsBusy = false;     
    }
    public async Task GetSearchForFlights()
    {
        IsBusy = true;
        var res = await _client.SearchForFlights(SearchParams);

        if (!res.is_valid || res.variants == null)
        {
            DebugInfo = "";
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

