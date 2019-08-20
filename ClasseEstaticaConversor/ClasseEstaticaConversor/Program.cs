using System;
using System.Globalization;

namespace ClasseEstaticaConversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.Converter(cotacao, quantia);

            Console.WriteLine("Valos a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
