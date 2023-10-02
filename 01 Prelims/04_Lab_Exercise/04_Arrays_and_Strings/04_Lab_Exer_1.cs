/*
 *  C# Console Program
 *  04 Laboratory Exercise 1 - AppleProgram.cs
 *  Computer Programming 3
 */

using System;

namespace BuyingApple
{
  class BuyingAppleProgram
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Console.Write("Enter the number of apples you want to purchase: ");
      int usrInput = Convert.ToInt32(Console.ReadLine());

      double ApplePrice = 32.50;
      double Price = ApplePrice * usrInput;
      int ConvertedPrice = Convert.ToInt32(Price);

      Console.WriteLine("\nThe total price of the " + usrInput + " apples is " + Price + ".");
      Console.WriteLine("The value of the converted price is " + ConvertedPrice);

      Console.Write("Press any key to exit...");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
