using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10
{
    public partial class 과제1 : Form
    {
        public 과제1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            txInputName.Text = txName.Text;
            txInputAge.Text = txAge.Text;
        }

        private void 과제1_Load(object sender, EventArgs e)
        {

        }
    }
}
