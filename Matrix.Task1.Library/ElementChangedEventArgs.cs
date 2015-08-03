using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Task1.Library
{
    public class ElementChangedEventArgs<T> : EventArgs
    {
        private readonly int row;
        private readonly int col;
        private readonly T newValue;
        private readonly T oldValue;

        public ElementChangedEventArgs(int row, int col, T oldValue, T newValue)
        {
            this.row = row;
            this.col = col;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

        public int Row { get { return row; } }
        public int Col { get { return col; } }
        public T OldValue { get { return this.oldValue; } }
        public T NewValue { get { return this.newValue; } }
    }
}
