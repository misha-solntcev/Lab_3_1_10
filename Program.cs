using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 10. Дано целое число N (> 1). Найти наибольшее целое 
    число K, при котором выполняется неравенство 3K < N.*/

namespace Lab_3_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 12;
            int K = 0;
            while (3 * K < N)
            {
                Console.WriteLine(K);
                K++;                
            }
            Console.ReadKey();
        }
    }
}
