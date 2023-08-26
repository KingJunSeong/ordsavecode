using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordsavecode
{
    public partial class SettingForm : MetroFramework.Forms.MetroForm
    {
        public string path = Application.StartupPath;
        public string folderPath = string.Empty;
        public SettingForm()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            path_textbox.Enabled = false;
/*            if (!File.Exists(path + @"\setting.txt"))
            {
                File.Create(path + @"\setting.txt");
            }*/
        }

        private void path_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderDialog = new CommonOpenFileDialog();
            folderDialog.IsFolderPicker = true;
            if(folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderPath = folderDialog.FileName;
                path_textbox.Text = folderPath;
                path_textbox.Enabled = false;
            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            if(name_textbox.Text == "")
            {
                MessageBox.Show("닉네임을 적어주세요");
            }
            else
            {
                using (var writer = new StreamWriter(path + @"\setting.txt"))
                {
                    writer.WriteLine(path + @"\");
                    writer.WriteLine(name_textbox.Text);
                }
                MessageBox.Show("설정되었습니다");
                this.Close();
            }
        }
    }
}
