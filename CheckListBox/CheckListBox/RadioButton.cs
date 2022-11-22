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
    public partial class RadioButton : Form
    {
        public RadioButton()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            // Checked 초기값은 False
            if (txSpl == radB1.Text)
                radB1.Checked = true;

            else if (txSpl == radB2.Text)
                radB2.Checked = true;

            else if (txSpl == radB3.Text)
                radB3.Checked = true;

        }
    }
}
