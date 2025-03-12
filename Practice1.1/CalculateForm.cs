using Practice_1._1.Algorithms;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace Practice_1._1
{
    public partial class CalculateForm : Form
    {
        GaussJordanEliminationAlgorithms mtrx = new GaussJordanEliminationAlgorithms();
        CalculateProtocol protocol = new CalculateProtocol();
        Random random = new Random();

        public CalculateForm()
        {
            InitializeComponent();
        }

        private void ScanMatrix()
        {
            try
            {
                mtrx.matrixA = new double[0, 0];
                mtrx.matrixB = new double[0];
                var linesA = textMatrixA.Text.Trim().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var arrayA = linesA.Select(l => l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray()).ToArray();

                if (arrayA.Length == 0 || arrayA.Any(row => row.Length == 0))
                {
                    throw new Exception("Матриця A порожня.");
                }

                mtrx.Rows = arrayA.Length;
                mtrx.Columns = arrayA[0].Length;
                mtrx.matrixA = new double[arrayA.Length, arrayA[0].Length];

                for (int i = 0; i < arrayA.Length; i++)
                {
                    if (arrayA[i].Length != mtrx.Columns)
                        throw new Exception("Матриця А написана неправильно!");

                    for (int j = 0; j < arrayA[i].Length; j++)
                    {
                        mtrx.matrixA[i, j] = arrayA[i][j];
                    }
                }

                if (checkBoxMatrixtB.Checked)
                {
                    var linesB = textMatrixB.Text.Trim().Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    var arrayB = linesB.SelectMany(l => l.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)).ToArray();

                    if (arrayB.Length == 0)
                    {
                        throw new Exception("Матриця B порожня.");
                    }

                    mtrx.matrixB = (double[])arrayB.Clone();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка в ScanMatrix: " + ex.Message);
            }
        }


        private void GenerateMatrix(object sender, EventArgs e)
        {
            mtrx.Rows = (int)numericUpDownRows.Value;
            mtrx.Columns = (int)numericUpDownColumns.Value;
            textBoxInverseMatrix.Clear();
            textBoxMatrixtRank.Clear();
            textBoxMatrixSolution.Clear();
            string resultA = "";
            string resultB = "";

            if (checkBoxMatrixtA.Checked)
            {
                for (int i = 0; i < mtrx.Rows; i++)
                {
                    for (int j = 0; j < mtrx.Columns; j++)
                    {
                        resultA += random.Next(-9, 9) + "   ";
                    }
                    resultA += Environment.NewLine;
                }
            }
            if (checkBoxMatrixtB.Checked)
            {
                for (int i = 0; i < mtrx.Rows; i++)
                {
                    resultB += random.Next(-9, 9);
                    resultB += Environment.NewLine;
                }
            }

            textMatrixA.Text = resultA;
            textMatrixB.Text = resultB;
        }

        private void FindInverseMatrix(object sender, EventArgs e)
        {
            try
            {
                ScanMatrix();
                double[,] matrixInverse = mtrx.matrixA;

                if (mtrx.Rows != mtrx.Columns)
                {
                    textBoxInverseMatrix.Text = "Рядки i стовпцi матриці повиннi бути однакової довжини!";
                    return;
                }
                for (int i = 0; i < mtrx.Rows; i++)
                {
                    double resolvingElement = matrixInverse[i, i];

                    if (!mtrx.GaussJordanElimination(matrixInverse, resolvingElement, i))
                    {
                        textBoxInverseMatrix.Text = "Матриця має нулі при розв'язанні на головній діагоналі, тому вона нерозв'язна!";
                        return;
                    }
                }
                textBoxInverseMatrix.Text = string.Join(Environment.NewLine,
                    Enumerable.Range(0, mtrx.Rows)
                    .Select(r => string.Join("   ", Enumerable.Range(0, mtrx.Columns)
                    .Select(c => matrixInverse[r, c].ToString("F2")))));
            }
            catch (Exception ex)
            {
                textBoxInverseMatrix.Text = "Помилка: " + ex.Message;
            }
        }

        private void FindRankMatrix(object sender, EventArgs e)
        {
            try
            {
                ScanMatrix();
                double[,] matrixInverse = (double[,])mtrx.matrixA.Clone();
                int matrixRank = 0;
                int length = Math.Min(mtrx.Rows, mtrx.Columns);

                for (int i = 0; i < length; i++)
                {
                    double resolvingElement = matrixInverse[i, i];

                    if (mtrx.GaussJordanElimination(matrixInverse, resolvingElement, i))
                    {
                        matrixRank++;
                    }
                }
                textBoxMatrixtRank.Text = matrixRank.ToString();
            }
            catch (Exception ex)
            {
                textBoxMatrixtRank.Text = "Помилка: " + ex.Message;
            }
        }

        public void FindSolutionMatrixt(object sender, EventArgs e)
        {
            try
            {
                if (!checkBoxMatrixtB.Checked)
                {
                    textBoxMatrixSolution.Text = "Матриця B порожня.";
                    return;
                }

                ScanMatrix();
                double[,] matrixInverse = mtrx.matrixA;
                double[,] matrixCloneA = (double[,])mtrx.matrixA.Clone();

                if (mtrx.Rows != mtrx.Columns)
                {
                    textBoxMatrixSolution.Text = "Рядки i стовпцi матриці повиннi бути однакової довжини!";
                    return;
                }
                for (int i = 0; i < mtrx.Rows; i++)
                {
                    double resolvingElement = matrixInverse[i, i];

                    if (!mtrx.GaussJordanElimination(matrixInverse, resolvingElement, i))
                    {
                        textBoxMatrixSolution.Text = "Матриця має нулі при розв'язанні на головній діагоналі, тому вона нерозв'язна!";
                        return;
                    }
                    protocol.FillIn(matrixCloneA, mtrx.matrixB, matrixInverse, resolvingElement, i);
                }

                double[] matrixX = new double[mtrx.Rows];

                for (int i = 0; i < mtrx.Rows; i++)
                {
                    for (int j = 0; j < mtrx.Columns; j++)
                    {
                        matrixX[i] += mtrx.matrixB[j] * matrixInverse[i, j];
                    }
                }

                if (checkBoxCalculateProtocol.Checked)
                {
                    if (protocol.IsDisposed)
                    {
                        protocol = new CalculateProtocol();
                    }
                    protocol.Show();
                }

                textBoxMatrixSolution.Text = string.Join(Environment.NewLine, matrixX.Select(x => x.ToString("F2")));
            }
            catch (Exception ex)
            {
                textBoxMatrixSolution.Text = "Помилка: " + ex.Message;
            }
        }
    }
}

