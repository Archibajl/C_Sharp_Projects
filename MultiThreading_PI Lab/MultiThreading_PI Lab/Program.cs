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
                for(int i =0; i<= 100000; i+= 2)
                {
                    oddFraction1 += oddFraction1 + 2;
                }
                Pi += oddFraction1/10000;
            });
            Thread Calculator2 = new Thread(() => {
                for (int i = 0; i <= 100000; i += 2)
                {
                    oddFraction2 += oddFraction2 + 2;
                }
                Pi += oddFraction2 / 200000;
            });
            Thread Calculator3 = new Thread(() => {
                for (int i = 0; i <= 100000; i += 2)
                {
                    oddFraction3 += oddFraction3 + 2;
                }
                Pi += oddFraction2 / 300000;
            });
            Thread Calculator4 = new Thread(() => {
                for (int i = 0; i <= 100000; i += 2)
                {
                    oddFraction4 += oddFraction4 + 2;
                }
                Pi += oddFraction2 / 400000;
            });

        }
    }
}
