/*
 *  C# Console Program
 *  04 Quiz 1 - StringChecker.cs
 *  Computer Programming 3
 */

using System;

namespace StringChecker
{
  class StringCheckingProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a sentence or paragraph below:");
      string usrInput = Console.ReadLine();

      bool helloExists = usrInput.Contains("hello");

      if ( helloExists == true )
      {
        Console.WriteLine($"The sentence does contain the word: \"hello\"");

        Console.ReadKey();
        Environment.Exit(0);
      }

      Console.WriteLine($"The sentence / paragraph does not contain the word: \"hello\"");
      Console.ReadKey();
      Environment.Exit(1);
    }
  }
}
