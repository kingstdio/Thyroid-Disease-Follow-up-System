namespace 甲状腺随访系统
{
    partial class F_patientChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_patientChoose));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_idcard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_hosno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tb_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tb_phone = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_query = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dataGridView1);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(763, 361);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_query);
            this.groupBox1.Controls.Add(this.tb_idcard);
            this.groupBox1.Controls.Add(this.tb_hosno);
            this.groupBox1.Controls.Add(this.tb_tel);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tb_idcard
            // 
            // 
            // 
            // 
            this.tb_idcard.Border.Class = "TextBoxBorder";
            this.tb_idcard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_idcard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_idcard.ForeColor = System.Drawing.Color.Maroon;
            this.tb_idcard.Location = new System.Drawing.Point(110, 25);
            this.tb_idcard.Name = "tb_idcard";
            this.tb_idcard.PreventEnterBeep = true;
            this.tb_idcard.Size = new System.Drawing.Size(179, 26);
            this.tb_idcard.TabIndex = 1;
            this.tb_idcard.Text = "101845";
            this.tb_idcard.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_hosno
            // 
            // 
            // 
            // 
            this.tb_hosno.Border.Class = "TextBoxBorder";
            this.tb_hosno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_hosno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_hosno.ForeColor = System.Drawing.Color.Maroon;
            this.tb_hosno.Location = new System.Drawing.Point(415, 66);
            this.tb_hosno.Name = "tb_hosno";
            this.tb_hosno.PreventEnterBeep = true;
            this.tb_hosno.Size = new System.Drawing.Size(179, 26);
            this.tb_hosno.TabIndex = 4;
            this.tb_hosno.Text = "13800138000";
            this.tb_hosno.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_tel
            // 
            // 
            // 
            // 
            this.tb_tel.Border.Class = "TextBoxBorder";
            this.tb_tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_tel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tel.ForeColor = System.Drawing.Color.Maroon;
            this.tb_tel.Location = new System.Drawing.Point(108, 64);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.PreventEnterBeep = true;
            this.tb_tel.Size = new System.Drawing.Size(179, 26);
            this.tb_tel.TabIndex = 3;
            this.tb_tel.Text = "130722189705136653X";
            this.tb_tel.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(17, 27);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(90, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "身份证号：";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_name
            // 
            // 
            // 
            // 
            this.tb_name.Border.Class = "TextBoxBorder";
            this.tb_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.ForeColor = System.Drawing.Color.Maroon;
            this.tb_name.Location = new System.Drawing.Point(415, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.PreventEnterBeep = true;
            this.tb_name.Size = new System.Drawing.Size(179, 26);
            this.tb_name.TabIndex = 2;
            this.tb_name.Text = "欧阳伟民";
            this.tb_name.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(323, 68);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(90, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "住院号：";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_phone
            // 
            // 
            // 
            // 
            this.tb_phone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_phone.Location = new System.Drawing.Point(17, 66);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(90, 23);
            this.tb_phone.TabIndex = 4;
            this.tb_phone.Text = "联系电话：";
            this.tb_phone.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(323, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "姓名：";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(739, 229);
            this.dataGridView1.TabIndex = 1;
            // 
            // bt_query
            // 
            this.bt_query.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_query.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_query.Location = new System.Drawing.Point(619, 26);
            this.bt_query.Name = "bt_query";
            this.bt_query.Size = new System.Drawing.Size(102, 65);
            this.bt_query.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_query.TabIndex = 5;
            this.bt_query.Text = "查询";
            this.bt_query.Click += new System.EventHandler(this.bt_query_Click);
            // 
            // F_patientChoose
            // 
            this.AcceptButton = this.bt_query;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 361);
            this.Controls.Add(this.panelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_patientChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "患者选择";
            this.panelEx1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_idcard;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_hosno;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_tel;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_name;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX tb_phone;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX bt_query;
    }
}