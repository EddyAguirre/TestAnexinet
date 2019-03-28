using System;

namespace SwapInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el numero A.");
            int numberA = 0;
            if (!int.TryParse(Console.ReadLine(), out numberA))
            {
                Console.WriteLine("Se ingreso un valor invalido.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Escribe el numero B.");
            int numberB = 0;
            if (!int.TryParse(Console.ReadLine(), out numberB))
            {
                Console.WriteLine("Se ingreso valor invalido.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Numero A: {numberA}");
            Console.WriteLine($"Numero B: {numberB}");
            Console.WriteLine($"Intercambiando...");
            numberA *= numberB;
            numberB = numberA / numberB;
            numberA /= numberB;
            Console.WriteLine($"Numero A: {numberA}");
            Console.WriteLine($"Numero B: {numberB}");
            Console.ReadKey();
        }
    }
}
