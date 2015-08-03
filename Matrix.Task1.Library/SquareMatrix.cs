using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Task1.Library
{
    public class SquareMatrix<T> : Matrix<T>
    {
        public int Order { get { return elements.GetLength(0); } }

        public SquareMatrix(T[,] elements) : base(elements) { }

        protected override void ArrayValidation()
        {
            if (elements.GetLength(0) != elements.GetLength(1))
                throw new ArgumentException("The expected input array to be square", "array");
        }
    }

}
