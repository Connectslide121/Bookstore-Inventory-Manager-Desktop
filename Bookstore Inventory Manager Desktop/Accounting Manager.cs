using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Inventory_Manager_Desktop
{
    public partial class Accounting_Manager : Form
    {
        public Accounting_Manager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Point currentFormLocation = Location;
            main.StartPosition = FormStartPosition.Manual;
            main.Location = currentFormLocation;
            main.Show();
            Close();
        }
    }
}
