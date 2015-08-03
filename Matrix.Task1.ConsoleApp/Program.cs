using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Task1.Library;
using MatrixExtensions.Task1.Library;

namespace Matrix.Task1.ConsoleApp
{
    class Program
    {
        public static int[,] GenerateSquareArray(int order)
        {
            int[,] array = new int[order, order];
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 99);
                }
            }
            return array;
        }

        public static int[,] GenerateSimmetricArray(int order)
        {
            int[,] array = GenerateSquareArray(order);

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[j, i];
                }
            }
            return array;
        }

        public static int[,] GenerateDiagonalArray(int order)
        {
            int[,] array = GenerateSquareArray(order);

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = default(int);
                    array[j, i] = default(int);
                }
            }
            return array;
        }

        public static void Print(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
        }

        static void Main(string[] args)
        {
            int[,] sqareArray = GenerateSquareArray(4);
            Print(sqareArray);
            int[,] simmetricArray = GenerateSimmetricArray(4);
            Print(simmetricArray);
            int[,] diagonalArray = GenerateDiagonalArray(4);
            Print(diagonalArray);


            SquareMatrix<int> squareMatrix = new SquareMatrix<int>(sqareArray);
            SimmetricMatrix<int> simmetricMatrix = new SimmetricMatrix<int>(simmetricArray);
            DiagonalMatrix<int> diagonalMatrix = new DiagonalMatrix<int>(diagonalArray);

            squareMatrix.Add(simmetricMatrix);


            Console.ReadLine();
        }
    }
}
