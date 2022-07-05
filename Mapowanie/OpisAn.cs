using System.Collections.Generic;

namespace Mapowanie
{
    public class OpisAn
    {
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {

        public string Name { get; set; }
        public Cecha Cecha { get; set; }
    }

    public class Cecha
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
