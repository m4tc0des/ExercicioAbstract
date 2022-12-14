using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAbstract;

namespace ExercicioAbstract.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double sum = 0;
            if (NumberOfEmployees > 10)
            {
                sum = (this.AnualIncome * 14) / 100;
            }
            else
            {
                sum = (this.AnualIncome * 16) / 100;
            }
            return sum;
        }
    }
}
