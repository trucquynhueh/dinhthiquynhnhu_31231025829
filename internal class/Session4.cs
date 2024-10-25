

using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace internal_class
{
    internal class Session4
    {
        public static void Main()
        {
            //Exercise_02();
            Exercise_03();
            //Exercise_05();
        }

        public static void Exercise_02()
        //Write a C# program to display certain values of the function x = y^2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        {
            Console.Write("Nhap mot so trong khoang tu -5 den 5: y = ");
            int y = int.Parse(Console.ReadLine());
            if (y>=-5 && y<=5)
            {
                double x = Math.Pow(y, 2) + (2 * y) + 1;
                Console.WriteLine($"x = y*y + 2*y + 1 = ({y})*({y}) + 2*({y}) + 1 = {x} ");
            }
            else
            {
                Console.WriteLine("Vui long nhap so trong khoang tu -5 den 5!!");
                return;
            }
        }

        public static void Exercise_03()
        //Write a C# program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        {
            Console.Write("Nhap mot khoang cach (km/miles):");
            int distance = int.Parse(Console.ReadLine());
            Console.Write("Nhap mot thoi gian (hours/minutes/seconds):");
            int time = int.Parse(Console.ReadLine());
            if(time=)

        }
    }
}
