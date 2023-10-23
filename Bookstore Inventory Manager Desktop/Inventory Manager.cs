using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Inventory_Manager_Desktop
{
    public partial class Inventory_Manager : Form
    {
        public Inventory_Manager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Point currentFormLocation = Location;
            Size currentFormSize = Size;
            main.StartPosition = FormStartPosition.Manual;
            main.Location = currentFormLocation;
            main.Size = currentFormSize;
            main.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display_Inventory display_Inventory = new Display_Inventory();
            Point currentFormLocation = Location;
            Size currentFormSize = Size;
            display_Inventory.StartPosition = FormStartPosition.Manual;
            display_Inventory.Location = currentFormLocation;
            display_Inventory.Size = currentFormSize;
            display_Inventory.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_books search_Books = new Search_books();
            Point currentFormLocation = Location;
            Size currentFormSize = Size;
            search_Books.StartPosition = FormStartPosition.Manual;
            search_Books.Location = currentFormLocation;
            search_Books.Size = currentFormSize;
            search_Books.Show();
            Close();
        }
    }
}
