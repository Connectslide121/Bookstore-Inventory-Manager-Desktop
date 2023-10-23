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
    public partial class Display_Inventory : Form
    {
        public Display_Inventory()
        {
            InitializeComponent();

            dataGridView1.DataSource = Main.inventory;

            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn stringArrayColumn = new DataGridViewTextBoxColumn();
            stringArrayColumn.HeaderText = "Authors";
            stringArrayColumn.DataPropertyName = "Authors";
            dataGridView1.Columns.Add(stringArrayColumn);

            dataGridView1.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 9 && e.RowIndex >= 0)
                {
                    var cellValue = e.Value as string[];
                    if (cellValue != null)
                    {
                        e.Value = string.Join(", ", cellValue);
                    }
                }
            };

            dataGridView1.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn stringArrayColumn2 = new DataGridViewTextBoxColumn();
            stringArrayColumn2.HeaderText = "Categories";
            stringArrayColumn2.DataPropertyName = "Categories";
            dataGridView1.Columns.Add(stringArrayColumn2);

            dataGridView1.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 10 && e.RowIndex >= 0)
                {
                    var cellValue = e.Value as string[];
                    if (cellValue != null)
                    {
                        e.Value = string.Join(", ", cellValue);
                    }
                }
            };
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
