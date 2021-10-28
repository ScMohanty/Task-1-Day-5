using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER TO CHECK WHETHER IT IS A STRONG NUMBER OR NOT");
            int numbers = Convert.ToInt32(Console.ReadLine());
            StrongNumber(numbers);

        }
        static void StrongNumber(int numbers)
        {
           
            int com = numbers;
            bool b = false;
            int sum = 0;
            for (int i = 0; i < numbers;)
            {
                int temp = 1;
                int num = numbers % 10;
                numbers = numbers / 10;
                for (int j = 0; j < num; num--)
                {
                    temp = temp * num;
                }
                sum = sum + temp;
            }

            if (sum.Equals(com))
            {
                Console.WriteLine(com + " is a strong number");

            }
            else
                Console.WriteLine(com + " is not a strong number");

          
        }
    }
}
