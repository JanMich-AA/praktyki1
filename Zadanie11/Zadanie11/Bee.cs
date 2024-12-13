using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg {  get; set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
