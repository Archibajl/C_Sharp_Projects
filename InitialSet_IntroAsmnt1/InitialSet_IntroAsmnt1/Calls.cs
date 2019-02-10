using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InitialSet_IntroAsmnt1
{
    class Calls
    {

        //Converts from Farenheight to Celcius
        public string TempConverter()
        {
            string inVal, outVal;
            double CVal, FVal;
            WriteLine("Enter a temperature in Fahrenheit to convert to Celsius.");
            inVal = ReadLine();
            //Converts from string to Decimal
            FVal = TestVal( inVal);
            //Returns the temperature converted to Celsius.
            CVal = (FVal - 32) / 1.8;
            outVal = Convert.ToString(CVal) + " degrese Celsius";
            return outVal;
        }

        public string SphereVolume()
        {
            string inVal = "0"; string outVal = "The volume of your sphere is ";
            double Vol = 0;
            WriteLine("Enter the radius of a sphere to find the volume.");
            ReadLine();
            //converts and uses the radius input to calculate the volume of the sphere .
            Vol = TestVal( inVal);
            Vol = Math.Pow(2, Vol) * Math.PI;
            outVal += Convert.ToString(Vol) +".";
            return outVal;
        }

        public string Multiple()
        {
            string inVal = "0";
            double inNumber = 0;        
            string outVal = "Your numbers are ";
            //Asks for a number and shows all numbers between that number and zero that are mulbiples of 3 or 5. 
            WriteLine("Enter a number greater than 0 to see the multiples of 3 or 5 between your number and 0.");
            inVal = ReadLine();
            WriteLine("/n  your numbers are ");
            inNumber = TestVal(inVal);
            //tests every integer between the number and zero for even division by 3 and 5.
            for (double i = inNumber; i > 0; i--)
            {
                if ((0 == (i % 3))||(0 == (i % 5)))
                {
                    outVal += Convert.ToString(i) + " ";
                }
            }
            outVal += ".";
            return outVal;
        }

        //Checks if a word entered is the same forwards and backwards.
        //Checks for Pallindrome.
        public string IsPallindrome()
        {
            string retVal = ""; string testVal;
            WriteLine("Enter a word to test whether it is a Pallindrome or not.");
            testVal = ReadLine();
            //Testvalue initialized as length of input string.
            int i = (testVal.Length - 1);
            //Loops and adds the string in reverse to another string.
            while (i != -1 && testVal.Substring(i) != " ")
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
                retVal = retVal + " Is not a Pallindrome.";
            }
            return retVal;
        }

        //Tests and returns an input as a number output.
        public double TestVal(string Input)
        {            
            double RetNum = 0 ;
            bool fails;
            //Catches failures or errors in the conversion of the input to a decimal number.
             
            if (double.TryParse(Input, out RetNum) == false)
            {
                WriteLine("You must enter a number;");
            }
           
            return RetNum;
        }
    }
}

