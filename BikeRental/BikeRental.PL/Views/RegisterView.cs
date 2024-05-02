using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeRental.BLL.Services;

namespace BikeRental.PL.Views
{
    public partial class RegisterView : UserControl
    {
        public event EventHandler CancelButtonClicked;
        public event EventHandler RegisterButtonClicked;
        UserService userService = new UserService();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                notificationLabel.Text = "Password missmatch!";
                notificationLabel.Visible = true;
                return;
            }

            if (await userService.CreateUserAsync(usernameTextBox.Text, passwordTextBox.Text) < 0)
            {
                notificationLabel.Text = "Registration failed!";
                notificationLabel.Visible = true;
                return;
            }
            clearView();
            RegisterButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearView();
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void notificationLabel_Click(object sender, EventArgs e)
        {
            notificationLabel.Visible=false;
        }

        private void clearView()
        {
            notificationLabel.Visible = false;
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }
    }
}
