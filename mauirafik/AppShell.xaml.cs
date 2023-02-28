namespace mauirafik;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("vvv", typeof(NewPage1));
	}
}

