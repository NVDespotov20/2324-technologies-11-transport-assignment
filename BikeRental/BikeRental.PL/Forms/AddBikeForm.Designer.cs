namespace BikeRental.PL.Forms
{
    partial class AddBikeForm
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
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addBikeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryBox
            // 
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(193, 85);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(130, 28);
            this.countryBox.TabIndex = 0;
            this.countryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(193, 128);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(130, 28);
            this.cityBox.TabIndex = 1;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(63, 85);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(120, 28);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Chose a country";
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(63, 128);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(120, 28);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "Chose a city";
            // 
            // addBikeLabel
            // 
            this.addBikeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBikeLabel.Location = new System.Drawing.Point(63, 21);
            this.addBikeLabel.Name = "addBikeLabel";
            this.addBikeLabel.Size = new System.Drawing.Size(120, 37);
            this.addBikeLabel.TabIndex = 4;
            this.addBikeLabel.Text = "Add bike";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(248, 181);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addBikeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Name = "AddBikeForm";
            this.Text = "Add a bike";
            this.Load += new System.EventHandler(this.AddBikeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox countryBox;
        private ComboBox cityBox;
        private Label countryLabel;
        private Label cityLabel;
        private Label addBikeLabel;
        private Button addButton;
    }
}