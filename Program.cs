using System;

namespace Домашка5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter words to Split");
      string input = Console.ReadLine();

      string inputPhrase = "";

      ReverseWords(inputPhrase);

      StringSpliter(input, inputPhrase);

    }
    public static string[] StringSpliter(string input, string inputPhrase)
    {
      foreach (var item in input.Split())
      {
        Console.WriteLine(item);
      }
      Console.WriteLine("\nPlease Enter String to Reverse Them");

      ReverseWords(inputPhrase);

      return input.Split(input);
    }
    public static string[] ReverseWords(string inputPhrase)
    {

      inputPhrase = Console.ReadLine();
      char[] inputStringChars = inputPhrase.ToCharArray();
      int inputStringLenght = inputStringChars.Length;

      string stringReverse = "";

      for (int i = inputStringLenght - 1; i >= 0; i--)
      {
        stringReverse += inputPhrase[i];
      }
      Console.WriteLine(stringReverse);
      return stringReverse.Split(inputPhrase);
    }

  }
}