
namespace AeroturApp.Views
{
    public partial class MainPage : ContentPage
    {
        List<string> VayVariants = new List<string>(["В одну сторону", "Туда и обратно", "Сложный маршрут"]);
        List<string> PricingTypes = new List<string>(["Эконом", "Бизнес", "Первый"]); 
        public MainPage()
        {
            InitializeComponent();
            VayVariantPicker.ItemsSource = VayVariants;
            PricingPicker.ItemsSource = PricingTypes;
        }
    }

}
