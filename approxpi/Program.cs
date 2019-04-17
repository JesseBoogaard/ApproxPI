using System;

namespace approxpi {
    class Program {
        static void Main(string[] args) {
            int j = 0;
            int Range = 100000000;
            int tries = 10000000;
            for(int i = 0; i < tries; i++) {
                if (GCD(RandomNumberInRange(Range), RandomNumberInRange(Range)) == 1) {
                    j++;
                }
            }
            Console.WriteLine(CalcPi(j, tries) + " <- Approximation of PI");
            Console.WriteLine(Math.PI + " <- PI");
            Console.ReadKey();
        }

        static uint RandomNumberInRange(int Range) {
            Random r = new Random();
            uint res = Convert.ToUInt32(r.Next(Range));
            return res;
        }

        static uint GCD(uint x, uint y) {
            while(x != 0 && y != 0) {
                if(x > y) {
                    x %= y;
                } else {
                    y %= x;
                }
            }
            return x == 0 ? y : x;
        }

        static decimal CalcPi(int x, int tries) {
            double y = (double)x / (double)tries;
            return Convert.ToDecimal(Math.Sqrt(6 / y));
        }
    }

}
