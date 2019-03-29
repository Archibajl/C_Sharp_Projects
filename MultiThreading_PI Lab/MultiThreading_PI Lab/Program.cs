using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_PI_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3;
            int oddFraction1 = 1;
            int oddFraction2 = 100001;
            int oddFraction3 = 200001;
            int oddFraction4 = 400001;

            Thread Calculator1 = new Thread(() => {
                for(int i =3; i<= 100000; i+= 2)
                {
                    oddFraction1 += oddFraction1 + 2;
                    Pi += (1 / Convert.ToDouble(oddFraction1));
                }                
            });
            Thread Calculator2 = new Thread(() => {
                for (int i =100001; i <= 200000; i += 2)
                {
                    oddFraction2 += oddFraction2 + 2;
                    Pi += ( 1/ Convert.ToDouble(oddFraction2));
                }                
            });
            Thread Calculator3 = new Thread(() => {
                for (int i = 200001; i <= 300000; i += 2)
                {
                    oddFraction3 += oddFraction3 + 2;
                    Pi += (1 / Convert.ToDouble(oddFraction3));
                }                
            });
            Thread Calculator4 = new Thread(() => {
                for (int i = 300001; i <= 400000; i += 2)
                {
                    oddFraction4 += oddFraction4 + 2;
                    Pi += (1 / Convert.ToDouble(oddFraction4));
                }                
            });

            Calculator1.Start();
            Calculator2.Start();
            Calculator3.Start();
            Calculator4.Start();
            Console.WriteLine($"{Pi}");
            Console.ReadKey();
        }
    }
}
