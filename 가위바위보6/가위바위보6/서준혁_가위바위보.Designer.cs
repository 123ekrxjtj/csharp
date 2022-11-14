namespace ch10_2_가위바위보
{
    partial class 서준혁_가위바위보
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(서준혁_가위바위보));
            this.lbCom = new System.Windows.Forms.Label();
            this.lbMe = new System.Windows.Forms.Label();
            this.pbCom = new System.Windows.Forms.PictureBox();
            this.pbMe = new System.Windows.Forms.PictureBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnGawei = new System.Windows.Forms.Button();
            this.btnBawei = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.Timer_View_Result = new System.Windows.Forms.Timer(this.components);
            this.btn_View_Result = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Com_P = new System.Windows.Forms.Label();
            this.lb_Com_R = new System.Windows.Forms.Label();
            this.lb_Com_S = new System.Windows.Forms.Label();
            this.lb_Com = new System.Windows.Forms.Label();
            this.lb_Me_P = new System.Windows.Forms.Label();
            this.lb_Me_R = new System.Windows.Forms.Label();
            this.lb_Me_S = new System.Windows.Forms.Label();
            this.lb_Me = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Total_Count = new System.Windows.Forms.Label();
            this.lb_Draw_Score = new System.Windows.Forms.Label();
            this.lb_Com_Score = new System.Windows.Forms.Label();
            this.lb_Me_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(12, 81);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(43, 15);
            this.lbCom.TabIndex = 0;
            this.lbCom.Text = "컴퓨터";
            // 
            // lbMe
            // 
            this.lbMe.AutoSize = true;
            this.lbMe.Location = new System.Drawing.Point(12, 216);
            this.lbMe.Name = "lbMe";
            this.lbMe.Size = new System.Drawing.Size(19, 15);
            this.lbMe.TabIndex = 1;
            this.lbMe.Text = "나";
            // 
            // pbCom
            // 
            this.pbCom.Location = new System.Drawing.Point(87, 24);
            this.pbCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCom.Name = "pbCom";
            this.pbCom.Size = new System.Drawing.Size(110, 125);
            this.pbCom.TabIndex = 2;
            this.pbCom.TabStop = false;
            // 
            // pbMe
            // 
            this.pbMe.Location = new System.Drawing.Point(87, 169);
            this.pbMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMe.Name = "pbMe";
            this.pbMe.Size = new System.Drawing.Size(110, 125);
            this.pbMe.TabIndex = 3;
            this.pbMe.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(293, 216);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(31, 15);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "결과";
            // 
            // btnGawei
            // 
            this.btnGawei.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGawei.ForeColor = System.Drawing.Color.Red;
            this.btnGawei.Image = ((System.Drawing.Image)(resources.GetObject("btnGawei.Image")));
            this.btnGawei.Location = new System.Drawing.Point(27, 345);
            this.btnGawei.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGawei.Name = "btnGawei";
            this.btnGawei.Size = new System.Drawing.Size(95, 98);
            this.btnGawei.TabIndex = 5;
            this.btnGawei.Text = "1";
            this.btnGawei.UseVisualStyleBackColor = true;
            this.btnGawei.Click += new System.EventHandler(this.gawei_Click);
            // 
            // btnBawei
            // 
            this.btnBawei.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBawei.ForeColor = System.Drawing.Color.Red;
            this.btnBawei.Image = ((System.Drawing.Image)(resources.GetObject("btnBawei.Image")));
            this.btnBawei.Location = new System.Drawing.Point(128, 345);
            this.btnBawei.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBawei.Name = "btnBawei";
            this.btnBawei.Size = new System.Drawing.Size(110, 98);
            this.btnBawei.TabIndex = 6;
            this.btnBawei.Text = "2";
            this.btnBawei.UseVisualStyleBackColor = true;
            this.btnBawei.Click += new System.EventHandler(this.bawei_Click);
            // 
            // btnBo
            // 
            this.btnBo.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBo.ForeColor = System.Drawing.Color.Red;
            this.btnBo.Image = ((System.Drawing.Image)(resources.GetObject("btnBo.Image")));
            this.btnBo.Location = new System.Drawing.Point(244, 345);
            this.btnBo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(110, 98);
            this.btnBo.TabIndex = 7;
            this.btnBo.Text = "3";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.bo_Click);
            // 
            // Timer_View_Result
            // 
            this.Timer_View_Result.Tick += new System.EventHandler(this.Timer_View_Result_Tick);
            // 
            // btn_View_Result
            // 
            this.btn_View_Result.Location = new System.Drawing.Point(259, 254);
            this.btn_View_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_View_Result.Name = "btn_View_Result";
            this.btn_View_Result.Size = new System.Drawing.Size(95, 29);
            this.btn_View_Result.TabIndex = 8;
            this.btn_View_Result.Text = "결과보기";
            this.btn_View_Result.UseVisualStyleBackColor = true;
            this.btn_View_Result.Click += new System.EventHandler(this.btn_View_Result_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Com_P);
            this.groupBox1.Controls.Add(this.lb_Com_R);
            this.groupBox1.Controls.Add(this.lb_Com_S);
            this.groupBox1.Controls.Add(this.lb_Com);
            this.groupBox1.Controls.Add(this.lb_Me_P);
            this.groupBox1.Controls.Add(this.lb_Me_R);
            this.groupBox1.Controls.Add(this.lb_Me_S);
            this.groupBox1.Controls.Add(this.lb_Me);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_Total_Count);
            this.groupBox1.Controls.Add(this.lb_Draw_Score);
            this.groupBox1.Controls.Add(this.lb_Com_Score);
            this.groupBox1.Controls.Add(this.lb_Me_Score);
            this.groupBox1.Location = new System.Drawing.Point(386, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(236, 419);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "게임 결과";
            // 
            // lb_Com_P
            // 
            this.lb_Com_P.AutoSize = true;
            this.lb_Com_P.Location = new System.Drawing.Point(124, 359);
            this.lb_Com_P.Name = "lb_Com_P";
            this.lb_Com_P.Size = new System.Drawing.Size(77, 15);
            this.lb_Com_P.TabIndex = 12;
            this.lb_Com_P.Text = "보 횟수 : 0번";
            // 
            // lb_Com_R
            // 
            this.lb_Com_R.AutoSize = true;
            this.lb_Com_R.Location = new System.Drawing.Point(124, 328);
            this.lb_Com_R.Name = "lb_Com_R";
            this.lb_Com_R.Size = new System.Drawing.Size(89, 15);
            this.lb_Com_R.TabIndex = 11;
            this.lb_Com_R.Text = "바위 횟수 : 0번";
            // 
            // lb_Com_S
            // 
            this.lb_Com_S.AutoSize = true;
            this.lb_Com_S.Location = new System.Drawing.Point(124, 292);
            this.lb_Com_S.Name = "lb_Com_S";
            this.lb_Com_S.Size = new System.Drawing.Size(89, 15);
            this.lb_Com_S.TabIndex = 10;
            this.lb_Com_S.Text = "가위 횟수 : 0번";
            // 
            // lb_Com
            // 
            this.lb_Com.AutoSize = true;
            this.lb_Com.Location = new System.Drawing.Point(124, 255);
            this.lb_Com.Name = "lb_Com";
            this.lb_Com.Size = new System.Drawing.Size(31, 15);
            this.lb_Com.TabIndex = 9;
            this.lb_Com.Text = "컴의";
            // 
            // lb_Me_P
            // 
            this.lb_Me_P.AutoSize = true;
            this.lb_Me_P.Location = new System.Drawing.Point(20, 359);
            this.lb_Me_P.Name = "lb_Me_P";
            this.lb_Me_P.Size = new System.Drawing.Size(77, 15);
            this.lb_Me_P.TabIndex = 8;
            this.lb_Me_P.Text = "보 횟수 : 0번";
            // 
            // lb_Me_R
            // 
            this.lb_Me_R.AutoSize = true;
            this.lb_Me_R.Location = new System.Drawing.Point(20, 328);
            this.lb_Me_R.Name = "lb_Me_R";
            this.lb_Me_R.Size = new System.Drawing.Size(89, 15);
            this.lb_Me_R.TabIndex = 7;
            this.lb_Me_R.Text = "바위 횟수 : 0번";
            // 
            // lb_Me_S
            // 
            this.lb_Me_S.AutoSize = true;
            this.lb_Me_S.Location = new System.Drawing.Point(20, 292);
            this.lb_Me_S.Name = "lb_Me_S";
            this.lb_Me_S.Size = new System.Drawing.Size(89, 15);
            this.lb_Me_S.TabIndex = 6;
            this.lb_Me_S.Text = "가위 횟수 : 0번";
            // 
            // lb_Me
            // 
            this.lb_Me.AutoSize = true;
            this.lb_Me.Location = new System.Drawing.Point(20, 255);
            this.lb_Me.Name = "lb_Me";
            this.lb_Me.Size = new System.Drawing.Size(31, 15);
            this.lb_Me.TabIndex = 5;
            this.lb_Me.Text = "나의";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "----------------------------";
            // 
            // lb_Total_Count
            // 
            this.lb_Total_Count.AutoSize = true;
            this.lb_Total_Count.Location = new System.Drawing.Point(20, 176);
            this.lb_Total_Count.Name = "lb_Total_Count";
            this.lb_Total_Count.Size = new System.Drawing.Size(105, 15);
            this.lb_Total_Count.TabIndex = 3;
            this.lb_Total_Count.Text = "총 게임 횟수 : 0번";
            // 
            // lb_Draw_Score
            // 
            this.lb_Draw_Score.AutoSize = true;
            this.lb_Draw_Score.Location = new System.Drawing.Point(20, 145);
            this.lb_Draw_Score.Name = "lb_Draw_Score";
            this.lb_Draw_Score.Size = new System.Drawing.Size(89, 15);
            this.lb_Draw_Score.TabIndex = 2;
            this.lb_Draw_Score.Text = "비긴 횟수 : 0번";
            // 
            // lb_Com_Score
            // 
            this.lb_Com_Score.AutoSize = true;
            this.lb_Com_Score.Location = new System.Drawing.Point(20, 110);
            this.lb_Com_Score.Name = "lb_Com_Score";
            this.lb_Com_Score.Size = new System.Drawing.Size(117, 15);
            this.lb_Com_Score.TabIndex = 1;
            this.lb_Com_Score.Text = "컴이 이긴 횟수 : 0번";
            // 
            // lb_Me_Score
            // 
            this.lb_Me_Score.AutoSize = true;
            this.lb_Me_Score.Location = new System.Drawing.Point(20, 72);
            this.lb_Me_Score.Name = "lb_Me_Score";
            this.lb_Me_Score.Size = new System.Drawing.Size(117, 15);
            this.lb_Me_Score.TabIndex = 0;
            this.lb_Me_Score.Text = "내가 이긴 횟수 : 0번";
            // 
            // 서준혁_가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_View_Result);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnBawei);
            this.Controls.Add(this.btnGawei);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.pbMe);
            this.Controls.Add(this.pbCom);
            this.Controls.Add(this.lbMe);
            this.Controls.Add(this.lbCom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(650, 490);
            this.MinimumSize = new System.Drawing.Size(370, 490);
            this.Name = "서준혁_가위바위보";
            this.Text = "서준혁_가위바위보";
            ((System.ComponentModel.ISupportInitialize)(this.pbCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Label lbMe;
        private System.Windows.Forms.PictureBox pbCom;
        private System.Windows.Forms.PictureBox pbMe;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnGawei;
        private System.Windows.Forms.Button btnBawei;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Timer Timer_View_Result;
        private System.Windows.Forms.Button btn_View_Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Com_P;
        private System.Windows.Forms.Label lb_Com_R;
        private System.Windows.Forms.Label lb_Com_S;
        private System.Windows.Forms.Label lb_Com;
        private System.Windows.Forms.Label lb_Me_P;
        private System.Windows.Forms.Label lb_Me_R;
        private System.Windows.Forms.Label lb_Me_S;
        private System.Windows.Forms.Label lb_Me;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Total_Count;
        private System.Windows.Forms.Label lb_Draw_Score;
        private System.Windows.Forms.Label lb_Com_Score;
        private System.Windows.Forms.Label lb_Me_Score;
    }
}

