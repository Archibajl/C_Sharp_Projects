using System;
using System.Collections;
using static System.Console;

namespace InitialSet_IntroAsmnt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calls Cal = new Calls();
            Program Pro = new Program();

            string InLine = "";
            
            double Transfer;
            bool exit = false;
            WriteLine("Enter a number (integer) from 1 to 5 to run each program \n" +
                "Enter 1 to Convert from Fahrenheit to Celsius. \n"+
                "Enter 2 to Calculate the volume of a circle from a radius. \n" +
                "Enter 3 to see what numbers between a number and 0 are multiples of 3 or 5. \n"+
                "Enter 4 to determine if an input is a Palindrome. \n" +
                "Enter 5 to exit the program \n");
            while (exit == false)
            {
                int KeyInput = 0;
                WriteLine("Enter a umber between 1 and 5.");
                InLine = ReadLine();
                //Calls the required functions to return a number and run each method.
                Transfer = Cal.TestVal(InLine);
                KeyInput = Convert.ToInt32(Transfer);

                //OutLine = Pro.Output(KeyInput, exit);
                WriteLine(Pro.Output(KeyInput, ref exit) + "\n \n");
            }
        }


        private string Output(int KeyIn, ref bool Exit)
        {
            Calls Cal = new Calls();
            string Ret1 = "0";           
            
            //Checks the input and runs the appropriate function.
            switch (KeyIn)
            {

                case 1:
                    Ret1 = Cal.TempConverter();
                    break;
                case 2:
                    Ret1 = Cal.SphereVolume();
                    break;
                case 3:
                    Ret1 = Cal.Multiple();
                    break;
                case 4:
                    Ret1 = Cal.IsPallindrome();
                    break;
                case 5:
                    Ret1 = "Exiting";
                    Exit = true;
                    break;
                default:
                    WriteLine("The number must be an integer between 1 and 5.");
                    break;
            }
            return Ret1;
        }
    }
}


