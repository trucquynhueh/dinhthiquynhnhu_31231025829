
namespace internal_class
{
    internal class Session3
    {
        public static void Main()
        {
            //Exercise_01();
            //Exercise_02();
            Exercise_03();
        }

        public static void Exercise_01()
        {
            Console.Write("Enter the degree in Celsius: ");
            double Celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = Celsius * 18 / 10 + 32;
            double Kelvin = Celsius + 273;
            Console.WriteLine($"{Celsius} Celsius = {Fahrenheit} Fahrenheit.");
            Console.WriteLine($"{Celsius} Celsius = {Kelvin} Kelvin.");
        }

        public static void Exercise_02()
        {
            Console.Write("Enter the radius of the sphere: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * radius * radius;
            double volume = 4 / 3 * Math.PI * radius * radius * radius;
            Console.WriteLine($"The surface of the sphere with the radius {radius} is: {surface}");
            Console.WriteLine($"The volume of the sphere with the radius {radius} is: {volume}");
        }

        public static void Exercise_03()
        {
        Console.Write("Enter the number a = ");
        Console.WriteLine();
        Console.Write("Enter the number b = ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float adding = a + b;
        float subtracting = a - b;
        float multiplying = a * b;
        float dividing = a / b;
        float mode = a % b;
        Console.WriteLine($"{a} + {b} = {adding}");
        Console.WriteLine($"{a} - {b} = {subtracting}");
        Console.WriteLine($"{a} * {b} = {multiplying}");
        Console.WriteLine($"{a} / {b} = {dividing}");
        Console.WriteLine($"{a} mode {b} = {mode}"); 
        }

    }
}
