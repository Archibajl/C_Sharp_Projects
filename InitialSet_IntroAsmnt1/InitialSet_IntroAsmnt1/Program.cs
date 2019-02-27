using System;
using System.Collections;
using static System.Console;

namespace InitialSet_IntroAsmnt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string InLine = "";
                string OutLine;
            double Transfer;
            bool exit = false;
            while (exit == false) {
                int KeyInput = 0;
                
                WriteLine("Enter a umber between 1 and 5.");                
                InLine = ReadLine();
                Transfer = TestVal( InLine);
                KeyInput = Convert.ToInt32(Transfer);
                
                OutLine = Output(KeyInput, exit);
                WriteLine(Output(KeyInput, exit));
            }
        }
        string Output(int KeyIn, bool Exit)
        {
            string Ret1 = "0";

            switch (KeyIn)
            {               

                case '1':
                    Ret1 = TempConverter();
                    break;
                case '2':
                    Ret1 = SphereVolume();
                    break;
                case '3':
                    Ret1 = Multiple();
                    break;
                case '4':
                    Ret1 = IsPallindrome();
                    break;
                default:
                    WriteLine("The number must be between 1 and 5.");
                    break;
                }
            return Ret1;
        }

        //Converts from Farenheight to Celcius
        String TempConverter()
        {
            string inVal, outVal;            
            double CVal, FVal;
            WriteLine("Enter a temperature in Fahrenheit to convert to Celsius.");
            inVal = ReadLine();
            //Converts from string to Decimal
            FVal = TestVal(inVal);
            //Returns the temperature converted to Celsius.
            CVal = (FVal - 32) / 1.8;
            outVal = Convert.ToString(CVal) + " degrese Celsius";
            return outVal; 
        }

        String SphereVolume()
        {
            string inVal = "0"; string outVal = "0";
            double Vol = 0;
            Vol = TestVal(inVal);
            Vol = Math.Pow(2, Vol) * Math.PI;
            return outVal;
        }

        string Multiple()
        {
            string inVal;
            string outVal = "0";


            return outVal;
        }

        //Checks if a word entered is the same forwards and backwards.
        //Checks for Pallindrome.
        string IsPallindrome()
        {
            string retVal = ""; string testVal;            
            WriteLine("Enter a word to test whether it is a Pallindrome or not.");
            testVal = ReadLine() ;
            //Testvalue initialized as length of input string.
            int i = (testVal.Length - 1);
            //Loops and adds the string in reverse to another string.
            while ( i != -1 && testVal.Substring(i) != " ")
            {
                retVal += testVal.Substring(i);
                i--;
            }

            //Tests the reverse string for pallindrome against orrigional.
            if (retVal == testVal)
            {
                retVal = retVal + " is a Pallindrome.";
            }
            else
            {
                retVal = retVal + " Is not Pallindrome.";
            }
            return retVal;
        }

        //Tests and returns an input as a number output.
        double TestVal(string Input)
        {
            double RetNum = 0;
            //Catches failures or errors in the conversion of the input to a decimal number.
                try { RetNum = Convert.ToDouble(Input); }
            catch (InvalidCastException e)
            {
                WriteLine("Invalid entry, You must enter a number.");
            }
            catch (ArgumentNullException e)
            {
                WriteLine("Invalid entry, You must enter a number.");
            }
            return RetNum;
        }
    }
}
