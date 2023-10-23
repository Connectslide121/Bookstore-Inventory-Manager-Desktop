namespace Bookstore_Inventory_Manager_Desktop
{
    partial class Search_books
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
            button3 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1152, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 5;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(397, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(536, 33);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(953, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(360, 20);
            label1.TabIndex = 8;
            label1.Text = "Enter Title, ISBN, Author, Category or Description:";
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
            dataGridView1.TabIndex = 9;
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
            // Search_books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Name = "Search_books";
            Text = "Search_books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
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
    }
}