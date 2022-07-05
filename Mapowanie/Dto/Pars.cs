using System.Collections.Generic;

namespace Mapowanie.Dto
{
    public class Pars
    {
        public string NumerDokumentu { get; set; }
        public decimal Kwota { get; set; }
        public IEnumerable<Platnosc> Platnosci { get; set; }
        public IEnumerable<PozycjaDto> PozycjeDto { get; set; }

    }
    
   
}
