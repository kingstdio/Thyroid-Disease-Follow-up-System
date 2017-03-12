namespace 甲状腺随访系统
{
    partial class F_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lb_version = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.bt_submit = new DevComponents.DotNetBar.ButtonX();
            this.tb_pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lb_version);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.bt_submit);
            this.panelEx1.Controls.Add(this.tb_pwd);
            this.panelEx1.Controls.Add(this.tb_username);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(553, 287);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lb_version
            // 
            // 
            // 
            // 
            this.lb_version.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_version.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_version.Location = new System.Drawing.Point(0, 252);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(550, 23);
            this.lb_version.TabIndex = 5;
            this.lb_version.Text = "labelX4";
            this.lb_version.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.Color.DarkRed;
            this.labelX3.Location = new System.Drawing.Point(3, 33);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(547, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "吉林大学白求恩第一附属医院甲状腺疾病随访系统";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bt_submit
            // 
            this.bt_submit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_submit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_submit.Location = new System.Drawing.Point(90, 186);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(370, 47);
            this.bt_submit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_submit.TabIndex = 3;
            this.bt_submit.Text = "登录";
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // tb_pwd
            // 
            // 
            // 
            // 
            this.tb_pwd.Border.Class = "TextBoxBorder";
            this.tb_pwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pwd.DisabledBackColor = System.Drawing.Color.White;
            this.tb_pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd.Location = new System.Drawing.Point(160, 133);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '.';
            this.tb_pwd.PreventEnterBeep = true;
            this.tb_pwd.Size = new System.Drawing.Size(300, 26);
            this.tb_pwd.TabIndex = 2;
            // 
            // tb_username
            // 
            // 
            // 
            // 
            this.tb_username.Border.Class = "TextBoxBorder";
            this.tb_username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_username.DisabledBackColor = System.Drawing.Color.White;
            this.tb_username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_username.Location = new System.Drawing.Point(160, 82);
            this.tb_username.Name = "tb_username";
            this.tb_username.PreventEnterBeep = true;
            this.tb_username.Size = new System.Drawing.Size(300, 26);
            this.tb_username.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(90, 135);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "口  令：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(90, 84);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "用户名：";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // F_login
            // 
            this.AcceptButton = this.bt_submit;
            this.ClientSize = new System.Drawing.Size(553, 287);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_login_KeyPress);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_username;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pwd;
        private DevComponents.DotNetBar.ButtonX bt_submit;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lb_version;
    }
}