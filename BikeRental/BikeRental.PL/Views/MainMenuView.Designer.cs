namespace BikeRental.PL.Views
{
    partial class MainMenuView
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
            this.AppName = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppName.Location = new System.Drawing.Point(200, 100);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(300, 100);
            this.AppName.TabIndex = 15;
            this.AppName.Text = "Bike Rental";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(215, 260);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(270, 50);
            this.signInButton.TabIndex = 16;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click_1);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(215, 320);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(270, 50);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.AppName);
            this.Name = "MainMenuView";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private Label AppName;
        private Button signInButton;
        private Button registerButton;
    }
}
