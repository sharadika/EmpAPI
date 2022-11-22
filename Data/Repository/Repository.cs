using AutoMapper;
using Common.Dto;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public partial class Repository : IRepository
    {
        private readonly EmployeeContext _Context;
        private readonly IMapper _mapper;

        public Repository(EmployeeContext context, IMapper mapper)
        {
            _Context = context;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

    }
}
