using AeroturApp.Models.DataModels;
using AeroturApp.Services;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Animations;
using System.Collections.ObjectModel;

namespace AeroturApp.Models.ViewModels;
[QueryProperty(nameof(SearchParams), nameof(SearchParams))]
public partial class SearchResultsViewModel : ObservableObject
{
    [ObservableProperty]
    SearchParams searchParams;

    private SearchReturn results=new();

    private List<Variant> variants=new();

    [ObservableProperty]
    private ObservableCollection<Variant> _flights = [];

    [ObservableProperty]
    private Variant _flight = new();

    private WebAPIClient _client;

    public SearchResultsViewModel(WebAPIClient client)
    {
        _client = client;
        SearchForFlights(SearchParams);
        //AddPartToCollection(8);
    }

    [RelayCommand]
    Task ReturnToPrevious() => Shell.Current.GoToAsync($"///..");

    public async void SearchForFlights(SearchParams pars)
    {
        var res = await _client.SearchForFlights(pars);
        if (res != null)
        {
            results = res;
            if (res.variants == null) return;
            variants = new List<Variant>(res.variants);
        }
    }
    public void AddPartToCollection()
    {
        var length = variants.Count;
        var len = (int)length / 4;
        if (len <= 0) { return; }
        var part = variants[0..^len];
        variants.RemoveRange(0, len);
        Flights.Concat(part.ToObservableCollection());
    }
    public void AddPartToCollection(int leng)
    {
        var length = variants.Count;
        var len = (int)length / leng;
        if (len <= 0) { return; }
        var part = variants[0..^len];
        variants.RemoveRange(0, len);
        Flights.Concat(part.ToObservableCollection());
    }
}

