using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Task1.Library
{
    public class SimmetricMatrix<T> : SquareMatrix<T>
    {
        public SimmetricMatrix(T[,] elements) : base(elements) { }

        public override T this[int i, int j]
        {
            get
            {
                return base[i, j];
            }
            set
            {
                base[i, j] = value;

                if (i != j)
                    base[j, i] = value;
            }
        }

        protected override void ArrayValidation()
        {
            base.ArrayValidation();

            for (int i = 0; i < elements.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < elements.GetLength(1); j++)
                {
                    if (!elements[i, j].Equals(elements[j, i]))
                        throw new ArgumentException("The expected matrix to be simmetric", "array");
                }
            }
        }
    }
}
