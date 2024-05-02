namespace BikeRental.PL.Views.Dashboard_Views
{
    partial class MyRentalsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rentButton = new Button();
            tabLable = new Label();
            rentalsListBox = new ListBox();
            SuspendLayout();
            // 
            // rentButton
            // 
            rentButton.Location = new Point(35, 160);
            rentButton.Margin = new Padding(3, 4, 3, 4);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(137, 53);
            rentButton.TabIndex = 3;
            rentButton.Text = "Rent bike";
            rentButton.UseVisualStyleBackColor = true;
            rentButton.Click += rentButton_Click;
            // 
            // tabLable
            // 
            tabLable.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tabLable.Location = new Point(35, 68);
            tabLable.Name = "tabLable";
            tabLable.Size = new Size(477, 67);
            tabLable.TabIndex = 2;
            tabLable.Text = "Active Rentals";
            tabLable.TextAlign = ContentAlignment.MiddleLeft;
            tabLable.Click += tabLable_Click;
            // 
            // rentalsListBox
            // 
            rentalsListBox.BackColor = SystemColors.Window;
            rentalsListBox.ColumnWidth = 50;
            rentalsListBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            rentalsListBox.FormattingEnabled = true;
            rentalsListBox.HorizontalScrollbar = true;
            rentalsListBox.ItemHeight = 31;
            rentalsListBox.Location = new Point(35, 255);
            rentalsListBox.Margin = new Padding(3, 4, 3, 4);
            rentalsListBox.Name = "rentalsListBox";
            rentalsListBox.Size = new Size(477, 314);
            rentalsListBox.TabIndex = 5;
            rentalsListBox.SelectedIndexChanged += rentalsListBox_SelectedIndexChanged;
            // 
            // MyRentalsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            Controls.Add(rentalsListBox);
            Controls.Add(rentButton);
            Controls.Add(tabLable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyRentalsView";
            Size = new Size(560, 653);
            ResumeLayout(false);
        }

        #endregion

        private Button rentButton;
        private Label tabLable;
        private ListBox rentalsListBox;
    }
}
