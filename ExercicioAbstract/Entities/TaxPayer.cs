using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAbstract.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();

       //public virtual string MostrarDados()
        //{
          //  StringBuilder sb = new StringBuilder();

            //sb.AppendLine("TAXES PAID: ");
            //sb.Append(Name);
            //sb.Append(": $ ");
            //sb.Append( );
            //return sb.ToString();

//        }
    }
}

