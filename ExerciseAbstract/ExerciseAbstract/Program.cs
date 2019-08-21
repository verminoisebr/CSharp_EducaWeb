using System;
using System.Globalization;
using System.Collections.Generic;
using ExerciseAbstract.Entities;

namespace ExerciseAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.Write("Entre the number of tax payers: ");
            int numPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char pType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string pName = Console.ReadLine();
                Console.Write("Annual Income: ");
                float pAI = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (pType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    float pHE = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    persons.Add(new IndividualPerson(pName, pAI, pHE));
                }
                else
                {
                    Console.Write("Number of employee: ");
                    int pNOE = int.Parse(Console.ReadLine());
                    persons.Add(new CompanyPerson(pName, pAI, pNOE));
                }
            }

            Console.WriteLine("TAXES PAID:");
            float totalTaxes = 0;
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
                totalTaxes += p.AnnualTaxes();
            }
            Console.WriteLine("TOTAL TAXES PAID: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
