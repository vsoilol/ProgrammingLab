using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyElements
{
    public sealed class CheckedListBox : System.Windows.Forms.CheckedListBox
    {
        public CheckedListBox()
        {
            ItemHeight = 20;
        }
        public override int ItemHeight { get; set; }
    }
}
