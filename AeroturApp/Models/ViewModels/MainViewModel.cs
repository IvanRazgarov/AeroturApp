using AeroturApp.Models.DataModels;
using AeroturApp.Services;
using AeroturApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AeroturApp.Models.ViewModels;
public partial class MainViewModel : ObservableObject
{
    private IataCodesService codeService;
    private Dictionary<string, string> translatePricingName = new()
    {
        { "Эконом", "Economy" },
        { "Бизнес", "Business" },
        { "Первый", "First"}
    };
    private SearchParams searchParams { get; set; }

    [ObservableProperty]
    List<string> pricingTypes = ["Эконом", "Бизнес", "Первый"];
    [ObservableProperty]
    string pricingType = "Эконом";

    [ObservableProperty]
    bool isLoaded = false;

    [ObservableProperty]
    ObservableCollection<IATA_Citi> suggestionsFrom = new();
    [ObservableProperty]
    IATA_Citi suggestionFrom = new();

    [ObservableProperty]
    ObservableCollection<IATA_Citi> suggestionsTo = new();
    [ObservableProperty]
    IATA_Citi suggestionTo = new();

    [ObservableProperty]
    int adults = 1;
    [ObservableProperty]
    int children = 0;
    [ObservableProperty]
    int infants = 0;
    [ObservableProperty]
    int infants_seat = 0;

    partial void OnAdultsChanged(int value)
    {
        Total_people = value + children + infants + infants_seat;
    }
    partial void OnChildrenChanged(int value)
    {
        Total_people = adults + value + infants + infants_seat;
    }
    partial void OnInfantsChanged(int value)
    {
        Total_people = adults + children + value + infants_seat;
    }
    partial void OnInfants_seatChanged(int value)
    {
        Total_people = adults + children + infants + value;
    }

    [ObservableProperty]
    int total_people=1;

    [ObservableProperty]
    string from_iata = "Москва";
    [ObservableProperty]
    string to_iata = "Ташкент";
    [ObservableProperty]
    DateTime dep = DateTime.Now;
    //[ObservableProperty]
    DateTime? arr = null;
    public DateTime? Arr
    {
        get
        {
            if(arr == null || arr <= DateTime.Now) return null;
            else return arr;
        }
        set => SetProperty(ref arr, value);
    }

    [ObservableProperty]
    string date1 = DateTime.Now.ToString("dd'.'MM'.'yyyy");
    [ObservableProperty]
    string date2 = DateTime.Now.ToString("dd'.'MM'.'yyyy");

    public MainViewModel(IataCodesService serve)
    {
        codeService = serve;
        //codeService = iataCodesService;
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
            date1 = DateTime.Now.ToString("yyyy'-'MM'-'dd"),
            date2 = null,
            asGrouped = 0
        };*/
    }

    [RelayCommand]
    Task Navigate()
        => Shell.Current.GoToAsync($"{nameof(ResultsPage)}", new Dictionary<string, object>()
    {
            {"SearchParams", new SearchParams()
                {
                    locale = "RU",
                    instance = "aerotur.aero.dev",
                    adults = Adults,
                    children = Children,
                    infants = Infants,
                    infants_seat = Infants_seat,
                    flight_class = translatePricingName[PricingType??"Эконом"],
                    from = codeService.Cities.Find(x => 
                    {
                        if (x.name!=null)
                        {return x.name.ToUpper().Contains(From_iata.ToUpper()); }
                        else{return false; }
                    }).code,
                    fromType = "city",
                    to = codeService.Cities.Find(x =>
                    {
                        if (x.name!=null)
                        {return x.name.ToUpper().Contains(To_iata.ToUpper()); }
                        else{return false; } 
                    }).code,
                    toType = "city",
                    date1 = Dep.ToString("yyyy'-'MM'-'dd"),//DateTime.Now.AddDays(1).ToString("yyyy'-'MM'-'dd"),
                    date2 = Arr?.ToString("yyyy'-'MM'-'dd") ?? null,
                    asGrouped = 0
                }
            }
    });

}