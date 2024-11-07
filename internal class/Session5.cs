using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace internal_class
{
    internal class Session5
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            Question_06();

        }
        public static void Question_01()
        //1. Write a C# function to find the maximum of three numbers. Improve the next version that accept at least 1 parameter.
        {
            Console.Write("Nhap vao so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so c = ");
            int c = int.Parse(Console.ReadLine());
            int max = max2Num(c, max2Num(a, b));

            static int max2Num(int a, int b)
            {
                return a > b ? a : b;
            }
            static int max3Num(int a, int b, int c)
            {
                return max2Num(c, max2Num(a, b));
            }
            Console.WriteLine($"Gia tri lon nhat cua {a} va {b} va {c} la: {max}");

        }

        public static void Question_02()
        //2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        {
            do
            {
                Console.Write("Nhap vao so can tinh giai thua: ");
                int n = int.Parse(Console.ReadLine());
                {
                    if (n < 0)
                    {
                        Console.WriteLine("So nguyen am khong co giai thua.");
                        break;
                    }
                    else
                    {
                        long factorial = 1; //cài từ đầu cho bằng 1, vì bằng 0 thì nó nhân vào bằng 0 hết.
                        for (int i = 1; i <= n; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine($"Giai thua cua {n} la: {n}! = {factorial}");
                    }
                }
            } while (true);
        }

        public static void Question_03()
        //3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        {
            bool KtraNguyento(int n)
            {
                if (n <= 1) return false;
                for (int i = 2; i <= (n / 2); i++)
                {
                    if (n % i == 0)
                    return false;
                }
                return true;
            }
         
            int n = 0;

            do
            {
                Console.Write("Nhap vao mot so nguyen: ");
                n = int.Parse(Console.ReadLine());

                if (n <=1)
                {
                    Console.WriteLine("2 la so nguyen to nho nhat. Vui long nhap so nguyen lon hon hoac bang 2.");
                    break;
                }

                if (KtraNguyento (n))
                {
                    Console.WriteLine($"{n} la so nguyen to.");
                }

                else
                {
                    Console.WriteLine($"{n} khong phai la so nguyen to.");
                }

            } while (true);
        }

        public static void Question_04()
        ///4. Write a C# function to print
        ///a. all prime numbers that less than a number (enter prompt keyboard).
        ///b. the first N prime numbers.
        {
            Console.Write("a. Nhap vao mot so nguyen bat ky: ");
            int num = int.Parse(Console.ReadLine());
            random_number(num);
            Console.WriteLine();
            Console.Write("b. Nhap vao mot so nguyen N bat ky: ");
            int N = int.Parse(Console.ReadLine());
            firstPrimeNumbers(N);
        
            static bool KtraNgto (int so)
            {
                if (so <= 1) return false;
                for (int i = 2; i <= (so / 2); i++)
                {
                    if (so % i == 0)
                    return false;
                } 
                return true;
            }
            
            static void random_number(int num)
            {
                Console.WriteLine($"Cac so nguyen to nho hon {num} la: ");
                for (int i = 2; i < num; i++)
                {
                    if (KtraNgto (i) )
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            static void firstPrimeNumbers(int N)
            {
                int so = 2;
                int count = 0;
                Console.Write($"{N} so nguyen to dau tien la: ");
                while (count < N)
                {
                    if (KtraNgto (so) )
                    {
                        Console.Write(so + " ");
                        count++;
                    }
                    so++;
                }
            }
        }

        public static void Question_05()
        //5. Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        {
            Console.Write("Nhap vao mot so nguyen bat ky: ");
            int num2 = int.Parse(Console.ReadLine());
            KtraHoanhao(num2);
            if (num2 <=0 )
            {
                Console.WriteLine("So hoan hao la so nguyen duong.");
            }
            else if (KtraHoanhao(num2))
            {
                Console.WriteLine($"{num2} la so hoan hao.");
            }
            else 
            {
                Console.WriteLine($"{num2} khong phai la so hoan hao.");
            }

            Console.Write("Cac so hoan hao nho hon 1000 la: ");
            for (int i = 1;i < 1000;i++)
            {
                if (KtraHoanhao(i))
                {
                    Console.Write(i + " ");
                }
            }
            static bool KtraHoanhao (int num2)
            {
                int sum = 0;
                if(num2 <= 0) return false;
                for (int i = 1; i <= (num2 / 2);i++)
                {
                    if(num2 % i ==0)
                    {
                        sum += i;
                    }
                }
                return sum == num2;
            }
        }
        
        public static void Question_06()
        //6. Write a C# function to check whether a string is a pangram or not.
        {
            Console.Write("Nhap vao mot cau bat ky: ");
            string input = Console.ReadLine();
            if (IsPangram(input))
            {
                Console.WriteLine("Day la mot cau pangram.");
            }
            else 
            {
                Console.WriteLine("Day khong phai la mot cau pangram.");
            }

            static bool IsPangram(string input)
            {
            input = input.ToLower(); //De chuyen tat ca input sang chu thuong.
            for (char letter = 'a';letter <= 'z';letter++)
            {
                if(!input.Contains(letter))
                {
                    return false;
                }
            }
            return true;
            }
        }
        
    }
}
