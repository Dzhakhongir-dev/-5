using System;

namespace Домашка5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1) Разбор предложения в обратном порядке!" +
                                "\n2) Разделение предложения на Слова!" +
                                "\n3) Разделение Слова на буквы!");

                string choiseInput = Console.ReadLine();
                Console.Clear();

                switch (choiseInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Введите желаемое предложение, чтоб вывести в обратном порядке!");

                        string reverseInput = Console.ReadLine();

                        ReverseWords(reverseInput);

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Введите желаемое предложение, чтоб разделить на слова!");

                        string splitInput = Console.ReadLine();

                        StringSpliter(splitInput);

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Введите желаемое предложение, чтоб разделить на буквы!");

                        string splitIntoLetters = Console.ReadLine();

                        SplitToLetters(splitIntoLetters);

                        break;
                }
            }
        }
        public static string[] ReverseWords(string reverseInput)
        {
            string stringReverse = " ";

            char[] inputStringChars = reverseInput.ToCharArray();
            var inputStringLenght = inputStringChars.Length;


            for (int i = inputStringLenght - 1; i >= 0; i--)
            {
                stringReverse += reverseInput[i];
            }

            StringSpliter(stringReverse);

            Console.WriteLine(stringReverse);

            return stringReverse.Split(' ');

        }
        public static string[] StringSpliter(string splitInput)
        {
            char[] charArray = splitInput.ToCharArray();


            foreach (var item in splitInput.Split())
            {
                Console.WriteLine(item);
            }
            return splitInput.Split(charArray);
        }
        public static string[] SplitToLetters(string splitInputToLetters)
        {
            char[] charArray = splitInputToLetters.ToCharArray();

            foreach (var item in charArray)
            {
                Console.WriteLine(item);
            }
            return splitInputToLetters.Split(charArray);
        }


    }
}
