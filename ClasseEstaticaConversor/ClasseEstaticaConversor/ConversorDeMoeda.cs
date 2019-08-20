using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseEstaticaConversor
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        
        public static double Converter(double cotacao, double quantia)
        {
            double valor = cotacao * quantia;
            return valor + valor * IOF;
        }
    }
}
