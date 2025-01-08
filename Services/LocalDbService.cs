

using SQLite;

namespace MyMauiApp
{

    public class LocalDbService
    {
        private const string DB_NAME = "demno_locall_DB.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Customer>();

            LoadTestData();
        }

        private void LoadTestData()
        {
            int length = 10;
            Customer customer;

            for (int i = 0; i < length; i++)
            {


                customer = new Customer();
                customer.Id = i;
                customer.CustomerName = "Customer " + i;
                customer.Email = $"customer{i}@test.com";
                customer.Mobile = $"+1 123 456 78 {i}";

                Insert(customer);
            }
        }

        public async Task Insert(Customer customer)
        {
            await _connection.InsertAsync(customer);
        }

        public async Task<List<Customer>> GetCustomers() => await _connection.Table<Customer>().ToListAsync();

    }

}