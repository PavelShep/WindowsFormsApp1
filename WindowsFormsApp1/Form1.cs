﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
                if (!listBoxRegion.Items.Contains(country.region))
                    listBoxRegion.Items.Add(country.region);
            }
            buttonFind.Enabled=true;
        }

        private void PopulateSubregions(List<Country> countries, string region)
        {
            listBoxSubregion.Items.Clear();

            foreach (var country in countries)
            {
                if (country.region == region && country.subregion != null && !listBoxSubregion.Items.Contains(country.subregion))
                    listBoxSubregion.Items.Add(country.subregion);
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
                listBoxCountries.Items.Add(country.name.official);
            }
            buttonCountry.Enabled=true;
        }

        private async void buttonCountry_Click(object sender, EventArgs e)
        {
            string selectedCountryName = listBoxCountries.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedCountryName))
            {
                var selectedCountry = allCountries.Find(c => c.name.official == selectedCountryName);
                if (selectedCountry != null)
                {
                    ShowCountryInfo(selectedCountry);

                    string capital = selectedCountry.capital[0]; 
                    DateTime? capitalDateTime = await GetCapitalDateTimeAsync(capital);
                    if (capitalDateTime.HasValue)
                    {
                        labelCapitalDateTime.Text = capitalDateTime.Value.ToString();
                        labelCapitalDateTime.Visible = true;
                    }
                    else
                    {
                        labelCapitalDateTime.Text = "Failed to retrieve date and time in the capital.";
                    }

                    string latitude = selectedCountry.capitalInfo.latlng[0].ToString("0.00").Replace(",", ".");
                    string longitude = selectedCountry.capitalInfo.latlng[1].ToString("0.00").Replace(",", ".");

                    double? temperature = await GetCapitalTemperatureAsync(latitude, longitude);
                    if (temperature.HasValue)
                    {
                        labelCapitalTemperature.Text = temperature.Value.ToString("0.0") + "°C";
                        labelCapitalTemperature.Visible = true;
                    }
                    else
                    {
                        labelCapitalTemperature.Text = "Failed to retrieve temperature in the capital.";
                    }

                    var currencyRates = await GetCurrencyRatesAsync("A");
                    var selectedCurrency = currencyRates.FirstOrDefault(rate => rate.Code == selectedCountry.currencies.Keys.FirstOrDefault());

                    if (selectedCurrency == null)
                    {
                        currencyRates = await GetCurrencyRatesAsync("B");
                        selectedCurrency = currencyRates.FirstOrDefault(rate => rate.Code == selectedCountry.currencies.Keys.FirstOrDefault());
                    }

                    if (selectedCurrency != null)
                    {
                        richTextBoxCurrencyInfo.Text =  $"Nazwa waluty: {selectedCountry.currencies[selectedCountry.currencies.Keys.FirstOrDefault()].name}\n" +
                                                        $"Nazwa waluty po polsku: {selectedCurrency.Currency}\n" +
                                                        $"Symbol: {selectedCurrency.Code}\n" +
                                                        $"Kurs wymiany: {selectedCurrency.Mid}\n";
                    }
                    else
                    {
                        richTextBoxCurrencyInfo.Text = "Exchange rate information is not available.";
                    }

                }
                else
                {
                    MessageBox.Show("Country information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<List<CurrencyRate>> GetCurrencyRatesAsync(string tableType)
        {
            List<CurrencyRate> currencyRates = new List<CurrencyRate>();
            string apiUrl = $"https://api.nbp.pl/api/exchangerates/tables/{tableType}?format=json";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var currencyTable = JsonConvert.DeserializeObject<List<CurrencyTable>>(json);
                        if (currencyTable != null && currencyTable.Count > 0)
                        {
                            currencyRates = currencyTable[0].Rates;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving currency rates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return currencyRates;
        }



        private void ShowCountryInfo(Country country)
        {
            labelCountryName.Text = country.name.common;
            labelCountryName.Visible = true;

            string nativeOfficialName = string.Empty;
            if (country.name.nativeName != null)
            {
                foreach (var nativeName in country.name.nativeName)
                {
                    nativeOfficialName = nativeName.Value.official;
                    labelOfficialName.Visible = true;
                    break; 
                }
            }

            labelOfficialName.Text = (string.IsNullOrEmpty(nativeOfficialName) ? country.name.official : nativeOfficialName);
            labelOfficialName.Visible = true;

            labelCapital.Text = string.Join(", ", country.capital);
            labelCapital.Visible = true;

            pictureBoxFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCoatOfArms.SizeMode = PictureBoxSizeMode.Zoom;

            if (!string.IsNullOrEmpty(country.flags?.png))
            {
                pictureBoxFlag.ImageLocation = country.flags.png;
            }
            else
            {
                pictureBoxFlag.Image = null;
            }

            if (!string.IsNullOrEmpty(country.coatOfArms?.png))
            {
                pictureBoxCoatOfArms.ImageLocation = country.coatOfArms.png;
            }
            else
            {
                pictureBoxCoatOfArms.Image = null;
            }
        }

        private List<Country> FilterCountries(string region, string subregion)
        {
            if (allCountries == null)
                return new List<Country>();

            var filteredCountries = allCountries;

            if (!string.IsNullOrEmpty(region))
                filteredCountries = filteredCountries.FindAll(c => c.region == region);

            if (!string.IsNullOrEmpty(subregion))
                filteredCountries = filteredCountries.FindAll(c => c.subregion == subregion);

            return filteredCountries;
        }

        private async Task<DateTime?> GetCapitalDateTimeAsync(string capital)
        {
            string selectedCountryName = listBoxCountries.SelectedItem?.ToString();
            var selectedCountry = allCountries.Find(c => c.name.official == selectedCountryName);

            if (selectedCountry == null || selectedCountry.capitalInfo == null)
            {
                return null;
            }

            string latitude = selectedCountry.capitalInfo.latlng[0].ToString("0.00").Replace(",", ".");
            string longitude = selectedCountry.capitalInfo.latlng[1].ToString("0.00").Replace(",", ".");

            string apiUrl = $"https://timeapi.io/api/Time/current/coordinate?latitude={latitude}&longitude={longitude}";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<TimeResponse>(json);
                    return result.DateTime;
                }
                else
                {
                    return null;
                }
            }
        }

        private async Task<double?> GetCapitalTemperatureAsync(string latitude, string longitude)
        {
            string apiUrl = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current=temperature_2m";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<OpenMeteoResponse>(json);
                    return result?.current?.temperature_2m;
                }
                else
                {
                    return null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonCountry.Enabled = false;
            buttonFind.Enabled = false;

            labelCapital.Visible = false;
            labelCapitalDateTime.Visible = false;
            labelCapitalTemperature.Visible = false;
            labelCountryName.Visible = false;
            labelOfficialName.Visible = false;
        }
    }

    public class Country
    {
        public Name name { get; set; }
        public string[] tld { get; set; }
        public string cca2 { get; set; }
        public string ccn3 { get; set; }
        public string cca3 { get; set; }
        public string cioc { get; set; }
        public bool independent { get; set; }
        public string status { get; set; }
        public bool unMember { get; set; }
        public Dictionary<string, Currencies> currencies { get; set; }
        public Idd idd { get; set; }
        public string[] capital { get; set; }
        public string[] altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public Dictionary<string, string> languages { get; set; }
        public Dictionary<string, Translation> translations { get; set; }
        public float[] latlng { get; set; }
        public bool landlocked { get; set; }
        public float area { get; set; }
        public Demonyms demonyms { get; set; }
        public Flags flags { get; set; }
        public Coatofarms coatOfArms { get; set; }
        public int population { get; set; }
        public Dictionary<string, float> gini { get; set; }
        public string fifa { get; set; }
        public Car car { get; set; }
        public string[] timezones { get; set; }
        public string[] continents { get; set; }
        public string startOfWeek { get; set; }
        public Capitalinfo capitalInfo { get; set; }
        public Postalcode postalCode { get; set; }
        public string[] borders { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Dictionary<string, Nativename> nativeName { get; set; }
    }

    public class Currencies
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Idd
    {
        public string root { get; set; }
        public string[] suffixes { get; set; }
    }

    public class Nativename
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Translation
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Demonyms
    {
        public Dem eng { get; set; }
        public Dem fra { get; set; }
    }

    public class Dem
    {
        public string f { get; set; }
        public string m { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }

    public class Coatofarms
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Capitalinfo
    {
        public float[] latlng { get; set; }
    }

    public class Postalcode
    {
        public string format { get; set; }
        public string regex { get; set; }
    }

    public class Car
    {
        public string[] signs { get; set; }
        public string side { get; set; }
    }

    public class TimeResponse
    {
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }
    }

    public class OpenMeteoResponse
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public CurrentUnits current_units { get; set; }
        public Current current { get; set; }
    }

    public class CurrentUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Current
    {
        public DateTime time { get; set; }
        public int interval { get; set; }
        public double temperature_2m { get; set; }
    }

    public class CurrencyTable
    {
        public string Table { get; set; }
        public string No { get; set; }
        public DateTime EffectiveDate { get; set; }
        public List<CurrencyRate> Rates { get; set; }
    }

    public class CurrencyRate
    {
        public string Currency { get; set; }
        public string Code { get; set; }
        public decimal Mid { get; set; }
    }

}
