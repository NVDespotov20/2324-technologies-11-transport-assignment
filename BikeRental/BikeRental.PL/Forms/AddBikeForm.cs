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
using BikeRental.DAL.Models;

namespace BikeRental.PL.Forms
{
    public partial class AddBikeForm : Form
    {
        CountryService countryService = new CountryService();
        CityService cityService = new CityService();
        BikeService bikeService = new BikeService();
        public AddBikeForm()
        {
            InitializeComponent();
            countryBox.Items.Clear();
            LoadCountriesAsync();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCitiesAsync();
        }

        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBikeAsync(cityBox.Text);
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
        private async void LoadCitiesAsync()
        {
            try
            {
                int selectedCountryId = Convert.ToInt32(countryBox.SelectedValue);

                List<City> cities = await cityService.GetCitiesByCountryIdAsync(selectedCountryId);

                // Bind the city ComboBox with the list of cities
                cityBox.DisplayMember = "Name";
                cityBox.ValueMember = "Id";
                cityBox.DataSource = cities;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cities: " + ex.Message);
            }
        }

        private void AddBikeForm_Load(object sender, EventArgs e)
        {

        }

        public async Task AddBikeAsync(string cityName)
        {
            int cityId = await cityService.GetCityIdByNameAsync(cityBox.Text);
            if (await bikeService.CreateBikeAsync(cityId, UserService.CurrentUser!.Id) != -1)
            {
                this.Close();
                return;
            }
            addBikeLabel.Text = "Error!";
        }
    }
}
