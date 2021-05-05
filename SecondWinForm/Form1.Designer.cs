
using System.Windows.Forms;

namespace SecondWinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBoxUnitMeasurements = new MyElements.CheckedListBox();
            this.labelUnitMeasurementsText = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxCalculationMode = new System.Windows.Forms.GroupBox();
            this.radioButtonIntervalValue = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleValue = new System.Windows.Forms.RadioButton();
            this.groupBoxEditorSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxRedColor = new System.Windows.Forms.CheckBox();
            this.richTextBoxIntervalResult = new System.Windows.Forms.RichTextBox();
            this.panelTranslation = new System.Windows.Forms.Panel();
            this.buttonCalculateTranslation = new System.Windows.Forms.Button();
            this.textBoxResultTranslation = new System.Windows.Forms.TextBox();
            this.labelResultTranslationText = new System.Windows.Forms.Label();
            this.textBoxEnterValueTranslation = new System.Windows.Forms.TextBox();
            this.labelEnterValueTranslationText = new System.Windows.Forms.Label();
            this.panelInterval = new System.Windows.Forms.Panel();
            this.buttonCalculateInterval = new System.Windows.Forms.Button();
            this.textBoxIncrementStep = new System.Windows.Forms.TextBox();
            this.textBoxFinalValue = new System.Windows.Forms.TextBox();
            this.textBoxInitialValue = new System.Windows.Forms.TextBox();
            this.labelFinalValueText = new System.Windows.Forms.Label();
            this.labelIncrementStepText = new System.Windows.Forms.Label();
            this.labelInitialValueText = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxCalculationMode.SuspendLayout();
            this.groupBoxEditorSettings.SuspendLayout();
            this.panelTranslation.SuspendLayout();
            this.panelInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxIntervalResult, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTranslation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelInterval, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.29412F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.labelTitle, 3);
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(896, 43);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Перевод граммов в другие единицы измерения";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.checkedListBoxUnitMeasurements);
            this.panel1.Controls.Add(this.labelUnitMeasurementsText);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.groupBoxCalculationMode);
            this.panel1.Controls.Add(this.groupBoxEditorSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 244);
            this.panel1.TabIndex = 1;
            // 
            // checkedListBoxUnitMeasurements
            // 
            this.checkedListBoxUnitMeasurements.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkedListBoxUnitMeasurements.ForeColor = System.Drawing.Color.Blue;
            this.checkedListBoxUnitMeasurements.FormattingEnabled = true;
            this.checkedListBoxUnitMeasurements.Location = new System.Drawing.Point(9, 74);
            this.checkedListBoxUnitMeasurements.Name = "checkedListBoxUnitMeasurements";
            this.checkedListBoxUnitMeasurements.Size = new System.Drawing.Size(143, 144);
            this.checkedListBoxUnitMeasurements.TabIndex = 5;
            this.checkedListBoxUnitMeasurements.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxUnitMeasurements_ItemCheck);
            // 
            // labelUnitMeasurementsText
            // 
            this.labelUnitMeasurementsText.AutoSize = true;
            this.labelUnitMeasurementsText.Location = new System.Drawing.Point(9, 54);
            this.labelUnitMeasurementsText.Name = "labelUnitMeasurementsText";
            this.labelUnitMeasurementsText.Size = new System.Drawing.Size(143, 17);
            this.labelUnitMeasurementsText.TabIndex = 3;
            this.labelUnitMeasurementsText.Text = "Единицы измерения";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(763, 187);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 44);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxCalculationMode
            // 
            this.groupBoxCalculationMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCalculationMode.Controls.Add(this.radioButtonIntervalValue);
            this.groupBoxCalculationMode.Controls.Add(this.radioButtonSingleValue);
            this.groupBoxCalculationMode.Location = new System.Drawing.Point(456, 71);
            this.groupBoxCalculationMode.Name = "groupBoxCalculationMode";
            this.groupBoxCalculationMode.Size = new System.Drawing.Size(225, 100);
            this.groupBoxCalculationMode.TabIndex = 1;
            this.groupBoxCalculationMode.TabStop = false;
            this.groupBoxCalculationMode.Text = "Режим расчета";
            // 
            // radioButtonIntervalValue
            // 
            this.radioButtonIntervalValue.AutoSize = true;
            this.radioButtonIntervalValue.Location = new System.Drawing.Point(21, 57);
            this.radioButtonIntervalValue.Name = "radioButtonIntervalValue";
            this.radioButtonIntervalValue.Size = new System.Drawing.Size(178, 21);
            this.radioButtonIntervalValue.TabIndex = 1;
            this.radioButtonIntervalValue.TabStop = true;
            this.radioButtonIntervalValue.Text = "Расчет для интервала";
            this.radioButtonIntervalValue.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingleValue
            // 
            this.radioButtonSingleValue.AutoSize = true;
            this.radioButtonSingleValue.Location = new System.Drawing.Point(21, 30);
            this.radioButtonSingleValue.Name = "radioButtonSingleValue";
            this.radioButtonSingleValue.Size = new System.Drawing.Size(169, 21);
            this.radioButtonSingleValue.TabIndex = 0;
            this.radioButtonSingleValue.TabStop = true;
            this.radioButtonSingleValue.Text = "Единичное значение";
            this.radioButtonSingleValue.UseVisualStyleBackColor = true;
            this.radioButtonSingleValue.CheckedChanged += new System.EventHandler(this.radioButtonSingleValue_CheckedChanged);
            // 
            // groupBoxEditorSettings
            // 
            this.groupBoxEditorSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEditorSettings.Controls.Add(this.checkBoxRedColor);
            this.groupBoxEditorSettings.Location = new System.Drawing.Point(687, 71);
            this.groupBoxEditorSettings.Name = "groupBoxEditorSettings";
            this.groupBoxEditorSettings.Size = new System.Drawing.Size(200, 100);
            this.groupBoxEditorSettings.TabIndex = 0;
            this.groupBoxEditorSettings.TabStop = false;
            this.groupBoxEditorSettings.Text = "Настройка редактора";
            // 
            // checkBoxRedColor
            // 
            this.checkBoxRedColor.AutoSize = true;
            this.checkBoxRedColor.Location = new System.Drawing.Point(26, 44);
            this.checkBoxRedColor.Name = "checkBoxRedColor";
            this.checkBoxRedColor.Size = new System.Drawing.Size(123, 21);
            this.checkBoxRedColor.TabIndex = 0;
            this.checkBoxRedColor.Text = "Цвет красный";
            this.checkBoxRedColor.UseVisualStyleBackColor = true;
            this.checkBoxRedColor.CheckedChanged += new System.EventHandler(this.checkBoxRedColor_CheckedChanged);
            // 
            // richTextBoxIntervalResult
            // 
            this.richTextBoxIntervalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxIntervalResult.Location = new System.Drawing.Point(555, 46);
            this.richTextBoxIntervalResult.Name = "richTextBoxIntervalResult";
            this.richTextBoxIntervalResult.Size = new System.Drawing.Size(344, 249);
            this.richTextBoxIntervalResult.TabIndex = 2;
            this.richTextBoxIntervalResult.Text = "";
            // 
            // panelTranslation
            // 
            this.panelTranslation.BackColor = System.Drawing.SystemColors.Control;
            this.panelTranslation.Controls.Add(this.buttonCalculateTranslation);
            this.panelTranslation.Controls.Add(this.textBoxResultTranslation);
            this.panelTranslation.Controls.Add(this.labelResultTranslationText);
            this.panelTranslation.Controls.Add(this.textBoxEnterValueTranslation);
            this.panelTranslation.Controls.Add(this.labelEnterValueTranslationText);
            this.panelTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTranslation.Location = new System.Drawing.Point(3, 46);
            this.panelTranslation.Name = "panelTranslation";
            this.panelTranslation.Size = new System.Drawing.Size(283, 249);
            this.panelTranslation.TabIndex = 3;
            // 
            // buttonCalculateTranslation
            // 
            this.buttonCalculateTranslation.Location = new System.Drawing.Point(70, 173);
            this.buttonCalculateTranslation.Name = "buttonCalculateTranslation";
            this.buttonCalculateTranslation.Size = new System.Drawing.Size(125, 37);
            this.buttonCalculateTranslation.TabIndex = 4;
            this.buttonCalculateTranslation.Text = "Calculate";
            this.buttonCalculateTranslation.UseVisualStyleBackColor = true;
            this.buttonCalculateTranslation.Click += new System.EventHandler(this.buttonCalculateTranslation_Click);
            // 
            // textBoxResultTranslation
            // 
            this.textBoxResultTranslation.Location = new System.Drawing.Point(70, 121);
            this.textBoxResultTranslation.Name = "textBoxResultTranslation";
            this.textBoxResultTranslation.Size = new System.Drawing.Size(125, 22);
            this.textBoxResultTranslation.TabIndex = 3;
            // 
            // labelResultTranslationText
            // 
            this.labelResultTranslationText.AutoSize = true;
            this.labelResultTranslationText.Location = new System.Drawing.Point(92, 101);
            this.labelResultTranslationText.Name = "labelResultTranslationText";
            this.labelResultTranslationText.Size = new System.Drawing.Size(76, 17);
            this.labelResultTranslationText.TabIndex = 2;
            this.labelResultTranslationText.Text = "Результат";
            // 
            // textBoxEnterValueTranslation
            // 
            this.textBoxEnterValueTranslation.Location = new System.Drawing.Point(70, 58);
            this.textBoxEnterValueTranslation.Name = "textBoxEnterValueTranslation";
            this.textBoxEnterValueTranslation.Size = new System.Drawing.Size(125, 22);
            this.textBoxEnterValueTranslation.TabIndex = 1;
            this.textBoxEnterValueTranslation.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            this.textBoxEnterValueTranslation.Validated += new System.EventHandler(this.TextBoxValidated);
            // 
            // labelEnterValueTranslationText
            // 
            this.labelEnterValueTranslationText.AutoSize = true;
            this.labelEnterValueTranslationText.Location = new System.Drawing.Point(35, 38);
            this.labelEnterValueTranslationText.Name = "labelEnterValueTranslationText";
            this.labelEnterValueTranslationText.Size = new System.Drawing.Size(198, 17);
            this.labelEnterValueTranslationText.TabIndex = 0;
            this.labelEnterValueTranslationText.Text = "Введите значение в граммах";
            // 
            // panelInterval
            // 
            this.panelInterval.BackColor = System.Drawing.SystemColors.Control;
            this.panelInterval.Controls.Add(this.buttonCalculateInterval);
            this.panelInterval.Controls.Add(this.textBoxIncrementStep);
            this.panelInterval.Controls.Add(this.textBoxFinalValue);
            this.panelInterval.Controls.Add(this.textBoxInitialValue);
            this.panelInterval.Controls.Add(this.labelFinalValueText);
            this.panelInterval.Controls.Add(this.labelIncrementStepText);
            this.panelInterval.Controls.Add(this.labelInitialValueText);
            this.panelInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInterval.Location = new System.Drawing.Point(292, 46);
            this.panelInterval.Name = "panelInterval";
            this.panelInterval.Size = new System.Drawing.Size(257, 249);
            this.panelInterval.TabIndex = 4;
            // 
            // buttonCalculateInterval
            // 
            this.buttonCalculateInterval.Location = new System.Drawing.Point(75, 193);
            this.buttonCalculateInterval.Name = "buttonCalculateInterval";
            this.buttonCalculateInterval.Size = new System.Drawing.Size(100, 37);
            this.buttonCalculateInterval.TabIndex = 5;
            this.buttonCalculateInterval.Text = "Calculate";
            this.buttonCalculateInterval.UseVisualStyleBackColor = true;
            this.buttonCalculateInterval.Click += new System.EventHandler(this.buttonCalculateInterval_Click);
            // 
            // textBoxIncrementStep
            // 
            this.textBoxIncrementStep.Location = new System.Drawing.Point(75, 153);
            this.textBoxIncrementStep.Name = "textBoxIncrementStep";
            this.textBoxIncrementStep.Size = new System.Drawing.Size(100, 22);
            this.textBoxIncrementStep.TabIndex = 5;
            this.textBoxIncrementStep.Text = "0";
            this.textBoxIncrementStep.Leave += new System.EventHandler(this.TextBoxLeave);
            this.textBoxIncrementStep.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            this.textBoxIncrementStep.Validated += new System.EventHandler(this.TextBoxValidated);
            // 
            // textBoxFinalValue
            // 
            this.textBoxFinalValue.Location = new System.Drawing.Point(75, 103);
            this.textBoxFinalValue.Name = "textBoxFinalValue";
            this.textBoxFinalValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxFinalValue.TabIndex = 4;
            this.textBoxFinalValue.Text = "0";
            this.textBoxFinalValue.Leave += new System.EventHandler(this.TextBoxLeave);
            this.textBoxFinalValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            this.textBoxFinalValue.Validated += new System.EventHandler(this.TextBoxValidated);
            // 
            // textBoxInitialValue
            // 
            this.textBoxInitialValue.Location = new System.Drawing.Point(75, 58);
            this.textBoxInitialValue.Name = "textBoxInitialValue";
            this.textBoxInitialValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxInitialValue.TabIndex = 3;
            this.textBoxInitialValue.Text = "0";
            this.textBoxInitialValue.Leave += new System.EventHandler(this.TextBoxLeave);
            this.textBoxInitialValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxValidating);
            this.textBoxInitialValue.Validated += new System.EventHandler(this.TextBoxValidated);
            // 
            // labelFinalValueText
            // 
            this.labelFinalValueText.AutoSize = true;
            this.labelFinalValueText.Location = new System.Drawing.Point(56, 83);
            this.labelFinalValueText.Name = "labelFinalValueText";
            this.labelFinalValueText.Size = new System.Drawing.Size(140, 17);
            this.labelFinalValueText.TabIndex = 2;
            this.labelFinalValueText.Text = "Конечное значение";
            // 
            // labelIncrementStepText
            // 
            this.labelIncrementStepText.AutoSize = true;
            this.labelIncrementStepText.Location = new System.Drawing.Point(72, 133);
            this.labelIncrementStepText.Name = "labelIncrementStepText";
            this.labelIncrementStepText.Size = new System.Drawing.Size(119, 17);
            this.labelIncrementStepText.TabIndex = 1;
            this.labelIncrementStepText.Text = "Шаг приращения";
            // 
            // labelInitialValueText
            // 
            this.labelInitialValueText.AutoSize = true;
            this.labelInitialValueText.Location = new System.Drawing.Point(56, 38);
            this.labelInitialValueText.Name = "labelInitialValueText";
            this.labelInitialValueText.Size = new System.Drawing.Size(148, 17);
            this.labelInitialValueText.TabIndex = 0;
            this.labelInitialValueText.Text = "Начальное значение";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCalculationMode.ResumeLayout(false);
            this.groupBoxCalculationMode.PerformLayout();
            this.groupBoxEditorSettings.ResumeLayout(false);
            this.groupBoxEditorSettings.PerformLayout();
            this.panelTranslation.ResumeLayout(false);
            this.panelTranslation.PerformLayout();
            this.panelInterval.ResumeLayout(false);
            this.panelInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxIntervalResult;
        private System.Windows.Forms.Panel panelTranslation;
        private System.Windows.Forms.TextBox textBoxResultTranslation;
        private System.Windows.Forms.Label labelResultTranslationText;
        private System.Windows.Forms.TextBox textBoxEnterValueTranslation;
        private System.Windows.Forms.Label labelEnterValueTranslationText;
        private System.Windows.Forms.Panel panelInterval;
        private System.Windows.Forms.Label labelUnitMeasurementsText;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxCalculationMode;
        private System.Windows.Forms.RadioButton radioButtonIntervalValue;
        private System.Windows.Forms.RadioButton radioButtonSingleValue;
        private System.Windows.Forms.GroupBox groupBoxEditorSettings;
        private System.Windows.Forms.CheckBox checkBoxRedColor;
        private System.Windows.Forms.TextBox textBoxIncrementStep;
        private System.Windows.Forms.TextBox textBoxFinalValue;
        private System.Windows.Forms.TextBox textBoxInitialValue;
        private System.Windows.Forms.Label labelFinalValueText;
        private System.Windows.Forms.Label labelIncrementStepText;
        private System.Windows.Forms.Label labelInitialValueText;
        private MyElements.CheckedListBox checkedListBoxUnitMeasurements;
        private Button buttonCalculateTranslation;
        private Button buttonCalculateInterval;
        private ErrorProvider errorProvider1;
    }
}

