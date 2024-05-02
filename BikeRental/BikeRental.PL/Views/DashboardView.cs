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

namespace BikeRental.PL.Views
{

    public partial class DashboardView : UserControl
    {
        public event EventHandler SignOutButtonClicked;
        public DashboardView()
        {
            InitializeComponent();
        }

        private void myBikesButton_Click(object sender, EventArgs e)
        {
            myBikesView.Visible = true;
            myRentalsView.Visible = false;
            myBikesView.BringToFront();
            myBikesView.LoadBikesAsync();
        }

        private void myRentalsButton_Click(object sender, EventArgs e)
        {
            myBikesView.Visible = false;
            myRentalsView.Visible = true;
            myBikesView.BringToFront();
            myRentalsView.LoadBikesAsync();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            UserService.CurrentUser = null;
            SignOutButtonClicked?.Invoke(this, new EventArgs());
        }

        public void UpdateUsernameLabel()
        {
            usernameLabel.Text = UserService.CurrentUser?.Username;
        }
    }
}
