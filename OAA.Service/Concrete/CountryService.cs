using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SC.Service
{
    public class CountryService : ICountryService
    {
        private IRepository<Country> CountryRepository;
        public CountryService(IRepository<Country> countryRepository)
        {
            this.CountryRepository = countryRepository;
        }
        public List<Country> GetAllCountries()
        {
            return CountryRepository.GetQueryable().ToList();
        }
        public List<Country> GetCountries()
        {
            return CountryRepository.GetAll().ToList();
        }

        public void AddCountry(Country Country)
        {
            CountryRepository.Insert(Country);
        }

        public Country GetCountry(long id)
        {
            return CountryRepository.Get(id);
        }

        public void UpdateCountry(Country country)
        {
            CountryRepository.Update(country);
        }
    }
}
