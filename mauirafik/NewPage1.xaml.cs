namespace mauirafik;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    async void to_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync("vvv");
    }

}
 