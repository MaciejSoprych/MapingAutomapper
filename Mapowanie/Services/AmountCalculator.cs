using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapowanie.Services
{
    public class AmountCalculator : IAmountCalculator
    {
        public int CalculateAmount()
        {
            return 2;
        }
    }

    public interface IAmountCalculator
    {
        public int CalculateAmount();
    }
}
