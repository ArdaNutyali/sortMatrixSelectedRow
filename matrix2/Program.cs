using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static int[,] matrix = new int[5, 3];
        static void Sort(int a)
        {
            for (int i = a; i <= a; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (matrix[i, j] < matrix[i, k])
                        {
                            int tmp = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = tmp;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Which Row Do You Want to Sort: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Sort(a);
            for (int i = a; i <= a; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
