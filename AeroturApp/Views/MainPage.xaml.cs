
using AeroturApp.Models.DataModels;
using AeroturApp.Models.ViewModels;

namespace AeroturApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel model)
        {
            InitializeComponent();
            this.BindingContext = model;
        }
        /*async void OnButtonClicked(object sender, EventArgs args)
        {
            var searchParams = new SearchParams()
            {
                locale = "RU",
                instance = "aerotur.aero.dev",
                adults = ((int)adults.Value),
                children = ((int)children.Value),
                infants = ((int)infants.Value),
                infants_seat = ((int)infants_seat.Value),
                flight_class = pricingNameTranslation[((string)flight_class.SelectedItem)],
                from = "LED",
                fromType = "city",
                to = "OSS",
                toType = "city",
                date1 = $"{fromDatePicker.Date.Year}-{fromDatePicker.Date.Month}-{fromDatePicker.Date.Day}",
                date2 = null,
                asGrouped = 0
            };
            await Shell.Current.GoToAsync($"///{nameof(SearchResultPage)}", new Dictionary<string, object>()
            {
                ["SearchParams"] = searchParams
            }) ;*/
        
    }

}
