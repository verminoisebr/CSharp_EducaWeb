using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            List<Employee> listEmployees = new List<Employee>();

            int idIncrease;
            Employee emp;
            
            Console.Write("How many employees will be registered? ");
            n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
            {
                int id;
                string name;
                float salary;

                Console.WriteLine();
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employee = new Employee() { Id = id, Name = name, Salary = salary };

                listEmployees.Add(employee);
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            idIncrease = int.Parse(Console.ReadLine());
                        
            emp = listEmployees.Find(x => x.Id == idIncrease);

            if (emp != null)
            {
                float percentIncrease;

                Console.Write("Enter the percentage: ");
                percentIncrease = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentIncrease);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in listEmployees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
