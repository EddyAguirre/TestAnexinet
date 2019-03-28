using System;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un minuto.");
            int minute = 0;
            if (!int.TryParse(Console.ReadLine(), out minute) || minute > 59 || minute < 0)
            {
                Console.WriteLine("Se ingreso un minuto invalido.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Escribe una hora.");
            int hour = 0;
            if (!int.TryParse(Console.ReadLine(), out hour) || hour > 12 || hour < 0)
            {
                Console.WriteLine("Se ingreso una hora invalida.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"El angulo interno es: {GetAngle(minute, hour)}");
            Console.ReadKey();
        }

        /// <summary>
        /// Get the inner Angle from the given hour and minute 
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <returns></returns>
        static double GetAngle(int hour, int minute)
        {
            //Get each minute angle
            int minutePart = 360 / 60;
            //Get each hour angle
            int hourPart = 360 / 12;

            int minuteAngle = minute * minutePart;
            int hourAngle = hour * hourPart;
            int innerAngleA = Math.Abs(minuteAngle - hourAngle);
            int innerAngleB = Math.Abs(Math.Abs(minuteAngle - hourAngle) - 360);
            if (innerAngleA < innerAngleB)
                return innerAngleA;
            else return innerAngleB;

        }
    }
}
