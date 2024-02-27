using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txb_A.Text);
            double b = double.Parse(txb_B.Text);
            double c = a + b;

            txb_KQ.Text = c.ToString();
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txb_A.Text);
            double b = double.Parse(txb_B.Text);
            double c = a - b;

            txb_KQ.Text = c.ToString();
        }
    }
}
