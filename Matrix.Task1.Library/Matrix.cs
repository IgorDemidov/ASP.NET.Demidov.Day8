using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Task1.Library
{
    public abstract class Matrix<T>
    {
        protected T[,] elements;

        public virtual T this[int i, int j]
        {
            get { return elements[i, j]; }
            set
            {
                ElementChangedEventArgs<T> e = new ElementChangedEventArgs<T>(i, j, elements[i, j], value);
                OnElementChanged(e);
                elements[i, j] = value;
            }
        }

        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            if (ElementChanged != null)
                ElementChanged(this, e);
        }

        public Matrix(T[,] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Input array can't be null", "array");
            }

            this.elements = (T[,])elements.Clone();

            ArrayValidation();
        }

        protected abstract void ArrayValidation();

        public T[,] ToArray()
        {
            return (T[,])(elements.Clone());
        }
    }
}
