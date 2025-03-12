using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1._1.Algorithms
{
    public class GaussJordanEliminationAlgorithms
    {
        public int Rows { get; set; } = 3;
        public int Columns { get; set; } = 3;
        public bool GenCalcProt { get; set; } = false;
        public bool MatrixHaveZero { get; set; } = false;
        private int TurnCounter { get; set; } = 0;
        public double[,] matrixA;
        public double[] matrixB;

        public bool GaussJordanElimination(double[,] matrixInverse, double resolvingElement, int i)
        {
            if (resolvingElement == 0)
            {
                MatrixHaveZero = true;
                return false;
            }
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (r == i && c == i)
                    {
                        matrixInverse[i, i] = 1;
                    }
                    else if (r == i || c == i)
                    {
                        if (r == i && matrixInverse[r, c] != 0)
                        {
                            matrixInverse[r, c] *= -1;
                        }
                    }
                }
            }
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if ((r == i && c == i) || (r == i || c == i))
                        continue;
                    matrixInverse[r, c] = matrixInverse[r, c] * resolvingElement - matrixInverse[i, c] * (-1) * matrixInverse[r, i];
                }
            }
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    matrixInverse[r, c] /= resolvingElement;
                }
            }
            return true;
        }
    }
}
