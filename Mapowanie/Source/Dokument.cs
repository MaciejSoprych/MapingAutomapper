using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapowanie.Source
{

    public class Dokument 
    {
        [JsonProperty("kwotaNetto")]
        public decimal KwotaNetto { get; set; }

        [JsonProperty("pozycje")]
        public Pozycje Pozycje { get; set; }

        [JsonProperty("numerDokumentu")]
        public string NumerDokumentu { get; set; }
        public string DatabaseHandle { get; set; }


    }


}
