using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysImplimentations
{
    internal class TwoDimensionalArray
    {
        private int rows, columns;
        private int[,] array;
        public TwoDimensionalArray(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            array = new int[rows, columns];
        }

        public int Rows { get { return rows; } }
        public int Columns { get { return columns;} }

        public int GetValue(int row,int col)
        {
            return array[row,col];
        }

        public void SetValue(int row,int col,int value)
        {
            array[row,col] = value;

        }

        public void DisplayArray()
        {
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
