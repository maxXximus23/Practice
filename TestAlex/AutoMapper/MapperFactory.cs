using AutoMapper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TestAlex.AutoMapper
{
    public static class MapperFactory
    {
        private static IMapper mapper;
        public static IMapper GetMapper()
        {
            if(mapper == null)
            {
                var config = new MapperConfiguration(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));
                mapper = config.CreateMapper();
            }
            return mapper;
        }
    }
}
