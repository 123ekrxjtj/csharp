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
    public partial class FrmMouseDown : Form
    {
        public FrmMouseDown()
        {
            InitializeComponent();
        }

        private void FrmMouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            // e.Button : 눌러진 마우스 버튼 값
            // MouseButton :  마우스 중에서 어떤 마우스 버튼 눌렀는지
            if (e.Button == MouseButtons.Right)
            {
                // 그래픽 객체 생성
                Graphics g = CreateGraphics();
                // 우측 마우스 클릭시 아래의 원 그리기
                g.DrawEllipse(Pens.Red, 0, 0, 20, 20);
                // 지정된 좌표에 20 크기 원
                g.DrawEllipse(Pens.Black, e.X, e.Y, 15, 15);
                // 마우스 클릭된 위치에서 15 크기 원
                g.Dispose();   //할당된 메모리가 더 이상 사용되지
            }  // 않을 때 가비지 수집기를 통해 리소스를  해제 함
            p.X = e.X; p.Y = e.Y; // 클릭한 곳의 좌표를 기억
        }

        private Point p; //  Point 객체 p 생성


        private void FrmMouseDown_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // 윈쪽 마우스 버튼 눌렀을 때 처리 
            {
                Graphics g = this.CreateGraphics();
                // 클릭한 곳의 좌표에서 드래그 한 곳 까지 직선 그림
                g.DrawLine(Pens.Blue, p.X, p.Y, e.X, e.Y);
                g.Dispose(); // 모든 리소스 해제
            }
        }

    }
}
