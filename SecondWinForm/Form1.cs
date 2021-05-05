using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SecondWinForm
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> translationValues;
        readonly Dictionary<TextBox, double> textBoxValues;

        public Form1()
        {
            CreateTranslationValues();
            
            InitializeComponent();

            AddCheckBoxItems();

            panelTranslation.Visible = true;
            radioButtonSingleValue.Checked = true;
            panelInterval.Visible = false;

            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            textBoxValues = new Dictionary<TextBox, double>
            { 
                {textBoxFinalValue, 0 },
                {textBoxInitialValue, 0 },
                {textBoxIncrementStep, 0 },
                {textBoxEnterValueTranslation, 0 },
            };
        }

        private void CreateTranslationValues()
        {
            translationValues = new Dictionary<string, double>
            {
                {"Фунт", 400 },
                {"Пуд", 16380},
                {"Унция", 28.35 },
                {"Драхм", 3.732 },
                {"Гран", 0.0622 }
            };
        }

        private void AddCheckBoxItems()
        {
            foreach (var item in translationValues.Keys)
            {
                checkedListBoxUnitMeasurements.Items.Add(item);
            }
        }

        private void checkBoxRedColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRedColor.Checked)
            {
                checkedListBoxUnitMeasurements.ForeColor = Color.Red;
            }
            else
            {
                checkedListBoxUnitMeasurements.ForeColor = Color.Blue;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonSingleValue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingleValue.Checked)
            {
                panelTranslation.Visible = true;
                panelInterval.Visible = false;
            }
            else
            {
                panelTranslation.Visible = false;
                panelInterval.Visible = true;
            }
        }

        private void checkedListBoxUnitMeasurements_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxUnitMeasurements.CheckedItems.Count > 0)
            {
                checkedListBoxUnitMeasurements.ItemCheck -= checkedListBoxUnitMeasurements_ItemCheck;
                checkedListBoxUnitMeasurements.SetItemChecked(checkedListBoxUnitMeasurements.CheckedIndices[0], false);
                checkedListBoxUnitMeasurements.ItemCheck += checkedListBoxUnitMeasurements_ItemCheck;
            }
        }

        private void buttonCalculateTranslation_Click(object sender, EventArgs e)
        {
            if(CheckAndGetUnitMeasurement(out string translation))
            {
                textBoxResultTranslation.Text = (textBoxValues[textBoxEnterValueTranslation] * translationValues[translation]).ToString();
            }
        }

        #region Interval
        private void buttonCalculateInterval_Click(object sender, EventArgs e)
        {
            if(textBoxValues[textBoxFinalValue] <= textBoxValues[textBoxInitialValue])
            {
                ShowErrorAndClearTextBoxes(Resources.InitialValueGreaterThanFinal, textBoxFinalValue, textBoxInitialValue);
                return;
            }

            if(textBoxValues[textBoxIncrementStep] == 0)
            {
                ShowErrorAndClearTextBoxes(Resources.ZeroStep, textBoxIncrementStep);
                return;
            }

            if((textBoxValues[textBoxFinalValue] - textBoxValues[textBoxInitialValue]) <= textBoxValues[textBoxIncrementStep])
            {
                ShowErrorAndClearTextBoxes(Resources.StepGreaterThanIntervalLength, textBoxIncrementStep);
                return;
            }

            if(CheckAndGetUnitMeasurement(out string translation))
            {
                richTextBoxIntervalResult.Text = string.Empty;

                for (double i = textBoxValues[textBoxInitialValue]; i <= textBoxValues[textBoxFinalValue]; i += textBoxValues[textBoxIncrementStep])
                {
                    richTextBoxIntervalResult.Text += (i * translationValues[translation]).ToString() + "\n";
                }
            }

        }

        private void TextBoxLeave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                ClearTextBox(textBox);
            }
        }

        private void TextBoxValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!Validation.ValidIntervalValue(textBox, out double value, out string errorMessage))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, errorMessage);
                textBox.Select(0, textBox.Text.Length);
            }
            else
            {
                textBoxValues[textBox] = value;
            }
        }

        private void TextBoxValidated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        #endregion

        private void ShowErrorAndClearTextBoxes(string message, params TextBox[] textBoxes)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (var textBox in textBoxes)
            {
                ClearTextBox(textBox);
            }
        }

        private void ClearTextBox(TextBox textBox)
        {
            textBox.Text = "0";
            textBoxValues[textBox] = 0;
        }

        private bool CheckAndGetUnitMeasurement(out string translation)
        {
            translation = "";
            if (checkedListBoxUnitMeasurements.CheckedItems.Count == 0)
            {
                ShowErrorAndClearTextBoxes(Resources.ValueNotSelected);
                return false;
            }

            translation = checkedListBoxUnitMeasurements.CheckedItems[0].ToString();
            return true;
        }
    }
}
