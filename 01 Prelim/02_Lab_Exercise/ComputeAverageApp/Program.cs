using System;

namespace ComputeAverageApp {

  class ComputeAverageProgram {

    static void Main(String[] args) {

      Console.WriteLine("Enter five(5) grades separated by a new line: ");
      
      double[] Grades = new double[5];

      int arrayNum = 0;

      do {
        Grades[arrayNum] = Convert.ToDouble(Console.ReadLine());
        arrayNum++;
      } while (arrayNum < Grades.Length);

      double GradeAdd = 0;
      foreach (double usrInput in Grades) {
        GradeAdd += usrInput;
      }

      double Avg = GradeAdd / Grades.Length;
      int RoundOff = Convert.ToInt32(Math.Round(Avg));

      Console.WriteLine("The average is " + Avg + " and got rounded off to " + RoundOff);

      Console.WriteLine("Press ANY key to exit...");
      Console.ReadKey();

    }

  }

}
