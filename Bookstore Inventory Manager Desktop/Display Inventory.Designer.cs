namespace Bookstore_Inventory_Manager_Desktop
{
    partial class Display_Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shortDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantitySoldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            benefitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            benefitSoldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titleDataGridViewTextBoxColumn, isbnDataGridViewTextBoxColumn, shortDescriptionDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, quantitySoldDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, benefitDataGridViewTextBoxColumn, benefitSoldDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1240, 681);
            dataGridView1.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // shortDescriptionDataGridViewTextBoxColumn
            // 
            shortDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShortDescription";
            shortDescriptionDataGridViewTextBoxColumn.HeaderText = "ShortDescription";
            shortDescriptionDataGridViewTextBoxColumn.Name = "shortDescriptionDataGridViewTextBoxColumn";
            shortDescriptionDataGridViewTextBoxColumn.Width = 520;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantitySoldDataGridViewTextBoxColumn
            // 
            quantitySoldDataGridViewTextBoxColumn.DataPropertyName = "QuantitySold";
            quantitySoldDataGridViewTextBoxColumn.HeaderText = "QuantitySold";
            quantitySoldDataGridViewTextBoxColumn.Name = "quantitySoldDataGridViewTextBoxColumn";
            quantitySoldDataGridViewTextBoxColumn.Width = 80;
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            costDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // benefitDataGridViewTextBoxColumn
            // 
            benefitDataGridViewTextBoxColumn.DataPropertyName = "Benefit";
            benefitDataGridViewTextBoxColumn.HeaderText = "Benefit";
            benefitDataGridViewTextBoxColumn.Name = "benefitDataGridViewTextBoxColumn";
            benefitDataGridViewTextBoxColumn.Width = 80;
            // 
            // benefitSoldDataGridViewTextBoxColumn
            // 
            benefitSoldDataGridViewTextBoxColumn.DataPropertyName = "BenefitSold";
            benefitSoldDataGridViewTextBoxColumn.HeaderText = "BenefitSold";
            benefitSoldDataGridViewTextBoxColumn.Name = "benefitSoldDataGridViewTextBoxColumn";
            benefitSoldDataGridViewTextBoxColumn.Width = 80;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1152, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Display_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 761);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Name = "Display_Inventory";
            Text = "Display Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shortDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantitySoldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn benefitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn benefitSoldDataGridViewTextBoxColumn;
        private Button button3;
    }
}