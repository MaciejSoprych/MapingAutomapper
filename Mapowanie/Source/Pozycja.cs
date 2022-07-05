using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mapowanie.Source
{
    
    public class Pozycja
    {

        [JsonProperty("symbolKonta")]
        public string SymbolKonta { get; set; }

        [JsonProperty("cechy")]
        public List<Cechy> Cechy { get; set; }
        
        public string NumerDokumentu { get; set; }

        public string DatabaseHandle { get; set; }




    }
}
