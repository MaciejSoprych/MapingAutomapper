using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mapowanie.Source
{
    public class Pozycje
    {
        [JsonProperty("pozycja")]
        public List<Pozycja> Pozycja { get; set; }
    }


}
