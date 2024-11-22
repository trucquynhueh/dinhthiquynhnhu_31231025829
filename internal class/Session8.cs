
using System.Globalization;

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
            CountCharactersType(s1);

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
            static int CountWords(string s)
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

            //to count the number of alphabets, digits and special characters in a string.
            static void CountCharactersType(string s)
            {
                int alphabets = 0, digits = 0, specialChars = 0;
                foreach (char c in s)
                {
                    if (Char.IsLetter(c)) alphabets++;
                    else if (Char.IsDigit(c)) digits++;
                    else specialChars++;
                }
                Console.WriteLine($"Chu cai: {alphabets}, chu so: {digits}, ky tu dac biet: {specialChars}");
            }
            //to count the number of vowels or consonants in a string.

            //to check whether a given substring is present in the given string.

            //to search for the position of a substring within a string.

            //to check whether a character is an alphabet and not and if so, check for the case.

            //to find the number of times a substring appears in a given string.

            //to insert a substring before the first occurrence of a string.

        }
    }
}
