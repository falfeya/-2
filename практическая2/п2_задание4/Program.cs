using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п2_задание4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности:");
            int length = Convert.ToInt32(Console.ReadLine());

            int min = int.MaxValue; 

            Console.WriteLine("Введите целые числа последовательности (числа разделяются клавишей Enter):");
            for (int i = 0; i < length; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < min) 
                {
                    min = num; 
                }
            }

            Console.WriteLine($"Наименьший элемент в последовательности: {min}");
        }
    }
}
