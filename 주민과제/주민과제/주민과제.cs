using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 주민과제
{
    public partial class 주민과제 : Form
    {
        public 주민과제()
        {
            InitializeComponent();
        }

        private void 주민과제_Load(object sender, EventArgs e)
        {

        }

        private void tx_Front_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <'0' || e.KeyChar > '9') && 
                (e.KeyChar != (char) Keys.Back))
            {
                MessageBox.Show("숫자만 입력하세요");
                e.Handled = true;
            }
            if(tx_Front.Text.Length == 5)
            {
                tx_Back.Focus();
                tx_Back_Clear();
            }
        }

        private void tx_Back_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("숫자만 입력하세요");
                e.Handled = true;
            }
        }


        private void tx_Front_Clear()
        {
            tx_Front.Clear();
        }

        private void tx_Back_Clear()
        {
            tx_Back.Clear();
        }

        private void tx_Front_MouseClick(object sender, MouseEventArgs e)
        {
            tx_Front_Clear();
        }

        private void tx_Back_MouseClick(object sender, MouseEventArgs e)
        {
            tx_Back_Clear();
        }
    }
}
