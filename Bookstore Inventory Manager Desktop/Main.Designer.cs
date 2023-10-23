namespace Bookstore_Inventory_Manager_Desktop
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(484, 177);
            button1.Name = "button1";
            button1.Size = new Size(350, 164);
            button1.TabIndex = 0;
            button1.Text = "Inventory Manager";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(484, 395);
            button2.Name = "button2";
            button2.Size = new Size(350, 164);
            button2.TabIndex = 1;
            button2.Text = "Accounting Manager";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(1152, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 50);
            button3.TabIndex = 2;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Main";
            Text = "BookMan by Connect_Slide_121";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}