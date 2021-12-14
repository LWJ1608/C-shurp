namespace 小中大学生的平均成绩
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnglsh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPupil = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnCollege = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(174, 157);
            this.txtAge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(175, 30);
            this.txtAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "年龄";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(499, 37);
            this.txtChinese.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(175, 30);
            this.txtChinese.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "语文/必修课";
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(499, 100);
            this.txtMath.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(175, 30);
            this.txtMath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "数学/选修课";
            // 
            // txtEnglsh
            // 
            this.txtEnglsh.Location = new System.Drawing.Point(499, 157);
            this.txtEnglsh.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEnglsh.Name = "txtEnglsh";
            this.txtEnglsh.Size = new System.Drawing.Size(175, 30);
            this.txtEnglsh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "英语";
            // 
            // btnPupil
            // 
            this.btnPupil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPupil.Location = new System.Drawing.Point(709, 29);
            this.btnPupil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPupil.Name = "btnPupil";
            this.btnPupil.Size = new System.Drawing.Size(143, 48);
            this.btnPupil.TabIndex = 10;
            this.btnPupil.Text = "小学生";
            this.btnPupil.UseVisualStyleBackColor = true;
            this.btnPupil.Click += new System.EventHandler(this.btnPupil_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMiddle.Location = new System.Drawing.Point(709, 91);
            this.btnMiddle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(143, 48);
            this.btnMiddle.TabIndex = 11;
            this.btnMiddle.Text = "中学生";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnCollege
            // 
            this.btnCollege.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCollege.Location = new System.Drawing.Point(709, 149);
            this.btnCollege.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCollege.Name = "btnCollege";
            this.btnCollege.Size = new System.Drawing.Size(143, 48);
            this.btnCollege.TabIndex = 12;
            this.btnCollege.Text = "大学生";
            this.btnCollege.UseVisualStyleBackColor = true;
            this.btnCollege.Click += new System.EventHandler(this.btnCollege_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(49, 224);
            this.lblShow.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(856, 268);
            this.lblShow.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 523);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnCollege);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnPupil);
            this.Controls.Add(this.txtEnglsh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "实验1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnglsh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPupil;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnCollege;
        private System.Windows.Forms.Label lblShow;
    }
}

