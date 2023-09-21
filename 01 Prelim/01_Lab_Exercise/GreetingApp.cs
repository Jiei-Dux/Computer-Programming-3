/*
 *
 * C# Console Program
 * 01 Laboratory Exercise - GreetingApp.cs
 * Computer Programming 3
 *
 */

using System;

// MAIN CODE //
namespace GreetingApp {

  class GreetingProgram {

    static void Main(string[] args) {

      // VARIABLE DECLARATION //
      string usrName;
      int usrEnrolledCoursesCount;
      double usrFavBookPrice;

      // CONSOLE ASK USER FOR INPUT //
      Console.Write("Enter your name: ");
      usrName = Console.ReadLine();
      
      Console.Write("Enter the total number of your enrolled courses: ");
      usrEnrolledCoursesCount = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the price of your favorite book: ");
      usrFavBookPrice = Convert.ToDouble(Console.ReadLine());

      // PROGRAM PRINTS OUT USER INPUT //
      Console.WriteLine("Name: " + usrName);
      Console.WriteLine("Total enrolled courses: " + usrEnrolledCoursesCount);
      Console.WriteLine("Price of my favorite book: " + usrFavBookPrice);

      // EXIT //
      Console.Write("Press ANY key to exit...");
      Console.ReadKey();
      
    }

  }

}
