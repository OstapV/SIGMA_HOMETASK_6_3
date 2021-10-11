using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FOREACH
{
    class Matrix : IEnumerable<int>
    {
        private int[,] matrix;

        public int this[int i, int j]
        {
            get 
            {
                return matrix[i, j]; 
            }
            set 
            { 
                matrix[i, j] = value;
            }
        }


        public IEnumerator<int> GetEnumerator()
        {
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    yield return matrix[i, j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
