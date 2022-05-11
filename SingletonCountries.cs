using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia8
{
    public sealed class SingletonCountries
    {
        private static SingletonCountries _instance;
        private Country[] countries;
        
        private SingletonCountries() 
        { 
            
        }

        
        public static SingletonCountries GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonCountries();
            }
            return _instance;
        }

        public Country GetCountries(int ID)
        {
            if (countries[ID] != null)
            {
                return countries[ID];
            }
            else
            {
                return default;
            }
        }

        public string[] GetProvincies(int ID)
        {
            if(countries[ID] != null)
            {
                return countries[ID].CountryProvinces;
            }
            else
            {
                return default;
            }
        }
    }
}
