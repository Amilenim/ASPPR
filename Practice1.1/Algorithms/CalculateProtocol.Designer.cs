namespace Practice_1._1.Algorithms
{
    partial class CalculateProtocol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxCalculateProtocol = new TextBox();
            SuspendLayout();
            // 
            // textBoxCalculateProtocol
            // 
            textBoxCalculateProtocol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCalculateProtocol.BackColor = Color.FromArgb(64, 64, 64);
            textBoxCalculateProtocol.ForeColor = SystemColors.Window;
            textBoxCalculateProtocol.Location = new Point(-4, 0);
            textBoxCalculateProtocol.Multiline = true;
            textBoxCalculateProtocol.Name = "textBoxCalculateProtocol";
            textBoxCalculateProtocol.ScrollBars = ScrollBars.Both;
            textBoxCalculateProtocol.Size = new Size(806, 450);
            textBoxCalculateProtocol.TabIndex = 0;
            // 
            // CalculateProtocol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCalculateProtocol);
            Name = "CalculateProtocol";
            Text = "CalculateProtocol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCalculateProtocol;
    }
}