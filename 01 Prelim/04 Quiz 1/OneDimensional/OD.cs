/*
 *  C# Console Application
 *  04 Quiz 1 - OneDimensional.cs
 *  Computer Programming 4
 */

using System;

namespace OneDimension
{
  class OneDimensionProgram
  {
    static void Main(String[] args)
    {
      string[] Names = { "Adriel", "Alex", "Carmen", "Jay", "Jeremiah", "Rose" };

      foreach ( string ListNames in Names ) 
      {
        Console.WriteLine(ListNames);
      }
    }
  }
}

