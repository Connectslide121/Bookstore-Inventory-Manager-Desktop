using System.Text.Json;

namespace Bookstore_Inventory_Manager_Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }


        public static string filePath = "C:\\Users\\Jon\\Desktop\\Lexicon .NET\\Self study\\Bookstore Inventory Manager Desktop\\Bookstore Inventory Manager Desktop\\BookList.json";

        public static List<Book> inventory = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(filePath));


        private void button1_Click(object sender, EventArgs e)
        {
            Inventory_Manager inventory_Manager = new Inventory_Manager();
            Point currentFormLocation = Location;
            Size currentFormSize = Size;
            inventory_Manager.StartPosition = FormStartPosition.Manual;
            inventory_Manager.Location = currentFormLocation;
            inventory_Manager.Size = currentFormSize;
            inventory_Manager.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounting_Manager accounting_Manager = new Accounting_Manager();
            Point currentFormLocation = Location;
            Size currentFormSize = Size;
            accounting_Manager.StartPosition = FormStartPosition.Manual;
            accounting_Manager.Location = currentFormLocation;
            accounting_Manager.Size = currentFormSize;
            accounting_Manager.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}