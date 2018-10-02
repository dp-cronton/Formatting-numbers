using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formatting_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n\n");

            double pi = 3.141592653589793;
            double c = 299792458;

            richTextBox1.AppendText(pi.ToString("0.000") + " (pi to 3dp)\n");
            richTextBox1.AppendText(pi.ToString("0.00000") + " (pi to 5dp)\n");
            richTextBox1.AppendText(pi.ToString("N15") + " (pi to 15dp)\n\n");

            richTextBox1.AppendText(c.ToString() + " (c)\n");
            richTextBox1.AppendText(c.ToString("N0") + " (c with ,)\n");
            richTextBox1.AppendText(c.ToString("0.000000000000000E0") + " (c to 16SF)\n");
            richTextBox1.AppendText(c.ToString("0.00E0") + " (c to 3SF)\n");
        }
    }
}
