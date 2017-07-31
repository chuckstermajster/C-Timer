using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.HelperClasses
{
    class RandomGenerator
    {
        private static readonly Random random = new Random();

        public static double generateRandomBeetwenTwoValues(double firstValue, double secondValue)
        {
            var randomNumber = random.NextDouble();
            return (firstValue + (randomNumber * (secondValue - firstValue)))*1000;
        }
    }
}
