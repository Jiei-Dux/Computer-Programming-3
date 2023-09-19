using System;

namespace DataTypesApp {

  class DataTypesProgram {

    static void Main(String[] args) {

      Console.Write("Enter the pieces of apple(s): ");
      int ApplePcs = Convert.ToInt32(Console.ReadLine());

      string TotalApples = ApplePcs + " apple(s)";

      Console.Write("Enter total price of " + TotalApples + ":");
      double ApplePrice = Convert.ToDouble(Console.ReadLine());
      int ConvertedApplePrice = Convert.ToInt32(ApplePrice);

      Console.WriteLine("The total price of " + TotalApples + " is " + ApplePrice);
      Console.WriteLine("Original Price: " + ApplePrice);
      Console.WriteLine("Converted Price: " + ConvertedApplePrice);

    }

  }

}
