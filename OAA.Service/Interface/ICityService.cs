using System;
using SC.Data;
using System.Collections.Generic;
using System.Text;

namespace SC.Service.Interface
{
    public interface ICityService
    {
        List<City> GetAllCity();
        void AddCity(City City);
        City GetCity(long id);
        void UpdateCity(City City);
        List<City> GetCity();
    }
}
