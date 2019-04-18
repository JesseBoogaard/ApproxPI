using System;

namespace approxpi {
    class Program {
        static void Main(string[] args) {
            int j = 0;
            int r = 2000000000;
            int t = 10000000;
            for(int i = 0; i < t; i++) {
                if (GCD(RandomNumberInRange(r), RandomNumberInRange(r)) == 1) {
                    j++;
                }
            }
            Console.WriteLine(CalcPi(j, t) + " <- Approximation of PI");
            Console.WriteLine(Math.PI + " <- PI");
            Console.ReadKey();
        }

        static uint RandomNumberInRange(int r) {
            Random Rand = new Random();
            uint res = Convert.ToUInt32(Rand.Next(r));
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

        static decimal CalcPi(int x, int t) {
            double y = (double)x / (double)t;
            return Convert.ToDecimal(Math.Sqrt(6 / y));
        }
    }

}
