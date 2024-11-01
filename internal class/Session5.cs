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
            Question_03();
            //Question_04();
            //Question_05();
            //Question_06();

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
                do
                {
                    Console.WriteLine("Nhap vao mot so nguyen: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 2; i <= (n / 2); i++)
                    {
                        if (n % i == 0)
                        {
                            Console.WriteLine($"{n} khong phai la so nguyen to");
                        }
                        else
                        {
                            Console.WriteLine($"{n} la so nguyen to");
                        }
                    }
                } while (true);
            }



        }
    }
}
