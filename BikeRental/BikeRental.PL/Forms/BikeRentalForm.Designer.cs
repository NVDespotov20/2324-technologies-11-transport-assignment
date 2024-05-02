namespace BikeRental.PL.Views
{
    partial class BikeRentalForm
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
            this.signInView = new BikeRental.PL.Views.SignInView();
            this.mainMenuView = new BikeRental.PL.Views.MainMenuView();
            this.registerView = new BikeRental.PL.Views.RegisterView();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.dashboardView = new BikeRental.PL.Views.DashboardView();
            this.SuspendLayout();
            // 
            // signInView
            // 
            this.signInView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signInView.Location = new System.Drawing.Point(43, 32);
            this.signInView.Name = "signInView";
            this.signInView.Size = new System.Drawing.Size(700, 500);
            this.signInView.TabIndex = 0;
            this.signInView.Visible = false;
            this.signInView.Load += new System.EventHandler(this.signInView_Load);
            // 
            // mainMenuView
            // 
            this.mainMenuView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mainMenuView.Location = new System.Drawing.Point(43, 32);
            this.mainMenuView.Name = "mainMenuView";
            this.mainMenuView.Size = new System.Drawing.Size(700, 500);
            this.mainMenuView.TabIndex = 1;
            this.mainMenuView.Load += new System.EventHandler(this.mainMenuView_Load);
            // 
            // registerView
            // 
            this.registerView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registerView.Location = new System.Drawing.Point(43, 32);
            this.registerView.Name = "registerView";
            this.registerView.Size = new System.Drawing.Size(700, 500);
            this.registerView.TabIndex = 2;
            this.registerView.Visible = false;
            // 
            // notificationLabel
            // 
            this.notificationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.notificationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notificationLabel.Location = new System.Drawing.Point(12, 9);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(760, 30);
            this.notificationLabel.TabIndex = 3;
            this.notificationLabel.Text = "label1";
            this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notificationLabel.Visible = false;
            this.notificationLabel.Click += new System.EventHandler(this.notificationLabel_Click);
            // 
            // dashboardView
            // 
            this.dashboardView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dashboardView.Location = new System.Drawing.Point(43, 32);
            this.dashboardView.Name = "dashboardView";
            this.dashboardView.Size = new System.Drawing.Size(700, 500);
            this.dashboardView.TabIndex = 4;
            this.dashboardView.Visible = false;
            // 
            // BikeRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dashboardView);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.mainMenuView);
            this.Controls.Add(this.signInView);
            this.Controls.Add(this.registerView);
            this.Name = "BikeRentalForm";
            this.Text = "BikeRental";
            this.Load += new System.EventHandler(this.BikeRental_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SignInView signInView;
        private MainMenuView mainMenuView;
        private RegisterView registerView;
        private Label notificationLabel;
        private DashboardView dashboardView;
    }
}