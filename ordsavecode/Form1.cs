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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string path = Application.StartupPath + @"\setting.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                code_copy_btn.Enabled = false;
            }
            else
            {
                code_copy_btn.Enabled = true;
            }
        }

        private void code_copy_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
        }
    }
}
