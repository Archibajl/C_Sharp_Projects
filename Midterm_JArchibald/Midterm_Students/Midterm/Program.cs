//Justin Archibald
//Midterm Project
//CS 3020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {               
        static void Main(string[] args)
        {
            int menuSelection = 0;
            VendingMachine machine = new VendingMachine();
            do
            {
                Console.WriteLine("Please enter an integer for the option you want to select:");
                Console.WriteLine("1. Print vending machine.");
                Console.WriteLine("2. List only healthy food and drink.");
                Console.WriteLine("3. List toy options for kids under 7.");
                Console.WriteLine("4. Exit Program");
                
                //Set this section to test for numeric input, prevents from user entered error.
                if (int.TryParse(Console.ReadLine(), out menuSelection))
                {

                    List<VendingMachineOption> exclusions = new List<VendingMachineOption>();

                    switch (menuSelection)
                    {
                        case 1:
                            machine.PrintVendingMachine(new List<VendingMachineOption>());
                            break;
                        case 2:
                            //returns every exclusion to a list of "exclusions", with the exception of food items under 100 calories
                            exclusions =
                            (
                                from ex in machine
                                where ((ex is Food) || (ex is Drink)) ? ((ex as Food)?.CalorieCount > 100 || (ex as Drink)?.CalorieCount > 100) : true
                                select ex
                            ).ToList();

                            machine.PrintVendingMachine(exclusions);
                            break;
                        case 3:
                            //returns every exclusion to a list of "exclusions", with the exception of toys with an age requirement of under 7
                            exclusions =
                           (
                               from ex in machine
                               where ((ex is NonElectronic) || (ex is Electronic)) ?
                               ((ex as NonElectronic)?.AgeRequirement >= 7 || (ex as Electronic)?.AgeRequirement >= 7) :
                               true
                               select ex
                           ).ToList();

                            machine.PrintVendingMachine(exclusions);
                            break;
                        case 4:
                            Console.WriteLine("Thankyou for using this program!");
                            Console.ReadKey();
                            break;
                        default:    //returns for improper numeric input.
                            Console.WriteLine("Improper input, try again.");
                            break;
                    }
                }else {
                    Console.WriteLine("You entered an incorrect value, try a correct one."); }                    
                
            } while (menuSelection != 4);
        }

        static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
