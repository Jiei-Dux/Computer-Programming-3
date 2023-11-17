/* * * * * * * * * * * * * * * * * * * * * * * * * *
 *                                                 *
 * C# Winforms Application                         *
 * 09_Laboratory_Exercise - CalculatorApplication  *
 * Computer Programming 3                          *
 * Github: Jiei-Dux                                *
 *                                                 *
 * * * * * * * * * * * * * * * * * * * * * * * * * */

// Create a simple calculator. Name the project as "CalculatorApplication"  //
namespace CalculatorApplication
{
    // Name the form as "FrmCalculator" //
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();

            // Instantiate it inside the constructor of FrmCalculator           //
            cal = new CalculatorClass();
        }

        // In the "FrmCalculator" class, declare the variable for the           //
        // "CalculatorClass" named "cal".                                       //
        CalculatorClass cal;
        
        // Set the two(2) variables where the data types are *double* with      //
        // a variable named "num1" and "num2".                                  //
        double num1, num2;
        string Operator;

        // Double click the button to create the method for button event        //
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Get the value of *txtBoxInput1* for "num1" and *txtBoxInput2*    //
            // for "num2".
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            // In the "FrmCalculator" class, write a condition that validates   //
            // the selected arithmetic operator in the ComboBox. It should call //
            // the event and display the answer in a label.                     //
            Operator = cbOperator.Text;

            if ( Operator == null | Operator == "" | Operator == " " )
            {
                lblDisplayTotal.Text = "Please choose an operator...";
            }

            if ( Operator == "+" ) 
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }

            if ( Operator == "-" )
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }

            if ( Operator == "*" )
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }

            if  (Operator == "/" )
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }
        }
    }




    // Declare a generic delegate named "Formula" above the "CalculatorClass"   //
    public delegate T Formula <T> ( T txtBoxInput1, T txtBoxInput2 );

    // Create a class named "CalculatorClass"   //
    class CalculatorClass
    {
        // Inside the class, declare the generic delegate's variable and set its    //
        // data type to *double*.                                                   //
        public Formula<double> frmla;

        // After declaring the variable for the generic delegate, create two(2)     //
        // methods that return the sum and difference.                              //
        public double GetSum(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 + txtBoxInput2;
        }

        public double GetDifference(double txtBoxInput1, double txtBoxInput2) 
        {
            return txtBoxInput1 - txtBoxInput2;
        }

        // In "CalculatorClass", add two(2) return type methods named "GetProduct"  //
        // for multiplication and "GetQuotient" for division.                       //
        public double GetProduct(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 * txtBoxInput2;
        }

        public double GetQuotient(double txtBoxInput1, double txtBoxInput2)
        {
            if (txtBoxInput1 == 0) {
                throw new DivideByZeroException();
            }

            return txtBoxInput1 / txtBoxInput2;
        }

        // Add an event accessor named "CalculateEvent" with two(2) methods         //
        // "add" and "remove".                                                      //
        public event Formula<double> CalculateEvent
        {
            // Set a message in the console just to confirm if the delegate is      //
            // added or removed.                                                    //
            add { Console.WriteLine("Added the Delegate."); }

            remove { Console.WriteLine("Removed the Delegate."); }
        }
    }
}