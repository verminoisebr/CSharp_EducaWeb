using System.Globalization;

namespace ExerciciosClasse
{
    class Funcionario
    {
        public string Nome = "João Silva";
        public double SalarioBruto = 6000;
        public double Imposto = 1000;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto *( porcentagem / 100.0);
            return SalarioLiquido();
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                   + "\nSalário Bruto: " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)
                   + "\nImposto: " + Imposto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
