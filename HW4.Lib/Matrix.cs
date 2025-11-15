using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class Matrix
    {
        private int[,] matrix;

        public int RowNumber
        {
            get;
            private set;
        }

        public int ColumnNumber
        {
            get;
            private set;
        }

        private Random rand = new();

        public Matrix(int rowNum, int colNum, bool isToFillRandom = false)
        {
            RowNumber = rowNum;
            ColumnNumber = colNum;
            matrix = new int[RowNumber, ColumnNumber];
            /* Чи потрібно заповнювати матрицю рандомними числами?
             За замовчуванням - ні, щоб не робити зайві дії*/
            if (isToFillRandom)
            {
                initMatrix();
            }
        }

        public int this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }

        private void initMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(0, 101);
                }
            }
        }

        public static Matrix operator +(Matrix mtrx1, Matrix mtrx2)
        {
            if (mtrx1.RowNumber != mtrx2.RowNumber || mtrx1.ColumnNumber != mtrx2.ColumnNumber)
                throw new InvalidOperationException("You can add only matrices with identical row and column pairs.");
            Matrix result = new Matrix(mtrx1.RowNumber, mtrx1.ColumnNumber);

            for (int i = 0; i < result.RowNumber; i++)
            {
                for (int j = 0; j < result.ColumnNumber; j++)
                {
                    result[i,j] = mtrx1[i,j] + mtrx2[i,j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix mtrx1, Matrix mtrx2)
        {
            if (mtrx1.RowNumber != mtrx2.RowNumber || mtrx1.ColumnNumber != mtrx2.ColumnNumber)
                throw new InvalidOperationException("You can subtruct only matrices with identical row and column pairs.");
            Matrix result = new Matrix(mtrx1.RowNumber, mtrx1.ColumnNumber);

            for (int i = 0; i < result.RowNumber; i++)
            {
                for (int j = 0; j < result.ColumnNumber; j++)
                {
                    result[i, j] = mtrx1[i, j] - mtrx2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix mtrx, int scalar)
        {
            Matrix result = new Matrix(mtrx.RowNumber, mtrx.ColumnNumber);
            for (int i = 0; i < result.RowNumber; i++)
            {
                for (int j = 0; j < result.ColumnNumber; j++)
                {
                    result[i, j] = mtrx[i,j] * scalar;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix mtrx1, Matrix mtrx2)
        {
            if (mtrx1.ColumnNumber != mtrx2.RowNumber)
                throw new InvalidOperationException("Column number of the 1 matix must equal to row number of the 2 matrix.");
            Matrix result = new Matrix(mtrx1.RowNumber, mtrx2.ColumnNumber);
            for (int i = 0; i < result.RowNumber; i++)
            {
                for (int j = 0; j < result.ColumnNumber; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < mtrx1.ColumnNumber; k++)
                    {
                        sum += mtrx1[i, k] * mtrx2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix mtrx1, Matrix mtrx2)
        {
            if (mtrx1.RowNumber != mtrx2.RowNumber || mtrx1.ColumnNumber != mtrx2.ColumnNumber)
                throw new InvalidOperationException("Matrices are not identical, because of different row and column pairs.");
            for (int i = 0; i < mtrx1.RowNumber; i++)
            {
                for (int j = 0; j < mtrx1.ColumnNumber; j++)
                {
                    if(mtrx1[i, j] != mtrx2[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix mtrx1, Matrix mtrx2)
        {
            if (mtrx1.RowNumber != mtrx2.RowNumber || mtrx1.ColumnNumber != mtrx2.ColumnNumber)
                throw new InvalidOperationException("Matrices are not identical, because of different row and column pairs.");
            for (int i = 0; i < mtrx1.RowNumber; i++)
            {
                for (int j = 0; j < mtrx1.ColumnNumber; j++)
                {
                    if (mtrx1[i, j] != mtrx2[i, j])
                        return true;
                }
            }
            return false;
        }
    }
}
