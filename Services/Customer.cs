using SQLite;

namespace MyMauiApp
{

    [Table("customer")]
    public class Customer
    {
        private string mobile;

        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
        [Column("customer_name")]

        public  string? CustomerName { get; set; }
        [Column("mobile")]
        public string Mobile { get => mobile; set => mobile = value; }

        [Column("email")]
        public  string? Email { get; set; }

    }
}
