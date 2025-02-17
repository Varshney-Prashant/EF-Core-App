using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.Services.Configurations
{
    public static class MapperFactory
    {
        private static readonly Lazy<IMapper> _mapper = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Default: Scan all assemblies in the current domain
                cfg.AddMaps(typeof(MappingProfile).Assembly);
            });
            return config.CreateMapper();
        });

        public static IMapper GetInstance() => _mapper.Value;
    }
}
