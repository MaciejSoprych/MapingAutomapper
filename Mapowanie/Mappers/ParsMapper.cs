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
    public class ParsMapper : Profile
    {
        public ParsMapper()
        {
            CreateMap<Dokument, Pars>()
                .ForPath(dest => dest.PozycjeDto,
                 opt => opt.MapFrom(src => src))
                .ForPath(dest => dest.PozycjeDto,
                opt => opt.MapFrom(src => src.Pozycje.Pozycja))
                .BeforeMap((src,dest)=> 
                {
                    foreach (var pozycja in src.Pozycje.Pozycja)
                    {
                        pozycja.NumerDokumentu = src.NumerDokumentu;
                        pozycja.DatabaseHandle = src.DatabaseHandle;
                    }
                });
        }
    }
}
