namespace ch11_이벤트
{
    public partial class FirmKeyBoard : Form
    {
        public FirmKeyBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                button1.Focus();
            }
        }
    }
}