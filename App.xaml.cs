namespace MyMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		 // Copy the database file if not already present
        CopyDatabaseFile("PreCreatedDBFile.db");

		MainPage = new AppShell(); // Sample DB read
		//RTLSamplePage = new AppShell(); //Sample RTL Page
	}

	private void CopyDatabaseFile(string fileName)
    {
        // Path to the destination
        string destinationPath = Path.Combine(FileSystem.AppDataDirectory, fileName);

        // Check if the file already exists
        if (!File.Exists(destinationPath))
        {
            // Get the stream for the database file in the Resources/Raw folder
            using var stream = FileSystem.OpenAppPackageFileAsync(fileName).Result;

            // Copy the file to the destination
            using var destinationStream = File.Create(destinationPath);
            stream.CopyTo(destinationStream);
        }else
        {
            File.Delete(destinationPath);
            Console.WriteLine("File already exists");
            // Get the stream for the database file in the Resources/Raw folder
            using var stream = FileSystem.OpenAppPackageFileAsync(fileName).Result;

            // Copy the file to the destination
            using var destinationStream = File.Create(destinationPath);
            stream.CopyTo(destinationStream);
        }
    }
}
