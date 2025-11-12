using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[m, n];
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                    sum += matrix[i, j];
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Summa: {sum}");
        }
    }
}
