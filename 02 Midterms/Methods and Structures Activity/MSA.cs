/*
 *  C# Console Application
 *  Methods and Structures Activity - MSA.cs
 *  Computer Programming 3
 */

using System;

namespace MSA {


    class MSAProgram {
        
        public static bool THING = true;

        static void ExitPrompt() {
            
            Console.WriteLine("Go back to main menu? [y/N]");
            string usrInputExt = Console.ReadLine();

            if ( usrInputExt == "y" || usrInputExt == "Y" ) {
                
                mainMenu();

            }

            THING = false;
        }


    //  ========== //  ========== //  ========== //  ========== //  ========== //  ========== //


        public string nameAndGreeting(string firstName) {

            string fName = firstName;
            return fName;

        }

        public string nameAndGreeting(string firstName, string lastName) {

            string fullName = firstName + " " + lastName;
            return fullName;

        }

        public string nameAndGreeting(string greetingMessage, string firstName, string lastName) {

            string GreetingMSG = greetingMessage + firstName + " " + lastName;
            return GreetingMSG;

        }


    //  ========== //  ========== //  ========== //  ========== //  ========== //  ========== //


        public float ItemPrice(float itemQuantity) {

            float numOfItems = itemQuantity;
            return numOfItems;

        }

        public float ItemPrice(float itemQuantity, float itemCost) {

            float ItemCost = itemQuantity * itemCost;
            return ItemCost;

        }


    //  ========== //  ========== //  ========== //  ========== //  ========== //  ========== //


        static void nameAndGreetingPrompt() {

            MSAProgram NGP = new MSAProgram();

            Console.Clear();
            Console.Write("Enter First Name: ");
            string usrInput_FirstName = Console.ReadLine();

            Console.Clear();
            Console.Write("Enter Last Name: ");
            string usrInput_LastName = Console.ReadLine();

            string MSG = "Yo whats up! Welcome ";
            string usrInput_FullName = NGP.nameAndGreeting(MSG, usrInput_FirstName, usrInput_LastName);

            Console.Clear();
            Console.WriteLine(usrInput_FullName);
            ExitPrompt();

        }

        static void itemPricePrompt() {

            MSAProgram itemPrice = new MSAProgram();

            Console.Clear();
            Console.Write("Enter item quantity: ");
            float usrInput_itemQuantity = Convert.ToSingle(Console.ReadLine());

            Console.Clear();
            Console.Write("Enter item price: ");
            float usrInput_itemPrice = Convert.ToSingle(Console.ReadLine());

            float TotalItemPrice = itemPrice.ItemPrice(usrInput_itemQuantity, usrInput_itemPrice);

            string MSG = "The total price of ";
            MSG += usrInput_itemQuantity;
            MSG += " is ";
            MSG += TotalItemPrice;

            Console.Clear();
            Console.WriteLine(MSG);
            ExitPrompt();

        }


    //  ========== //  ========== //  ========== //  ========== //  ========== //  ========== //


        static void mainMenu() {
            
            do {

                Console.Clear();
                string Dialogue = "Which Activity do you want to access?\n";
                Dialogue += "1. Activity 1: Names and Greetings\n";
                Dialogue += "2. Activity 2: Total Item Price\n";
                Dialogue += "3. Quit Program\n\n";
                Dialogue += "User Input [1-3]: ";

                Console.Write(Dialogue);

                try {
                    
                    int usrInput = Convert.ToInt32(Console.ReadLine());

                    if ( usrInput == 1 ) {
                        nameAndGreetingPrompt();
                    }

                    if ( usrInput == 2 ) {
                        itemPricePrompt();
                    }

                    if ( usrInput == 3 ) {
                        Console.Write("Bye bye~");
                        THING = false;
                    }

                } catch ( Exception e ) {
                    Console.WriteLine("Enter something pls...");
                    Thread.Sleep(2000);
                    mainMenu();
                }

            } while ( THING == true);

        }


    //  ========== //  ========== //  ========== //  ========== //  ========== //  ========== //


        static void Main(string[] args) {
            mainMenu();
        }

    }
}