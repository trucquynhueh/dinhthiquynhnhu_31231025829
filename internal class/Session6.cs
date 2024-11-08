using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_class
{
    internal class Session6
    {
        public static void Main(string[] args)
        {
            Exercise_01_02();
            //Exercise_03();
            //Exercise_04();
            //Exercise_05();
            //Exercise_06();
        }

        public static void Exercise_01_02()
        //Enter item values for this array and Print the array to screen.
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());   //n la length, a la value.
            int[] a = new int[n];
            //nhapmabangCom(a);
            nhapmaNgaunhien(a);
            InMang(a);
        }

        static void nhapmabangCom(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap vao phan tu thu {i}: ");
                a[i] = int.Parse(Console.ReadLine());
           
            }
        }

        static void nhapmaNgaunhien(int[]a) 
        {
            double sum = 0.0;
            double average = 0.0 ;
            Random random = new Random();
            for (int i = 0;i < a.Length;i++)
            {
                a[i] = random.Next(100); //random cac phan tu co value < 100, tuc la value trong khoang 0 den 99.
                sum += a[i];
                average = (sum)/a.Length;
            }
            Console.WriteLine($"Tong cac phan tu cua mang la: {sum}");
            Console.WriteLine($"Trung binh cac phan tu cua mang la: {average}");
        }
        static void InMang(int[]a) 
        {
            foreach (int item in a)
            {
                Console.Write(item + " ");
                double sum = 0.0;
                double average = 0.0;
            }
        }

        static void sum(int[]a)
        { 
            foreach (int item in a)}

        public static void Exercise_03()
        //Write a function that increase each item of the array by adding it with 2.
        {

        }

        public static void Exercise_04()
        //Print the array to screen (again).
        {

        }

        public static void Exercise_05()
        //Write a function that calculate the sum of all items of the array.
        {

        }

        public static void Exercise_06()
        //average, min, max...
        {

        }

    }
}
