using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace internal_class
{
    internal class Session4
    {
        public static void Main()
        {
            //ExerciseOperators_02();
            //ExerciseOperators_03();
            //ExerciseOperators_05();
            //ExerciseCFS_01();
            //ExerciseCFS_02();
            //ExerciseCFS_03();
            //ExerciseCFS_04();
            //ExerciseCFS_05();
            //ExerciseCFS_06();
            ExerciseCFS_07();
        }

        public static void ExerciseOperators_02()
        //Write a C# program to display certain values of the function x = y^2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        {
            Console.Write("Nhap mot so trong khoang tu -5 den 5: y = ");
            int y = int.Parse(Console.ReadLine());
            if (y>=-5 && y<=5)
            {
                double x = Math.Pow(y, 2) + (2 * y) + 1;
                Console.WriteLine($"x = y * y + 2 * y + 1 = ({y})*({y}) + 2*({y}) + 1 = {x} ");
            }
            else
            {
                Console.WriteLine("Vui long nhap so trong khoang tu -5 den 5!!");
                return;
            }
        }

        public static void ExerciseOperators_03()
        //Write a C# program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
       {
            Console.Write("Nhap mot khoang cach (km): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Nhap loai thoi gian (nhap theo dinh dang hours/minutes/seconds): ");
            string timeFormat = Console.ReadLine();

            Console.Write("Nhap thoi gian (so): ");
            double time = double.Parse(Console.ReadLine());

            double timeInHours;

            if (timeFormat.Contains("hours"))
            {
                timeInHours = time; 
            }
            else if (timeFormat.Contains("minutes"))
            {
                timeInHours = time / 60.0; 
            }
            else 
            {
                timeInHours = time / 3600.0; 
            }

            double speedKmh = distance / timeInHours; 
            double speedMph = speedKmh * 0.621371; 
            Console.WriteLine($"Toc do trong km/h: {speedKmh:F3} km/h");
            Console.WriteLine($"Toc do trong miles/h: {speedMph:F3} miles/h");
        }
    
        public static void ExerciseOperators_05()
        //Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        {
            Console.Write("Nhap vao mot ky tu bat ki: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
        
            if (char.IsDigit(input))
            {
                Console.WriteLine($"{input} la mot chu so");
            }
            else if ("ueoaiUEOAI".Contains(input))
            {
                Console.WriteLine($"{input} la mot nguyen am");
            }
            else
            {
                Console.WriteLine($"{input} la mot ky tu khac");
            }
        }
        public static void ExerciseCFS_01()
        //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        {
            Console.WriteLine("Nhap vao do dai ba canh cua tam giac: ");
            Console.Write("Do dai canh a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Do dai canh b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Do dai canh c = ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Do dai cac canh cua tam giac phai lon hon 0.");
            }

            else if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Ba canh nay tao thanh mot tam giac.");
                
                if (a==b && b==c)
                {
                    Console.WriteLine("Day la tam giac deu.");
                }

                else if (a==b || b==c || a==c)
                {
                    Console.WriteLine("Day la tam giac can.");
                }

                else
                {
                    Console.WriteLine("Day la tam giac thuong.");
                }
            }

            else
            {
                Console.WriteLine("Ba canh nay khong tao thanh mot tam giac.");
            }
        }
        public static void ExerciseCFS_02()
        //Write a program to read 10 numbers and find their average and sum.
        {
            Console.WriteLine("Nhap vao 10 so:");
            double sum = 0;
            double average;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"So {i}: ");
                double number = double.Parse(Console.ReadLine()); 
                sum += number; 
            }

            average = sum / 10;
            Console.WriteLine($"Tong cac so la: {sum}");
            Console.WriteLine($"Trung binh cac so la: {average}");
        }
        public static void ExerciseCFS_03()
        //Write a program to display the multiplication table of a given integer.
        {
            Console.Write("Nhap vao mot so nguyen");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            Console.WriteLine($"Bang phep nhan cua {n} la: ");
            while (i <=10)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
                i++;
            }
        }
        public static void ExerciseCFS_04()
        //Write a program to display a pattern like triangles with a number.
        {
            Console.Write("Nhap vao so dong cho tam giac: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
            // " " là khoảng trắng đứng trước các số
                for (int j = i; j < rows; j++)  
                {
                    Console.Write(" "); 
                }

            // In các số từ 1 đến i, " " là khoảng cách giữa các số
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " "); 
                }
                Console.WriteLine();
            }

        }
        public static void ExerciseCFS_05() 
        //Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms.
        {
            Console.Write("Nhap vao so hang n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;

            Console.Write("Day so dieu hoa la: ");
            for (int i = 1; i <= n; i++)
            {
            // In phân số 1/i
                Console.Write($"1/{i}");
                 double term = 1.0 / i;
                if (i < n)
                {
                    Console.Write(" + "); 
                }
                sum += term; 
            }
            Console.WriteLine();
            Console.WriteLine("Tong cua ca day so dieu hoa tren la: " + sum.ToString("F3"));
        }
        public static void ExerciseCFS_06()
        //Write a program to find the ‘perfect’ numbers within a given number range.
        {
            Console.Write("Nhap vao so bat dau: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so ket thuc: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cac so hoan hao trong khoang tu {start} den {end} la:");

            for (int number = start; number <= end; number++)
            {
                if (IsPerfect(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num && num != 0;
        }
        public static void ExerciseCFS_07()
        //Write a program to determine whether a given number is prime or not.
        {
            Console.Write("Nhap vao mot so nguyen duong: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false; 
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false; 
                        break; 
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so nguyen to.");
            }
        }
    }   
}    
        


