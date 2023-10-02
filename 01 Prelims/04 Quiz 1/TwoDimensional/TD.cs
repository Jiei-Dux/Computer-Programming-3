/*
 *  C# Console Program
 *  04 Quiz 1 - TwoDimensional.cs
 *  Computer Programming 3
 */

using System;

namespace TwoDimensions
{
  class TwoDimensionProgram 
  {
    static void Main(string[] args) 
    {
      char[,] F6 = { {'A', 'B', 'C'}, {'D', 'E', 'F'} };

      foreach (char x in F6)
      {
        Console.Write(x + " ");
      }

      Console.WriteLine();
    }
  }
}
