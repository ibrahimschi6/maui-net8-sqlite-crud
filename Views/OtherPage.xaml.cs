namespace MyMauiApp.Views;

public partial class OtherPage : ContentPage
{
	public OtherPage()
	{
		InitializeComponent();
	}
	 private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        // Navigate to the second page using its route
        await Shell.Current.GoToAsync("SettingsPage");


		
    }
}