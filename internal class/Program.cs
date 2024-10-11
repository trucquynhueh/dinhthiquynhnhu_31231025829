namespace internal_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string name = "Quynh Nhu";
                int age = 19;
                string add = "59 NVT";
                //concatenate
                Console.WriteLine("My name is "   + name +   ", age "   + age +   ", address "   + add);
                //composite
                Console.WriteLine("My name is {0}, age {1}, address {2}", name, age, add);
                //interpolation
                Console.WriteLine($"My name is {name}, age {age}, address {add}");


                Console.Write("Nhap mot chuoi:");
                string chuoi = Console.ReadLine();
                Console.WriteLine($"Chuoi vua nhap la:{chuoi}");


                Console.Write("Nhap mot so nguyen:");
                string chu_so = Console.ReadLine(); 
                int so = Convert.ToInt32(chu_so);
                int Ketqua = so * 10;
                Console.WriteLine($"Ket qua la:{Ketqua}");

                //dừng màn hình kết quả, chờ nhập một phím rồi mới thoát
                Console.ReadKey();

            // bugs (errors) -> debugging: giải lỗi
            // tips: đưa trỏ vào code -> hiện gì đó ai bit k nhìn thấy
            // call stack: báo lỗi dòng mấy, file nào

            //comment trong một dòng

            /*
             * 
             * comment nhiều dòng
             * 
             */

            /// <summary>
            /// giải thích một cách ngắn gọn mục tiêu và tác dụng của hàm
            /// </summary>


        }

    }

}

