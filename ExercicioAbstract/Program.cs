using System;
using System.Collections.Generic;
using ExercicioAbstract.Entities;

namespace ExercicioAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Tax payer #{i} data: ");
                Console.WriteLine("Individual or company (i/c)?");
                char comp = char.Parse(Console.ReadLine());
                if (comp == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                if (comp == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Numbers of employees: ");
                    int numberofEmployeers = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberofEmployeers));
                }
                Console.WriteLine("TAXES PAID:");
                foreach(TaxPayer tax in list)
                {
                    Console.WriteLine(tax.Name + ": $ " + tax.Tax());

                }
                
            }
        }
    }
}
