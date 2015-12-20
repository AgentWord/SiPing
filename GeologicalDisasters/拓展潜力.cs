using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeologicalDisasters
{
    public partial class 拓展潜力 : Form
    {
        public 拓展潜力()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit14_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("保存成功！是否进入计算界面？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                地块拓展潜力 dt = new 地块拓展潜力();
                dt.StartPosition = FormStartPosition.CenterScreen;
                dt.Show();
                this.Close();

            }
            else
                return;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            地块拓展潜力 dt = new 地块拓展潜力();
            dt.StartPosition = FormStartPosition.CenterScreen;
            dt.Show();
            this.Close();
        }
    }
}
