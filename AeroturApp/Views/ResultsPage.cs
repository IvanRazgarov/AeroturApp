using AeroturApp.Models.ViewModels;
using AeroturApp.Views.Cards;

namespace AeroturApp.Views;

public class ResultsPage : ContentPage
{
	public ResultsPage(SearchResultsViewModel model)
	{
        BindingContext = model;
        var beh = new BackButtonBehavior()
        {
            BindingContext = model,
        };
        beh.SetBinding(BackButtonBehavior.CommandProperty, new Binding(nameof(model.ReturnToPreviousCommand)));
        //	.SetBinding(BackButtonBehavior.CommandProperty, nameof(model.ReturnToPreviousCommand));

        Shell.SetBackButtonBehavior(this, beh);
        ;

#if ANDROID || IOS
        Content = new CollectionViewMobile();
#elif WINDOWS || MACCATALYST
		Content = new CollectionViewPC();
#endif
    }
}