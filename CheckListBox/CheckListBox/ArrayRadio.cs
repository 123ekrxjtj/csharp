using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class ArrayRadio : Form
    {
        public ArrayRadio()
        {
            InitializeComponent();
            Rb2_1.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int score = 0;
            if(Rb1_1.Checked == true) { score++; }
            if(Rb2_3.Checked == true) { score++; }
            lbScore.Text = "Score : " + score.ToString();
        }
    }
}
