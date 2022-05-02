using AutoMapper;
using Common.Dto;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
   public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
        }
    }
    
}
