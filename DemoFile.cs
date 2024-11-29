using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo
    {
        static void Main()
        {
            string path = "data.txt";
            string text = "";
            /*Random rnd=new Random();
            for (int i = 0; i < 50; i++)
            {
                text+= rnd.Next(100).ToString()+",";
            }
            writeText(path, text);*/

            /*text = readText(path);
            Console.WriteLine(text);
            long sum = sumData(text);
            Console.WriteLine(sum);*/
            string bPath = "data.bin";
            //writeBinary(bPath);
            readBinary(bPath);
        }

        static void writeText(string path, string text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(text);
            writer.Close();
        }
        static string readText(string path)
        {

            StreamReader reader = new StreamReader(path);
            string s = reader.ReadToEnd();
            reader.Close();
            return s;
        }

        static void writeBinary(string path)
        {
            FileStream fo = new FileStream(path, FileMode.OpenOrCreate);
            BinaryWriter binaryWriter=new BinaryWriter(fo, Encoding.UTF8);
            for (int i = 0; i <100;i++)
                binaryWriter.Write(i); //int32
            binaryWriter.Close();
        }
       
        static void readBinary(string path)
        {
            FileStream fo = new FileStream(path, FileMode.Open);
            BinaryReader binaryReader=new BinaryReader(fo);
            long sum = 0;
            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            {
                int so= binaryReader.ReadInt32();
                Console.Write(so+", ");
                sum += so;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

        static long sumData(string text)
        {
            long sum = 0;
            string[] items = text.Split(',');
            for (int i = 0; i < items.Length - 1; i++)
            {
                int so = int.Parse(items[i]);
                sum += so;
            }
            return sum;
        }
    }
}
