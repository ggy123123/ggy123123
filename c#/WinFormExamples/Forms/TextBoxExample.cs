using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExamples.Forms
{
    public partial class TextBoxExample : Form
    {
        public TextBoxExample()
        {
            InitializeComponent();
        }

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {
            textBoxPwdInfo.Text = textBoxPwd.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            this.Close();
        }
    }
}
