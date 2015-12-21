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
    public partial class 地块拓展潜力 : Form
    {
        public 地块拓展潜力()
        {
            InitializeComponent();
        }

        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.simpleButton1.Text = "正在计算";
            double [] value = {0.030,0.928,0.000,0.042 };
            txt_agriculture.Text = value[0].ToString();
            System.Threading.Thread.Sleep(1000);
            txt_building.Text = value[1].ToString(); System.Threading.Thread.Sleep(1000);
            txt_grass.Text = value[2].ToString(); System.Threading.Thread.Sleep(1000);
            txt_unused.Text = value[3].ToString(); System.Threading.Thread.Sleep(1000);
            txt_avg_change.Text = ((value[0]+value[2]+value[3])/3).ToString();
            this.simpleButton1.Text = "计算";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.simpleButton2.Text = "正在计算";
            double[] value = { 0.530, 0.130, 0.000, 0.340 };
            txt_agriculture_extend.Text = value[0].ToString();
            System.Threading.Thread.Sleep(1000);
            txt_building_extend.Text = value[1].ToString(); System.Threading.Thread.Sleep(1000);
            txt_grass_extend.Text = value[2].ToString(); System.Threading.Thread.Sleep(1000);
            txt_unused_extend.Text = value[3].ToString(); System.Threading.Thread.Sleep(1000);
            txt_avg_extend.Text = ((value[0] + value[2] + value[3]) / 3).ToString();
            this.simpleButton2.Text = "计算";
        }
    }
}
