using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Mapowanie.Source;
using System.Collections.Generic;

namespace Mapowanie.Dto
{
    [AutoMap(typeof(Dokument))]
    public class PozycjaDto
    {
        public string SymbolKonta { get; set; }
        public int Amount { get; set; }
        public string NumerDokumentu { get; set; }
        public string DatabaseHandle { get; set; }

       


    }
    
   
}
