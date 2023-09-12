using SC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Service
{
    public interface ICountryService
    {
        List<Country> GetAllCountries();
        void AddCountry(Country Country);
        Country GetCountry(long id);
        void UpdateCountry(Country Country);
        List<Country> GetCountries();
    }
}
