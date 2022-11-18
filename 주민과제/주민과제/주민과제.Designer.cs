namespace 주민과제
{
    partial class 주민과제
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_Front = new System.Windows.Forms.TextBox();
            this.tx_Back = new System.Windows.Forms.TextBox();
            this.tx_Year = new System.Windows.Forms.TextBox();
            this.tx_Month = new System.Windows.Forms.TextBox();
            this.tx_Days = new System.Windows.Forms.TextBox();
            this.tx_Gender = new System.Windows.Forms.TextBox();
            this.tx_Age = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "주민번호 입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "생년월일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "성별";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "나이";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "년";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "월";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "일";
            // 
            // tx_Front
            // 
            this.tx_Front.Location = new System.Drawing.Point(134, 60);
            this.tx_Front.Name = "tx_Front";
            this.tx_Front.Size = new System.Drawing.Size(100, 21);
            this.tx_Front.TabIndex = 8;
            this.tx_Front.Text = "앞 6자리";
            this.tx_Front.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tx_Front_MouseClick);
            this.tx_Front.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Front_KeyPress);
            // 
            // tx_Back
            // 
            this.tx_Back.Location = new System.Drawing.Point(270, 60);
            this.tx_Back.Name = "tx_Back";
            this.tx_Back.Size = new System.Drawing.Size(100, 21);
            this.tx_Back.TabIndex = 9;
            this.tx_Back.Text = "뒤 7자리";
            this.tx_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tx_Back_MouseClick);
            this.tx_Back.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Back_KeyPress);
            // 
            // tx_Year
            // 
            this.tx_Year.Location = new System.Drawing.Point(117, 219);
            this.tx_Year.Name = "tx_Year";
            this.tx_Year.Size = new System.Drawing.Size(54, 21);
            this.tx_Year.TabIndex = 10;
            // 
            // tx_Month
            // 
            this.tx_Month.Location = new System.Drawing.Point(201, 219);
            this.tx_Month.Name = "tx_Month";
            this.tx_Month.Size = new System.Drawing.Size(54, 21);
            this.tx_Month.TabIndex = 11;
            // 
            // tx_Days
            // 
            this.tx_Days.Location = new System.Drawing.Point(291, 219);
            this.tx_Days.Name = "tx_Days";
            this.tx_Days.Size = new System.Drawing.Size(54, 21);
            this.tx_Days.TabIndex = 12;
            // 
            // tx_Gender
            // 
            this.tx_Gender.Location = new System.Drawing.Point(117, 280);
            this.tx_Gender.Name = "tx_Gender";
            this.tx_Gender.Size = new System.Drawing.Size(54, 21);
            this.tx_Gender.TabIndex = 13;
            // 
            // tx_Age
            // 
            this.tx_Age.Location = new System.Drawing.Point(117, 338);
            this.tx_Age.Name = "tx_Age";
            this.tx_Age.Size = new System.Drawing.Size(54, 21);
            this.tx_Age.TabIndex = 14;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(134, 117);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 15;
            this.btn_Confirm.Text = "확인";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "label9";
            // 
            // 주민과제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 381);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.tx_Age);
            this.Controls.Add(this.tx_Gender);
            this.Controls.Add(this.tx_Days);
            this.Controls.Add(this.tx_Month);
            this.Controls.Add(this.tx_Year);
            this.Controls.Add(this.tx_Back);
            this.Controls.Add(this.tx_Front);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "주민과제";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.주민과제_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_Front;
        private System.Windows.Forms.TextBox tx_Back;
        private System.Windows.Forms.TextBox tx_Year;
        private System.Windows.Forms.TextBox tx_Month;
        private System.Windows.Forms.TextBox tx_Days;
        private System.Windows.Forms.TextBox tx_Gender;
        private System.Windows.Forms.TextBox tx_Age;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label9;
    }
}

