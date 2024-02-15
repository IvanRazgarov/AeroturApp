#if ANDROID || IOS
using DevExpress.Maui.CollectionView;
#endif
namespace AeroturApp.Views.Cards;

public class CollectionViewCommon:ContentView
{
    public CollectionViewCommon()
    {
#if ANDROID || IOS
        var collection = new DXCollectionView()
        {
            ItemSize = 290f,
            IsPullToRefreshEnabled = true,
            IndicatorColor = Color.Parse("Orange"),
            AutoExpandAllGroups = false,
            ZIndex = 1,
            GroupDescription = new GroupDescription() 
            {
                FieldName = "parent_data", 
                GroupInterval = DevExpress.Maui.Core.DataGroupInterval.Value 
            },
            //ItemTemplate = Application.Current.Resources["FlightCardSegment"] as DataTemplate,
            ItemTemplate = Get<DataTemplate>("FlightCardSegment"),
            //GroupHeaderTemplate = Application.Current.Resources["FlightCard_small"] as DataTemplate,
            GroupHeaderTemplate = Get<DataTemplate>("FlightCard_small"),
            //Background = Application.Current.Resources["PrimaryGradientBrushV"] as Brush,
            Background = Get<Brush>("PrimaryGradientBrushV")
        };
        
        collection.SetBinding(DXCollectionView.ItemsSourceProperty, "Flights");
        collection.SetBinding(DXCollectionView.IsRefreshingProperty, "IsBusy");
        collection.SetBinding(DXCollectionView.PullToRefreshCommandProperty, "RetrySearchCommand");

        Content = collection;
#else
        var colection = new CollectionView()
        {
            VerticalScrollBarVisibility = ScrollBarVisibility.Always,
            ItemSizingStrategy = ItemSizingStrategy.MeasureFirstItem,
            //ItemTemplate = Application.Current.Resources["FlightCard_big"] as DataTemplate,
            ItemTemplate = Get<DataTemplate>("FlightCard_big")
        };
        colection.SetBinding(CollectionView.ItemsSourceProperty, "Flights");
        var structure = new RefreshView()
        {
            //RefreshColor = Application.Current.Resources["Secondary"] as Color,
            RefreshColor = Get<Color>("Secondary"),
            //Background = Application.Current.Resources["PrimaryGradientBrushV"] as Brush,
            Background = Get<Brush>("PrimaryGradientBrushV"), 
            ZIndex = 1,
            Margin = 0,
            Padding = 0,
            Content = colection
        };
        structure.SetBinding(RefreshView.IsRefreshingProperty, "IsBusy");
        structure.SetBinding(RefreshView.CommandProperty, "RetrySearchCommand");
#endif
    }
    public static T Get<T>(string resourceName)
    {
        try
        {
            var success = Application.Current.Resources.TryGetValue(resourceName, out var outValue);

            if (success && outValue is T)
            {
                return (T)outValue;
            }
            else
            {
                return default(T);
            }
        }
        catch
        {
            return default(T);
        }
    }
}
