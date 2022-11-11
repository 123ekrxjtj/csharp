namespace ch10
{
    partial class 과제1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOutput = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbInputAge = new System.Windows.Forms.Label();
            this.lbInputName = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.txAge = new System.Windows.Forms.TextBox();
            this.txInputAge = new System.Windows.Forms.TextBox();
            this.txInputName = new System.Windows.Forms.TextBox();
            this.lbOutAge = new System.Windows.Forms.Label();
            this.lbOutName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(121, 131);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "전송하기";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(35, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "이름";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(35, 96);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(29, 12);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "나이";
            // 
            // lbInputAge
            // 
            this.lbInputAge.AutoSize = true;
            this.lbInputAge.Location = new System.Drawing.Point(35, 238);
            this.lbInputAge.Name = "lbInputAge";
            this.lbInputAge.Size = new System.Drawing.Size(69, 12);
            this.lbInputAge.TabIndex = 4;
            this.lbInputAge.Text = "입력한 이름";
            // 
            // lbInputName
            // 
            this.lbInputName.AutoSize = true;
            this.lbInputName.Location = new System.Drawing.Point(35, 192);
            this.lbInputName.Name = "lbInputName";
            this.lbInputName.Size = new System.Drawing.Size(69, 12);
            this.lbInputName.TabIndex = 3;
            this.lbInputName.Text = "입력한 나이";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(121, 40);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 21);
            this.txName.TabIndex = 5;
            // 
            // txAge
            // 
            this.txAge.Location = new System.Drawing.Point(121, 91);
            this.txAge.Name = "txAge";
            this.txAge.Size = new System.Drawing.Size(100, 21);
            this.txAge.TabIndex = 6;
            // 
            // txInputAge
            // 
            this.txInputAge.Location = new System.Drawing.Point(121, 233);
            this.txInputAge.Name = "txInputAge";
            this.txInputAge.Size = new System.Drawing.Size(100, 21);
            this.txInputAge.TabIndex = 8;
            // 
            // txInputName
            // 
            this.txInputName.Location = new System.Drawing.Point(121, 187);
            this.txInputName.Name = "txInputName";
            this.txInputName.Size = new System.Drawing.Size(100, 21);
            this.txInputName.TabIndex = 7;
            // 
            // lbOutAge
            // 
            this.lbOutAge.AutoSize = true;
            this.lbOutAge.Location = new System.Drawing.Point(276, 238);
            this.lbOutAge.Name = "lbOutAge";
            this.lbOutAge.Size = new System.Drawing.Size(0, 12);
            this.lbOutAge.TabIndex = 10;
            // 
            // lbOutName
            // 
            this.lbOutName.AutoSize = true;
            this.lbOutName.Location = new System.Drawing.Point(276, 192);
            this.lbOutName.Name = "lbOutName";
            this.lbOutName.Size = new System.Drawing.Size(5, 12);
            this.lbOutName.TabIndex = 9;
            this.lbOutName.Text = "\r\n";
            // 
            // 과제1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbOutAge);
            this.Controls.Add(this.lbOutName);
            this.Controls.Add(this.txInputAge);
            this.Controls.Add(this.txInputName);
            this.Controls.Add(this.txAge);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbInputAge);
            this.Controls.Add(this.lbInputName);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnOutput);
            this.Name = "과제1";
            this.Text = "과제1";
            this.Load += new System.EventHandler(this.과제1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbInputAge;
        private System.Windows.Forms.Label lbInputName;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txAge;
        private System.Windows.Forms.TextBox txInputAge;
        private System.Windows.Forms.TextBox txInputName;
        private System.Windows.Forms.Label lbOutAge;
        private System.Windows.Forms.Label lbOutName;
    }
}