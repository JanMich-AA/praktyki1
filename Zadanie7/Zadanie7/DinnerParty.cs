using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    internal class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople;
        public decimal CostOfBevaragesPerPerson;
        public decimal CostOfDecorations = 0;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBevaragesPerPerson = 5.00M;
            } else
            {
                CostOfBevaragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;

            } else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBevaragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            } else
            {
                return totalCost;
            }
        }
    }
}
