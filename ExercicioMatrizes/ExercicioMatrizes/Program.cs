using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimension;
            int[,] mat;
            int valueSearch;            

            Console.WriteLine("Enter dimensions of matrix(eg: x y): ");
            dimension = Console.ReadLine().Split(' ');
            mat = new int[int.Parse(dimension[0]), int.Parse(dimension[1])];

            Console.WriteLine("Enter values of each line of matrix(eg: a b c): ");
            for (int i = 0; i < int.Parse(dimension[0]); i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(dimension[1]); j++)
                {
                    mat[i, j] = int.Parse(line[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Enter value to be considered: ");
            valueSearch = int.Parse(Console.ReadLine());

            for (int i = 0; i < int.Parse(dimension[0]); i++)
            {
                for (int j = 0; j < int.Parse(dimension[1]); j++)
                {
                    if (mat[i, j] == valueSearch)
                    {
                        Console.WriteLine($"Position: {i},{j}");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j + 1 < mat.GetLength(1))
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i + 1 < mat.GetLength(0))
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
