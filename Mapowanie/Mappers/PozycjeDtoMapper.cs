using AutoMapper;
using Mapowanie.Dto;
using Mapowanie.Services;
using Mapowanie.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapowanie.Mappers
{
    public class PozycjaMapper: Profile
    {
        public PozycjaMapper()
        {
            CreateMap<Pozycja, PozycjaDto>()
                .ForMember(dest => dest.SymbolKonta,
                opt => opt.MapFrom(src => src.SymbolKonta))
                .ForMember(dest=>dest.DatabaseHandle,
                opt=>opt.MapFrom(src=>src.DatabaseHandle))
                .ForMember(dest=>dest.Amount,
                opt=>opt.MapFrom<AmountResolver>());
        }

    }
    public class AmountResolver : IValueResolver<Pozycja, PozycjaDto, int>
    {
        private readonly IAmountCalculator _amountCalculator;

        public AmountResolver(IAmountCalculator amountCalculator)
        {
            _amountCalculator = amountCalculator;
        }

        public int Resolve(Pozycja source, PozycjaDto destination, int destMember, ResolutionContext context)
        {
            return _amountCalculator.CalculateAmount();
        }
    }

}
