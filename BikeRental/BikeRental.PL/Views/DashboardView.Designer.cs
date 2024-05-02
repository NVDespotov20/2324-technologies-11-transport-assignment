namespace BikeRental.PL.Views
{
    partial class DashboardView
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.signOutButton = new System.Windows.Forms.Button();
            this.myRentalsButton = new System.Windows.Forms.Button();
            this.myBikesButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.myBikesView = new BikeRental.PL.Views.Dashboard_Views.MyBikesView();
            this.myRentalsView = new BikeRental.PL.Views.Dashboard_Views.MyRentalsView();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.signOutButton);
            this.navPanel.Controls.Add(this.myRentalsButton);
            this.navPanel.Controls.Add(this.myBikesButton);
            this.navPanel.Controls.Add(this.usernameLabel);
            this.navPanel.Location = new System.Drawing.Point(5, 5);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(190, 490);
            this.navPanel.TabIndex = 0;
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(5, 445);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(180, 40);
            this.signOutButton.TabIndex = 3;
            this.signOutButton.Text = "Sign out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // myRentalsButton
            // 
            this.myRentalsButton.Location = new System.Drawing.Point(5, 135);
            this.myRentalsButton.Name = "myRentalsButton";
            this.myRentalsButton.Size = new System.Drawing.Size(180, 40);
            this.myRentalsButton.TabIndex = 2;
            this.myRentalsButton.Text = "My Rentals";
            this.myRentalsButton.UseVisualStyleBackColor = true;
            this.myRentalsButton.Click += new System.EventHandler(this.myRentalsButton_Click);
            // 
            // myBikesButton
            // 
            this.myBikesButton.Location = new System.Drawing.Point(5, 90);
            this.myBikesButton.Name = "myBikesButton";
            this.myBikesButton.Size = new System.Drawing.Size(180, 40);
            this.myBikesButton.TabIndex = 1;
            this.myBikesButton.Text = "My Bikes";
            this.myBikesButton.UseVisualStyleBackColor = true;
            this.myBikesButton.Click += new System.EventHandler(this.myBikesButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(5, 5);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(180, 50);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "User";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // myBikesView
            // 
            this.myBikesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.myBikesView.Location = new System.Drawing.Point(200, 5);
            this.myBikesView.Name = "myBikesView";
            this.myBikesView.Size = new System.Drawing.Size(490, 490);
            this.myBikesView.TabIndex = 1;
            // 
            // myRentalsView
            // 
            this.myRentalsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.myRentalsView.Location = new System.Drawing.Point(200, 5);
            this.myRentalsView.Name = "myRentalsView";
            this.myRentalsView.Size = new System.Drawing.Size(490, 490);
            this.myRentalsView.TabIndex = 2;
            this.myRentalsView.Visible = false;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.myRentalsView);
            this.Controls.Add(this.myBikesView);
            this.Controls.Add(this.navPanel);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(700, 500);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel navPanel;
        private Button signOutButton;
        private Button myRentalsButton;
        private Button myBikesButton;
        private Label usernameLabel;
        public Dashboard_Views.MyBikesView myBikesView;
        private Dashboard_Views.MyRentalsView myRentalsView;
    }
}
