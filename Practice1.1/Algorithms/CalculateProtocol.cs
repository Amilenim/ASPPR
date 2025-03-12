using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice_1._1.Algorithms
{

    public partial class CalculateProtocol : Form
    {
        GaussJordanEliminationAlgorithms algorithm = new GaussJordanEliminationAlgorithms();
        private StringBuilder resultD;
        double[] matrixX;
        int Rank;

        public CalculateProtocol()
        {
            InitializeComponent();
        }
        public void FillIn(double[,] matrixCloneA, double[] matrixB, double[,] matrixInverse, double resolvingElement, int turn)
        {
            if (turn == 0)
            {
                if (matrixCloneA[turn, turn] != 0)
                    Rank++;
            }
            else
            {
                if (matrixInverse[turn, turn] != 0)
                    Rank++;
            }

            if (turn == 0)
            {
                resultD = new StringBuilder("Згенерований протокол обчислення:");
                resultD.AppendLine();
                resultD.AppendLine("Знаходження розв’язків СЛАР 1-м методом (за допомогою оберненої матрицi):");
                resultD.AppendLine("Знаходження оберненої матриці:");
                resultD.AppendLine();
                resultD.AppendLine("Вхідна матриця:");

                resultD.AppendLine(string.Join(Environment.NewLine,
                    Enumerable.Range(0, algorithm.Rows)
                    .Select(r => string.Join("   ", Enumerable.Range(0, algorithm.Columns)
                    .Select(c => matrixCloneA[r, c].ToString("F2"))))));
                resultD.AppendLine();
                resultD.AppendLine("Протокол обчислення:");
            }

            resultD.AppendLine();
            resultD.AppendLine($"\nКрок #{turn + 1}");
            resultD.AppendLine("Матриця після виконання ЗЖВ:");
            resultD.AppendLine($"Розв’язувальний елемент: A[{turn}, {turn}] = {resolvingElement:F2}");
            resultD.AppendLine(string.Join(Environment.NewLine,
                    Enumerable.Range(0, algorithm.Rows)
                    .Select(r => string.Join("   ", Enumerable.Range(0, algorithm.Columns)
                    .Select(c => matrixInverse[r, c].ToString("F2"))))));

            if (turn == algorithm.Rows - 1)
            {
                resultD.AppendLine();
                resultD.AppendLine("Обернена матриця:");
                resultD.AppendLine(string.Join(Environment.NewLine,
                    Enumerable.Range(0, algorithm.Rows)
                    .Select(r => string.Join("   ", Enumerable.Range(0, algorithm.Columns)
                    .Select(c => matrixInverse[r, c].ToString("F2"))))));

                if (matrixB != null)
                {
                    matrixX = new double[algorithm.Rows];

                    for (int i = 0; i < algorithm.Rows; i++)
                    {
                        for (int j = 0; j < algorithm.Columns; j++)
                        {
                            matrixX[i] += matrixB[j] * matrixInverse[i, j];
                        }
                    }

                    resultD.AppendLine();
                    resultD.AppendLine("Вхідна матриця В:");
                    for (int i = 0; i < algorithm.Rows; i++)
                    {
                        resultD.Append($"{matrixB[i]:F2}   ");
                        resultD.AppendLine();
                    }

                    resultD.AppendLine();
                    resultD.AppendLine("Обчислення розв’язків:");

                    for (int i = 0; i < algorithm.Rows; i++)
                    {
                        resultD.AppendLine();
                        resultD.Append($"X[{i + 1}] =");
                        for (int j = 0; j < algorithm.Columns; j++)
                        {
                            if (j != algorithm.Columns - 1)
                            {
                                resultD.Append($" {matrixB[j]} * {matrixInverse[i, j]:F2} +");
                            }
                            else
                            {
                                resultD.Append($" {matrixB[j]} * {matrixInverse[i, j]:F2} = {matrixX[i]:F2}");
                            }
                        }
                    }

                    resultD.AppendLine();
                    resultD.AppendLine();
                    resultD.AppendLine($"Ранг матриці: {Rank}");
                }
            }

            textBoxCalculateProtocol.Text = resultD.ToString();
        }
    }
}
