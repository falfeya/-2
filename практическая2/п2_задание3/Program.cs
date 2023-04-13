using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п2_задание3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int n = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;
            int i = 2;
            while (i <= n - 1)
            {
                if (n % i == 0)
                {                  
                    isPrime = false;
                    break;
                }
                i++;
            }
            if (isPrime)
            {
                Console.WriteLine($"{n} является простым числом.");
            }
            else
            {
                Console.WriteLine($"{n} не является простым числом.");
            }

            Console.ReadLine();
        }
    }
}
