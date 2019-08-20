using System;

namespace ExercicioVetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Lodger[] lodger = new Lodger[10];

            Console.Write("How many rooms will be rented? ");
            n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string name;
                string email;
                int room;

                Console.WriteLine();
                Console.WriteLine("Rent #" + (i + 1));
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());

                lodger[room] = new Lodger { Name = name, Email = email, Room = room };
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            foreach (Lodger i in lodger)
            {
                if (i != null)
                    Console.WriteLine(i);
            }
        }
    }
}
