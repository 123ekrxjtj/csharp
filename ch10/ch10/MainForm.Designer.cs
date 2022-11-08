namespace ch10
{
    partial class MainForm
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
            this.btnOutput = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txResult = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(204, 95);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "출력";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "이름";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(6, 135);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(29, 12);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "결과";
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(75, 132);
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(100, 21);
            this.txResult.TabIndex = 3;
            this.txResult.Click += new System.EventHandler(this.tx_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(75, 95);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 21);
            this.txName.TabIndex = 4;
            this.txName.Text = "이름을 입력하세요";
            this.txName.Click += new System.EventHandler(this.tx_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(204, 132);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "리셋";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnOutput);
            this.Name = "MainForm";
            this.Text = "201901566";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txResult;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Button btnReset;
    }
}

