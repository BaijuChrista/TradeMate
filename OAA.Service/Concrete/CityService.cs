using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;
using SC.Repository;
using SC.Service.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SC.Service.Concrete
{
    public class CityService : ICityService
    {
        private IRepository<City> CityRepository;

        public CityService(IRepository<City> cityRepository)
        {
            this.CityRepository = cityRepository;
        }

        public List<City> GetAllCity()
        {
            return CityRepository.GetQueryable().Include(b => b.State).Include(b=>b.State.Country).ToList();
        }
        public List<City> GetCity()
        {
            return CityRepository.GetAll().ToList();
        }

        public void AddCity(City City)
        {
            CityRepository.Insert(City);
        }

        public City GetCity(long id)
        {
            return CityRepository.Get(id);
        }

        public void UpdateCity(City City)
        {
            CityRepository.Update(City);
        }
    }
}
