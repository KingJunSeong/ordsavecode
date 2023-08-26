namespace ordsavecode
{
    partial class SettingForm
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
            this.path_textbox = new MetroFramework.Controls.MetroTextBox();
            this.path_btn = new MetroFramework.Controls.MetroButton();
            this.name_textbox = new MetroFramework.Controls.MetroTextBox();
            this.check_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // path_textbox
            // 
            // 
            // 
            // 
            this.path_textbox.CustomButton.Image = null;
            this.path_textbox.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.path_textbox.CustomButton.Name = "";
            this.path_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.path_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.path_textbox.CustomButton.TabIndex = 1;
            this.path_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.path_textbox.CustomButton.UseSelectable = true;
            this.path_textbox.CustomButton.Visible = false;
            this.path_textbox.Lines = new string[0];
            this.path_textbox.Location = new System.Drawing.Point(104, 63);
            this.path_textbox.MaxLength = 32767;
            this.path_textbox.Name = "path_textbox";
            this.path_textbox.PasswordChar = '\0';
            this.path_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.path_textbox.SelectedText = "";
            this.path_textbox.SelectionLength = 0;
            this.path_textbox.SelectionStart = 0;
            this.path_textbox.ShortcutsEnabled = true;
            this.path_textbox.Size = new System.Drawing.Size(573, 23);
            this.path_textbox.TabIndex = 0;
            this.path_textbox.UseSelectable = true;
            this.path_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.path_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // path_btn
            // 
            this.path_btn.Location = new System.Drawing.Point(23, 63);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(75, 23);
            this.path_btn.TabIndex = 1;
            this.path_btn.Text = "경로설정";
            this.path_btn.UseSelectable = true;
            this.path_btn.Click += new System.EventHandler(this.path_btn_Click);
            // 
            // name_textbox
            // 
            // 
            // 
            // 
            this.name_textbox.CustomButton.Image = null;
            this.name_textbox.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.name_textbox.CustomButton.Name = "";
            this.name_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_textbox.CustomButton.TabIndex = 1;
            this.name_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_textbox.CustomButton.UseSelectable = true;
            this.name_textbox.CustomButton.Visible = false;
            this.name_textbox.Lines = new string[0];
            this.name_textbox.Location = new System.Drawing.Point(104, 92);
            this.name_textbox.MaxLength = 32767;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.PasswordChar = '\0';
            this.name_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_textbox.SelectedText = "";
            this.name_textbox.SelectionLength = 0;
            this.name_textbox.SelectionStart = 0;
            this.name_textbox.ShortcutsEnabled = true;
            this.name_textbox.Size = new System.Drawing.Size(573, 23);
            this.name_textbox.TabIndex = 2;
            this.name_textbox.UseSelectable = true;
            this.name_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(602, 121);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 36);
            this.check_btn.TabIndex = 4;
            this.check_btn.Text = "설정확인";
            this.check_btn.UseSelectable = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "닉네임";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 180);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.path_btn);
            this.Controls.Add(this.path_textbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SettingForm";
            this.Text = "설정";
            this.Load += new System.EventHandler(this.setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox path_textbox;
        private MetroFramework.Controls.MetroButton path_btn;
        private MetroFramework.Controls.MetroTextBox name_textbox;
        private MetroFramework.Controls.MetroButton check_btn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}