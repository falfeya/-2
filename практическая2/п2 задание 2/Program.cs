using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п2_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Здравствуйте, сколько карт у вас на руках? ");
            int hcards = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= hcards; i++)
            {
                Console.WriteLine($"Введите номинал {i}-й карты: ");
                string cvalue = Console.ReadLine();
                int value;
                switch (cvalue)
                {
                    case "2":
                        {
                            value = Convert.ToInt32(2);
                            sum = value + sum;
                            break;
                        }
                    case "3":
                        {
                            value = Convert.ToInt32(3);
                            sum = value + sum;
                            break;
                        }
                    case "4":
                        {
                            value = Convert.ToInt32(4);
                            sum = value + sum;
                            break;
                        }
                    case "5":
                        {
                            value = Convert.ToInt32(5);
                            sum = value + sum;
                            break;
                        }
                    case "6":
                        {
                            value = Convert.ToInt32(6);
                            sum = value + sum;
                            break;
                        }
                    case "7":
                        {
                            value = Convert.ToInt32(7);
                            sum = value + sum;
                            break;
                        }
                    case "8":
                        {
                            value = Convert.ToInt32(8);
                            sum = value + sum;
                            break;
                        }
                    case "9":
                        {
                            value = Convert.ToInt32(9);
                            sum = value + sum;
                            break;
                        }
                    case "10":
                        {
                            value = Convert.ToInt32(10);
                            sum = value + sum;
                            break;
                        }
                    case "J":
                        {
                            value = 10;
                            sum = value + sum;
                            break;
                        }
                    case "Q":
                        {
                            value = Convert.ToInt32(10);
                            sum = value + sum;
                            break;
                        }
                    case "K":
                        {
                            value = Convert.ToInt32(10);
                            sum = value + sum;
                            break;
                        }
                    case "T":
                        {
                            value = Convert.ToInt32(10);
                            sum = value + sum;
                            break;
                        }
                }




            }
            Console.WriteLine("Сумма карт на руках: " + sum);
            Console.ReadKey();
        }
    }
}
