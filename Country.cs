using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    public class Country
    {
        string countryName;
        string[] countryProvinces;

        public Country(string countryName, string[] countryProvinces)
        {
            this.countryName = countryName;
            this.countryProvinces = countryProvinces;
        }
        public Country()
        {

        }

        public string CountryName { get => countryName; set => countryName = value; }
        public string[] CountryProvinces { get => countryProvinces; set => countryProvinces = value; }
    }
}
