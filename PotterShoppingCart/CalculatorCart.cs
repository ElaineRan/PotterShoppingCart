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

        public double ComputeSpecialSet()
        {
            return 100 * 3 * 0.9 + 100 * 2 * 0.95;
        }

        public double Compute(int set, int count, int num)
        {
            double price;

            switch (set)
            {
                case 2:
                    price = 0.95 * 100 * set * count + 100 * num;
                    break;
                case 3:
                    price = 0.9 * 100 * set * count + 100 * num;
                    break;
                case 4:
                    price = 0.8 * 100 * set * count + 100 * num;
                    break;
                case 5:
                    price = 0.75 * 100 * set * count + 100 * num;
                    break;
                default:
                    price = 100 * set;
                    break;
            }

            return price;
        }
    }
}
