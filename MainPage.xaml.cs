namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	
	public readonly LocalDbService _dbService;
	public List<Customer> Customers { get; set; }

	public MainPage(LocalDbService dbService)
	{
		InitializeComponent();
		_dbService = dbService;
		Task.Run(async ()=> ((ListView)ListViewTest).ItemsSource = await _dbService.GetCustomers());
	}


}

