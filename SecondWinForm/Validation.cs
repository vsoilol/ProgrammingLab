using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondWinForm
{
    class Validation
    {
        public static bool ValidIntervalValue(TextBox textBox, out double value, out string errorMessage)
        {
            errorMessage = "";

            if (!double.TryParse(textBox.Text, out value))
            {
                errorMessage = Resources.IncorrectValue;
                return false;
            }

            if (value < 0)
            {
                errorMessage = Resources.NegativeValue;
                return false;
            }
            return true;
        }
    }
}
