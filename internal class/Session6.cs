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
            Exercise_01();
            //Exercise_02();
            //Exercise_03();
            //Exercise_04();
            //Exercise_05();
        }

        public static void Exercise_01()
        //Enter item values for this array and Print the array to screen.
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());   //n la length, a la value.
            int[] a = new int[n];
            //nhapmabangCom(a);
            nhapmaNgaunhien(a);
            InMang(a);
            sum(a);
            Console.Write("Nhap vao so can tim: ");
            int SoCanTim = int.Parse(Console.ReadLine());
            int position = LinearSearch(a, SoCanTim);
            if (position == -1)
                Console.WriteLine($"So {SoCanTim} khong co trong mang.");
            else
                Console.WriteLine($"So {SoCanTim} xuat hien tai vi tri {position} trong mang.");
            Sapxep(a);
            swap(a,b);
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
            Random random = new Random();
            for (int i = 0;i < a.Length;i++)
            {
                a[i] = random.Next(100); //random cac phan tu co value < 100, tuc la value trong khoang 0 den 99.
            }
        }
        static void InMang(int[]a) 
        {
            for (int i = 0;i < a.Length;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void sum(int[]a)
        { 
            int sum = 0;
            for (int i = 0;i < a.Length;i++)
            sum +=a[i];
            Console.WriteLine($"Tong cua cac phan tu cua mang la: {sum}");
            double average = (double) sum / a.Length;
            Console.WriteLine($"Trung binh cac phan tu cua mang la: {average}");
        }

        static int LinearSearch(int[]a, int SoCanTim)
        {
            for (int i = 0;i < a.Length;i++)
                if (a[i] == SoCanTim)
                    return i;
                return -1;
        }

        static void Sapxep(int[]a)
        {
            for (int i = 0; i < a.Length - 1;i++)
                for (int j = 0;j < a.Length - i - 1;j++)
                {
                    if (a[j] > a[j+1])
                        swap(ref a[j], ref a[j+1]);
                }
        }

        static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }





        public static void Exercise_03()
        //to find the maximum and minimum value of an array.
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
