using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioClasseEncapsulamento
{
    class Conta
    {
        private float Saldo = 0;
        public int Numero { get; private set; }
        public string Titular { get ; private set ; }
                
        public Conta (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, float depInicial) : this(numero, titular)
        {
            Deposito(depInicial);
        }

        public void Deposito(float valor)
        {
            Saldo += valor;
        }

        public void Saque(float valor)
        {
            if (valor <= (Saldo + 5))
            {
                Saldo -= (valor + 5);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public override string ToString()
        {
            return "Conta "+Numero+", Titular: "+Titular+", Saldo: $ "+Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
