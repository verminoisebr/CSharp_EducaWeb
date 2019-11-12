using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using ExerciseLinq.Entities;
using System.Globalization;

namespace ExerciseLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the full path of file: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine("Enter salary: ");
            double salaryValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emailSalary = list.Where(p => p.Salary > salaryValue).OrderBy(p => p.Name).Select(p => p.Email);
            Console.WriteLine("Email of people whose salary is more than " + salaryValue.ToString("F2", CultureInfo.InvariantCulture) + ":");
            foreach (string value in emailSalary)
            {
                Console.WriteLine(value);
            }

            var sum = list.Where(p => p.Name.StartsWith('M')).Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
