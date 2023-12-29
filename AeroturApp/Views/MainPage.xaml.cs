using AeroturApp.Models.DataModels;
using AeroturApp.Models.ViewModels;
using AeroturApp.Views.Cards;
using CommunityToolkit.Mvvm.Messaging;
using Mopups.Services;

namespace AeroturApp.Views;
public partial class MainPage : ContentPage
{
    private bool isLoaded = false;
    public MainPage(MainViewModel model)
    {
        InitializeComponent();
        BindingContext = model;
        WeakReferenceMessenger.Default.Register<LoadingConfirmationMessage>(this, (r, m) => OnMessageRecieved(m.Value));
    }

    private void toDatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        (sender as DatePicker).TextColor = Colors.Black;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if(!isLoaded){MopupService.Instance.PushAsync(new LoadingPopup());}
    }
    private void OnMessageRecieved(bool conf)
    {
        if (conf) { MopupService.Instance.PopAllAsync(); }
        else
        {
            MopupService.Instance.PopAllAsync();
            MopupService.Instance.PushAsync(new ErrorPopup());
        }
        isLoaded = true;
    }
}
