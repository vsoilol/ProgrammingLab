using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingLabWinForms
{
    public partial class WindowsForm : Form
    {
        private double[] degrees = new double[3];
        private TextBox[] textBoxesDegree;

        private const string IncorrectValue = "Вы ввели неверное значение";
        private const string DiscriminantLessZero = "Дискриминант меньше нуля";
        private const string NoValue = "Вы не ввели значение";

        public WindowsForm()
        {
            InitializeComponent();

            textBoxesDegree = new TextBox[]
            {
                textBoxZeroDegreeValue,
                textBoxFirstDegreeValue,
                textBoxSecondDegreeValue,
            };
        }

        private void textBoxSecondDegreeValue_Leave(object sender, EventArgs e)
        {
            AssignValue(2);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxFirstDegreeValue_Leave(object sender, EventArgs e)
        {
            AssignValue(1);
        }

        private void textBoxZeroDegreeValue_Leave(object sender, EventArgs e)
        {
            AssignValue(0);
        }

        private void AssignValue(int numberArray)
        {
            if (!double.TryParse(textBoxesDegree[numberArray].Text, out degrees[numberArray]))
            {
                ShowError(IncorrectValue);
                textBoxesDegree[numberArray].Text = string.Empty;
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxesDegree)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    ShowError(NoValue);
                    return;
                }
            }
            CalculateEquationRoots();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxesDegree)
            {
                textBox.Text = string.Empty;
            }

            degrees = new double[3];

            labelFirstRootValue.Text = string.Empty;
            labelSecondRootValue.Text = string.Empty;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculateEquationRoots()
        {
            double discriminant = Math.Pow(degrees[1], 2) - 4 * degrees[0] * degrees[2];

            if (discriminant < 0)
            {
                ShowError(DiscriminantLessZero);
            }
            else
            {
                labelFirstRootValue.Text = ((-degrees[1] + Math.Sqrt(discriminant)) / (2 * degrees[0])).ToString();
                labelSecondRootValue.Text = ((-degrees[1] - Math.Sqrt(discriminant)) / (2 * degrees[0])).ToString();
            }
        }
    }
}
