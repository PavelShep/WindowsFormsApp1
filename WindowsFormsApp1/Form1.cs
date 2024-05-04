using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string ApiBaseUrl = "https://restcountries.com/v3.1/all";
        private List<Country> allCountries;

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            await LoadCountriesAsync();
        }

        private async Task LoadCountriesAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(ApiBaseUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        // save local json
                        var path = "../../all_countries.json";
                        File.WriteAllText(path, json);

                        allCountries = JsonConvert.DeserializeObject<List<Country>>(json);
                        PopulateRegions(allCountries);
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve country data: " + response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error with connection to " + ApiBaseUrl + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult result = MessageBox.Show("Would you like to use local all_countries.json?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var path = "../../all_countries.json";
                    var json = File.ReadAllText(path);
                    allCountries = JsonConvert.DeserializeObject<List<Country>>(json);
                    PopulateRegions(allCountries);
                }
                else
                {
                    MessageBox.Show("Try to restart app", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                buttonStart.Enabled = true;
            }
        }

        private void PopulateRegions(List<Country> countries)
        {
            foreach (var country in countries)
            {
                if (!listBoxRegion.Items.Contains(country.Region))
                    listBoxRegion.Items.Add(country.Region);
            }
        }

        private void PopulateSubregions(List<Country> countries, string region)
        {
            listBoxSubregion.Items.Clear();

            foreach (var country in countries)
            {
                if (country.Region == region && country.Subregion != null && !listBoxSubregion.Items.Contains(country.Subregion))
                    listBoxSubregion.Items.Add(country.Subregion);
            }
        }

        private void listBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegion = listBoxRegion.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedRegion))
            {
                PopulateSubregions(allCountries, selectedRegion);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            var filteredCountries = FilterCountries(listBoxRegion.SelectedItem?.ToString(), listBoxSubregion.SelectedItem?.ToString());
            listBoxCountries.Items.Clear();

            foreach (var country in filteredCountries)
            {
                listBoxCountries.Items.Add(country.Name.Common);
            }
        }

        private List<Country> FilterCountries(string region, string subregion)
        {
            if (allCountries == null)
                return new List<Country>();

            var filteredCountries = allCountries;

            if (!string.IsNullOrEmpty(region))
                filteredCountries = filteredCountries.FindAll(c => c.Region == region);

            if (!string.IsNullOrEmpty(subregion))
                filteredCountries = filteredCountries.FindAll(c => c.Subregion == subregion);

            return filteredCountries;
        }
    }

    public class Country
    {
        [JsonProperty("name")]
        public CountryName Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }
    }

    public class CountryName
    {
        [JsonProperty("common")]
        public string Common { get; set; }
    }
}
