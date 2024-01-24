using AeroturApp.Models.DataModels;
using AeroturApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AeroturApp.Models.ViewModels;
public partial class SearchResultsViewModel : ObservableObject, IQueryAttributable
{
    private Dictionary<string, GenericCompany> airlines;
    private Dictionary<string, GenericAirport> airports;
    private Dictionary<string, GenericAircraft> aircraft;
    private SearchParams searchParams;
    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        searchParams = query[nameof(SearchParams)] as SearchParams;
        await GetSearchForFlights(searchParams);
    }

    private List<Segment> variants = new();

    [ObservableProperty]
    public string debugInfo = "No debug info";

    [ObservableProperty]
    private bool isBusy = true;

    [ObservableProperty]
    private ObservableCollection<Segment> _flights;

    [ObservableProperty]
    private Variant _flight = new();

    private WebAPIService _client;

    public SearchResultsViewModel(WebAPIService client)
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

    [RelayCommand]
    Task RetrySearch() => GetSearchForFlights(searchParams);

    [RelayCommand]
    Task NavigateToSelected(string link)
        => Shell.Current.GoToAsync($"PaymentPage", new Dictionary<string, object>()
        {
            ["link"]=link
        }); 

    public async Task GetSearchForFlights(SearchParams pars)
    {
        IsBusy = true;
        try
        {
            var res = await _client.SearchForFlights(pars);
            if (res == null || !res.is_valid)
            {
                IsBusy = false;
                Debug.WriteLine(res == null ? "no result" : res.error_msg);
                return;
            }
            //Debug.WriteLine(res.request_id);
            //var airlines = res.airlines;
            //var airports = res.airports;
            //var aircraft = res.aircraft;

            //Flights = new ObservableCollection<Segment>(res.segments);

            Flights = new ObservableCollection<Segment>(res.segments.OrderBy(x => int.Parse(x.parent_data.Split(',')[3])));

            /*variants = new List<Variant>(res.variants);

            foreach(var v in variants)
            {
                foreach(var l in v.legs)
                {
                    foreach(var s in l.segments)
                    {
                        //s.aircraft_type = aircraft[s.aircraft_type].name;
                        //s.marketing_company = airlines[s.marketing_company].name;
                        //s.operating_company = airlines[s.operating_company].name;
                        if (airlines.Keys.Contains(s.validating_airline))
                        {
                            var va = s.validating_airline;
                            s.validating_airline = airlines[va].name;
                            s.operating_company_logo = airlines[va].logo_url;
                        }
                    }
                }
            }

            Flights = new ObservableCollection<Variant>(variants.OrderBy((x)=>x?.price ?? int.MaxValue));*/
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.StackTrace);
            Debug.WriteLine(ex.Message);
            return;
        }
        finally { IsBusy = false; }
    }

}

