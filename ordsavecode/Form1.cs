using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
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
            timer1.Start();
        }

        private void code_copy_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("설정부터 해주세요.");
                return;
            }
            string ord_path = string.Empty;
            string ord_name = string.Empty;
            string[] notepad_text = File.ReadAllLines(path);
            if(notepad_text.Length < 0)
            {
                MessageBox.Show("설정을 다시하여주세요.");
                return;
            }
            try
            {
                ord_path = notepad_text[0];
                ord_name = notepad_text[1];
                DirectoryInfo info = new DirectoryInfo(ord_path);
                string scan_path = string.Empty;
                Dictionary<int, string> arr = new Dictionary<int, string>();
                int number = 0;
                string replace = string.Empty;
                foreach (var item in info.GetFiles())
                {
                    if (item.Name.Contains(ord_name) == true)
                    {
                        replace = Regex.Replace(item.Name, @"[^0-9]", "");
                        arr.Add(int.Parse(replace), item.Name);
                    }
                }
                int a = arr.Keys.Max();
                //MessageBox.Show(arr[a]);
                string real_path = $@"{ord_path}\{arr[a]}";
                string content = File.ReadAllText(real_path);
                Regex regex = new Regex("\"(.*?)\"");
                var matches = regex.Matches(content);
                string code = string.Empty;
                foreach (var match in matches)
                {
                    code = match.ToString().Replace("\"", "");
                }
                Clipboard.SetText(code);
                metroLabel2.Text = "복사완료";
            }
            catch
            {
                metroLabel2.Text = "복사실패";
                MessageBox.Show("경로가 제대로 설정되었는지, 닉네임이 일치한지 확인해주세요");
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel2.Text = "";
        }
    }
}
