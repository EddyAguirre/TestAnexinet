using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escribe un numero entre 1 y 3999");
                int number = 0;
                if (!int.TryParse(Console.ReadLine(), out number) || number > 3999 || number < 1)
                {
                    Console.WriteLine("Se ingreso un numero invalido.");
                    Console.ReadKey();
                    return;
                }
                Console.Write($"Numerico: {number}, Romano: {RomanNumeral(number)}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static string RomanNumeral(int number)
        {
            if (number >= 1000) return "M" + RomanNumeral(number - 1000);
            if (number >= 900) return "CM" + RomanNumeral(number - 900);
            if (number >= 500) return "D" + RomanNumeral(number - 500);
            if (number >= 400) return "CD" + RomanNumeral(number - 400);
            if (number >= 100) return "C" + RomanNumeral(number - 100);
            if (number >= 90) return "XC" + RomanNumeral(number - 90);
            if (number >= 50) return "L" + RomanNumeral(number - 50);
            if (number >= 40) return "XL" + RomanNumeral(number - 40);
            if (number >= 10) return "X" + RomanNumeral(number - 10);
            if (number >= 9) return "IX" + RomanNumeral(number - 9);
            if (number >= 5) return "V" + RomanNumeral(number - 5);
            if (number >= 4) return "IV" + RomanNumeral(number - 4);
            if (number >= 1) return "I" + RomanNumeral(number - 1);
            if (number == 0) return "";
            throw new IndexOutOfRangeException("El numero esta fuera del rango permitido.");
        }
    }
}
