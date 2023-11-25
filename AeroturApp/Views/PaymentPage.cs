using System.Diagnostics;

namespace AeroturApp.Views;
public class PaymentPage : ContentPage, IQueryAttributable
{
	private string link = "";

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        link = query["link"] as string;
        Debug.WriteLine(link);
    }
    public PaymentPage()
	{
		Content = new WebView();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		(Content as WebView).Source = link;
    }
}