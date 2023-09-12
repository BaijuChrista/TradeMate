using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SC.Data;
namespace SC.Web.Models
{
public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Country ,SC.Data.Country> ();
        }
    }
}
