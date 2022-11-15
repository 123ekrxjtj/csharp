using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch11_이벤트
{
    public partial class FrmKeyInput : Form
    {
        public FrmKeyInput()
        {
            InitializeComponent();
        }

        private void FrmKeyInput_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = Convert.ToString(e.KeyCode);
        }
    }
}
