using System;

namespace ComputeAverageApp {

  class ComputeAverageProgram {

    static void Main(String[] args) {

      Console.WriteLine("Enter five(5) grades separated by a new line: ");
      double Gr1 = Convert.ToDouble(Console.ReadLine());
      double Gr2 = Convert.ToDouble(Console.ReadLine());
      double Gr3 = Convert.ToDouble(Console.ReadLine());
      double Gr4 = Convert.ToDouble(Console.ReadLine());
      double Gr5 = Convert.ToDouble(Console.ReadLine());

      double added = Gr1 + Gr2 + Gr3 + Gr4 + Gr5;
      double avg = added / 5;

      int RoundOff = Convert.ToInt32(Math.Round(avg));

      Console.WriteLine("The average is " + avg + " and round off to " + RoundOff );
      Console.Write("Press any key to exit...");
      Console.ReadKey();

    }

  }

}
