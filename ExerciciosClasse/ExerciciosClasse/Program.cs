using System;
using System.Globalization;

namespace ExerciciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = retangulo.Area();
            Console.WriteLine("Área = " + area.ToString("F2",CultureInfo.InvariantCulture));
            double perimetro = retangulo.Perimetro();
            Console.WriteLine("Perímetro = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            Funcionario joao = new Funcionario();
            Console.WriteLine(joao);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + joao.Nome + ", $ " + joao.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumentar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            joao.AumentarSalario(aumentar);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + joao.Nome + ", $ " + joao.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            Aluno aluno = new Aluno();
            Console.WriteLine(aluno);
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.NotaFinal() < 60)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}
