using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_class
{
    internal class Session7
    {
        public static void Main1(string[] args)
        //Create an integermatrix N x M(N, M was prompted from user) randomly.

        {
            int[,] a; //Khai bao mot mang 2 chieu
            Console.Write("Nhap vao so dong: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot: ");
            int cols = int.Parse(Console.ReadLine());

            a = new int[rows, cols]; //Cap phat vung nho cho mang 2 chieu

            NhapMang2ChieuNgauNhien(a);
            XuatMang(a);
            Console.Write("Nhap so cot ban muon in ra: ");
            int colnum = int.Parse(Console.ReadLine());
            XuatMangColIndex(a,colnum);
            ChuyenVi(a);
            XuatMang(a);
        }
        static void NhapMang2ChieuNgauNhien(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++) //a.GetLength(0) la tra ve so dong cua mang 2 chieu
            {
                for (int j = 0; j < a.GetLength(1); j++) ////a.GetLength(1) la tra ve so cot cua mang 2 chieu
                {
                    {
                        a[i, j] = random.Next(100);
                    }
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void XuatMangColIndex(int[,] a, int ColIndex)
        //Print the i(th) row/column. (i was prompted from user)
        {
            if (ColIndex < 0 || ColIndex > a.GetLength(0) - 1)
            {
                Console.WriteLine("Sai roi!!");
                return;
            }
          
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i, ColIndex]}\t");
            }
            Console.ReadKey() ;
        }
        static void ChuyenVi(int[,] a)
        {
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    a[j,i] = a[i, j];
                }
                Console.WriteLine();
            }
        }


    }
}
