using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix.Task1.Library;

namespace MatrixExtensions.Task1.Library
{
    public static class MatrixExtensions
    {
        public static SquareMatrix<T> Add<T>(this SquareMatrix<T> current, SquareMatrix<T> summand)
        {
            if (current.Order != summand.Order)
                throw new InvalidOperationException("Two square matrices must have an equal order to be added.");

            //Console.WriteLine(current.GetType().Name);
            //Console.WriteLine(summand.GetType().Name);

            //Console.WriteLine(summand.GetType().IsInstanceOfType(current));
            //Console.WriteLine(current.GetType().IsInstanceOfType(summand));

            T[,] resultArray = new T[current.Order,current.Order];

            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                for (int j = 0; j < resultArray.GetLength(1); j++)
                {
                    try
                    {
                        resultArray = (dynamic)current[i, j] + (dynamic)summand[i, j];
                    }
                        
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException(string.Format("The addition operation cannot be applied to operands SquareMatrix<{0}>", typeof(T).Name),ex);
                    }                   
                }
            }
            return new SquareMatrix<T>(resultArray);
        }
    }
}
