﻿namespace AnimalShelter
{
    partial class Form1
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
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CustomerDetail = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewFirstname = new System.Windows.Forms.TextBox();
            this.CusNewLastname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusListPanel = new System.Windows.Forms.Panel();
            this.CusList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CusPetInfo = new System.Windows.Forms.Label();
            this.CustomerDetail.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.CusListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(219, 318);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(149, 42);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CustomerDetail
            // 
            this.CustomerDetail.Controls.Add(this.CusPetInfo);
            this.CustomerDetail.Controls.Add(this.label11);
            this.CustomerDetail.Controls.Add(this.label1);
            this.CustomerDetail.Controls.Add(this.CusIsQualified);
            this.CustomerDetail.Controls.Add(this.label5);
            this.CustomerDetail.Controls.Add(this.CusDescription);
            this.CustomerDetail.Controls.Add(this.label4);
            this.CustomerDetail.Controls.Add(this.CusAddress);
            this.CustomerDetail.Controls.Add(this.label3);
            this.CustomerDetail.Controls.Add(this.CusAge);
            this.CustomerDetail.Controls.Add(this.label2);
            this.CustomerDetail.Controls.Add(this.CusFullName);
            this.CustomerDetail.Location = new System.Drawing.Point(403, 406);
            this.CustomerDetail.Name = "CustomerDetail";
            this.CustomerDetail.Size = new System.Drawing.Size(403, 321);
            this.CustomerDetail.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "입양가능 :";
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(144, 90);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(38, 15);
            this.CusIsQualified.TabIndex = 11;
            this.CusIsQualified.Text = "temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "설명 :";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(144, 235);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(38, 15);
            this.CusDescription.TabIndex = 9;
            this.CusDescription.Text = "temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "주소 :";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(144, 125);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(38, 15);
            this.CusAddress.TabIndex = 7;
            this.CusAddress.Text = "temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "나이 :";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(144, 55);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(38, 15);
            this.CusAge.TabIndex = 5;
            this.CusAge.Text = "temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "이름 :";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(144, 20);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(38, 15);
            this.CusFullName.TabIndex = 3;
            this.CusFullName.Text = "temp";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CusNewFirstname);
            this.CusNewPanel.Controls.Add(this.CusNewLastname);
            this.CusNewPanel.Controls.Add(this.label10);
            this.CusNewPanel.Controls.Add(this.label9);
            this.CusNewPanel.Controls.Add(this.label8);
            this.CusNewPanel.Controls.Add(this.label7);
            this.CusNewPanel.Controls.Add(this.label6);
            this.CusNewPanel.Location = new System.Drawing.Point(403, 21);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(403, 379);
            this.CusNewPanel.TabIndex = 2;
            this.CusNewPanel.Visible = false;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(88, 156);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(280, 146);
            this.CusNewDescription.TabIndex = 9;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(88, 121);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(280, 25);
            this.CusNewAddress.TabIndex = 8;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(88, 86);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(100, 25);
            this.CusNewBirthday.TabIndex = 7;
            // 
            // CusNewFirstname
            // 
            this.CusNewFirstname.Location = new System.Drawing.Point(88, 51);
            this.CusNewFirstname.Name = "CusNewFirstname";
            this.CusNewFirstname.Size = new System.Drawing.Size(100, 25);
            this.CusNewFirstname.TabIndex = 6;
            // 
            // CusNewLastname
            // 
            this.CusNewLastname.Location = new System.Drawing.Point(88, 16);
            this.CusNewLastname.Name = "CusNewLastname";
            this.CusNewLastname.Size = new System.Drawing.Size(100, 25);
            this.CusNewLastname.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "설명 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "주소 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "생일 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "이름 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "성 :";
            // 
            // CusListPanel
            // 
            this.CusListPanel.Controls.Add(this.CusList);
            this.CusListPanel.Location = new System.Drawing.Point(13, 68);
            this.CusListPanel.Name = "CusListPanel";
            this.CusListPanel.Size = new System.Drawing.Size(384, 379);
            this.CusListPanel.TabIndex = 3;
            // 
            // CusList
            // 
            this.CusList.AllowUserToAddRows = false;
            this.CusList.AllowUserToDeleteRows = false;
            this.CusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CusList.Location = new System.Drawing.Point(0, 0);
            this.CusList.MultiSelect = false;
            this.CusList.Name = "CusList";
            this.CusList.RowTemplate.Height = 27;
            this.CusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CusList.Size = new System.Drawing.Size(384, 379);
            this.CusList.TabIndex = 0;
            this.CusList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입양가능";
            this.Column3.Name = "Column3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.toolStripMenuItem1.Text = "입양자 생성";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // CusPetInfo
            // 
            this.CusPetInfo.AutoSize = true;
            this.CusPetInfo.Location = new System.Drawing.Point(144, 160);
            this.CusPetInfo.Name = "CusPetInfo";
            this.CusPetInfo.Size = new System.Drawing.Size(38, 15);
            this.CusPetInfo.TabIndex = 14;
            this.CusPetInfo.Text = "temp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 752);
            this.Controls.Add(this.CusListPanel);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CustomerDetail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CustomerDetail.ResumeLayout(false);
            this.CustomerDetail.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.CusListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CustomerDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Panel CusNewPanel;
        private System.Windows.Forms.TextBox CusNewLastname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.TextBox CusNewFirstname;
        private System.Windows.Forms.Panel CusListPanel;
        private System.Windows.Forms.DataGridView CusList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CusPetInfo;
    }
}

