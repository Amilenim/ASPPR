namespace Practice_1._1
{
    partial class CalculateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textMatrixA = new TextBox();
            textMatrixB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonCalculate = new Button();
            label7 = new Label();
            textBoxInverseMatrix = new TextBox();
            textBoxMatrixSolution = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBoxMatrixtRank = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonFindInversMartix = new Button();
            buttonFindRankMatrix = new Button();
            checkBoxCalculateProtocol = new CheckBox();
            checkBoxMatrixtB = new CheckBox();
            checkBoxMatrixtA = new CheckBox();
            buttonGenerate = new Button();
            numericUpDownColumns = new NumericUpDown();
            numericUpDownRows = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).BeginInit();
            SuspendLayout();
            // 
            // textMatrixA
            // 
            textMatrixA.BackColor = SystemColors.AppWorkspace;
            textMatrixA.Font = new Font("Segoe UI", 9F);
            textMatrixA.Location = new Point(12, 29);
            textMatrixA.Multiline = true;
            textMatrixA.Name = "textMatrixA";
            textMatrixA.ScrollBars = ScrollBars.Both;
            textMatrixA.Size = new Size(159, 109);
            textMatrixA.TabIndex = 11;
            // 
            // textMatrixB
            // 
            textMatrixB.BackColor = SystemColors.AppWorkspace;
            textMatrixB.Location = new Point(177, 29);
            textMatrixB.Multiline = true;
            textMatrixB.Name = "textMatrixB";
            textMatrixB.Size = new Size(74, 109);
            textMatrixB.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 13;
            label1.Text = "Matrixt A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(177, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 14;
            label2.Text = "Matrixt B";
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = SystemColors.AppWorkspace;
            buttonCalculate.Location = new Point(285, 169);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(98, 45);
            buttonCalculate.TabIndex = 39;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += FindSolutionMatrixt;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(111, 222);
            label7.Name = "label7";
            label7.Size = new Size(96, 17);
            label7.TabIndex = 38;
            label7.Text = "Inverse Matrix";
            // 
            // textBoxInverseMatrix
            // 
            textBoxInverseMatrix.BackColor = SystemColors.AppWorkspace;
            textBoxInverseMatrix.Enabled = false;
            textBoxInverseMatrix.Font = new Font("Segoe UI", 9F);
            textBoxInverseMatrix.Location = new Point(111, 243);
            textBoxInverseMatrix.Multiline = true;
            textBoxInverseMatrix.Name = "textBoxInverseMatrix";
            textBoxInverseMatrix.ScrollBars = ScrollBars.Both;
            textBoxInverseMatrix.Size = new Size(159, 109);
            textBoxInverseMatrix.TabIndex = 37;
            // 
            // textBoxMatrixSolution
            // 
            textBoxMatrixSolution.BackColor = SystemColors.AppWorkspace;
            textBoxMatrixSolution.Enabled = false;
            textBoxMatrixSolution.Location = new Point(285, 243);
            textBoxMatrixSolution.Multiline = true;
            textBoxMatrixSolution.Name = "textBoxMatrixSolution";
            textBoxMatrixSolution.Size = new Size(98, 110);
            textBoxMatrixSolution.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(285, 222);
            label6.Name = "label6";
            label6.Size = new Size(109, 17);
            label6.TabIndex = 35;
            label6.Text = "Matrixt Solution";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 34;
            label5.Text = "Matrixt Rank";
            // 
            // textBoxMatrixtRank
            // 
            textBoxMatrixtRank.BackColor = SystemColors.AppWorkspace;
            textBoxMatrixtRank.Enabled = false;
            textBoxMatrixtRank.Location = new Point(12, 242);
            textBoxMatrixtRank.Multiline = true;
            textBoxMatrixtRank.Name = "textBoxMatrixtRank";
            textBoxMatrixtRank.Size = new Size(83, 109);
            textBoxMatrixtRank.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(325, 10);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 32;
            label4.Text = "Columns";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(261, 9);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 31;
            label3.Text = "Rows";
            // 
            // buttonFindInversMartix
            // 
            buttonFindInversMartix.BackColor = Color.DarkGray;
            buttonFindInversMartix.Location = new Point(111, 169);
            buttonFindInversMartix.Name = "buttonFindInversMartix";
            buttonFindInversMartix.Size = new Size(159, 45);
            buttonFindInversMartix.TabIndex = 30;
            buttonFindInversMartix.Text = "Find Inverse Martix";
            buttonFindInversMartix.UseVisualStyleBackColor = false;
            buttonFindInversMartix.Click += FindInverseMatrix;
            // 
            // buttonFindRankMatrix
            // 
            buttonFindRankMatrix.BackColor = SystemColors.AppWorkspace;
            buttonFindRankMatrix.Location = new Point(12, 169);
            buttonFindRankMatrix.Name = "buttonFindRankMatrix";
            buttonFindRankMatrix.Size = new Size(83, 45);
            buttonFindRankMatrix.TabIndex = 29;
            buttonFindRankMatrix.Text = "Find Rank";
            buttonFindRankMatrix.UseVisualStyleBackColor = false;
            buttonFindRankMatrix.Click += FindRankMatrix;
            // 
            // checkBoxCalculateProtocol
            // 
            checkBoxCalculateProtocol.AutoSize = true;
            checkBoxCalculateProtocol.ForeColor = SystemColors.ControlLight;
            checkBoxCalculateProtocol.Location = new Point(12, 144);
            checkBoxCalculateProtocol.Name = "checkBoxCalculateProtocol";
            checkBoxCalculateProtocol.Size = new Size(193, 19);
            checkBoxCalculateProtocol.TabIndex = 28;
            checkBoxCalculateProtocol.Text = "Generate a Calculation Protocol";
            checkBoxCalculateProtocol.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatrixtB
            // 
            checkBoxMatrixtB.AutoSize = true;
            checkBoxMatrixtB.ForeColor = SystemColors.ControlLight;
            checkBoxMatrixtB.Location = new Point(261, 84);
            checkBoxMatrixtB.Name = "checkBoxMatrixtB";
            checkBoxMatrixtB.Size = new Size(73, 19);
            checkBoxMatrixtB.TabIndex = 27;
            checkBoxMatrixtB.Text = "Matrixt B";
            checkBoxMatrixtB.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatrixtA
            // 
            checkBoxMatrixtA.AutoSize = true;
            checkBoxMatrixtA.Checked = true;
            checkBoxMatrixtA.CheckState = CheckState.Checked;
            checkBoxMatrixtA.ForeColor = SystemColors.ControlLight;
            checkBoxMatrixtA.Location = new Point(261, 59);
            checkBoxMatrixtA.Name = "checkBoxMatrixtA";
            checkBoxMatrixtA.Size = new Size(74, 19);
            checkBoxMatrixtA.TabIndex = 26;
            checkBoxMatrixtA.Text = "Matrixt A";
            checkBoxMatrixtA.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = SystemColors.AppWorkspace;
            buttonGenerate.Location = new Point(257, 108);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(126, 30);
            buttonGenerate.TabIndex = 25;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += GenerateMatrix;
            // 
            // numericUpDownColumns
            // 
            numericUpDownColumns.BackColor = SystemColors.AppWorkspace;
            numericUpDownColumns.Location = new Point(325, 30);
            numericUpDownColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownColumns.Name = "numericUpDownColumns";
            numericUpDownColumns.Size = new Size(58, 23);
            numericUpDownColumns.TabIndex = 24;
            numericUpDownColumns.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numericUpDownRows
            // 
            numericUpDownRows.BackColor = SystemColors.AppWorkspace;
            numericUpDownRows.Location = new Point(261, 29);
            numericUpDownRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new Size(58, 23);
            numericUpDownRows.TabIndex = 23;
            numericUpDownRows.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(398, 364);
            Controls.Add(buttonCalculate);
            Controls.Add(label7);
            Controls.Add(textBoxInverseMatrix);
            Controls.Add(textBoxMatrixSolution);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxMatrixtRank);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonFindInversMartix);
            Controls.Add(buttonFindRankMatrix);
            Controls.Add(checkBoxCalculateProtocol);
            Controls.Add(checkBoxMatrixtB);
            Controls.Add(checkBoxMatrixtA);
            Controls.Add(buttonGenerate);
            Controls.Add(numericUpDownColumns);
            Controls.Add(numericUpDownRows);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textMatrixB);
            Controls.Add(textMatrixA);
            Name = "MainForm";
            Text = "AmilBakhshaliev";
            ((System.ComponentModel.ISupportInitialize)numericUpDownColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMatrixA;
        private TextBox textMatrixB;
        private Label label1;
        private Label label2;
        private Button buttonCalculate;
        private Label label7;
        private TextBox textBoxInverseMatrix;
        private TextBox textBoxMatrixSolution;
        private Label label6;
        private Label label5;
        private TextBox textBoxMatrixtRank;
        private Label label4;
        private Label label3;
        private Button buttonFindInversMartix;
        private Button buttonFindRankMatrix;
        private CheckBox checkBoxCalculateProtocol;
        private CheckBox checkBoxMatrixtB;
        private CheckBox checkBoxMatrixtA;
        private Button buttonGenerate;
        private NumericUpDown numericUpDownColumns;
        private NumericUpDown numericUpDownRows;
    }
}
