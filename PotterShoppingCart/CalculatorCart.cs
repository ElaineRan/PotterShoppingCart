using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class CalculatorCart
    {
        public double ComputeOne()
        {
            return 100 * 1 ;
        }

        public double ComputeTwo()
        {
            return 100 * 2 * 0.95;
        }

        public double ComputeThree()
        {
            return 100 * 3 * 0.9;
        }

        public double ComputeFour()
        {
            return 100 * 4 * 0.8;
        }

        public double ComputeFive()
        {
            return 100 * 5 * 0.75;
        }

        public double ComputeSpecial()
        {
            return 100 * 3 * 0.9 + 100;
        }

        public object ComputeSpecialSet()
        {
            throw new NotImplementedException();
        }
    }
}
