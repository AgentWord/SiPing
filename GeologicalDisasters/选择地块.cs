using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
namespace GeologicalDisasters
{
    public partial class 选择地块 : Form
    {
        private AxMapControl axmapcontrol;
        public 选择地块(AxMapControl axm)
        {
            this.axmapcontrol = axm;
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否进入潜力评估参数重新设置？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question )== DialogResult.OK)
            {
                拓展潜力 t = new 拓展潜力();
                t.StartPosition = FormStartPosition.CenterScreen;
                t.Show();
            }
            else
            {
                地块拓展潜力 dt = new 地块拓展潜力();
                dt.StartPosition = FormStartPosition.CenterParent;
                dt.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 选择地块_Load(object sender, EventArgs e)
        {
            RefreshLayer();
        }
        private void RefreshLayer()
        {

            layerComboBox.Items.Clear();

            for (int i = 0; i < axmapcontrol.LayerCount; i++)
            {

                layerComboBox.Items.Add(axmapcontrol.get_Layer(i).Name);

            }

            layerComboBox.Text = layerComboBox.Items[0].ToString();

        }
    }
}
