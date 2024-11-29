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
            /* do
            {
                int sel = menu();
                switch(sel)
                {
                    case 1: 
                        XuatMang(a);
                        break;
                    case 2: 
                        TimMinMaxTrongDong(a);
                        break;
                    case 3: 
                        TimMinMaxTrongMaTran(a);
                        break;
                    /*case 4:
                        SapXepTangDan(a);
                        break; 
                    case 5: 
                        TimSoNguyenToTrongDong(a);
                        break; 

                } */
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();
            //Exercise_04();
            //Exercise_05();
            //Exercise_06();
            //Exercise_07();
            //Exercise_08();
            //Exercise_09();
            //Exercise_10();
            //Exercise_11();
            //Exercise_12();
            //Exercise_13();
            //Exercise_14();
            //Exercise_15();
            //Exercise_16();
            //Exercise_17();
            //Exercise_18();
            Exercise_19();
            //Exercise_20();

        }

        public static void Exercise_01()
        //1. Tinh tong cua hai so.
        {
            Console.Write("Nhap vao mot so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mot so b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"Tong cua hai so la: {a} + {b} = {sum}");
        }
        public static void Exercise_02()
        //2. Chuyen doi feet sang meter.
        {
            Console.Write("Nhap vao so feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"{feet} feet tuong ung voi {meter} meters.");
        }
        public static void Exercise_03()
        //3. Tim kich thuoc cua kieu du lieu.
        {
            int x = sizeof(int);
            Console.WriteLine($"Kich thuoc cua kieu int: {x}");
            int y = sizeof(double);
            Console.WriteLine($"Kich thuoc cua kieu int: {y}");
            int z = sizeof(char);
            Console.WriteLine($"Kich thuoc cua kieu int: {z}");
            int t = sizeof(bool);
            Console.WriteLine($"Kich thuoc cua kieu int: {t}");
        }
        public static void Exercise_04()
        //4. to Print ASCII Value (tip: read character, print number of this char).
        {
            Console.Write("Nhap vao mot ky tu: ");
            char input = char.Parse(Console.ReadLine());
            int ASCIIVal = (int)input;
            Console.WriteLine($"Gia tri cua {input} trong bang ma ASCII la: {ASCIIVal}");
        }
        
        public static void Exercise_05()
        //5. Chuyen ngay sang ngay, tuan, nam.
        {
            Console.Write("Nhap vao so ngay: ");
            int day = int.Parse(Console.ReadLine());
            int year = day / 365;
            int day_w = day % 365;
            int week = day_w / 7;
            int day_d = day_w % 7;
            Console.WriteLine($"{day} ngay tuong duong voi: {year} nam, {week} tuan va {day_d} ngay.");
        }
        public static void Exercise_06()
        //6. Write a C# program to display certain values of the function x = y^2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        {
            Console.Write("Nhap vao mot so y (y nam trong khoang tu -5 den 5): ");
            int y = int.Parse(Console.ReadLine());
           
            {
            if (y >= -5 && y <=5)
            {
                double x = Math.Pow(y,2) + (2*y) + 1;
                Console.WriteLine($"Ta co gia tri bieu thuc: x= y^2 + 2y + 1 = {x}");
            }
            else
                Console.WriteLine("Vui long nhap so trong khoang tu -5 den 5.");
            
            }
        }
        public static void Exercise_07()
        //7. Write a C# program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
        {
            Console.Write("Nhap vao khoang cach (km): ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao loai thoi gian (hours, minutes, seconds): ");
            string timeFormat = Console.ReadLine();
            Console.Write("Nhap vao thoi gian (number): ");
            double time = double.Parse(Console.ReadLine());
            double TimeinHours;
            double miles = km / 1609344;
            if (timeFormat.Contains("minutes"))
            {
                TimeinHours = time /60;
            }
            else if (timeFormat.Contains("seconds"))
            {
                TimeinHours = time / 3600;
            }
            else 
            {
                TimeinHours = time;
            }
            double speed_1 = km / TimeinHours;
            double speed_2 = miles / TimeinHours;
            Console.Write($"Toc do trong km/h la: {speed_1}");
            Console.WriteLine($"Toc do trong miles/h la: {speed_2}");
        }
        public static void Exercise_08()
        //Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        {
            Console.Write("Nhap vao mot ki tu: ");
            char input = char.Parse(Console.ReadLine());
            if(char.IsDigit(input))
                Console.WriteLine("Ky tu nhap vao la mot chu so.");
            else if(char.IsLetter(input))
                Console.WriteLine("Ky tu nhap vao la mot chu cai.");
            else
                Console.WriteLine("Ky tu nhap vao la mot ky tu khac.");

        }
        public static void Exercise_09()
        //9. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        {
            Console.Write("Nhap vao do dai ba canh cua tam giac: ");
            Console.Write("Do dai canh a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Do dai canh b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Do dai canh c: ");
            double c = double.Parse(Console.ReadLine());
            if (a <=0 || b <=0 || c<=0)
            {
                Console.WriteLine("Ba canh cua tam giac phai lon hon 0.");
            }
            else if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b & b == c)
                    Console.WriteLine("Day la tam giac deu.");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Day la tam giac can.");
                else
                    Console.WriteLine("Day la tam giac thuong.");
            }
            else 
                Console.WriteLine("Day khong phai ba canh cua mot tam giac.");
        }
        public static void Exercise_10()
        ////10. Write a program to read 10 numbers and find their average and sum.
        {
            Console.WriteLine("Nhap vao 10 so nguyen bat ki: ");
            double sum = 0;
            double average = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"So thu {i} la: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            average = sum / 10;
            Console.Write($"Tong cua 10 so la: {sum}");
            Console.WriteLine($"Trung binh cong cua 10 so la: {average}");
        }
        public static void Exercise_11()
        //11. Write a program to display the multiplication table of a given integer.
        {
            Console.Write("Nhap vao mot so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong cua {num} la: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
            
        }
        public static void Exercise_12()
        //12. Write a program to display a pattern like triangles with a number.
        {
            Console.Write("Nhap vao so dong cua tam giac: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j< rows; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Exercise_13()
        //13. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms.
        {
            Console.Write("Nhap vao so hang n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <=n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
                double sohang = 1.0 / i;
                sum += sohang;
            }
            Console.WriteLine($" = {sum}");
        }
        public static void Exercise_14()
        //14. Kiem tra so nguyen to.
        {
            bool KtraSoNgto(int a)
            {
                if (a <= 1) 
                return false;
                for (int i = 2; i <= (a/2); i++)
                {
                    if (a % i == 0)
                    return false; 
                }
                return true;
            }
            Console.Write("Nhap vao mot so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 1)
                Console.WriteLine("2 la so nguyen to nho nhat. Vui long nhap so nguyen lon hon hoac bang 2");
            if (KtraSoNgto(num))
                Console.WriteLine($"{num} la so nguyen to.");
            else 
                Console.WriteLine($"{num} khong phai la so nguyen to.");
        }
        public static void Exercise_15()
        //15. Kiem tra so hoan hao.
        {
            bool KtraSoHoanHao (int a)
            {
                int sum = 0;
                if (a <= 0) return false;
                for (int i = 1; i <= (a/2); i++)
                {
                    if (a % i == 0)
                    {
                        sum += i; 
                    }
                }
                return sum == a;
            }
            Console.Write("Nhap vao mot so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
                Console.WriteLine("So hoan hao la so nguyen duong.");
            if (KtraSoHoanHao(num))
                Console.WriteLine($"{num} la so hoan hao.");
            else 
                Console.WriteLine($"{num} khong phai la so hoan hao.");
        }
        public static void Exercise_16()
        //16. Tim GTLN trong 3 so.
        {
            Console.Write("Nhap vao so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = Max2Num(Max2Num(a,b),c);

            static int Max2Num(int a, int b)
            {
                if (a>b)
                    return a;
                else 
                    return b;
            }

            static int Max3Num(int a, int b, int c)
            {
                return Max2Num(Max2Num(a,b),c);
            }
            Console.WriteLine($"Gia tri lon nhat trong ba so da nhap la: {max}");
        }
        public static void Exercise_17()
        //17. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        {
            Console.Write("Nhap vao mot so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            if (num < 0)
                Console.WriteLine("So nguyen am khong co giai thua.");
            else if (num == 0)
                Console.WriteLine("Giai thua cua 0 la: 0! = 1");
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Giai thua cua {num} la: {num}! = {factorial}");
            }
        }
        public static void Exercise_18()
        //a. all prime numbers that less than a number (enter prompt keyboard).
        //b. the first N prime numbers.
        {
            Console.Write("a. Nhap vao mot so nguyen: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("b. Nhap vao mot so nguyen N bat ky: ");
            int N = int.Parse(Console.ReadLine());
            PrimeLessThanNum(num);
            firstNPrime(N);

            static bool KtraNgto (int a)
            {
                if (a <= 1) return false;
                for (int i = 2; i <= (a/2); i++)
                {
                    if (a % i == 0) 
                    return false;
                }
                return true;
            }
            
            static void PrimeLessThanNum(int num)
            {
                if (num <= 1)
                    Console.WriteLine("a. Khong co so nguyen to nao nho hon so da nhap.");
                else
                {
                    Console.Write($"a. Cac so nguyen to nho hon {num} la: ");
                    for (int i = 2; i <= num; i++)
                    {
                        if (KtraNgto(i))
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void firstNPrime(int N)
            {
               
                int a = 2;
                int count = 0;
                Console.WriteLine($"{N} so nguyen to dau tien la: ");
                while (count < N)
                {
                    if (KtraNgto(a))
                    {
                        Console.Write(a + " ");
                        count++;

                    }
                    a++;
                }
            }
        }
        public static void Exercise_19()
        //Enter item values for this array and Print the array to screen.
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //NhapMangNgauNhien(a);
            NhapMangTuBanPhim(a);
            InMang(a);
            sum(a);
            TimSoTrongMang(a);
            max(a);
            /*static void NhapMangNgauNhien(int[] a)
            {4
        
                Random random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(100);
                }
            } */
            static void NhapMangTuBanPhim(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Nhap vao phan tu thu {i}: ");
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            static void InMang(int[] a)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();

            }
            static void sum(int[] a)
            {
                int sum = 0;
                for(int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                    double average = (double) sum / a.Length;
                    Console.WriteLine($"Tong cac phan tu cua mang la: {sum}");
                    Console.WriteLine($"Trung binh cac phan tu cua mang la: {average}");
            }
            static void TimSoTrongMang(int[] a)
            {
                Console.Write("Nhap vao so can tim trong mang: ");
                int n = int.Parse(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == n)
                    {
                        Console.WriteLine($"{n} o vi tri thu {i} trong mang.");
                        found = true;
                        break;
                    }
                }
                if(!found)
                {
                        Console.WriteLine($"{n} khong co trong mang.");

                }
            }
            static void max(int[] a)
            {
                int max = a[0];
                foreach (int num in a)
                {
                    if (num > max) max = num;
                }
                Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
            }
        }
        /*static int menu()
        {
            Console.WriteLine("_____MENU_____");
            Console.WriteLine("1. In ra ma tran da nhap.");
            Console.WriteLine("2. In ra phan tu lon nhat, nho nhat tren moi dong.");
            Console.WriteLine("3. In ra phan tu lon nhat, nho nhat tren toan bo ma tran.");
            Console.WriteLine("4. Sap xep cac dong theo thu tu tang dan.");
            Console.WriteLine("5. In ra cac phan tu cua dong la so nguyen to.");
            Console.Write("Vui long chon chuc nang tu 1 den 5: ");
            int sel;
            do
            {
                bool r = int.TryParse(Console.ReadLine(), out sel);  //ep kieu gia tri nhap vao (r) thanh so nguyen int, va gan no cho sel.
                if (!r || sel < 1 || sel > 5)
                    Console.WriteLine("Vui long nhap cho dung.");
                else
                    break;
            } while (true);
            return sel;
        } */
    }
}
