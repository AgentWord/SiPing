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
                this.Close();
            }
            else
            {
                地块拓展潜力 dt = new 地块拓展潜力();
                dt.StartPosition = FormStartPosition.CenterParent;
                dt.Show();
                this.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 选择地块_Load(object sender, EventArgs e)
        {
            RefreshLayer();
            get_LandName();
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
        private void get_LandName()
        {
            try
            {
                string[] name = GISHandler.GISTools.GetUniqueValue(axmapcontrol, layerComboBox.SelectedIndex, "用地类型");
                for (int i = 0; i < name.Length; i++)
                {
                    choose_landName.Items.Add(name[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void choose_landName_SelectedValueChanged(object sender, EventArgs e)
        {
          int m= GISHandler.GISTools.query(axmapcontrol,choose_landName.Text,layerComboBox.SelectedIndex,true);
          label1.Text = "选择了:"+choose_landName.Text + m.ToString() + "个地块";
        }
    }
}
