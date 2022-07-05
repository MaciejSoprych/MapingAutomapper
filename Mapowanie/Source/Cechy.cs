using Newtonsoft.Json;

namespace Mapowanie.Source
{
   
    public class Cechy
    {
        [JsonProperty("nazwa")]
        public string Nazwa { get; set; }

        [JsonProperty("wartosc")]
        public string Wartosc { get; set; }
        
    }


}
