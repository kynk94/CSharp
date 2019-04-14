namespace CuteCat
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
            this.components = new System.ComponentModel.Container();
            this.CatScreen = new System.Windows.Forms.Label();
            this.Play_button = new System.Windows.Forms.Button();
            this.Feed_button = new System.Windows.Forms.Button();
            this.BoredTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CatScreen
            // 
            this.CatScreen.BackColor = System.Drawing.SystemColors.Window;
            this.CatScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CatScreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CatScreen.Location = new System.Drawing.Point(36, 24);
            this.CatScreen.Name = "CatScreen";
            this.CatScreen.Size = new System.Drawing.Size(387, 80);
            this.CatScreen.TabIndex = 0;
            this.CatScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play_button
            // 
            this.Play_button.Location = new System.Drawing.Point(86, 129);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(75, 23);
            this.Play_button.TabIndex = 1;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Feed_button
            // 
            this.Feed_button.Location = new System.Drawing.Point(188, 128);
            this.Feed_button.Name = "Feed_button";
            this.Feed_button.Size = new System.Drawing.Size(75, 23);
            this.Feed_button.TabIndex = 2;
            this.Feed_button.Text = "Feed";
            this.Feed_button.UseVisualStyleBackColor = true;
            this.Feed_button.Click += new System.EventHandler(this.Feed_button_Click);
            // 
            // BoredTimer
            // 
            this.BoredTimer.Enabled = true;
            this.BoredTimer.Interval = 5000;
            this.BoredTimer.Tick += new System.EventHandler(this.BoredTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 235);
            this.Controls.Add(this.Feed_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.CatScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CatScreen;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Feed_button;
        private System.Windows.Forms.Timer BoredTimer;
    }
}

