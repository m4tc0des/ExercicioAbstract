using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAbstract;


namespace ExercicioAbstract.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
       
        public override double Tax()
        {
            if (HealthExpenditures < 20000.00)
            {
                return (HealthExpenditures * 15) / 100;
            }
            else if (HealthExpenditures >= 20000.00)
            {
                return (HealthExpenditures * 25) / 100;
            }
            return HealthExpenditures;
        }
    }
}
