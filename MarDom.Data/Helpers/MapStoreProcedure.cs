using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Data.Helpers
{

   
    public static class MapStoreProcedure<TSource ,TDestination>
    {


        public static TDestination Map(TSource model)
        {


            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            return Mapper.Map<TSource, TDestination>(model);
        }

     
    }

 
}
