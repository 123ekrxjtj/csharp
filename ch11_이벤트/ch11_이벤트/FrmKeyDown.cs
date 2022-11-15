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
    public partial class FrmKeyDown : Form
    {
        private Point p, red;    //  포인터 객체
        private int score = 0;
        public FrmKeyDown()
        {
            InitializeComponent();
            p.X = 50; p.Y = 360; //  좌표 할당
            red.X = 0; red.Y = 0;
        }

        private void FrmK됴애주_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, p.X, p.Y, 40, 40);
            e.Graphics.FillEllipse(Brushes.Red, red.X, red.Y, 40, 40);
        }

        private void FrmK됴애주_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    p.X -= 20;
                    if (p.X < 0) p.X = 300;
                    red.Y += 30;
                    if (red.Y >500) red.Y = 0;
                    Invalidate();
                    break;
                case Keys.Right:
                    p.X += 20;
                    if (p.X > 300) p.X = 0;
                    red.Y += 30;
                    if (red.Y > 500) red.Y = 0;
                    Invalidate();
                    break;
                default:
                    break;
            }
            int difX = (p.X - red.X) * (p.X - red.X);
            int difY = (p.Y - red.Y) * (p.Y - red.Y);
            if (difX + difY <= 40 * 40)
            {
                red.Y = 0;
                score++;
                label1.Text = Convert.ToString(score);
            }
        }
    }
}
