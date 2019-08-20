using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioLista
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public void IncreaseSalary (float percent)
        {
            Salary += Salary * (percent / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
