using System;

namespace Домашка5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter words to Reverse");
            string input = Console.ReadLine();

            ReverseWords(input);
        }
        public static string[] ReverseWords(string inputPhrase)
        {
            char[] inputStringChars = inputPhrase.ToCharArray();
            int inputStringLenght = inputStringChars.Length;

            string stringReverse = "";

            for (int i = inputStringLenght - 1; i >= 0; i--)
            {
                stringReverse += inputPhrase[i];
            }
            Console.WriteLine(stringReverse);

            StringSpliter(inputPhrase);

            return stringReverse.Split(inputPhrase);
        }
        public static string[] StringSpliter(string input)
        {
            foreach (var item in input.Split())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            return input.Split(input);
        }
    }
}
