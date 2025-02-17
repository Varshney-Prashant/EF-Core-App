using AutoMapper;
using EfCoreApp.CoreModels.Employee;
using EfCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.Services.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Address, AddressDto>()
                .ReverseMap();

            CreateMap<Employee, EmployeeDto>()
                .ReverseMap();
        }
    }
}
