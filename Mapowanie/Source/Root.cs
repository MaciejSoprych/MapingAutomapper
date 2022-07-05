using Newtonsoft.Json;

namespace Mapowanie.Source
{
    public class Root
    {
        [JsonProperty("dataBaseHandle")]
        public string DataBaseHandle { get; set; }
        [JsonProperty("dokument")]
        public Dokument Dokument { get; set; }
    }
    


}
