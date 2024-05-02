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
    public partial class MyBikesView : UserControl
    {
        private readonly BikeService bikeService = new BikeService();
        private readonly CityService cityService = new CityService();
        private readonly CountryService countryService = new CountryService();
        public MyBikesView()
        {
            InitializeComponent();
        }

        private void addBikeButton_Click(object sender, EventArgs e)
        {
            AddBikeForm addBikeForm = new AddBikeForm();
            addBikeForm.FormClosed += AddBikeForm_FormClosed;
            addBikeForm.Show();
        }
        private async void AddBikeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await LoadBikesAsync();
        }
        private void bikesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public async Task LoadBikesAsync()
        {
            try
            {
                // Get bikes owned by the current user
                List<Bike> userBikes = await bikeService.GetBikesByOwnerIdAsync(UserService.CurrentUser.Id);

                // Update the ListBox with bike information
                await UpdateListBox(userBikes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bikes: " + ex.Message);
            }
        }
        private async Task UpdateListBox(List<Bike> userBikes)
        {
            bikesListBox.Items.Clear();

            foreach (var bike in userBikes)
            {
                string cityName = await cityService.GetCityNameByIdAsync(bike.CityId);
                string countryName = countryService.GetCountryNameByCityId(bike.CityId);
                // Display bike information in the ListBox
                bikesListBox.Items.Add(
                    $"BikeId: {bike.Id}, City: {cityName}, Country: {countryName}");
            }
        }

        private void removeBikeButton_Click(object sender, EventArgs e)
        {
            RemoveBikeAsync();
        }
        private async Task RemoveBikeAsync()
        {
            Regex rg = new Regex("[0-9]+");
            if (bikesListBox.SelectedItem == null)
                return;
            await bikeService.DeleteBikeAsync(Convert.ToInt32(rg.Matches(bikesListBox.SelectedItem.ToString())[0].Value));
            await LoadBikesAsync();
        }
    }
}