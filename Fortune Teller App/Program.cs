using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_App
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            
            
            
           
            int yearsTilRet;
            string sibTotal;
            string carColor;
            string bankMoney;
            

            
            string userFirstName;

            Console.WriteLine("What is your first name?");
            userFirstName = Console.ReadLine();



            string userLastName;

            Console.WriteLine("What is your last name?");
            userLastName = Console.ReadLine();


            int userAge;

            Console.WriteLine("What is your age?");
            userAge = int.Parse(Console.ReadLine());


            int userBirthMonth;

            Console.WriteLine("What is your birth month (1-12)");  
            userBirthMonth = int.Parse(Console.ReadLine());



            string userfavColor;

            Console.WriteLine("Enter your favorite ROYGBIV color? (If you do not know ROYGBIV, enter \"Help\"");

            userfavColor = Console.ReadLine();
           
            /*
            // No response with lower case "help"
            string help1 = "Help";
            string help2 = "help";
            bool strH = (help1 == help2);
            bool strH2 = help1.Equals(help2,StringComparison.CurrentCultureIgnoreCase);
            */

            if (userfavColor == "Help")
                
            {
                Console.WriteLine("Red \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet \nPlease enter your favorite ROYGBIV color listed above.");
                userfavColor = Console.ReadLine();
            }



            int userSiblings;

            Console.WriteLine("How many siblings do you have?");
            userSiblings = int.Parse(Console.ReadLine());

            
            if (userAge % 2 == 0)
            {
                yearsTilRet = 10;
            }
            else
            {
                yearsTilRet = 20;

            }

            
            if (userSiblings == 0)
            {
                sibTotal = "Miami";

            }

            else if (userSiblings == 1)
            {
                sibTotal = "Hawaii";
            }

            else if (userSiblings == 2)
            {
                sibTotal = "Mexico";
            }

            else if (userSiblings == 3)
            {
                sibTotal = "Denver";
            }

            else if (userSiblings >= 4)
            {
                sibTotal = "Dallas";
            }

            else
            {
                sibTotal = "garbage can";
            }

            // Color selection

            if (userfavColor == "Red")
            {
                carColor = "Corvette";
            }

            else if (userfavColor == "Orange")
            {
                carColor = "Explorer";
            }

            else if (userfavColor == "Yellow")
            {
                carColor = "BMW";
            }

            else if (userfavColor == "Green")
            {
                carColor = "VW";
            }

            else if (userfavColor == "Blue")
            {
                carColor = "Chevy";
            }

            else if (userfavColor == "Indigo")
            {
                carColor = "Honda";

            }

            else if (userfavColor == "Violet")
            {
                carColor = "Nissan";

            }

            else
            {
                carColor = "Running Shoes";
            }

            if (userBirthMonth >0 && userBirthMonth <= 4)
            {
                bankMoney = "$10";

            }

            else if (userBirthMonth > 4 && userBirthMonth <= 8)
            {
                bankMoney = "$50";

            }

            else if (userBirthMonth > 8 && userBirthMonth <= 12)
            {
                bankMoney = "$20,000,000";
            }

            else
            {

                bankMoney = "$0";
            }

            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank, a vacation home in {4} and a {5}.", userFirstName, userLastName, yearsTilRet, bankMoney, sibTotal, carColor);

        }
    }
}
