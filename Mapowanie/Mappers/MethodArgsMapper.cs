using AutoMapper;
using Mapowanie.Dto;
using Mapowanie.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapowanie.Mappers
{
    public class MethodArgsMapper : Profile
    {
        public MethodArgsMapper()
        {
            CreateMap<Root, MethodArgs>()
                .ForMember(dest=>dest.Database,
                opt=>opt.MapFrom(src=>src.DataBaseHandle))
                .BeforeMap((src,dest)=> 
                {
                    src.Dokument.DatabaseHandle = src.DataBaseHandle;
                });
        }
    }
}
