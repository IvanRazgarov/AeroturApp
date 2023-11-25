using AeroturApp.Models.ViewModels;

namespace AeroturApp.Views;
public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }

    private void toDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        (sender as DatePicker).TextColor = Colors.Black;
    }
}
