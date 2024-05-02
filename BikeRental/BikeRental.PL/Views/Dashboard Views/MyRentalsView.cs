using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeRental.BLL.Interfaces;
using BikeRental.BLL.Services;
using BikeRental.DAL.Models;
using BikeRental.PL.Forms;
namespace BikeRental.PL.Views.Dashboard_Views
{
    public partial class MyRentalsView : UserControl
    {
        RentalAgreementService raService = new RentalAgreementService();
        UserService userService = new UserService();
        public MyRentalsView()
        {
            InitializeComponent();
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            RentBikeForm rentBikeForm = new RentBikeForm();
            rentBikeForm.FormClosed += RentBikeForm_FormClosed;
            rentBikeForm.Show();
        }
        private async void RentBikeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await LoadBikesAsync();
        }
        private void rentalsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public async Task LoadBikesAsync()
        {
            try
            {
                // Get agreements for bikes rented by the current user
                List<RentalAgreement> rentals = await raService.GetActiveRentalAgreementsByRenterIdAsync(UserService.CurrentUser.Id);

                // Update the ListBox with bike information
                await UpdateListBox(rentals);
            } catch (Exception ex)
            {
                MessageBox.Show("Error loading bikes: " + ex.Message);
            }
        }
        private async Task UpdateListBox(List<RentalAgreement> rentals)
        {
            rentalsListBox.Items.Clear();

            foreach (var rental in rentals)
            {
                string ownerName = userService.GetUsernameByBikeId(rental.BikeId);
                // Display bike information in the ListBox
                rentalsListBox.Items.Add(
                    $"BikeId: {rental.BikeId}, Owner: {ownerName}, Start date: {rental.StartDate.ToString()}, End date: {rental.EndDate.ToString()}");
            }
        }

        private void tabLable_Click(object sender, EventArgs e)
        {

        }
    }
}
