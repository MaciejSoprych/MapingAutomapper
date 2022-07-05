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
    public class PlatnosciMapper:Profile
    {
        public PlatnosciMapper()
        {
            CreateMap<Dokument, IEnumerable<Platnosc>>().ConvertUsing<EventLogConverter>();
            CreateMap<Dokument, Platnosc>()
                .ForPath(dest=>dest.Opis,
                opt=>opt.MapFrom(src=>src.NumerDokumentu))
                .ForPath(dest=>dest.Kwota,
                opt=>opt.MapFrom(src=>src.KwotaNetto));
        }
        
    }

    public class EventLogConverter : ITypeConverter<Dokument, IEnumerable<Platnosc>>
    {
        public IEnumerable<Platnosc> Convert(Dokument source, IEnumerable<Platnosc> destination, ResolutionContext context)
        {
            var platnosci = new List<Platnosc>();
            platnosci.Add(context.Mapper.Map<Platnosc>(source));
            return platnosci;
        }
    }
}
