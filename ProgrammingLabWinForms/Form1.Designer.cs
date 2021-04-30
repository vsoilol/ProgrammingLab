
namespace ProgrammingLabWinForms
{
    partial class WindowsForm
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
            this.labelCoefficientsEquationText = new System.Windows.Forms.Label();
            this.labelSecondDegreeText = new System.Windows.Forms.Label();
            this.labelFirstDegreeText = new System.Windows.Forms.Label();
            this.labelZeroDegreeText = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxSecondDegreeValue = new System.Windows.Forms.TextBox();
            this.textBoxFirstDegreeValue = new System.Windows.Forms.TextBox();
            this.textBoxZeroDegreeValue = new System.Windows.Forms.TextBox();
            this.labelRootsText = new System.Windows.Forms.Label();
            this.labelFirstRootText = new System.Windows.Forms.Label();
            this.labelFirstRootValue = new System.Windows.Forms.Label();
            this.labelSecondRootText = new System.Windows.Forms.Label();
            this.labelSecondRootValue = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCoefficientsEquationText
            // 
            this.labelCoefficientsEquationText.AutoSize = true;
            this.labelCoefficientsEquationText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoefficientsEquationText.Location = new System.Drawing.Point(171, 50);
            this.labelCoefficientsEquationText.Name = "labelCoefficientsEquationText";
            this.labelCoefficientsEquationText.Size = new System.Drawing.Size(283, 27);
            this.labelCoefficientsEquationText.TabIndex = 0;
            this.labelCoefficientsEquationText.Text = "Коэффициенты уравнения";
            // 
            // labelSecondDegreeText
            // 
            this.labelSecondDegreeText.AutoSize = true;
            this.labelSecondDegreeText.Location = new System.Drawing.Point(69, 112);
            this.labelSecondDegreeText.Name = "labelSecondDegreeText";
            this.labelSecondDegreeText.Size = new System.Drawing.Size(125, 17);
            this.labelSecondDegreeText.TabIndex = 1;
            this.labelSecondDegreeText.Text = "При 2-ой степени";
            // 
            // labelFirstDegreeText
            // 
            this.labelFirstDegreeText.AutoSize = true;
            this.labelFirstDegreeText.Location = new System.Drawing.Point(241, 112);
            this.labelFirstDegreeText.Name = "labelFirstDegreeText";
            this.labelFirstDegreeText.Size = new System.Drawing.Size(125, 17);
            this.labelFirstDegreeText.TabIndex = 2;
            this.labelFirstDegreeText.Text = "При 1-ой степени";
            // 
            // labelZeroDegreeText
            // 
            this.labelZeroDegreeText.AutoSize = true;
            this.labelZeroDegreeText.Location = new System.Drawing.Point(414, 112);
            this.labelZeroDegreeText.Name = "labelZeroDegreeText";
            this.labelZeroDegreeText.Size = new System.Drawing.Size(125, 17);
            this.labelZeroDegreeText.TabIndex = 3;
            this.labelZeroDegreeText.Text = "При 0-ой степени";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(72, 307);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(113, 45);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxSecondDegreeValue
            // 
            this.textBoxSecondDegreeValue.Location = new System.Drawing.Point(72, 132);
            this.textBoxSecondDegreeValue.Name = "textBoxSecondDegreeValue";
            this.textBoxSecondDegreeValue.Size = new System.Drawing.Size(122, 22);
            this.textBoxSecondDegreeValue.TabIndex = 7;
            this.textBoxSecondDegreeValue.Leave += new System.EventHandler(this.textBoxSecondDegreeValue_Leave);
            // 
            // textBoxFirstDegreeValue
            // 
            this.textBoxFirstDegreeValue.Location = new System.Drawing.Point(244, 132);
            this.textBoxFirstDegreeValue.Name = "textBoxFirstDegreeValue";
            this.textBoxFirstDegreeValue.Size = new System.Drawing.Size(122, 22);
            this.textBoxFirstDegreeValue.TabIndex = 8;
            this.textBoxFirstDegreeValue.Leave += new System.EventHandler(this.textBoxFirstDegreeValue_Leave);
            // 
            // textBoxZeroDegreeValue
            // 
            this.textBoxZeroDegreeValue.Location = new System.Drawing.Point(417, 132);
            this.textBoxZeroDegreeValue.Name = "textBoxZeroDegreeValue";
            this.textBoxZeroDegreeValue.Size = new System.Drawing.Size(122, 22);
            this.textBoxZeroDegreeValue.TabIndex = 9;
            this.textBoxZeroDegreeValue.Leave += new System.EventHandler(this.textBoxZeroDegreeValue_Leave);
            // 
            // labelRootsText
            // 
            this.labelRootsText.AutoSize = true;
            this.labelRootsText.Location = new System.Drawing.Point(69, 194);
            this.labelRootsText.Name = "labelRootsText";
            this.labelRootsText.Size = new System.Drawing.Size(123, 17);
            this.labelRootsText.TabIndex = 10;
            this.labelRootsText.Text = "Корни уравнения";
            // 
            // labelFirstRootText
            // 
            this.labelFirstRootText.AutoSize = true;
            this.labelFirstRootText.Location = new System.Drawing.Point(69, 234);
            this.labelFirstRootText.Name = "labelFirstRootText";
            this.labelFirstRootText.Size = new System.Drawing.Size(38, 17);
            this.labelFirstRootText.TabIndex = 11;
            this.labelFirstRootText.Text = "x1 = ";
            // 
            // labelFirstRootValue
            // 
            this.labelFirstRootValue.AutoSize = true;
            this.labelFirstRootValue.Location = new System.Drawing.Point(113, 234);
            this.labelFirstRootValue.Name = "labelFirstRootValue";
            this.labelFirstRootValue.Size = new System.Drawing.Size(0, 17);
            this.labelFirstRootValue.TabIndex = 12;
            // 
            // labelSecondRootText
            // 
            this.labelSecondRootText.AutoSize = true;
            this.labelSecondRootText.Location = new System.Drawing.Point(69, 264);
            this.labelSecondRootText.Name = "labelSecondRootText";
            this.labelSecondRootText.Size = new System.Drawing.Size(38, 17);
            this.labelSecondRootText.TabIndex = 13;
            this.labelSecondRootText.Text = "x2 = ";
            // 
            // labelSecondRootValue
            // 
            this.labelSecondRootValue.AutoSize = true;
            this.labelSecondRootValue.Location = new System.Drawing.Point(113, 264);
            this.labelSecondRootValue.Name = "labelSecondRootValue";
            this.labelSecondRootValue.Size = new System.Drawing.Size(0, 17);
            this.labelSecondRootValue.TabIndex = 14;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(244, 307);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(113, 45);
            this.buttonNew.TabIndex = 15;
            this.buttonNew.Text = "Новое";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(417, 307);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 45);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Завершить";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 398);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.labelSecondRootValue);
            this.Controls.Add(this.labelSecondRootText);
            this.Controls.Add(this.labelFirstRootValue);
            this.Controls.Add(this.labelFirstRootText);
            this.Controls.Add(this.labelRootsText);
            this.Controls.Add(this.textBoxZeroDegreeValue);
            this.Controls.Add(this.textBoxFirstDegreeValue);
            this.Controls.Add(this.textBoxSecondDegreeValue);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelZeroDegreeText);
            this.Controls.Add(this.labelFirstDegreeText);
            this.Controls.Add(this.labelSecondDegreeText);
            this.Controls.Add(this.labelCoefficientsEquationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WindowsForm";
            this.Text = "WindowsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoefficientsEquationText;
        private System.Windows.Forms.Label labelSecondDegreeText;
        private System.Windows.Forms.Label labelFirstDegreeText;
        private System.Windows.Forms.Label labelZeroDegreeText;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxSecondDegreeValue;
        private System.Windows.Forms.TextBox textBoxFirstDegreeValue;
        private System.Windows.Forms.TextBox textBoxZeroDegreeValue;
        private System.Windows.Forms.Label labelRootsText;
        private System.Windows.Forms.Label labelFirstRootText;
        private System.Windows.Forms.Label labelFirstRootValue;
        private System.Windows.Forms.Label labelSecondRootText;
        private System.Windows.Forms.Label labelSecondRootValue;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonClose;
    }
}

