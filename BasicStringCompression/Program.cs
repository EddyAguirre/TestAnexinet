using System;
using System.Text;

namespace BasicStringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una cadena para comprimir:");
            string text = Console.ReadLine();

            Console.WriteLine(StringCompression(text));
            Console.ReadKey();
        }

        /// <summary>
        /// Compress the given string into a basic string compression.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>It returns a basic string compression, if the compression is bigger than the string, returns the original string</returns>
        static string StringCompression(string text)
        {
            if (text.Length <= 0)
                return "";
            char stored = char.MaxValue;
            int counter = 0;
            StringBuilder sb = new StringBuilder("");

            for (int i = 0; i < text.Length; i++)
            {
                if (stored != text[i])
                {
                    if (counter > 0)
                        sb.Append(counter);
                    counter = 1;
                    stored = text[i];
                    sb.Append(text[i]);
                    if (i == text.Length - 1)
                        sb.Append(counter);
                }
                else
                    counter++;
            }
            if (counter > 1)
                sb.Append(counter);
            if (sb.Length > text.Length)
                return text;
            else return sb.ToString();
        }
    }
}
