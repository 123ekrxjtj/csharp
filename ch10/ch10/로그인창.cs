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
    public partial class 로그인창 : Form
    {
        public 로그인창()
        {
            InitializeComponent();
        }

        private bool CheckData()
        {
            if (this.txtID.Text == "")  // 아디 입력 안하면
            {
                MessageBox.Show("로그인 아이디를 입력하세요", "알림",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtID.Focus();    // 커서 이동 
                return false;
            }
            else if (this.txtPass.Text == "")  // 패스 입력 안하면 
            {
                MessageBox.Show("로그인 비밀번호를 입력하세요", "알림",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPass.Focus();      // 커서 이동 
                return false;
            }
            else
            {
                if (this.txtID.Text == "test")
                {
                    if (this.txtPass.Text == "1234")  // 아디와 패스 일치하고 
                        return true;
                    else      // 패스 일치 안 하면
                    {
                        this.lbResult.Text = "일치하는 비밀번호가 없습니다.";
                        this.txtPass.Focus(); // 커서 이동 
                        return false;
                    }
                }
                else    // 아디와 패스 둘 다 일치 안 하면
                {
                    this.lbResult.Text = "일치하는 아이디가 없습니다.";
                    this.txtID.Focus(); // 커서 이동 
                    return false;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)   // CheckData()   사용 
            {
                lbResult.Text = "  로그인 성공 ";

                btnAut.Enabled = true;    //  초기값은 flase 
                btnSearch.Enabled = true;   //  초기값은 flase 
                btnAut.Visible = true;
                btnSearch.Visible = true;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnAut_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
