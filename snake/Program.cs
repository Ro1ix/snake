using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗМЕЙКА");
            Console.WriteLine("\nВведите размер квадрата");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int x = 0;
            int y = 0;
            array[x, y] = 1;
            Console.WriteLine(array[x, y]);
            for (int i = 1; i <= Math.Pow(n, 2); i++)
            {
                switch (x)
                {
                    case 0:
                        if (y < n)
                            y = y + 1;
                        else
                            x = x + 1;
                        array[x, y] = i + 1;
                        break;
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write($"{array[x, y]}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
