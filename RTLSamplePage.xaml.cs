namespace MyMauiApp;

public partial class RTLSamplePage : ContentPage
{
	
	public readonly LocalDbService _dbService;
	public List<Customer>? Customers { get; set; }

	public RTLSamplePage(LocalDbService dbService)
	{
		InitializeComponent();
		_dbService = dbService;
		//Task.Run(async ()=> ((ListView)ListViewTest).ItemsSource = await _dbService.GetCustomers());
	}


}

