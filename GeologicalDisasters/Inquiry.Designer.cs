namespace GeologicalDisasters
{
    partial class Inquiry
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lab_report = new DevComponents.DotNetBar.LabelX();
            this.check_flash = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.layerComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.but_Close = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.but_Atr = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lab_report);
            this.panelEx1.Controls.Add(this.check_flash);
            this.panelEx1.Controls.Add(this.layerComboBox);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.but_Close);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.textBoxX1);
            this.panelEx1.Controls.Add(this.but_Atr);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(264, 142);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lab_report
            // 
            // 
            // 
            // 
            this.lab_report.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lab_report.Location = new System.Drawing.Point(122, 114);
            this.lab_report.Name = "lab_report";
            this.lab_report.Size = new System.Drawing.Size(121, 23);
            this.lab_report.TabIndex = 7;
            this.lab_report.Text = "查询到 0 条记录";
            // 
            // check_flash
            // 
            // 
            // 
            // 
            this.check_flash.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.check_flash.Location = new System.Drawing.Point(14, 114);
            this.check_flash.Name = "check_flash";
            this.check_flash.Size = new System.Drawing.Size(100, 23);
            this.check_flash.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.check_flash.TabIndex = 6;
            this.check_flash.Text = "闪烁显示";
            // 
            // layerComboBox
            // 
            this.layerComboBox.DisplayMember = "Text";
            this.layerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.layerComboBox.FormattingEnabled = true;
            this.layerComboBox.ItemHeight = 15;
            this.layerComboBox.Location = new System.Drawing.Point(79, 17);
            this.layerComboBox.Name = "layerComboBox";
            this.layerComboBox.Size = new System.Drawing.Size(162, 21);
            this.layerComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.layerComboBox.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "选择图层：";
            // 
            // but_Close
            // 
            this.but_Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_Close.Location = new System.Drawing.Point(166, 55);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(75, 23);
            this.but_Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_Close.TabIndex = 3;
            this.but_Close.Text = "关闭";
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "请输入查询地物类型:";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.ButtonCustom.Tooltip = "";
            this.textBoxX1.ButtonCustom2.Tooltip = "";
            this.textBoxX1.Location = new System.Drawing.Point(12, 84);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(148, 21);
            this.textBoxX1.TabIndex = 1;
            // 
            // but_Atr
            // 
            this.but_Atr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.but_Atr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.but_Atr.Location = new System.Drawing.Point(166, 84);
            this.but_Atr.Name = "but_Atr";
            this.but_Atr.Size = new System.Drawing.Size(75, 23);
            this.but_Atr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.but_Atr.TabIndex = 0;
            this.but_Atr.Text = "查询";
            this.but_Atr.Click += new System.EventHandler(this.but_Atr_Click);
            // 
            // Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 142);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Inquiry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "查询";
            this.Load += new System.EventHandler(this.Inquiry_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX but_Atr;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.ButtonX but_Close;
        private DevComponents.DotNetBar.Controls.ComboBoxEx layerComboBox;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lab_report;
        private DevComponents.DotNetBar.Controls.CheckBoxX check_flash;
    }
}