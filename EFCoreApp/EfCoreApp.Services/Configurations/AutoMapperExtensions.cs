using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.Services.Configurations
{
    public static class AutoMapperExtensions
    {
        public static T MapTo<T>(this object o)
        {
            if(o == null)
            {
                return default(T);
            }

            return MapperFactory.GetInstance().Map<T>(o);
        }

        public static IEnumerable<TDestination> MapCollectionTo<TSource, TDestination>(this IEnumerable<TSource> o)
        {
            if(o == null)
            {
                return null;
            }

            return MapperFactory.GetInstance().Map<IEnumerable<TSource>, IEnumerable<TDestination>>(o);
        }
    }
}
