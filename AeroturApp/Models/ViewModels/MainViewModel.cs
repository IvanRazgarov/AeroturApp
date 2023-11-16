using AeroturApp.Models.DataModels;
using AeroturApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;



namespace AeroturApp.Models.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private Dictionary<string, string> translatePricingName = new()
        {
            { "Эконом", "Economy" },
            { "Бизнес", "Business" },
            { "Первый", "First"}
        };
        private SearchParams searchParams;

        [ObservableProperty]
        List<string> pricingTypes = ["Эконом", "Бизнес", "Первый"];
        [ObservableProperty]
        string pricingType;

        [ObservableProperty]
        int adults;
        [ObservableProperty]
        int children;
        [ObservableProperty]
        int infants;
        [ObservableProperty]
        int infants_seat;

        public MainViewModel()
        {
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
                date1 = DateTime.Now.ToString("yyyy'-'mm'-'dd"),
                date2 = null,
                asGrouped = 0
            };
        }

        [RelayCommand]
        Task Navigate() 
            => Shell.Current.GoToAsync($"{nameof(SearchResultPage)}"/*,new Dictionary<string, object>()
        {
                {"SearchParams", searchParams new SearchParams()
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
                        date1 = "2023-11-10",//DateTime.Now.ToString("yyyy'-'mm'-'dd"),
                        date2 = null,
                        asGrouped = 0
                    }
                }
        }*/);
    }
}