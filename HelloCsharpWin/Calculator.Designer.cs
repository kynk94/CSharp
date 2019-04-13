namespace HelloCsharpWin
{
    partial class Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_signed = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 80);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_num_Click);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.White;
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Screen.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Screen.Location = new System.Drawing.Point(17, 9);
            this.Screen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(382, 52);
            this.Screen.TabIndex = 3;
            this.Screen.Text = "0";
            this.Screen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 66);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 152);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 66);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 152);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 66);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(17, 224);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 66);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(95, 224);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 66);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(173, 224);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 66);
            this.button9.TabIndex = 1;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(251, 80);
            this.button_plus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(70, 66);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_oper_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(251, 152);
            this.button_minus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(70, 66);
            this.button_minus.TabIndex = 5;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_oper_Click);
            // 
            // button_mul
            // 
            this.button_mul.Location = new System.Drawing.Point(251, 224);
            this.button_mul.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(70, 66);
            this.button_mul.TabIndex = 6;
            this.button_mul.Text = "X";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_oper_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(251, 296);
            this.button_div.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(70, 66);
            this.button_div.TabIndex = 7;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_oper_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(95, 296);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 66);
            this.button0.TabIndex = 8;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_num_Click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(173, 296);
            this.button_dot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(70, 66);
            this.button_dot.TabIndex = 9;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_signed
            // 
            this.button_signed.Location = new System.Drawing.Point(17, 296);
            this.button_signed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_signed.Name = "button_signed";
            this.button_signed.Size = new System.Drawing.Size(70, 66);
            this.button_signed.TabIndex = 10;
            this.button_signed.Text = "(-)";
            this.button_signed.UseVisualStyleBackColor = true;
            this.button_signed.Click += new System.EventHandler(this.button_signed_Click);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(329, 296);
            this.button_result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(70, 66);
            this.button_result.TabIndex = 11;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(329, 224);
            this.button_del.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(70, 66);
            this.button_del.TabIndex = 12;
            this.button_del.Text = "del";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(329, 152);
            this.button_CE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(70, 66);
            this.button_CE.TabIndex = 13;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(329, 80);
            this.button_C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(70, 66);
            this.button_C.TabIndex = 14;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 378);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_signed);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_signed;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_C;
    }
}

