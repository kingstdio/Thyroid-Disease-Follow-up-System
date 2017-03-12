namespace 甲状腺随访系统
{
    partial class UC_userManagement
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sgc_UserInfo = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_deleteuser = new DevComponents.DotNetBar.ButtonX();
            this.bt_updateuser = new DevComponents.DotNetBar.ButtonX();
            this.bt_newuser = new DevComponents.DotNetBar.ButtonX();
            this.tb_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_email = new DevComponents.DotNetBar.LabelX();
            this.tb_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_phone = new DevComponents.DotNetBar.LabelX();
            this.switch_forbidden = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lb_forbidden = new DevComponents.DotNetBar.LabelX();
            this.cbe_privilege = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.pri1 = new DevComponents.Editors.ComboItem();
            this.pri2 = new DevComponents.Editors.ComboItem();
            this.pri3 = new DevComponents.Editors.ComboItem();
            this.lb_privilege = new DevComponents.DotNetBar.LabelX();
            this.tb_passag = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_passag = new DevComponents.DotNetBar.LabelX();
            this.tb_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_pass = new DevComponents.DotNetBar.LabelX();
            this.tb_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_name = new DevComponents.DotNetBar.LabelX();
            this.pri_3 = new DevComponents.Editors.ComboItem();
            this.pri_2 = new DevComponents.Editors.ComboItem();
            this.pri_1 = new DevComponents.Editors.ComboItem();
            this.panel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sgc_UserInfo
            // 
            this.sgc_UserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sgc_UserInfo.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_UserInfo.Location = new System.Drawing.Point(4, 21);
            this.sgc_UserInfo.Name = "sgc_UserInfo";
            // 
            // 
            // 
            this.sgc_UserInfo.PrimaryGrid.AllowEdit = false;
            this.sgc_UserInfo.Size = new System.Drawing.Size(853, 643);
            this.sgc_UserInfo.TabIndex = 0;
            this.sgc_UserInfo.Text = "superGridControl1";
            this.sgc_UserInfo.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.sgc_UserInfo_RowDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.sgc_UserInfo);
            this.panel1.Controls.Add(this.groupPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1419, 675);
            this.panel1.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.bt_deleteuser);
            this.groupPanel1.Controls.Add(this.bt_updateuser);
            this.groupPanel1.Controls.Add(this.bt_newuser);
            this.groupPanel1.Controls.Add(this.tb_email);
            this.groupPanel1.Controls.Add(this.lb_email);
            this.groupPanel1.Controls.Add(this.tb_phone);
            this.groupPanel1.Controls.Add(this.lb_phone);
            this.groupPanel1.Controls.Add(this.switch_forbidden);
            this.groupPanel1.Controls.Add(this.lb_forbidden);
            this.groupPanel1.Controls.Add(this.cbe_privilege);
            this.groupPanel1.Controls.Add(this.lb_privilege);
            this.groupPanel1.Controls.Add(this.tb_passag);
            this.groupPanel1.Controls.Add(this.lb_passag);
            this.groupPanel1.Controls.Add(this.tb_pass);
            this.groupPanel1.Controls.Add(this.lb_pass);
            this.groupPanel1.Controls.Add(this.tb_name);
            this.groupPanel1.Controls.Add(this.lb_name);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(883, 11);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(482, 653);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "用户信息";
            // 
            // bt_deleteuser
            // 
            this.bt_deleteuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_deleteuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_deleteuser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_deleteuser.Location = new System.Drawing.Point(49, 556);
            this.bt_deleteuser.Name = "bt_deleteuser";
            this.bt_deleteuser.Size = new System.Drawing.Size(384, 44);
            this.bt_deleteuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_deleteuser.TabIndex = 129;
            this.bt_deleteuser.Text = "删除";
            this.bt_deleteuser.Click += new System.EventHandler(this.bt_deleteuser_Click);
            // 
            // bt_updateuser
            // 
            this.bt_updateuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_updateuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_updateuser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_updateuser.Location = new System.Drawing.Point(49, 502);
            this.bt_updateuser.Name = "bt_updateuser";
            this.bt_updateuser.Size = new System.Drawing.Size(384, 44);
            this.bt_updateuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_updateuser.TabIndex = 128;
            this.bt_updateuser.Text = "更改";
            this.bt_updateuser.Click += new System.EventHandler(this.bt_updateuser_Click);
            // 
            // bt_newuser
            // 
            this.bt_newuser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_newuser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_newuser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_newuser.Location = new System.Drawing.Point(49, 444);
            this.bt_newuser.Name = "bt_newuser";
            this.bt_newuser.Size = new System.Drawing.Size(384, 44);
            this.bt_newuser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_newuser.TabIndex = 127;
            this.bt_newuser.Text = "添加";
            this.bt_newuser.Click += new System.EventHandler(this.bt_newuser_Click);
            // 
            // tb_email
            // 
            // 
            // 
            // 
            this.tb_email.Border.Class = "TextBoxBorder";
            this.tb_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_email.DisabledBackColor = System.Drawing.Color.White;
            this.tb_email.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_email.Location = new System.Drawing.Point(148, 375);
            this.tb_email.Name = "tb_email";
            this.tb_email.PreventEnterBeep = true;
            this.tb_email.Size = new System.Drawing.Size(281, 26);
            this.tb_email.TabIndex = 125;
            // 
            // lb_email
            // 
            this.lb_email.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_email.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_email.Location = new System.Drawing.Point(35, 378);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(97, 23);
            this.lb_email.TabIndex = 126;
            this.lb_email.Text = "电子邮件：";
            this.lb_email.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_phone
            // 
            // 
            // 
            // 
            this.tb_phone.Border.Class = "TextBoxBorder";
            this.tb_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_phone.DisabledBackColor = System.Drawing.Color.White;
            this.tb_phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_phone.Location = new System.Drawing.Point(148, 323);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PreventEnterBeep = true;
            this.tb_phone.Size = new System.Drawing.Size(281, 26);
            this.tb_phone.TabIndex = 123;
            // 
            // lb_phone
            // 
            this.lb_phone.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_phone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_phone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_phone.Location = new System.Drawing.Point(35, 326);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(97, 23);
            this.lb_phone.TabIndex = 124;
            this.lb_phone.Text = "联系电话：";
            this.lb_phone.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // switch_forbidden
            // 
            // 
            // 
            // 
            this.switch_forbidden.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_forbidden.Location = new System.Drawing.Point(148, 271);
            this.switch_forbidden.Name = "switch_forbidden";
            this.switch_forbidden.OffText = "否";
            this.switch_forbidden.OnText = "是";
            this.switch_forbidden.Size = new System.Drawing.Size(281, 26);
            this.switch_forbidden.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_forbidden.SwitchWidth = 110;
            this.switch_forbidden.TabIndex = 121;
            // 
            // lb_forbidden
            // 
            this.lb_forbidden.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_forbidden.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_forbidden.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_forbidden.Location = new System.Drawing.Point(35, 274);
            this.lb_forbidden.Name = "lb_forbidden";
            this.lb_forbidden.Size = new System.Drawing.Size(97, 23);
            this.lb_forbidden.TabIndex = 122;
            this.lb_forbidden.Text = "禁用用户：";
            this.lb_forbidden.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbe_privilege
            // 
            this.cbe_privilege.DisplayMember = "Text";
            this.cbe_privilege.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbe_privilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbe_privilege.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_privilege.FormattingEnabled = true;
            this.cbe_privilege.ItemHeight = 20;
            this.cbe_privilege.Items.AddRange(new object[] {
            this.pri1,
            this.pri2,
            this.pri3});
            this.cbe_privilege.Location = new System.Drawing.Point(148, 219);
            this.cbe_privilege.Name = "cbe_privilege";
            this.cbe_privilege.Size = new System.Drawing.Size(281, 26);
            this.cbe_privilege.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbe_privilege.TabIndex = 120;
            // 
            // pri1
            // 
            this.pri1.Text = "超级管理员";
            // 
            // pri2
            // 
            this.pri2.Text = "管理员";
            // 
            // pri3
            // 
            this.pri3.Text = "普通用户";
            // 
            // lb_privilege
            // 
            this.lb_privilege.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_privilege.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_privilege.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_privilege.Location = new System.Drawing.Point(35, 222);
            this.lb_privilege.Name = "lb_privilege";
            this.lb_privilege.Size = new System.Drawing.Size(97, 23);
            this.lb_privilege.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lb_privilege.TabIndex = 119;
            this.lb_privilege.Text = "用户权限：";
            this.lb_privilege.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_passag
            // 
            // 
            // 
            // 
            this.tb_passag.Border.Class = "TextBoxBorder";
            this.tb_passag.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_passag.DisabledBackColor = System.Drawing.Color.White;
            this.tb_passag.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_passag.Location = new System.Drawing.Point(148, 167);
            this.tb_passag.Name = "tb_passag";
            this.tb_passag.PasswordChar = '.';
            this.tb_passag.PreventEnterBeep = true;
            this.tb_passag.Size = new System.Drawing.Size(281, 26);
            this.tb_passag.TabIndex = 117;
            this.tb_passag.Leave += new System.EventHandler(this.tb_passag_Leave);
            // 
            // lb_passag
            // 
            this.lb_passag.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_passag.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_passag.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_passag.Location = new System.Drawing.Point(35, 170);
            this.lb_passag.Name = "lb_passag";
            this.lb_passag.Size = new System.Drawing.Size(97, 23);
            this.lb_passag.TabIndex = 118;
            this.lb_passag.Text = "确认密码：";
            this.lb_passag.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_pass
            // 
            // 
            // 
            // 
            this.tb_pass.Border.Class = "TextBoxBorder";
            this.tb_pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pass.DisabledBackColor = System.Drawing.Color.White;
            this.tb_pass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pass.Location = new System.Drawing.Point(148, 115);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '.';
            this.tb_pass.PreventEnterBeep = true;
            this.tb_pass.Size = new System.Drawing.Size(281, 26);
            this.tb_pass.TabIndex = 115;
            // 
            // lb_pass
            // 
            this.lb_pass.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_pass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_pass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_pass.Location = new System.Drawing.Point(35, 118);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(97, 23);
            this.lb_pass.TabIndex = 116;
            this.lb_pass.Text = "密码：";
            this.lb_pass.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_name
            // 
            // 
            // 
            // 
            this.tb_name.Border.Class = "TextBoxBorder";
            this.tb_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_name.DisabledBackColor = System.Drawing.Color.White;
            this.tb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(148, 63);
            this.tb_name.Name = "tb_name";
            this.tb_name.PreventEnterBeep = true;
            this.tb_name.Size = new System.Drawing.Size(281, 26);
            this.tb_name.TabIndex = 113;
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_name.Location = new System.Drawing.Point(35, 66);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(97, 23);
            this.lb_name.TabIndex = 114;
            this.lb_name.Text = "登录名：";
            this.lb_name.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // pri_3
            // 
            this.pri_3.Text = "第三等级";
            this.pri_3.Value = "3";
            // 
            // pri_2
            // 
            this.pri_2.Text = "第二等级";
            this.pri_2.Value = "2";
            // 
            // pri_1
            // 
            this.pri_1.Text = "第一等级";
            this.pri_1.Value = "1";
            // 
            // UC_userManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_userManagement";
            this.Size = new System.Drawing.Size(1419, 681);
            this.panel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_UserInfo;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX bt_deleteuser;
        private DevComponents.DotNetBar.ButtonX bt_updateuser;
        private DevComponents.DotNetBar.ButtonX bt_newuser;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_email;
        private DevComponents.DotNetBar.LabelX lb_email;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_phone;
        private DevComponents.DotNetBar.LabelX lb_phone;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_forbidden;
        private DevComponents.DotNetBar.LabelX lb_forbidden;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbe_privilege;
        private DevComponents.DotNetBar.LabelX lb_privilege;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_passag;
        private DevComponents.DotNetBar.LabelX lb_passag;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pass;
        private DevComponents.DotNetBar.LabelX lb_pass;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_name;
        private DevComponents.DotNetBar.LabelX lb_name;
        private DevComponents.Editors.ComboItem pri_3;
        private DevComponents.Editors.ComboItem pri_2;
        private DevComponents.Editors.ComboItem pri_1;
        private DevComponents.Editors.ComboItem pri1;
        private DevComponents.Editors.ComboItem pri2;
        private DevComponents.Editors.ComboItem pri3;

    }
}
