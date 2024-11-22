
namespace internal_class
{
    internal class Session8
    {
        public static void Main(string[] args)
        {
            string s1 = "cho tui ve nha an tet, tui khong hoc nua dau!";
            //to input a string and print it.
            Console.WriteLine(s1);
            Console.WriteLine(len(s1));
            print(s1);
            Console.WriteLine();
            printReverse(s1);
            Console.WriteLine($"Tong cac tu cua chuoi la: {CountWords(s1)}");

            //to separate individual characters from a string.
            static void print(string s)
            {
                for (int i = 0; i < s.Length; i++) 
                {
                    Console.WriteLine(s[i]);
                }
            }
           
            //to find the length of a string without using a library function.
            static int len(string s)
            {
                int l = 0;
                foreach (char c in s)
                    l++;
                return l;
            }

            //to print individual characters of the string in reverse order.
            static void printReverse(string s)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(s[i]);    
                }
            }

            //to count the total number of words in a string.
            static void CountWords(string s)
            {
                int wordCount = 0;
                bool inWord = false;
                foreach (char c in s)
                {
                    if (Char.IsWhiteSpace(c))
                    {
                        if (inWord)
                        {
                            wordCount++;
                            inWord = false;
                        }
                    }
                    else
                    {
                        inWord = true;
                    }
                }
                if (inWord)
                    wordCount++;

                return wordCount;
            }
        

            //to compare two strings without using a string library functions.
        }
    }
}
