using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BikeRental.PL.Views.MainMenuView;
using static BikeRental.PL.Views.RegisterView;
using BikeRental.BLL.Services;

namespace BikeRental.PL.Views
{
    public partial class BikeRentalForm : Form
    {
        public BikeRentalForm()
        {
            InitializeComponent();
            mainMenuView.MainMenuButtonClicked += MainMenuView_MainMenuButtonClicked;
            signInView.CancelButtonClicked += SignInView_CancelButtonClicked;
            signInView.SignInButtonClicked += SignInView_SignInButtonClicked;
            registerView.CancelButtonClicked += RegisterView_CancelButtonClicked;
            registerView.RegisterButtonClicked += RegisterView_RegisterButtonClicked;
            dashboardView.SignOutButtonClicked += DashboardView_SignOutButtonClicked;
        }

        private void BikeRental_Load(object sender, EventArgs e)
        {

        }

        private void mainMenuView_Load(object sender, EventArgs e)
        {

        }
        private void SignInView_CancelButtonClicked(object sender, EventArgs e)
        {
            mainMenuView.Visible = true;
            signInView.Visible = false;
            mainMenuView.BringToFront();
        }
        private void SignInView_SignInButtonClicked(object sender, EventArgs e)
        {
            mainMenuView.Visible = false;
            signInView.Visible = false;
            dashboardView.Visible = true;
            dashboardView.UpdateUsernameLabel();
            dashboardView.myBikesView.LoadBikesAsync();
            dashboardView.BringToFront();
        }

        public void RegisterView_CancelButtonClicked(object sender, EventArgs e)
        {
            mainMenuView.Visible = true;
            registerView.Visible = false;
            mainMenuView.BringToFront();
        }
        public void RegisterView_RegisterButtonClicked(object sender, EventArgs e)
        {
            mainMenuView.Visible = true;
            registerView.Visible = false;
            mainMenuView.BringToFront();
            
            notificationLabel.Text = "Registration successful!";
            notificationLabel.BackColor = Color.Green;
            notificationLabel.Visible = true;
            notificationLabel.BringToFront();
        }
        public void DashboardView_SignOutButtonClicked(object sender, EventArgs e)
        {
            mainMenuView.Visible = true;
            registerView.Visible = false;
            dashboardView.Visible = false;
            mainMenuView.BringToFront();
        }
        private void MainMenuView_MainMenuButtonClicked(object sender, MainMenuEventArgs e)
        {
            clearView();
            // Handle the button click based on the provided information
            switch (e.ButtonType)
            {
                case MainMenuButtonType.SignIn:
                    // Show the sign-in view and hide the main menu
                    mainMenuView.Visible = false;
                    signInView.Visible = true;
                    signInView.BringToFront();
                    break;

                case MainMenuButtonType.Register:
                    // Show the register view and hide the main menu
                    mainMenuView.Visible = false;
                    registerView.Visible = true;
                    registerView.BringToFront();
                    break;

                default:
                    break;
            }
        }

        private void signInView_Load(object sender, EventArgs e)
        {

        }

        private void notificationLabel_Click(object sender, EventArgs e)
        {
            notificationLabel.Visible = false;
        }

        private void clearView()
        {
            notificationLabel.Visible = false;
        }
    }
}
