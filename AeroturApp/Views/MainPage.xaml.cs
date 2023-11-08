
using AeroturApp.Models.DataModels;
using AeroturApp.Models.ViewModels;

namespace AeroturApp.Views
{
    public partial class MainPage : ContentPage
    {
        //string[] VayVariants = ["В одну сторону", "Туда и обратно", "Сложный маршрут"];
        List<string> pricingTypes = new List<string>();
        //Dictionary<string,string> pricingNameTranslation = new Dictionary<string,string>();
        //SearchParams searchParams;
        public MainPage(MainViewModel model)
        {
            InitializeComponent();
            this.BindingContext = model;
            pricingTypes = ["Эконом", "Бизнес", "Первый"];

            //pricingNameTranslation.Add("Эконом", "Economy");
            //pricingNameTranslation.Add("Бизнес", "Business");
            //pricingNameTranslation.Add("Первый", "First");

            //VayVariantPicker.ItemsSource = VayVariants;
            flight_class.ItemsSource = pricingTypes;
            flight_class.SelectedIndex = 0;
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
