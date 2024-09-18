using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormExamples.Forms;

namespace WinFormExamples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonHelloWorld.Click += button_Click;
            this.FormClosing += MainForm_FormClosing;
            buttonTextBox.Click += button_Click;
            buttonCheckBox.Click += button_Click;
            buttonListBox.Click += button_Click;
            buttonError.Click += button_Click;
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出应用程序？", "提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true; //取消关闭窗体
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form fm = null;
            switch (btn.Text)
            {
                case "显示新窗体":
                    fm = new HelloWorldForm();
                    break;
                case "TextBox示例":
                    fm = new TextBoxExample();
                    break;
                case "CheckBox和RadioButton示例":
                    fm = new CheckBoxRadioButton();
                    break;
                case "ListBox和ComboBox示例":
                    fm = new ListBoxComboBox();
                    break;
                case "错误提示示例":
                    fm = new ErrorProviderExample();
                    break;
            }
            if (fm != null)
            {
                fm.Owner = this;
                fm.StartPosition = FormStartPosition.CenterParent;
                fm.ShowDialog(this);
            }
        }
    }
}
