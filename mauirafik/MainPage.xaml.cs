  namespace mauirafik;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count= 11;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    void intenet_check_Clicked(System.Object sender, System.EventArgs e)
    {
var hasInternet	= Connectivity.Current.NetworkAccess == NetworkAccess.Internet;
		DisplayAlert("internet ", $"{hasInternet}", "ok");
	}
}


