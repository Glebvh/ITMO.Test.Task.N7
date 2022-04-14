using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Test.Task.N7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            do
            {
                Console.WriteLine("Введите значение n");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);
            
            double S = 0;
            int i = 1;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите значение D");
                double D = Convert.ToInt32(Console.ReadLine());
                S = S + D;
            }

            double Mid = S/(i - 1);
            Console.WriteLine("Результат = " + Mid);

            Console.WriteLine("anykey");
            string y = Console.ReadLine();

        }
    }
}
