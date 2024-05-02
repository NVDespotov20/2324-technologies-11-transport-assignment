using BikeRental.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BikeRental.PL.Views.RegisterView;

namespace BikeRental.PL.Views
{
    public partial class SignInView : UserControl
    {
        public event EventHandler CancelButtonClicked;
        public event EventHandler SignInButtonClicked;
        public SignInView()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearView();
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private async void signInButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (!await userService.ValidateUserCredentialsAsync(usernameTextBox.Text, passwordTextBox.Text))
            {
                notificationLabel.Text = "Authentication failed!";
                notificationLabel.Visible = true;
                return;
            }
            clearView();
            SignInButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void notificationLabel_Click(object sender, EventArgs e)
        {
            notificationLabel.Visible = false;
        }
        private void clearView()
        {
            notificationLabel.Visible = false;
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
