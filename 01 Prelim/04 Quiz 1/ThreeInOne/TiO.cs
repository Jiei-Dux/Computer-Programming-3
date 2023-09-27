/*
 *  C# Console Program
 *  04 Quiz 1 - ThreeInOne.cs
 *  Computer Programming 3
 */

using System;

namespace THREEinONE
{
  class THREEinONE_Program
  {
    public static bool Stuff = true;

    static void Prompt()
    {
      Console.WriteLine("Go back to main menu? [y/N]");
      string usrInputExt = Console.ReadLine();

      if ( usrInputExt == "y" || usrInputExt == "Y" )
      {
        mainMenu();
      }

      Environment.Exit(0);
    }

    static void OneDimension()
    {
      string[] Names = { "Adriel", "Alex", "Carmen", "Jay", "Jeremiah", "Rose" };

      foreach ( string ListNames in Names ) 
      {
        Console.WriteLine(ListNames);
      }

      Prompt();
    }

    static void TwoDimension()
    {
      char[,] F6 = { {'A', 'B', 'C'}, {'D', 'E', 'F'} };

      foreach (char x in F6)
      {
        Console.Write(x + " ");
      }

      Console.WriteLine();
      Prompt();
    }

    private static void StringChecker()
    {
      Console.WriteLine("Enter a sentence or paragraph below:");
      string usrInputSC = Console.ReadLine();

      bool helloExists = usrInputSC.Contains("hello");

      if ( helloExists == true )
      {
        Console.WriteLine($"The sentence does contain the word: \"hello\"");

        Prompt();
      }

      if ( helloExists == false )
      {
        Console.WriteLine($"The sentence / paragraph does not contain the word: \"hello\"");
        Console.ReadKey();
        Prompt();
      }
    }

    static void mainMenu()
    {
      do
      {
        Console.Clear();
        string Dialogue = "Choose what you want to access: \n";
        Dialogue += "a. One Dimensional Array\n";
        Dialogue += "b. Two Dimensional Array\n";
        Dialogue += "c. String Checker\n";
        Dialogue += "e. Exit\n";
        Dialogue += "User Input: ";
        Console.Write(Dialogue);
      
        string usrInput = Console.ReadLine();

        if ( usrInput == "a" || usrInput == "A" )
        {
          Console.Clear();
          OneDimension();
        }

        if ( usrInput == "b" || usrInput == "B" )
        {
          Console.Clear();
          TwoDimension();
        }

        if ( usrInput == "c" || usrInput == "C" )
        {
          Console.Clear();
          StringChecker();
        }

        if ( usrInput == "e" || usrInput == "E" )
        {
          Console.WriteLine("Aight...");
          Environment.Exit(0);
        }
      } while ( Stuff = true );
    }

    static void Main(string[] args)
    {
      mainMenu();
    }
  }
}

