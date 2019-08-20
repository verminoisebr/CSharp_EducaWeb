using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {        
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            int qtde;            

            Console.Write("O curso A possui quantos alunos? ");
            qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i<qtde; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < qtde; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < qtde; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            A.UnionWith(B);
            A.UnionWith(C);

            Console.WriteLine("Total de alunos: " + A.Count);
        }
    }
}
