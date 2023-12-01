using AeroturApp.Models.ViewModels;
#if ANDROID
using DevExpress.Maui.CollectionView;
using Microsoft.Maui.Controls;
#endif
#if IOS
using DevExpress.Maui.CollectionView;
#endif
namespace AeroturApp.Views;

public class ResultsPage: ContentPage
{
	public ResultsPage(SearchResultsViewModel model)
	{
		BindingContext = model;
		Shell.SetBackButtonBehavior(this, new BackButtonBehavior() { Command = model.ReturnToPreviousCommand});
#if ANDROID
		DXCollectionView con = new DXCollectionView
		{
			IsPullToRefreshEnabled = true,
			IndicatorColor=Colors.Orange,
			ItemsSource = model.Flights,
		};
		con.SetBinding(DXCollectionView.ItemsSourceProperty, "Flights");
		con.SetBinding(DXCollectionView.ItemTemplateProperty, new Binding() { Source=Application.Current.Resources["FlightCard_small"] as DataTemplate });
#endif
#if IOS
		Content = new DXCollectionView
		{
			IsPullToRefreshEnabled = true,
			IndicatorColor=Colors.Orange,
			ItemsSource = model.Flights,
		};
#endif
    }
}