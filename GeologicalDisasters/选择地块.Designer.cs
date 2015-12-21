namespace GeologicalDisasters
{
    partial class 选择地块
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layerComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.choose_landName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // layerComboBox
            // 
            this.layerComboBox.DisplayMember = "Text";
            this.layerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.layerComboBox.FormattingEnabled = true;
            this.layerComboBox.ItemHeight = 15;
            this.layerComboBox.Location = new System.Drawing.Point(86, 33);
            this.layerComboBox.Name = "layerComboBox";
            this.layerComboBox.Size = new System.Drawing.Size(162, 21);
            this.layerComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.layerComboBox.TabIndex = 7;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(21, 33);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "选择图层：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 85);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "选择地类：";
            // 
            // choose_landName
            // 
            this.choose_landName.DisplayMember = "Text";
            this.choose_landName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.choose_landName.FormattingEnabled = true;
            this.choose_landName.ItemHeight = 15;
            this.choose_landName.Location = new System.Drawing.Point(86, 85);
            this.choose_landName.Name = "choose_landName";
            this.choose_landName.Size = new System.Drawing.Size(162, 21);
            this.choose_landName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.choose_landName.TabIndex = 7;
            this.choose_landName.SelectedValueChanged += new System.EventHandler(this.choose_landName_SelectedValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(37, 148);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "取消";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(177, 147);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "确定";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "选择中了  0  地块";
            // 
            // 选择地块
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.choose_landName);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.layerComboBox);
            this.Controls.Add(this.labelX2);
            this.Name = "选择地块";
            this.Text = "选择地块";
            this.Load += new System.EventHandler(this.选择地块_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx layerComboBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx choose_landName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
    }
}