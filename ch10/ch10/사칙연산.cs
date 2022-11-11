using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Operation;

namespace ch10
{
    public partial class 사칙연산 : Form
    {
        public 사칙연산()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float doubleA = Convert.ToSingle(txA.Text);
            float doubleB = Convert.ToSingle(txB.Text);
            //  float result = doubleA + doubleB;
            float result = 연산.Plus(doubleA, doubleB);
            txResult.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float doubleA = Convert.ToSingle(txA.Text);
            float doubleB = Convert.ToSingle(txB.Text);
            //  float result = doubleA + doubleB;
            float result = 연산.Minus(doubleA, doubleB);
            txResult.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float doubleA = Convert.ToSingle(txA.Text);
            float doubleB = Convert.ToSingle(txB.Text);
            //  float result = doubleA + doubleB;
            float result = 연산.Multiply(doubleA, doubleB);
            txResult.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float doubleA = Convert.ToSingle(txA.Text);
            float doubleB = Convert.ToSingle(txB.Text);
            //  float result = doubleA + doubleB;
            float result = 연산.Divide(doubleA, doubleB);
            txResult.Text = Convert.ToString(result);
        }
    }
}
