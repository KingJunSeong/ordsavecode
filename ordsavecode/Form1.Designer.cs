namespace ordsavecode
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
            this.code_copy_btn = new MetroFramework.Controls.MetroButton();
            this.setting_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // code_copy_btn
            // 
            this.code_copy_btn.Location = new System.Drawing.Point(23, 63);
            this.code_copy_btn.Name = "code_copy_btn";
            this.code_copy_btn.Size = new System.Drawing.Size(113, 35);
            this.code_copy_btn.TabIndex = 0;
            this.code_copy_btn.Text = "세이브코드 복사";
            this.code_copy_btn.UseSelectable = true;
            this.code_copy_btn.Click += new System.EventHandler(this.code_copy_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.Location = new System.Drawing.Point(142, 63);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(113, 35);
            this.setting_btn.TabIndex = 1;
            this.setting_btn.Text = "설정하기";
            this.setting_btn.UseSelectable = true;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(306, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "설정을 완료 하셔야 버튼이 열립니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.code_copy_btn);
            this.Name = "Form1";
            this.Text = "원랜디 세이브 복사기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton code_copy_btn;
        private MetroFramework.Controls.MetroButton setting_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

