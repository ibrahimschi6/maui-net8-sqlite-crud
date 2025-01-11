using MyMauiApp.Views;

namespace MyMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		    this.FlyoutBehavior = FlyoutBehavior.Flyout; // Ensures hamburger menu is shown

			Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));


	}
}
