namespace BikeRental.PL.Forms
{
    partial class RentBikeForm
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
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.choseABikeLabel = new System.Windows.Forms.Label();
            this.bikeBox = new System.Windows.Forms.ComboBox();
            this.rentButton = new System.Windows.Forms.Button();
            this.rentBikeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // endDateLabel
            // 
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDateLabel.Location = new System.Drawing.Point(63, 277);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(120, 28);
            this.endDateLabel.TabIndex = 29;
            this.endDateLabel.Text = "Rent until:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateLabel.Location = new System.Drawing.Point(63, 228);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(120, 28);
            this.startDateLabel.TabIndex = 28;
            this.startDateLabel.Text = "Rent from:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "dd/mm/yyyy";
            this.endDatePicker.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(192, 279);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 27);
            this.endDatePicker.TabIndex = 22;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "dd/mm/yyyy";
            this.startDatePicker.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(192, 229);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 27);
            this.startDatePicker.TabIndex = 21;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // choseABikeLabel
            // 
            this.choseABikeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choseABikeLabel.Location = new System.Drawing.Point(63, 171);
            this.choseABikeLabel.Name = "choseABikeLabel";
            this.choseABikeLabel.Size = new System.Drawing.Size(120, 28);
            this.choseABikeLabel.TabIndex = 27;
            this.choseABikeLabel.Text = "Chose a bike";
            // 
            // bikeBox
            // 
            this.bikeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bikeBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bikeBox.FormattingEnabled = true;
            this.bikeBox.Location = new System.Drawing.Point(193, 171);
            this.bikeBox.Name = "bikeBox";
            this.bikeBox.Size = new System.Drawing.Size(200, 28);
            this.bikeBox.TabIndex = 20;
            this.bikeBox.SelectedIndexChanged += new System.EventHandler(this.bikeBox_SelectedIndexChanged);
            // 
            // rentButton
            // 
            this.rentButton.Location = new System.Drawing.Point(318, 380);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(75, 23);
            this.rentButton.TabIndex = 23;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // rentBikeLabel
            // 
            this.rentBikeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentBikeLabel.Location = new System.Drawing.Point(63, 21);
            this.rentBikeLabel.Name = "rentBikeLabel";
            this.rentBikeLabel.Size = new System.Drawing.Size(120, 37);
            this.rentBikeLabel.TabIndex = 26;
            this.rentBikeLabel.Text = "Rent bike";
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(63, 128);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(120, 28);
            this.cityLabel.TabIndex = 25;
            this.cityLabel.Text = "Chose a city";
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(63, 85);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(120, 28);
            this.countryLabel.TabIndex = 24;
            this.countryLabel.Text = "Chose a country";
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(192, 128);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(200, 28);
            this.cityBox.TabIndex = 19;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // countryBox
            // 
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(193, 85);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(200, 28);
            this.countryBox.TabIndex = 18;
            this.countryBox.SelectedIndexChanged += new System.EventHandler(this.countryBox_SelectedIndexChanged);
            // 
            // RentBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(454, 444);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.choseABikeLabel);
            this.Controls.Add(this.bikeBox);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.rentBikeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryBox);
            this.Name = "RentBikeForm";
            this.Text = "RentBikeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Label endDateLabel;
        private Label startDateLabel;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Label choseABikeLabel;
        private ComboBox bikeBox;
        private Button rentButton;
        private Label rentBikeLabel;
        private Label cityLabel;
        private Label countryLabel;
        private ComboBox cityBox;
        private ComboBox countryBox;
    }
}