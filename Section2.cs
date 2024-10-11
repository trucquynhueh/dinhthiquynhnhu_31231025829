
using System.Drawing;

namespace dinhthiquynhnhu_31231025829
{
    internal class Section2
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();
            //Console.WriteLine("Please press any key to stop")
            //Console.ReadKey();

        }

            /// <summary>
            /// 1. to Add / Sum Two Numbers.
            /// </summary>
            public static void Question_01()
            {
                Console.Write("Enter a number a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter a number b = ");
                int b = int.Parse(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine($"{a} + {b} = {sum}");
            }

            /// <summary>
            /// 2. to Swap Values of Two Variables.
            /// </summary>
            public static void Question_02()
            {
                Console.Write("Enter a number a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter a number b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"a = {b} , b = {a}");
            }

            /// <summary>
            ///  3. to Multiply two Floating Point Numbers.
            /// </summary>
            public static void Question_03()
            {
                Console.Write("Enter the first floating point number: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Enter the second floating point number: ");
                float b = float.Parse(Console.ReadLine());
                float multiply = a * b;
                Console.WriteLine($"The result of multiplying {a} and {b} is: {multiply}");
            }   
        
            /// <summary>
            ///  4. to convert feet to meter.
            /// </summary>
            public static void Question_04()
            {
                Console.Write("Enter the length in feet: ");
                double feet = double.Parse(Console.ReadLine());
                double meters = feet * 0.3048;
                Console.WriteLine($"{feet} feet is equal to {meters} meters.");
            }
            
            /// <summary>
            ///   5. to convert Celsius to Fahrenheit and vice versa.
            /// </summary>
            public static void Question_05()
            {
                Console.Write("Enter the degree in Celsius: ");
                double Celsius1 = double.Parse(Console.ReadLine());
                double Fahrenheit1 = Celsius1 * 33.8;
                Console.WriteLine($"{Celsius1} Celsius is equal to {Fahrenheit1} Fahrenheit.");
                Console.Write("Enter the degree in Fahrenheit: ");
                double Fahrenheit2 = double.Parse(Console.ReadLine());
                double Celsius2 = Fahrenheit2 / 33.8;
                Console.WriteLine($"{Fahrenheit2} Fahrenheit is equal to {Celsius2} Celsius.");
            }

            /// <summary>
            ///   6. to find the Size of data types.
            /// </summary>
            public static void Question_06()
            {

            }

            /// <summary>
            ///   7. to Print ASCII Value (tip: read character, print number of this char).
            /// </summary>
            public static void Question_07()
            {

            }

            /// <summary>
            ///   8. to Calculate Area of Circle.
            /// </summary>
            public static void Question_08()
            {

            }

            /// <summary>
            ///   9. to Calculate Area of Square.
            /// </summary>
            public static void Question_09()
            {

            }

            /// <summary>
            ///   10. to convert days to years, weeks and days.
            /// </summary>
            public static void Question_10()
            {

            }
    }
}
