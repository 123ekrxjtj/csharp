namespace ch10
{
    partial class 사칙연산
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
            this.lxA = new System.Windows.Forms.Label();
            this.lxB = new System.Windows.Forms.Label();
            this.lxResult = new System.Windows.Forms.Label();
            this.txA = new System.Windows.Forms.TextBox();
            this.txB = new System.Windows.Forms.TextBox();
            this.txResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lxA
            // 
            this.lxA.AutoSize = true;
            this.lxA.Location = new System.Drawing.Point(34, 65);
            this.lxA.Name = "lxA";
            this.lxA.Size = new System.Drawing.Size(13, 12);
            this.lxA.TabIndex = 0;
            this.lxA.Text = "A";
            // 
            // lxB
            // 
            this.lxB.AutoSize = true;
            this.lxB.Location = new System.Drawing.Point(34, 147);
            this.lxB.Name = "lxB";
            this.lxB.Size = new System.Drawing.Size(13, 12);
            this.lxB.TabIndex = 1;
            this.lxB.Text = "B";
            // 
            // lxResult
            // 
            this.lxResult.AutoSize = true;
            this.lxResult.Location = new System.Drawing.Point(34, 218);
            this.lxResult.Name = "lxResult";
            this.lxResult.Size = new System.Drawing.Size(41, 12);
            this.lxResult.TabIndex = 2;
            this.lxResult.Text = "결과는";
            // 
            // txA
            // 
            this.txA.Location = new System.Drawing.Point(165, 55);
            this.txA.Name = "txA";
            this.txA.Size = new System.Drawing.Size(100, 21);
            this.txA.TabIndex = 3;
            // 
            // txB
            // 
            this.txB.Location = new System.Drawing.Point(165, 138);
            this.txB.Name = "txB";
            this.txB.Size = new System.Drawing.Size(100, 21);
            this.txB.TabIndex = 4;
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(165, 209);
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(100, 21);
            this.txResult.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 사칙연산
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txResult);
            this.Controls.Add(this.txB);
            this.Controls.Add(this.txA);
            this.Controls.Add(this.lxResult);
            this.Controls.Add(this.lxB);
            this.Controls.Add(this.lxA);
            this.Name = "사칙연산";
            this.Text = "사칙연산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lxA;
        private System.Windows.Forms.Label lxB;
        private System.Windows.Forms.Label lxResult;
        private System.Windows.Forms.TextBox txA;
        private System.Windows.Forms.TextBox txB;
        private System.Windows.Forms.TextBox txResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}