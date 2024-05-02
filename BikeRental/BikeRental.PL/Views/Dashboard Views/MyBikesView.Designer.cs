namespace BikeRental.PL.Views.Dashboard_Views
{
    partial class MyBikesView
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
            this.tabLable = new System.Windows.Forms.Label();
            this.addBikeButton = new System.Windows.Forms.Button();
            this.bikesListBox = new System.Windows.Forms.ListBox();
            this.removeBikeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabLable
            // 
            this.tabLable.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabLable.Location = new System.Drawing.Point(31, 51);
            this.tabLable.Name = "tabLable";
            this.tabLable.Size = new System.Drawing.Size(180, 50);
            this.tabLable.TabIndex = 0;
            this.tabLable.Text = "My Bikes";
            this.tabLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addBikeButton
            // 
            this.addBikeButton.Location = new System.Drawing.Point(31, 120);
            this.addBikeButton.Name = "addBikeButton";
            this.addBikeButton.Size = new System.Drawing.Size(120, 40);
            this.addBikeButton.TabIndex = 1;
            this.addBikeButton.Text = "Add bike";
            this.addBikeButton.UseVisualStyleBackColor = true;
            this.addBikeButton.Click += new System.EventHandler(this.addBikeButton_Click);
            // 
            // bikesListBox
            // 
            this.bikesListBox.BackColor = System.Drawing.SystemColors.Window;
            this.bikesListBox.ColumnWidth = 50;
            this.bikesListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bikesListBox.FormattingEnabled = true;
            this.bikesListBox.ItemHeight = 25;
            this.bikesListBox.Location = new System.Drawing.Point(31, 191);
            this.bikesListBox.Name = "bikesListBox";
            this.bikesListBox.Size = new System.Drawing.Size(418, 254);
            this.bikesListBox.TabIndex = 2;
            this.bikesListBox.SelectedIndexChanged += new System.EventHandler(this.bikesListBox_SelectedIndexChanged);
            // 
            // removeBikeButton
            // 
            this.removeBikeButton.Location = new System.Drawing.Point(182, 120);
            this.removeBikeButton.Name = "removeBikeButton";
            this.removeBikeButton.Size = new System.Drawing.Size(120, 40);
            this.removeBikeButton.TabIndex = 3;
            this.removeBikeButton.Text = "Remove bike";
            this.removeBikeButton.UseVisualStyleBackColor = true;
            this.removeBikeButton.Click += new System.EventHandler(this.removeBikeButton_Click);
            // 
            // MyBikesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.removeBikeButton);
            this.Controls.Add(this.bikesListBox);
            this.Controls.Add(this.addBikeButton);
            this.Controls.Add(this.tabLable);
            this.Name = "MyBikesView";
            this.Size = new System.Drawing.Size(490, 490);
            this.ResumeLayout(false);

        }

        #endregion

        private Label tabLable;
        private Button addBikeButton;
        private ListBox bikesListBox;
        private Button removeBikeButton;
    }
}
