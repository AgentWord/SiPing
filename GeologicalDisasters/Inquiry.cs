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
    public partial class Inquiry : Form
    {
        private AxMapControl axmapcontrol;
        public Inquiry(AxMapControl axm)
        {
            this.axmapcontrol = axm;
            InitializeComponent();
        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Atr_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.refresh(axmapcontrol);
           int m= GISHandler.GISTools.query(axmapcontrol, textBoxX1.Text,layerComboBox.SelectedIndex,check_flash.Checked);
           lab_report.Text = "查询:"+m.ToString()+"条记录";
        
        }

        private void Inquiry_Load(object sender, EventArgs e)
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
