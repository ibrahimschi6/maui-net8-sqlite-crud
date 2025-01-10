namespace MyMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell(); // Sample DB read
		//RTLSamplePage = new AppShell(); //Sample RTL Page
	}
}
