namespace Bookstore_Inventory_Manager_Desktop
{
    partial class Inventory_Manager
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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1152, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 3;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(443, 136);
            button1.Name = "button1";
            button1.Size = new Size(356, 103);
            button1.TabIndex = 4;
            button1.Text = "Display inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(443, 245);
            button2.Name = "button2";
            button2.Size = new Size(356, 103);
            button2.TabIndex = 5;
            button2.Text = "Search books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(443, 572);
            button4.Name = "button4";
            button4.Size = new Size(356, 103);
            button4.TabIndex = 6;
            button4.Text = "Update quantity by ISBN";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(443, 463);
            button5.Name = "button5";
            button5.Size = new Size(356, 103);
            button5.TabIndex = 7;
            button5.Text = "Add a new book";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(443, 354);
            button6.Name = "button6";
            button6.Size = new Size(356, 103);
            button6.TabIndex = 8;
            button6.Text = "Info of book by ISBN";
            button6.UseVisualStyleBackColor = true;
            // 
            // Inventory_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1264, 761);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Name = "Inventory_Manager";
            Text = "Inventory Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}