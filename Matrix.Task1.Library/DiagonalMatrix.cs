using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Task1.Library
{
    public class DiagonalMatrix<T> : SimmetricMatrix<T>
    {
        public DiagonalMatrix(T[,] elements) : base(elements) { }

        public override T this[int i, int j]
        {
            get
            {
                return base[i, j];
            }
            set
            {
                if (i != j)
                    throw new ArgumentException();
                else
                    base[i, j] = value;
            }
        }

        protected override void ArrayValidation()
        {
            base.ArrayValidation();

            for (int i = 0; i < elements.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < elements.GetLength(1); j++)
                {
                    if (!elements[i, j].Equals(default(T)))
                            throw new ArgumentException("The expected matrix to be diagonal", "array");
                }
            }
        }

    }
}
