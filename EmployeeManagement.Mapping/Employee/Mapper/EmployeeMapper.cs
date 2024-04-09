using AutoMapper;
using EmployeeManagementt.API.Employees.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Employees.Mapping
{
    public class EmployeeMapper
    {
        public static IMapper Mapper => mapper.Value;

        public static IConfigurationProvider Configuration => config.Value;

        private static readonly Lazy<IMapper> mapper = new Lazy<IMapper>(() =>
        {
            var mapper = new Mapper(Configuration);
            return mapper;
        });

        private static readonly Lazy<IConfigurationProvider> config = new Lazy<IConfigurationProvider>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<EmployeeMappingProfile>();
            });
            return config;
        });

    }
}
