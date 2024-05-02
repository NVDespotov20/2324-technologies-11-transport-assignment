using BikeRental.BLL.Interfaces;
using BikeRental.BLL.Services;
using BikeRental.DAL.Models;
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

namespace BikeRental.PL.Forms
{
    public partial class RentBikeForm : Form
    {
        CountryService countryService = new CountryService();
        CityService cityService = new CityService();
        BikeService bikeService = new BikeService();
        UserService userService = new UserService();
        RentalAgreementService raService = new RentalAgreementService();
        public RentBikeForm()
        {
            InitializeComponent();
            countryBox.Items.Clear();
            LoadCountriesAsync();
            startDatePicker.MinDate = DateTime.Now;
        }

        private async void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadCitiesAsync();
        }

        private async void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadBikesAsync();
        }


        private void bikeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.MinDate = startDatePicker.Value.AddDays(1);
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex("[0-9]+");
            if (bikeBox.SelectedItem == null)
                return;
            int bikeId = Convert.ToInt32(rg.Matches(bikeBox.SelectedItem.ToString())[0].Value);
            RentBikeAsync(bikeId, startDatePicker.Value, endDatePicker.Value);
        }

        private async Task LoadCountriesAsync()
        {
            try
            {
                List<Country> countries = await countryService.GetAllCountriesAsync();

                // Bind the country ComboBox with the list of countries
                countryBox.DisplayMember = "Name";
                countryBox.ValueMember = "Id";
                countryBox.DataSource = countries;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading countries: " + ex.Message);
            }
        }

        private async Task LoadCitiesAsync()
        {
            try
            {
                int selectedCountryId = Convert.ToInt32(countryBox.SelectedValue);

                List<City> cities = await cityService.GetCitiesByCountryIdAsync(selectedCountryId);

                // Use Invoke to update UI on the UI thread
                countryBox.Invoke((Action)(() =>
                {
                    // Bind the city ComboBox with the list of cities
                    cityBox.DisplayMember = "Name";
                    cityBox.ValueMember = "Id";
                    cityBox.DataSource = cities;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cities: " + ex.Message);
            }
        }

        private async Task LoadBikesAsync()
        {
            try
            {
                int selectedCityId = Convert.ToInt32(cityBox.SelectedValue);

                List<Bike> bikes = await bikeService.GetBikesByCityIdExceptOwnedAsync(selectedCityId);

                // Use Invoke to update UI on the UI thread
                cityBox.Invoke((Action)(() =>
                {
                    // Bind the bikes ComboBox with the list of bikes
                    bikeBox.DisplayMember = "DisplayInfo";
                    bikeBox.ValueMember = "Id";
                    bikeBox.DataSource = bikes.Select(bike => new
                    {
                        DisplayInfo = $"ID: {bike.Id}, Owner: {userService.GetUsernameById(bike.OwnerId)}",
                        Id = bike.Id
                    }).ToList();
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bikes: " + ex.Message);
            }
        }

        public async Task RentBikeAsync(int bikeId, DateTime startDate, DateTime endDate)
        {
            if (await raService.CreateRentalAgreementAsync(bikeId, UserService.CurrentUser.Id, startDate, endDate) != -1)
            {
                this.Close();
                return;
            }
            rentBikeLabel.Text = "Error!";
        }
    }
}
