﻿namespace 甲状腺随访系统
{
    partial class UC_patientInfo
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
                this.ActiveControl.KeyPress +=new System.Windows.Forms.KeyPressEventHandler(InsertData); 
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
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.snav_patientInfo = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.tb_study = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_study = new DevComponents.DotNetBar.LabelX();
            this.tb_wechat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX41 = new DevComponents.DotNetBar.LabelX();
            this.dti_age = new DevComponents.Editors.IntegerInput();
            this.dti_regDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dti_dateLeave = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.switch_gender = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.dti_birthday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lb_dateLeave = new DevComponents.DotNetBar.LabelX();
            this.lb_regDate = new DevComponents.DotNetBar.LabelX();
            this.lb_age = new DevComponents.DotNetBar.LabelX();
            this.tb_hospitalNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_birthday = new DevComponents.DotNetBar.LabelX();
            this.lb_gender = new DevComponents.DotNetBar.LabelX();
            this.lb_hospitalNo = new DevComponents.DotNetBar.LabelX();
            this.tb_patientPhone3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_patientPhone2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_idNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_patientAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_patientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_patientName = new DevComponents.DotNetBar.LabelX();
            this.lb_idNumber = new DevComponents.DotNetBar.LabelX();
            this.lb_patientAddress = new DevComponents.DotNetBar.LabelX();
            this.lb_patientPhone2 = new DevComponents.DotNetBar.LabelX();
            this.lb_patientPhone3 = new DevComponents.DotNetBar.LabelX();
            this.line8 = new DevComponents.DotNetBar.Controls.Line();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.line5 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX43 = new DevComponents.DotNetBar.LabelX();
            this.labelX44 = new DevComponents.DotNetBar.LabelX();
            this.sideNavPanel3 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.lb_lastM = new DevComponents.DotNetBar.LabelX();
            this.dti_lastM = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dti_BMI = new DevComponents.Editors.DoubleInput();
            this.cbe_resident = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.res_null = new DevComponents.Editors.ComboItem();
            this.res_city = new DevComponents.Editors.ComboItem();
            this.res_country = new DevComponents.Editors.ComboItem();
            this.ii_eutociaT = new DevComponents.Editors.IntegerInput();
            this.ii_AFM = new DevComponents.Editors.IntegerInput();
            this.ii_TIA = new DevComponents.Editors.IntegerInput();
            this.ii_TP = new DevComponents.Editors.IntegerInput();
            this.ii_AFP = new DevComponents.Editors.IntegerInput();
            this.lb_BMI = new DevComponents.DotNetBar.LabelX();
            this.dti_weight = new DevComponents.Editors.DoubleInput();
            this.switch_drink = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_smoke = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_menopause = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.dti_height = new DevComponents.Editors.IntegerInput();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lb_weight = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lb_height = new DevComponents.DotNetBar.LabelX();
            this.lb_resident = new DevComponents.DotNetBar.LabelX();
            this.lb_AFM = new DevComponents.DotNetBar.LabelX();
            this.lb_AFP = new DevComponents.DotNetBar.LabelX();
            this.lb_TP = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lb_eutociaT = new DevComponents.DotNetBar.LabelX();
            this.lb_TIA = new DevComponents.DotNetBar.LabelX();
            this.tb_occupation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sideNavPanel5 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.switch_otherptumour = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.tb_fht = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_beizhu = new DevComponents.DotNetBar.LabelX();
            this.tb_otherptt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_othertt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.switch_familyhistory = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_otherntumour = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_diabetes = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_radiotherapy = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_coronary = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.switch_hypertension = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX37 = new DevComponents.DotNetBar.LabelX();
            this.labelX36 = new DevComponents.DotNetBar.LabelX();
            this.labelX34 = new DevComponents.DotNetBar.LabelX();
            this.labelX40 = new DevComponents.DotNetBar.LabelX();
            this.labelX28 = new DevComponents.DotNetBar.LabelX();
            this.labelX32 = new DevComponents.DotNetBar.LabelX();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.sideNavPanel4 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.labelX33 = new DevComponents.DotNetBar.LabelX();
            this.di_bloodGlucose = new DevComponents.Editors.DoubleInput();
            this.labelX35 = new DevComponents.DotNetBar.LabelX();
            this.line13 = new DevComponents.DotNetBar.Controls.Line();
            this.di_triglyceride = new DevComponents.Editors.DoubleInput();
            this.di_llipoprotein = new DevComponents.Editors.DoubleInput();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.di_hlipoprotein = new DevComponents.Editors.DoubleInput();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.di_cholesterol = new DevComponents.Editors.DoubleInput();
            this.labelX29 = new DevComponents.DotNetBar.LabelX();
            this.labelX30 = new DevComponents.DotNetBar.LabelX();
            this.labelX31 = new DevComponents.DotNetBar.LabelX();
            this.di_foll = new DevComponents.Editors.DoubleInput();
            this.labelX19 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.di_pregnendione = new DevComponents.Editors.DoubleInput();
            this.labelX21 = new DevComponents.DotNetBar.LabelX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.di_estradiol = new DevComponents.Editors.DoubleInput();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.di_luteinizing = new DevComponents.Editors.DoubleInput();
            this.di_testosterone = new DevComponents.Editors.DoubleInput();
            this.di_prolactin = new DevComponents.Editors.DoubleInput();
            this.labelX20 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.line6 = new DevComponents.DotNetBar.Controls.Line();
            this.line7 = new DevComponents.DotNetBar.Controls.Line();
            this.line9 = new DevComponents.DotNetBar.Controls.Line();
            this.line10 = new DevComponents.DotNetBar.Controls.Line();
            this.line11 = new DevComponents.DotNetBar.Controls.Line();
            this.line12 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX39 = new DevComponents.DotNetBar.LabelX();
            this.labelX38 = new DevComponents.DotNetBar.LabelX();
            this.labelX52 = new DevComponents.DotNetBar.LabelX();
            this.sni_menu = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem5 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator3 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator4 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator5 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem3 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator6 = new DevComponents.DotNetBar.Separator();
            this.snav_patientInfo.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dti_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_regDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_dateLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_birthday)).BeginInit();
            this.sideNavPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dti_lastM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_BMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_eutociaT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_AFM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_TIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_AFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_height)).BeginInit();
            this.sideNavPanel5.SuspendLayout();
            this.sideNavPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.di_bloodGlucose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_triglyceride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_llipoprotein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_hlipoprotein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_cholesterol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_foll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_pregnendione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_estradiol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_luteinizing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_testosterone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_prolactin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(19, 54);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(97, 23);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "患者姓名：";
            // 
            // snav_patientInfo
            // 
            this.snav_patientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snav_patientInfo.Controls.Add(this.sideNavPanel1);
            this.snav_patientInfo.Controls.Add(this.sideNavPanel3);
            this.snav_patientInfo.Controls.Add(this.sideNavPanel5);
            this.snav_patientInfo.Controls.Add(this.sideNavPanel4);
            this.snav_patientInfo.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sni_menu,
            this.separator1,
            this.sideNavItem5,
            this.separator3,
            this.sideNavItem1,
            this.separator4,
            this.sideNavItem2,
            this.separator5,
            this.sideNavItem3,
            this.separator6});
            this.snav_patientInfo.Location = new System.Drawing.Point(0, 0);
            this.snav_patientInfo.Name = "snav_patientInfo";
            this.snav_patientInfo.Padding = new System.Windows.Forms.Padding(1);
            this.snav_patientInfo.Size = new System.Drawing.Size(1413, 565);
            this.snav_patientInfo.TabIndex = 6;
            this.snav_patientInfo.Text = "snav_patientInfo";
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Controls.Add(this.tb_study);
            this.sideNavPanel1.Controls.Add(this.lb_study);
            this.sideNavPanel1.Controls.Add(this.tb_wechat);
            this.sideNavPanel1.Controls.Add(this.tb_email);
            this.sideNavPanel1.Controls.Add(this.labelX6);
            this.sideNavPanel1.Controls.Add(this.labelX41);
            this.sideNavPanel1.Controls.Add(this.dti_age);
            this.sideNavPanel1.Controls.Add(this.dti_regDate);
            this.sideNavPanel1.Controls.Add(this.dti_dateLeave);
            this.sideNavPanel1.Controls.Add(this.switch_gender);
            this.sideNavPanel1.Controls.Add(this.dti_birthday);
            this.sideNavPanel1.Controls.Add(this.lb_dateLeave);
            this.sideNavPanel1.Controls.Add(this.lb_regDate);
            this.sideNavPanel1.Controls.Add(this.lb_age);
            this.sideNavPanel1.Controls.Add(this.tb_hospitalNo);
            this.sideNavPanel1.Controls.Add(this.lb_birthday);
            this.sideNavPanel1.Controls.Add(this.lb_gender);
            this.sideNavPanel1.Controls.Add(this.lb_hospitalNo);
            this.sideNavPanel1.Controls.Add(this.tb_patientPhone3);
            this.sideNavPanel1.Controls.Add(this.tb_patientPhone2);
            this.sideNavPanel1.Controls.Add(this.tb_idNumber);
            this.sideNavPanel1.Controls.Add(this.tb_patientAddress);
            this.sideNavPanel1.Controls.Add(this.tb_patientName);
            this.sideNavPanel1.Controls.Add(this.lb_patientName);
            this.sideNavPanel1.Controls.Add(this.lb_idNumber);
            this.sideNavPanel1.Controls.Add(this.lb_patientAddress);
            this.sideNavPanel1.Controls.Add(this.lb_patientPhone2);
            this.sideNavPanel1.Controls.Add(this.lb_patientPhone3);
            this.sideNavPanel1.Controls.Add(this.line8);
            this.sideNavPanel1.Controls.Add(this.line4);
            this.sideNavPanel1.Controls.Add(this.line3);
            this.sideNavPanel1.Controls.Add(this.line5);
            this.sideNavPanel1.Controls.Add(this.line2);
            this.sideNavPanel1.Controls.Add(this.line1);
            this.sideNavPanel1.Controls.Add(this.labelX43);
            this.sideNavPanel1.Controls.Add(this.labelX44);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(132, 36);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(1276, 528);
            this.sideNavPanel1.TabIndex = 47;
            this.sideNavPanel1.Leave += new System.EventHandler(this.RefreshDatabase);
            this.sideNavPanel1.MouseLeave += new System.EventHandler(this.InsertData);
            // 
            // tb_study
            // 
            // 
            // 
            // 
            this.tb_study.Border.Class = "TextBoxBorder";
            this.tb_study.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_study.DisabledBackColor = System.Drawing.Color.White;
            this.tb_study.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_study.Location = new System.Drawing.Point(265, 215);
            this.tb_study.MaxLength = 7;
            this.tb_study.Name = "tb_study";
            this.tb_study.PreventEnterBeep = true;
            this.tb_study.Size = new System.Drawing.Size(290, 26);
            this.tb_study.TabIndex = 3;
            this.tb_study.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // lb_study
            // 
            this.lb_study.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_study.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_study.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_study.Location = new System.Drawing.Point(162, 218);
            this.lb_study.Name = "lb_study";
            this.lb_study.Size = new System.Drawing.Size(97, 23);
            this.lb_study.TabIndex = 129;
            this.lb_study.Text = "研究号：";
            // 
            // tb_wechat
            // 
            // 
            // 
            // 
            this.tb_wechat.Border.Class = "TextBoxBorder";
            this.tb_wechat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_wechat.DisabledBackColor = System.Drawing.Color.White;
            this.tb_wechat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_wechat.Location = new System.Drawing.Point(265, 405);
            this.tb_wechat.MaxLength = 30;
            this.tb_wechat.Name = "tb_wechat";
            this.tb_wechat.PreventEnterBeep = true;
            this.tb_wechat.Size = new System.Drawing.Size(290, 26);
            this.tb_wechat.TabIndex = 8;
            this.tb_wechat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
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
            this.tb_email.Location = new System.Drawing.Point(265, 367);
            this.tb_email.MaxLength = 30;
            this.tb_email.Name = "tb_email";
            this.tb_email.PreventEnterBeep = true;
            this.tb_email.Size = new System.Drawing.Size(290, 26);
            this.tb_email.TabIndex = 7;
            this.tb_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(162, 370);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(97, 23);
            this.labelX6.TabIndex = 127;
            this.labelX6.Text = "电子邮件：";
            // 
            // labelX41
            // 
            this.labelX41.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX41.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX41.Location = new System.Drawing.Point(162, 408);
            this.labelX41.Name = "labelX41";
            this.labelX41.Size = new System.Drawing.Size(97, 23);
            this.labelX41.TabIndex = 128;
            this.labelX41.Text = "微信号码：";
            // 
            // dti_age
            // 
            // 
            // 
            // 
            this.dti_age.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_age.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_age.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dti_age.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_age.Location = new System.Drawing.Point(854, 291);
            this.dti_age.MaxValue = 120;
            this.dti_age.MinValue = 0;
            this.dti_age.Name = "dti_age";
            this.dti_age.ShowUpDown = true;
            this.dti_age.Size = new System.Drawing.Size(253, 26);
            this.dti_age.TabIndex = 12;
            this.dti_age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // dti_regDate
            // 
            // 
            // 
            // 
            this.dti_regDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_regDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_regDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_regDate.ButtonDropDown.Visible = true;
            this.dti_regDate.CustomFormat = "yyyy-MM-dd";
            this.dti_regDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_regDate.IsPopupCalendarOpen = false;
            this.dti_regDate.Location = new System.Drawing.Point(854, 337);
            this.dti_regDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_regDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_regDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_regDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_regDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_regDate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 27, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dti_regDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_regDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_regDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_regDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_regDate.MonthCalendar.TodayButtonVisible = true;
            this.dti_regDate.Name = "dti_regDate";
            this.dti_regDate.Size = new System.Drawing.Size(253, 26);
            this.dti_regDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_regDate.TabIndex = 13;
            // 
            // dti_dateLeave
            // 
            // 
            // 
            // 
            this.dti_dateLeave.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_dateLeave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dateLeave.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_dateLeave.ButtonDropDown.Visible = true;
            this.dti_dateLeave.CustomFormat = "yyyy-MM-dd";
            this.dti_dateLeave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_dateLeave.IsPopupCalendarOpen = false;
            this.dti_dateLeave.Location = new System.Drawing.Point(854, 383);
            this.dti_dateLeave.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_dateLeave.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dateLeave.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_dateLeave.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_dateLeave.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dateLeave.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 27, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dti_dateLeave.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_dateLeave.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_dateLeave.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_dateLeave.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dateLeave.MonthCalendar.TodayButtonVisible = true;
            this.dti_dateLeave.Name = "dti_dateLeave";
            this.dti_dateLeave.Size = new System.Drawing.Size(253, 26);
            this.dti_dateLeave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_dateLeave.TabIndex = 14;
            // 
            // switch_gender
            // 
            // 
            // 
            // 
            this.switch_gender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch_gender.Location = new System.Drawing.Point(854, 199);
            this.switch_gender.Name = "switch_gender";
            this.switch_gender.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.switch_gender.OffText = "女";
            this.switch_gender.OnText = "男";
            this.switch_gender.Size = new System.Drawing.Size(253, 26);
            this.switch_gender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_gender.SwitchWidth = 130;
            this.switch_gender.TabIndex = 10;
            this.switch_gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // dti_birthday
            // 
            // 
            // 
            // 
            this.dti_birthday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_birthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_birthday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_birthday.ButtonDropDown.Visible = true;
            this.dti_birthday.CustomFormat = "yyyy-MM-dd";
            this.dti_birthday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_birthday.IsPopupCalendarOpen = false;
            this.dti_birthday.Location = new System.Drawing.Point(854, 245);
            this.dti_birthday.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_birthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_birthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_birthday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_birthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_birthday.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 27, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dti_birthday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_birthday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_birthday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_birthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_birthday.MonthCalendar.TodayButtonVisible = true;
            this.dti_birthday.Name = "dti_birthday";
            this.dti_birthday.Size = new System.Drawing.Size(253, 26);
            this.dti_birthday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_birthday.TabIndex = 11;
            // 
            // lb_dateLeave
            // 
            this.lb_dateLeave.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_dateLeave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_dateLeave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_dateLeave.Location = new System.Drawing.Point(756, 385);
            this.lb_dateLeave.Name = "lb_dateLeave";
            this.lb_dateLeave.Size = new System.Drawing.Size(97, 23);
            this.lb_dateLeave.TabIndex = 124;
            this.lb_dateLeave.Text = "出院日期：";
            // 
            // lb_regDate
            // 
            this.lb_regDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_regDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_regDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_regDate.Location = new System.Drawing.Point(756, 339);
            this.lb_regDate.Name = "lb_regDate";
            this.lb_regDate.Size = new System.Drawing.Size(97, 23);
            this.lb_regDate.TabIndex = 119;
            this.lb_regDate.Text = "住院日期：";
            // 
            // lb_age
            // 
            this.lb_age.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_age.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_age.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_age.Location = new System.Drawing.Point(756, 293);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(97, 23);
            this.lb_age.TabIndex = 121;
            this.lb_age.Text = "住院年龄：";
            // 
            // tb_hospitalNo
            // 
            // 
            // 
            // 
            this.tb_hospitalNo.Border.Class = "TextBoxBorder";
            this.tb_hospitalNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_hospitalNo.DisabledBackColor = System.Drawing.Color.White;
            this.tb_hospitalNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_hospitalNo.Location = new System.Drawing.Point(854, 153);
            this.tb_hospitalNo.MaxLength = 8;
            this.tb_hospitalNo.Name = "tb_hospitalNo";
            this.tb_hospitalNo.PreventEnterBeep = true;
            this.tb_hospitalNo.Size = new System.Drawing.Size(253, 26);
            this.tb_hospitalNo.TabIndex = 9;
            this.tb_hospitalNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // lb_birthday
            // 
            this.lb_birthday.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_birthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_birthday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_birthday.Location = new System.Drawing.Point(756, 247);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(97, 23);
            this.lb_birthday.TabIndex = 123;
            this.lb_birthday.Text = "出生日期：";
            // 
            // lb_gender
            // 
            this.lb_gender.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_gender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_gender.Location = new System.Drawing.Point(756, 201);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(97, 23);
            this.lb_gender.TabIndex = 122;
            this.lb_gender.Text = "性    别：";
            // 
            // lb_hospitalNo
            // 
            this.lb_hospitalNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_hospitalNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_hospitalNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_hospitalNo.Location = new System.Drawing.Point(756, 155);
            this.lb_hospitalNo.Name = "lb_hospitalNo";
            this.lb_hospitalNo.Size = new System.Drawing.Size(97, 23);
            this.lb_hospitalNo.TabIndex = 120;
            this.lb_hospitalNo.Text = "住院号码：";
            // 
            // tb_patientPhone3
            // 
            // 
            // 
            // 
            this.tb_patientPhone3.Border.Class = "TextBoxBorder";
            this.tb_patientPhone3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_patientPhone3.DisabledBackColor = System.Drawing.Color.White;
            this.tb_patientPhone3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_patientPhone3.Location = new System.Drawing.Point(265, 329);
            this.tb_patientPhone3.MaxLength = 11;
            this.tb_patientPhone3.Name = "tb_patientPhone3";
            this.tb_patientPhone3.PreventEnterBeep = true;
            this.tb_patientPhone3.Size = new System.Drawing.Size(290, 26);
            this.tb_patientPhone3.TabIndex = 6;
            this.tb_patientPhone3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // tb_patientPhone2
            // 
            // 
            // 
            // 
            this.tb_patientPhone2.Border.Class = "TextBoxBorder";
            this.tb_patientPhone2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_patientPhone2.DisabledBackColor = System.Drawing.Color.White;
            this.tb_patientPhone2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_patientPhone2.Location = new System.Drawing.Point(265, 291);
            this.tb_patientPhone2.MaxLength = 11;
            this.tb_patientPhone2.Name = "tb_patientPhone2";
            this.tb_patientPhone2.PreventEnterBeep = true;
            this.tb_patientPhone2.Size = new System.Drawing.Size(290, 26);
            this.tb_patientPhone2.TabIndex = 5;
            this.tb_patientPhone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // tb_idNumber
            // 
            // 
            // 
            // 
            this.tb_idNumber.Border.Class = "TextBoxBorder";
            this.tb_idNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_idNumber.DisabledBackColor = System.Drawing.Color.White;
            this.tb_idNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_idNumber.Location = new System.Drawing.Point(265, 177);
            this.tb_idNumber.MaxLength = 18;
            this.tb_idNumber.Name = "tb_idNumber";
            this.tb_idNumber.PreventEnterBeep = true;
            this.tb_idNumber.Size = new System.Drawing.Size(290, 26);
            this.tb_idNumber.TabIndex = 2;
            this.tb_idNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            this.tb_idNumber.Leave += new System.EventHandler(this.tb_idNumber_Leave);
            // 
            // tb_patientAddress
            // 
            // 
            // 
            // 
            this.tb_patientAddress.Border.Class = "TextBoxBorder";
            this.tb_patientAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_patientAddress.DisabledBackColor = System.Drawing.Color.White;
            this.tb_patientAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_patientAddress.Location = new System.Drawing.Point(265, 253);
            this.tb_patientAddress.Name = "tb_patientAddress";
            this.tb_patientAddress.PreventEnterBeep = true;
            this.tb_patientAddress.Size = new System.Drawing.Size(290, 26);
            this.tb_patientAddress.TabIndex = 4;
            this.tb_patientAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // tb_patientName
            // 
            // 
            // 
            // 
            this.tb_patientName.Border.Class = "TextBoxBorder";
            this.tb_patientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_patientName.DisabledBackColor = System.Drawing.Color.White;
            this.tb_patientName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_patientName.Location = new System.Drawing.Point(265, 139);
            this.tb_patientName.Name = "tb_patientName";
            this.tb_patientName.PreventEnterBeep = true;
            this.tb_patientName.Size = new System.Drawing.Size(290, 26);
            this.tb_patientName.TabIndex = 1;
            this.tb_patientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // lb_patientName
            // 
            this.lb_patientName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_patientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_patientName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_patientName.Location = new System.Drawing.Point(162, 142);
            this.lb_patientName.Name = "lb_patientName";
            this.lb_patientName.Size = new System.Drawing.Size(97, 23);
            this.lb_patientName.TabIndex = 110;
            this.lb_patientName.Text = "患者姓名：";
            // 
            // lb_idNumber
            // 
            this.lb_idNumber.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_idNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_idNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_idNumber.Location = new System.Drawing.Point(162, 180);
            this.lb_idNumber.Name = "lb_idNumber";
            this.lb_idNumber.Size = new System.Drawing.Size(97, 23);
            this.lb_idNumber.TabIndex = 109;
            this.lb_idNumber.Text = "身份证号：";
            // 
            // lb_patientAddress
            // 
            this.lb_patientAddress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_patientAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_patientAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_patientAddress.Location = new System.Drawing.Point(162, 256);
            this.lb_patientAddress.Name = "lb_patientAddress";
            this.lb_patientAddress.Size = new System.Drawing.Size(97, 23);
            this.lb_patientAddress.TabIndex = 112;
            this.lb_patientAddress.Text = "居住地址：";
            // 
            // lb_patientPhone2
            // 
            this.lb_patientPhone2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_patientPhone2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_patientPhone2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_patientPhone2.Location = new System.Drawing.Point(162, 294);
            this.lb_patientPhone2.Name = "lb_patientPhone2";
            this.lb_patientPhone2.Size = new System.Drawing.Size(97, 23);
            this.lb_patientPhone2.TabIndex = 111;
            this.lb_patientPhone2.Text = "移动电话：";
            // 
            // lb_patientPhone3
            // 
            this.lb_patientPhone3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_patientPhone3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_patientPhone3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_patientPhone3.Location = new System.Drawing.Point(162, 332);
            this.lb_patientPhone3.Name = "lb_patientPhone3";
            this.lb_patientPhone3.Size = new System.Drawing.Size(97, 23);
            this.lb_patientPhone3.TabIndex = 113;
            this.lb_patientPhone3.Text = "备用电话：";
            // 
            // line8
            // 
            this.line8.BackColor = System.Drawing.Color.Transparent;
            this.line8.ForeColor = System.Drawing.Color.White;
            this.line8.Location = new System.Drawing.Point(1184, 59);
            this.line8.Name = "line8";
            this.line8.Size = new System.Drawing.Size(1, 408);
            this.line8.TabIndex = 108;
            this.line8.Text = "line1";
            this.line8.VerticalLine = true;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.Transparent;
            this.line4.ForeColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(645, 58);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(1, 408);
            this.line4.TabIndex = 104;
            this.line4.Text = "line1";
            this.line4.VerticalLine = true;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Transparent;
            this.line3.ForeColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(76, 59);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1, 408);
            this.line3.TabIndex = 105;
            this.line3.Text = "line1";
            this.line3.VerticalLine = true;
            // 
            // line5
            // 
            this.line5.BackColor = System.Drawing.Color.Transparent;
            this.line5.ForeColor = System.Drawing.Color.White;
            this.line5.Location = new System.Drawing.Point(77, 466);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(1108, 1);
            this.line5.TabIndex = 103;
            this.line5.Text = "line1";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.ForeColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(77, 116);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(1108, 1);
            this.line2.TabIndex = 101;
            this.line2.Text = "line1";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.ForeColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(77, 59);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(1108, 1);
            this.line1.TabIndex = 102;
            this.line1.Text = "line1";
            // 
            // labelX43
            // 
            this.labelX43.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX43.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX43.Font = new System.Drawing.Font("宋体", 12F);
            this.labelX43.Location = new System.Drawing.Point(866, 80);
            this.labelX43.Name = "labelX43";
            this.labelX43.Size = new System.Drawing.Size(132, 23);
            this.labelX43.TabIndex = 97;
            this.labelX43.Text = "住院信息";
            this.labelX43.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX44
            // 
            this.labelX44.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX44.Font = new System.Drawing.Font("宋体", 12F);
            this.labelX44.Location = new System.Drawing.Point(257, 76);
            this.labelX44.Name = "labelX44";
            this.labelX44.Size = new System.Drawing.Size(132, 23);
            this.labelX44.TabIndex = 99;
            this.labelX44.Text = "基本信息";
            this.labelX44.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // sideNavPanel3
            // 
            this.sideNavPanel3.Controls.Add(this.lb_lastM);
            this.sideNavPanel3.Controls.Add(this.dti_lastM);
            this.sideNavPanel3.Controls.Add(this.dti_BMI);
            this.sideNavPanel3.Controls.Add(this.cbe_resident);
            this.sideNavPanel3.Controls.Add(this.ii_eutociaT);
            this.sideNavPanel3.Controls.Add(this.ii_AFM);
            this.sideNavPanel3.Controls.Add(this.ii_TIA);
            this.sideNavPanel3.Controls.Add(this.ii_TP);
            this.sideNavPanel3.Controls.Add(this.ii_AFP);
            this.sideNavPanel3.Controls.Add(this.lb_BMI);
            this.sideNavPanel3.Controls.Add(this.dti_weight);
            this.sideNavPanel3.Controls.Add(this.switch_drink);
            this.sideNavPanel3.Controls.Add(this.switch_smoke);
            this.sideNavPanel3.Controls.Add(this.switch_menopause);
            this.sideNavPanel3.Controls.Add(this.dti_height);
            this.sideNavPanel3.Controls.Add(this.labelX8);
            this.sideNavPanel3.Controls.Add(this.labelX7);
            this.sideNavPanel3.Controls.Add(this.lb_weight);
            this.sideNavPanel3.Controls.Add(this.labelX5);
            this.sideNavPanel3.Controls.Add(this.labelX4);
            this.sideNavPanel3.Controls.Add(this.labelX3);
            this.sideNavPanel3.Controls.Add(this.lb_height);
            this.sideNavPanel3.Controls.Add(this.lb_resident);
            this.sideNavPanel3.Controls.Add(this.lb_AFM);
            this.sideNavPanel3.Controls.Add(this.lb_AFP);
            this.sideNavPanel3.Controls.Add(this.lb_TP);
            this.sideNavPanel3.Controls.Add(this.labelX2);
            this.sideNavPanel3.Controls.Add(this.lb_eutociaT);
            this.sideNavPanel3.Controls.Add(this.lb_TIA);
            this.sideNavPanel3.Controls.Add(this.tb_occupation);
            this.sideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel3.Location = new System.Drawing.Point(132, 36);
            this.sideNavPanel3.Name = "sideNavPanel3";
            this.sideNavPanel3.Size = new System.Drawing.Size(1276, 528);
            this.sideNavPanel3.TabIndex = 13;
            this.sideNavPanel3.Visible = false;
            this.sideNavPanel3.Leave += new System.EventHandler(this.RefreshDatabase);
            this.sideNavPanel3.MouseLeave += new System.EventHandler(this.InsertData);
            // 
            // lb_lastM
            // 
            this.lb_lastM.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_lastM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_lastM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_lastM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_lastM.Location = new System.Drawing.Point(577, 367);
            this.lb_lastM.Name = "lb_lastM";
            this.lb_lastM.Size = new System.Drawing.Size(118, 23);
            this.lb_lastM.TabIndex = 125;
            this.lb_lastM.Text = "末次月经：";
            this.lb_lastM.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lb_lastM.Visible = false;
            // 
            // dti_lastM
            // 
            // 
            // 
            // 
            this.dti_lastM.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_lastM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_lastM.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_lastM.ButtonDropDown.Visible = true;
            this.dti_lastM.CustomFormat = "yyyy-MM-dd";
            this.dti_lastM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_lastM.IsPopupCalendarOpen = false;
            this.dti_lastM.Location = new System.Drawing.Point(732, 365);
            this.dti_lastM.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_lastM.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_lastM.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_lastM.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_lastM.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_lastM.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 27, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dti_lastM.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_lastM.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_lastM.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_lastM.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_lastM.MonthCalendar.TodayButtonVisible = true;
            this.dti_lastM.Name = "dti_lastM";
            this.dti_lastM.Size = new System.Drawing.Size(229, 26);
            this.dti_lastM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_lastM.TabIndex = 14;
            this.dti_lastM.Visible = false;
            // 
            // dti_BMI
            // 
            // 
            // 
            // 
            this.dti_BMI.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_BMI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_BMI.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dti_BMI.Enabled = false;
            this.dti_BMI.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_BMI.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.dti_BMI.Increment = 1D;
            this.dti_BMI.Location = new System.Drawing.Point(731, 313);
            this.dti_BMI.MaxValue = 500D;
            this.dti_BMI.MinValue = 0D;
            this.dti_BMI.Name = "dti_BMI";
            this.dti_BMI.ShowUpDown = true;
            this.dti_BMI.Size = new System.Drawing.Size(230, 26);
            this.dti_BMI.TabIndex = 12;
            this.dti_BMI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // cbe_resident
            // 
            this.cbe_resident.DisplayMember = "Text";
            this.cbe_resident.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbe_resident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbe_resident.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbe_resident.FormattingEnabled = true;
            this.cbe_resident.ItemHeight = 20;
            this.cbe_resident.Items.AddRange(new object[] {
            this.res_null,
            this.res_city,
            this.res_country});
            this.cbe_resident.Location = new System.Drawing.Point(271, 43);
            this.cbe_resident.Name = "cbe_resident";
            this.cbe_resident.Size = new System.Drawing.Size(228, 26);
            this.cbe_resident.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbe_resident.TabIndex = 1;
            this.cbe_resident.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // res_city
            // 
            this.res_city.Text = "城市";
            // 
            // res_country
            // 
            this.res_country.Text = "乡村";
            // 
            // ii_eutociaT
            // 
            // 
            // 
            // 
            this.ii_eutociaT.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_eutociaT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_eutociaT.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_eutociaT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ii_eutociaT.Location = new System.Drawing.Point(269, 313);
            this.ii_eutociaT.MaxValue = 10;
            this.ii_eutociaT.MinValue = 0;
            this.ii_eutociaT.Name = "ii_eutociaT";
            this.ii_eutociaT.ShowUpDown = true;
            this.ii_eutociaT.Size = new System.Drawing.Size(230, 26);
            this.ii_eutociaT.TabIndex = 6;
            this.ii_eutociaT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // ii_AFM
            // 
            // 
            // 
            // 
            this.ii_AFM.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_AFM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_AFM.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_AFM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ii_AFM.Location = new System.Drawing.Point(271, 97);
            this.ii_AFM.MaxValue = 120;
            this.ii_AFM.MinValue = 0;
            this.ii_AFM.Name = "ii_AFM";
            this.ii_AFM.ShowUpDown = true;
            this.ii_AFM.Size = new System.Drawing.Size(230, 26);
            this.ii_AFM.TabIndex = 2;
            this.ii_AFM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // ii_TIA
            // 
            // 
            // 
            // 
            this.ii_TIA.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_TIA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_TIA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_TIA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ii_TIA.Location = new System.Drawing.Point(269, 260);
            this.ii_TIA.MaxValue = 10;
            this.ii_TIA.MinValue = 0;
            this.ii_TIA.Name = "ii_TIA";
            this.ii_TIA.ShowUpDown = true;
            this.ii_TIA.Size = new System.Drawing.Size(230, 26);
            this.ii_TIA.TabIndex = 5;
            this.ii_TIA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // ii_TP
            // 
            // 
            // 
            // 
            this.ii_TP.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_TP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_TP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_TP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ii_TP.Location = new System.Drawing.Point(271, 206);
            this.ii_TP.MaxValue = 10;
            this.ii_TP.MinValue = 0;
            this.ii_TP.Name = "ii_TP";
            this.ii_TP.ShowUpDown = true;
            this.ii_TP.Size = new System.Drawing.Size(230, 26);
            this.ii_TP.TabIndex = 4;
            this.ii_TP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // ii_AFP
            // 
            // 
            // 
            // 
            this.ii_AFP.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_AFP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_AFP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_AFP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ii_AFP.Location = new System.Drawing.Point(271, 152);
            this.ii_AFP.MaxValue = 100;
            this.ii_AFP.MinValue = 0;
            this.ii_AFP.Name = "ii_AFP";
            this.ii_AFP.ShowUpDown = true;
            this.ii_AFP.Size = new System.Drawing.Size(230, 26);
            this.ii_AFP.TabIndex = 3;
            this.ii_AFP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // lb_BMI
            // 
            this.lb_BMI.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_BMI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_BMI.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_BMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_BMI.Location = new System.Drawing.Point(577, 316);
            this.lb_BMI.Name = "lb_BMI";
            this.lb_BMI.Size = new System.Drawing.Size(118, 23);
            this.lb_BMI.TabIndex = 27;
            this.lb_BMI.Text = "BMI：";
            this.lb_BMI.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dti_weight
            // 
            // 
            // 
            // 
            this.dti_weight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_weight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_weight.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dti_weight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_weight.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.dti_weight.Increment = 1D;
            this.dti_weight.Location = new System.Drawing.Point(731, 260);
            this.dti_weight.MaxValue = 500D;
            this.dti_weight.MinValue = 0D;
            this.dti_weight.Name = "dti_weight";
            this.dti_weight.ShowUpDown = true;
            this.dti_weight.Size = new System.Drawing.Size(230, 26);
            this.dti_weight.TabIndex = 11;
            this.dti_weight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            this.dti_weight.Leave += new System.EventHandler(this.dti_weight_Leave);
            // 
            // switch_drink
            // 
            // 
            // 
            // 
            this.switch_drink.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_drink.Location = new System.Drawing.Point(731, 98);
            this.switch_drink.Name = "switch_drink";
            this.switch_drink.OffText = "否";
            this.switch_drink.OnText = "是";
            this.switch_drink.Size = new System.Drawing.Size(230, 26);
            this.switch_drink.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_drink.SwitchWidth = 110;
            this.switch_drink.TabIndex = 8;
            this.switch_drink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_smoke
            // 
            // 
            // 
            // 
            this.switch_smoke.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_smoke.Location = new System.Drawing.Point(731, 44);
            this.switch_smoke.Name = "switch_smoke";
            this.switch_smoke.OffText = "否";
            this.switch_smoke.OnText = "是";
            this.switch_smoke.Size = new System.Drawing.Size(230, 26);
            this.switch_smoke.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_smoke.SwitchWidth = 110;
            this.switch_smoke.TabIndex = 7;
            this.switch_smoke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_menopause
            // 
            // 
            // 
            // 
            this.switch_menopause.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_menopause.Location = new System.Drawing.Point(270, 368);
            this.switch_menopause.Name = "switch_menopause";
            this.switch_menopause.OffText = "否";
            this.switch_menopause.OnText = "是";
            this.switch_menopause.Size = new System.Drawing.Size(230, 26);
            this.switch_menopause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_menopause.SwitchWidth = 110;
            this.switch_menopause.TabIndex = 13;
            this.switch_menopause.ValueChanged += new System.EventHandler(this.switch_menopause_ValueChanged);
            this.switch_menopause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // dti_height
            // 
            // 
            // 
            // 
            this.dti_height.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_height.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_height.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dti_height.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dti_height.Location = new System.Drawing.Point(731, 206);
            this.dti_height.MaxValue = 320;
            this.dti_height.MinValue = 0;
            this.dti_height.Name = "dti_height";
            this.dti_height.ShowUpDown = true;
            this.dti_height.Size = new System.Drawing.Size(230, 26);
            this.dti_height.TabIndex = 10;
            this.dti_height.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            this.dti_height.Leave += new System.EventHandler(this.dti_height_Leave);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX8.Location = new System.Drawing.Point(1016, 313);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(12, 23);
            this.labelX8.TabIndex = 23;
            this.labelX8.Text = "2";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(965, 317);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(123, 23);
            this.labelX7.TabIndex = 23;
            this.labelX7.Text = "（kg/m  ）";
            // 
            // lb_weight
            // 
            this.lb_weight.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_weight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_weight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_weight.Location = new System.Drawing.Point(577, 262);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(118, 23);
            this.lb_weight.TabIndex = 23;
            this.lb_weight.Text = "体重(kg)：";
            this.lb_weight.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.Location = new System.Drawing.Point(577, 154);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(118, 23);
            this.labelX5.TabIndex = 24;
            this.labelX5.Text = "职业：";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(577, 100);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(118, 23);
            this.labelX4.TabIndex = 24;
            this.labelX4.Text = "喝酒：";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(577, 46);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(118, 23);
            this.labelX3.TabIndex = 24;
            this.labelX3.Text = "抽烟：";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_height
            // 
            this.lb_height.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_height.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_height.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_height.Location = new System.Drawing.Point(577, 208);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(118, 23);
            this.lb_height.TabIndex = 24;
            this.lb_height.Text = "身高(cm)：";
            this.lb_height.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_resident
            // 
            this.lb_resident.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_resident.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_resident.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_resident.Location = new System.Drawing.Point(129, 43);
            this.lb_resident.Name = "lb_resident";
            this.lb_resident.Size = new System.Drawing.Size(130, 28);
            this.lb_resident.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.lb_resident.TabIndex = 1;
            this.lb_resident.Text = "居住区域：";
            this.lb_resident.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_AFM
            // 
            this.lb_AFM.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_AFM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_AFM.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_AFM.Location = new System.Drawing.Point(129, 97);
            this.lb_AFM.Name = "lb_AFM";
            this.lb_AFM.Size = new System.Drawing.Size(130, 28);
            this.lb_AFM.TabIndex = 4;
            this.lb_AFM.Text = "月经初潮年龄：";
            this.lb_AFM.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_AFP
            // 
            this.lb_AFP.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_AFP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_AFP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_AFP.Location = new System.Drawing.Point(129, 151);
            this.lb_AFP.Name = "lb_AFP";
            this.lb_AFP.Size = new System.Drawing.Size(130, 28);
            this.lb_AFP.TabIndex = 5;
            this.lb_AFP.Text = "初次怀孕年龄：";
            this.lb_AFP.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_TP
            // 
            this.lb_TP.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_TP.Location = new System.Drawing.Point(129, 205);
            this.lb_TP.Name = "lb_TP";
            this.lb_TP.Size = new System.Drawing.Size(130, 28);
            this.lb_TP.TabIndex = 6;
            this.lb_TP.Text = "怀孕次数：";
            this.lb_TP.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(129, 367);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(130, 28);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "绝经：";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_eutociaT
            // 
            this.lb_eutociaT.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_eutociaT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_eutociaT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_eutociaT.Location = new System.Drawing.Point(129, 313);
            this.lb_eutociaT.Name = "lb_eutociaT";
            this.lb_eutociaT.Size = new System.Drawing.Size(130, 28);
            this.lb_eutociaT.TabIndex = 7;
            this.lb_eutociaT.Text = "正常分娩次数：";
            this.lb_eutociaT.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_TIA
            // 
            this.lb_TIA.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TIA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TIA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_TIA.Location = new System.Drawing.Point(129, 259);
            this.lb_TIA.Name = "lb_TIA";
            this.lb_TIA.Size = new System.Drawing.Size(130, 28);
            this.lb_TIA.TabIndex = 7;
            this.lb_TIA.Text = "人工流产次数：";
            this.lb_TIA.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // tb_occupation
            // 
            // 
            // 
            // 
            this.tb_occupation.Border.Class = "TextBoxBorder";
            this.tb_occupation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_occupation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_occupation.Location = new System.Drawing.Point(731, 152);
            this.tb_occupation.Name = "tb_occupation";
            this.tb_occupation.PreventEnterBeep = true;
            this.tb_occupation.Size = new System.Drawing.Size(230, 26);
            this.tb_occupation.TabIndex = 9;
            this.tb_occupation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // sideNavPanel5
            // 
            this.sideNavPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.sideNavPanel5.Controls.Add(this.switch_otherptumour);
            this.sideNavPanel5.Controls.Add(this.tb_fht);
            this.sideNavPanel5.Controls.Add(this.lb_beizhu);
            this.sideNavPanel5.Controls.Add(this.tb_otherptt);
            this.sideNavPanel5.Controls.Add(this.tb_othertt);
            this.sideNavPanel5.Controls.Add(this.switch_familyhistory);
            this.sideNavPanel5.Controls.Add(this.switch_otherntumour);
            this.sideNavPanel5.Controls.Add(this.switch_diabetes);
            this.sideNavPanel5.Controls.Add(this.switch_radiotherapy);
            this.sideNavPanel5.Controls.Add(this.switch_coronary);
            this.sideNavPanel5.Controls.Add(this.switch_hypertension);
            this.sideNavPanel5.Controls.Add(this.labelX37);
            this.sideNavPanel5.Controls.Add(this.labelX36);
            this.sideNavPanel5.Controls.Add(this.labelX34);
            this.sideNavPanel5.Controls.Add(this.labelX40);
            this.sideNavPanel5.Controls.Add(this.labelX28);
            this.sideNavPanel5.Controls.Add(this.labelX32);
            this.sideNavPanel5.Controls.Add(this.labelX27);
            this.sideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel5.Location = new System.Drawing.Point(132, 36);
            this.sideNavPanel5.Name = "sideNavPanel5";
            this.sideNavPanel5.Size = new System.Drawing.Size(1276, 528);
            this.sideNavPanel5.TabIndex = 21;
            this.sideNavPanel5.Visible = false;
            this.sideNavPanel5.Leave += new System.EventHandler(this.RefreshDatabase);
            this.sideNavPanel5.MouseLeave += new System.EventHandler(this.InsertData);
            // 
            // switch_otherptumour
            // 
            // 
            // 
            // 
            this.switch_otherptumour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_otherptumour.Location = new System.Drawing.Point(227, 257);
            this.switch_otherptumour.Name = "switch_otherptumour";
            this.switch_otherptumour.OffText = "否";
            this.switch_otherptumour.OnText = "是";
            this.switch_otherptumour.Size = new System.Drawing.Size(230, 26);
            this.switch_otherptumour.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_otherptumour.SwitchWidth = 110;
            this.switch_otherptumour.TabIndex = 29;
            this.switch_otherptumour.ValueChanged += new System.EventHandler(this.switch_otherptumour_ValueChanged);
            this.switch_otherptumour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            this.switch_otherptumour.Leave += new System.EventHandler(this.switch_otherptumour_Leave);
            // 
            // tb_fht
            // 
            // 
            // 
            // 
            this.tb_fht.Border.Class = "TextBoxBorder";
            this.tb_fht.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_fht.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_fht.Location = new System.Drawing.Point(228, 364);
            this.tb_fht.Multiline = true;
            this.tb_fht.Name = "tb_fht";
            this.tb_fht.PreventEnterBeep = true;
            this.tb_fht.Size = new System.Drawing.Size(703, 85);
            this.tb_fht.TabIndex = 10;
            this.tb_fht.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // lb_beizhu
            // 
            this.lb_beizhu.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_beizhu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_beizhu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_beizhu.Location = new System.Drawing.Point(157, 364);
            this.lb_beizhu.Name = "lb_beizhu";
            this.lb_beizhu.Size = new System.Drawing.Size(59, 23);
            this.lb_beizhu.TabIndex = 28;
            this.lb_beizhu.Text = "备注：";
            // 
            // tb_otherptt
            // 
            // 
            // 
            // 
            this.tb_otherptt.Border.Class = "TextBoxBorder";
            this.tb_otherptt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_otherptt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_otherptt.Location = new System.Drawing.Point(487, 257);
            this.tb_otherptt.Multiline = true;
            this.tb_otherptt.Name = "tb_otherptt";
            this.tb_otherptt.PreventEnterBeep = true;
            this.tb_otherptt.ReadOnly = true;
            this.tb_otherptt.Size = new System.Drawing.Size(668, 26);
            this.tb_otherptt.TabIndex = 8;
            this.tb_otherptt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // tb_othertt
            // 
            // 
            // 
            // 
            this.tb_othertt.Border.Class = "TextBoxBorder";
            this.tb_othertt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_othertt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_othertt.Location = new System.Drawing.Point(487, 216);
            this.tb_othertt.Multiline = true;
            this.tb_othertt.Name = "tb_othertt";
            this.tb_othertt.PreventEnterBeep = true;
            this.tb_othertt.ReadOnly = true;
            this.tb_othertt.Size = new System.Drawing.Size(668, 26);
            this.tb_othertt.TabIndex = 27;
            this.tb_othertt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_familyhistory
            // 
            // 
            // 
            // 
            this.switch_familyhistory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_familyhistory.Location = new System.Drawing.Point(228, 298);
            this.switch_familyhistory.Name = "switch_familyhistory";
            this.switch_familyhistory.OffText = "否";
            this.switch_familyhistory.OnText = "是";
            this.switch_familyhistory.Size = new System.Drawing.Size(230, 26);
            this.switch_familyhistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_familyhistory.SwitchWidth = 110;
            this.switch_familyhistory.TabIndex = 9;
            this.switch_familyhistory.ValueChanged += new System.EventHandler(this.switch_familyhistory_ValueChanged);
            this.switch_familyhistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_otherntumour
            // 
            // 
            // 
            // 
            this.switch_otherntumour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_otherntumour.Location = new System.Drawing.Point(228, 216);
            this.switch_otherntumour.Name = "switch_otherntumour";
            this.switch_otherntumour.OffText = "否";
            this.switch_otherntumour.OnText = "是";
            this.switch_otherntumour.Size = new System.Drawing.Size(230, 26);
            this.switch_otherntumour.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_otherntumour.SwitchWidth = 110;
            this.switch_otherntumour.TabIndex = 6;
            this.switch_otherntumour.ValueChanged += new System.EventHandler(this.switch_otherntumour_ValueChanged);
            this.switch_otherntumour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            this.switch_otherntumour.Leave += new System.EventHandler(this.switch_otherntumour_Leave);
            // 
            // switch_diabetes
            // 
            // 
            // 
            // 
            this.switch_diabetes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_diabetes.Location = new System.Drawing.Point(228, 93);
            this.switch_diabetes.Name = "switch_diabetes";
            this.switch_diabetes.OffText = "否";
            this.switch_diabetes.OnText = "是";
            this.switch_diabetes.Size = new System.Drawing.Size(230, 26);
            this.switch_diabetes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_diabetes.SwitchWidth = 110;
            this.switch_diabetes.TabIndex = 2;
            this.switch_diabetes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_radiotherapy
            // 
            // 
            // 
            // 
            this.switch_radiotherapy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_radiotherapy.Location = new System.Drawing.Point(228, 175);
            this.switch_radiotherapy.Name = "switch_radiotherapy";
            this.switch_radiotherapy.OffText = "否";
            this.switch_radiotherapy.OnText = "是";
            this.switch_radiotherapy.Size = new System.Drawing.Size(230, 26);
            this.switch_radiotherapy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_radiotherapy.SwitchWidth = 110;
            this.switch_radiotherapy.TabIndex = 4;
            this.switch_radiotherapy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_coronary
            // 
            // 
            // 
            // 
            this.switch_coronary.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_coronary.Location = new System.Drawing.Point(228, 134);
            this.switch_coronary.Name = "switch_coronary";
            this.switch_coronary.OffText = "否";
            this.switch_coronary.OnText = "是";
            this.switch_coronary.Size = new System.Drawing.Size(230, 26);
            this.switch_coronary.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_coronary.SwitchWidth = 110;
            this.switch_coronary.TabIndex = 3;
            this.switch_coronary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // switch_hypertension
            // 
            // 
            // 
            // 
            this.switch_hypertension.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switch_hypertension.Location = new System.Drawing.Point(228, 52);
            this.switch_hypertension.Name = "switch_hypertension";
            this.switch_hypertension.OffText = "否";
            this.switch_hypertension.OnText = "是";
            this.switch_hypertension.Size = new System.Drawing.Size(230, 26);
            this.switch_hypertension.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switch_hypertension.SwitchWidth = 110;
            this.switch_hypertension.TabIndex = 1;
            this.switch_hypertension.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX37
            // 
            this.labelX37.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX37.Location = new System.Drawing.Point(94, 300);
            this.labelX37.Name = "labelX37";
            this.labelX37.Size = new System.Drawing.Size(127, 23);
            this.labelX37.TabIndex = 26;
            this.labelX37.Text = "甲状腺家族史：";
            // 
            // labelX36
            // 
            this.labelX36.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX36.Location = new System.Drawing.Point(94, 259);
            this.labelX36.Name = "labelX36";
            this.labelX36.Size = new System.Drawing.Size(127, 23);
            this.labelX36.TabIndex = 26;
            this.labelX36.Text = "其它良性疾病：";
            // 
            // labelX34
            // 
            this.labelX34.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX34.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX34.Location = new System.Drawing.Point(94, 218);
            this.labelX34.Name = "labelX34";
            this.labelX34.Size = new System.Drawing.Size(127, 23);
            this.labelX34.TabIndex = 26;
            this.labelX34.Text = "其它恶性肿瘤：";
            // 
            // labelX40
            // 
            this.labelX40.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX40.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX40.Location = new System.Drawing.Point(78, 177);
            this.labelX40.Name = "labelX40";
            this.labelX40.Size = new System.Drawing.Size(140, 23);
            this.labelX40.TabIndex = 26;
            this.labelX40.Text = "颈部放射治疗史：";
            // 
            // labelX28
            // 
            this.labelX28.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX28.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX28.Location = new System.Drawing.Point(142, 95);
            this.labelX28.Name = "labelX28";
            this.labelX28.Size = new System.Drawing.Size(76, 23);
            this.labelX28.TabIndex = 26;
            this.labelX28.Text = "糖尿病：";
            // 
            // labelX32
            // 
            this.labelX32.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX32.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX32.Location = new System.Drawing.Point(142, 136);
            this.labelX32.Name = "labelX32";
            this.labelX32.Size = new System.Drawing.Size(76, 23);
            this.labelX32.TabIndex = 26;
            this.labelX32.Text = "冠心病：";
            // 
            // labelX27
            // 
            this.labelX27.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX27.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX27.Location = new System.Drawing.Point(142, 54);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(76, 23);
            this.labelX27.TabIndex = 26;
            this.labelX27.Text = "高血压：";
            // 
            // sideNavPanel4
            // 
            this.sideNavPanel4.Controls.Add(this.labelX33);
            this.sideNavPanel4.Controls.Add(this.di_bloodGlucose);
            this.sideNavPanel4.Controls.Add(this.labelX35);
            this.sideNavPanel4.Controls.Add(this.line13);
            this.sideNavPanel4.Controls.Add(this.di_triglyceride);
            this.sideNavPanel4.Controls.Add(this.di_llipoprotein);
            this.sideNavPanel4.Controls.Add(this.labelX25);
            this.sideNavPanel4.Controls.Add(this.labelX24);
            this.sideNavPanel4.Controls.Add(this.labelX23);
            this.sideNavPanel4.Controls.Add(this.labelX22);
            this.sideNavPanel4.Controls.Add(this.di_hlipoprotein);
            this.sideNavPanel4.Controls.Add(this.labelX26);
            this.sideNavPanel4.Controls.Add(this.di_cholesterol);
            this.sideNavPanel4.Controls.Add(this.labelX29);
            this.sideNavPanel4.Controls.Add(this.labelX30);
            this.sideNavPanel4.Controls.Add(this.labelX31);
            this.sideNavPanel4.Controls.Add(this.di_foll);
            this.sideNavPanel4.Controls.Add(this.labelX19);
            this.sideNavPanel4.Controls.Add(this.labelX16);
            this.sideNavPanel4.Controls.Add(this.di_pregnendione);
            this.sideNavPanel4.Controls.Add(this.labelX21);
            this.sideNavPanel4.Controls.Add(this.labelX18);
            this.sideNavPanel4.Controls.Add(this.di_estradiol);
            this.sideNavPanel4.Controls.Add(this.labelX14);
            this.sideNavPanel4.Controls.Add(this.di_luteinizing);
            this.sideNavPanel4.Controls.Add(this.di_testosterone);
            this.sideNavPanel4.Controls.Add(this.di_prolactin);
            this.sideNavPanel4.Controls.Add(this.labelX20);
            this.sideNavPanel4.Controls.Add(this.labelX10);
            this.sideNavPanel4.Controls.Add(this.labelX11);
            this.sideNavPanel4.Controls.Add(this.labelX13);
            this.sideNavPanel4.Controls.Add(this.labelX12);
            this.sideNavPanel4.Controls.Add(this.labelX17);
            this.sideNavPanel4.Controls.Add(this.labelX15);
            this.sideNavPanel4.Controls.Add(this.line6);
            this.sideNavPanel4.Controls.Add(this.line7);
            this.sideNavPanel4.Controls.Add(this.line9);
            this.sideNavPanel4.Controls.Add(this.line10);
            this.sideNavPanel4.Controls.Add(this.line11);
            this.sideNavPanel4.Controls.Add(this.line12);
            this.sideNavPanel4.Controls.Add(this.labelX39);
            this.sideNavPanel4.Controls.Add(this.labelX38);
            this.sideNavPanel4.Controls.Add(this.labelX52);
            this.sideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel4.Location = new System.Drawing.Point(132, 36);
            this.sideNavPanel4.Name = "sideNavPanel4";
            this.sideNavPanel4.Size = new System.Drawing.Size(1276, 528);
            this.sideNavPanel4.TabIndex = 17;
            this.sideNavPanel4.Visible = false;
            this.sideNavPanel4.Leave += new System.EventHandler(this.RefreshDatabase);
            this.sideNavPanel4.MouseLeave += new System.EventHandler(this.InsertData);
            // 
            // labelX33
            // 
            this.labelX33.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX33.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX33.Location = new System.Drawing.Point(523, 397);
            this.labelX33.Name = "labelX33";
            this.labelX33.Size = new System.Drawing.Size(91, 23);
            this.labelX33.TabIndex = 171;
            this.labelX33.Text = "（mmol/L）";
            // 
            // di_bloodGlucose
            // 
            // 
            // 
            // 
            this.di_bloodGlucose.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_bloodGlucose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_bloodGlucose.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_bloodGlucose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_bloodGlucose.Increment = 1D;
            this.di_bloodGlucose.Location = new System.Drawing.Point(377, 397);
            this.di_bloodGlucose.Name = "di_bloodGlucose";
            this.di_bloodGlucose.ShowUpDown = true;
            this.di_bloodGlucose.Size = new System.Drawing.Size(140, 26);
            this.di_bloodGlucose.TabIndex = 11;
            this.di_bloodGlucose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX35
            // 
            this.labelX35.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX35.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX35.Location = new System.Drawing.Point(265, 397);
            this.labelX35.Name = "labelX35";
            this.labelX35.Size = new System.Drawing.Size(105, 23);
            this.labelX35.TabIndex = 170;
            this.labelX35.Text = "血糖：";
            this.labelX35.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // line13
            // 
            this.line13.BackColor = System.Drawing.Color.Transparent;
            this.line13.ForeColor = System.Drawing.Color.White;
            this.line13.Location = new System.Drawing.Point(85, 362);
            this.line13.Name = "line13";
            this.line13.Size = new System.Drawing.Size(1108, 1);
            this.line13.TabIndex = 169;
            this.line13.Text = "line1";
            // 
            // di_triglyceride
            // 
            // 
            // 
            // 
            this.di_triglyceride.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_triglyceride.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_triglyceride.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_triglyceride.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_triglyceride.Increment = 1D;
            this.di_triglyceride.Location = new System.Drawing.Point(377, 303);
            this.di_triglyceride.Name = "di_triglyceride";
            this.di_triglyceride.ShowUpDown = true;
            this.di_triglyceride.Size = new System.Drawing.Size(140, 26);
            this.di_triglyceride.TabIndex = 8;
            this.di_triglyceride.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // di_llipoprotein
            // 
            // 
            // 
            // 
            this.di_llipoprotein.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_llipoprotein.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_llipoprotein.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_llipoprotein.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_llipoprotein.Increment = 1D;
            this.di_llipoprotein.Location = new System.Drawing.Point(778, 254);
            this.di_llipoprotein.Name = "di_llipoprotein";
            this.di_llipoprotein.ShowUpDown = true;
            this.di_llipoprotein.Size = new System.Drawing.Size(140, 26);
            this.di_llipoprotein.TabIndex = 9;
            this.di_llipoprotein.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX25
            // 
            this.labelX25.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX25.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX25.Location = new System.Drawing.Point(523, 306);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(91, 23);
            this.labelX25.TabIndex = 162;
            this.labelX25.Text = "（mmol/L）";
            // 
            // labelX24
            // 
            this.labelX24.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX24.Location = new System.Drawing.Point(921, 306);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(91, 23);
            this.labelX24.TabIndex = 164;
            this.labelX24.Text = "（mmol/L）";
            // 
            // labelX23
            // 
            this.labelX23.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX23.Location = new System.Drawing.Point(921, 261);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(91, 23);
            this.labelX23.TabIndex = 161;
            this.labelX23.Text = "（mmol/L）";
            // 
            // labelX22
            // 
            this.labelX22.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX22.Location = new System.Drawing.Point(525, 260);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(91, 23);
            this.labelX22.TabIndex = 163;
            this.labelX22.Text = "（mmol/L）";
            // 
            // di_hlipoprotein
            // 
            // 
            // 
            // 
            this.di_hlipoprotein.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_hlipoprotein.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_hlipoprotein.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_hlipoprotein.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_hlipoprotein.Increment = 1D;
            this.di_hlipoprotein.Location = new System.Drawing.Point(778, 299);
            this.di_hlipoprotein.Name = "di_hlipoprotein";
            this.di_hlipoprotein.ShowUpDown = true;
            this.di_hlipoprotein.Size = new System.Drawing.Size(140, 26);
            this.di_hlipoprotein.TabIndex = 10;
            this.di_hlipoprotein.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX26
            // 
            this.labelX26.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX26.Location = new System.Drawing.Point(638, 254);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(134, 23);
            this.labelX26.TabIndex = 157;
            this.labelX26.Text = "低密度脂蛋白：";
            this.labelX26.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // di_cholesterol
            // 
            // 
            // 
            // 
            this.di_cholesterol.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_cholesterol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_cholesterol.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_cholesterol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_cholesterol.Increment = 1D;
            this.di_cholesterol.Location = new System.Drawing.Point(377, 259);
            this.di_cholesterol.Name = "di_cholesterol";
            this.di_cholesterol.ShowUpDown = true;
            this.di_cholesterol.Size = new System.Drawing.Size(140, 26);
            this.di_cholesterol.TabIndex = 7;
            this.di_cholesterol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX29
            // 
            this.labelX29.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX29.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX29.Location = new System.Drawing.Point(271, 261);
            this.labelX29.Name = "labelX29";
            this.labelX29.Size = new System.Drawing.Size(105, 23);
            this.labelX29.TabIndex = 160;
            this.labelX29.Text = "胆固醇：";
            this.labelX29.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX30
            // 
            this.labelX30.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX30.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX30.Location = new System.Drawing.Point(638, 302);
            this.labelX30.Name = "labelX30";
            this.labelX30.Size = new System.Drawing.Size(134, 23);
            this.labelX30.TabIndex = 159;
            this.labelX30.Text = "高密度脂蛋白：";
            this.labelX30.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX31
            // 
            this.labelX31.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX31.Location = new System.Drawing.Point(271, 306);
            this.labelX31.Name = "labelX31";
            this.labelX31.Size = new System.Drawing.Size(105, 23);
            this.labelX31.TabIndex = 158;
            this.labelX31.Text = "甘油三酯：";
            this.labelX31.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // di_foll
            // 
            // 
            // 
            // 
            this.di_foll.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_foll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_foll.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_foll.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_foll.Increment = 1D;
            this.di_foll.Location = new System.Drawing.Point(778, 184);
            this.di_foll.Name = "di_foll";
            this.di_foll.ShowUpDown = true;
            this.di_foll.Size = new System.Drawing.Size(140, 26);
            this.di_foll.TabIndex = 6;
            this.di_foll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX19
            // 
            this.labelX19.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX19.Location = new System.Drawing.Point(523, 84);
            this.labelX19.Name = "labelX19";
            this.labelX19.Size = new System.Drawing.Size(91, 23);
            this.labelX19.TabIndex = 147;
            this.labelX19.Text = "（uIu/ml）";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX16.Location = new System.Drawing.Point(641, 180);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(134, 23);
            this.labelX16.TabIndex = 146;
            this.labelX16.Text = "促卵泡刺激素：";
            this.labelX16.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // di_pregnendione
            // 
            // 
            // 
            // 
            this.di_pregnendione.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_pregnendione.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_pregnendione.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_pregnendione.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_pregnendione.Increment = 1D;
            this.di_pregnendione.Location = new System.Drawing.Point(377, 182);
            this.di_pregnendione.Name = "di_pregnendione";
            this.di_pregnendione.ShowUpDown = true;
            this.di_pregnendione.Size = new System.Drawing.Size(140, 26);
            this.di_pregnendione.TabIndex = 3;
            this.di_pregnendione.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX21
            // 
            this.labelX21.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX21.Location = new System.Drawing.Point(924, 186);
            this.labelX21.Name = "labelX21";
            this.labelX21.Size = new System.Drawing.Size(88, 23);
            this.labelX21.TabIndex = 150;
            this.labelX21.Text = "（mIu/ml）";
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX18.Location = new System.Drawing.Point(922, 135);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(88, 23);
            this.labelX18.TabIndex = 149;
            this.labelX18.Text = "（mIu/ml）";
            // 
            // di_estradiol
            // 
            // 
            // 
            // 
            this.di_estradiol.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_estradiol.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_estradiol.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_estradiol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_estradiol.Increment = 1D;
            this.di_estradiol.Location = new System.Drawing.Point(778, 82);
            this.di_estradiol.Name = "di_estradiol";
            this.di_estradiol.ShowUpDown = true;
            this.di_estradiol.Size = new System.Drawing.Size(140, 26);
            this.di_estradiol.TabIndex = 4;
            this.di_estradiol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX14.Location = new System.Drawing.Point(271, 134);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(105, 23);
            this.labelX14.TabIndex = 141;
            this.labelX14.Text = "睾酮：";
            this.labelX14.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // di_luteinizing
            // 
            // 
            // 
            // 
            this.di_luteinizing.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_luteinizing.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_luteinizing.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_luteinizing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_luteinizing.Increment = 1D;
            this.di_luteinizing.Location = new System.Drawing.Point(778, 133);
            this.di_luteinizing.Name = "di_luteinizing";
            this.di_luteinizing.ShowUpDown = true;
            this.di_luteinizing.Size = new System.Drawing.Size(140, 26);
            this.di_luteinizing.TabIndex = 5;
            this.di_luteinizing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // di_testosterone
            // 
            // 
            // 
            // 
            this.di_testosterone.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_testosterone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_testosterone.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_testosterone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_testosterone.Increment = 1D;
            this.di_testosterone.Location = new System.Drawing.Point(377, 132);
            this.di_testosterone.Name = "di_testosterone";
            this.di_testosterone.ShowUpDown = true;
            this.di_testosterone.Size = new System.Drawing.Size(140, 26);
            this.di_testosterone.TabIndex = 2;
            this.di_testosterone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // di_prolactin
            // 
            // 
            // 
            // 
            this.di_prolactin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.di_prolactin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.di_prolactin.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.di_prolactin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.di_prolactin.Increment = 1D;
            this.di_prolactin.Location = new System.Drawing.Point(377, 82);
            this.di_prolactin.Name = "di_prolactin";
            this.di_prolactin.ShowUpDown = true;
            this.di_prolactin.Size = new System.Drawing.Size(140, 26);
            this.di_prolactin.TabIndex = 1;
            this.di_prolactin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_patientName_KeyDown);
            // 
            // labelX20
            // 
            this.labelX20.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX20.Location = new System.Drawing.Point(523, 134);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(96, 23);
            this.labelX20.TabIndex = 143;
            this.labelX20.Text = "（nmo/L）";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX10.Location = new System.Drawing.Point(525, 184);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(96, 23);
            this.labelX10.TabIndex = 142;
            this.labelX10.Text = "（nmo/L）";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX11.Location = new System.Drawing.Point(271, 84);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(105, 23);
            this.labelX11.TabIndex = 144;
            this.labelX11.Text = "泌乳素：";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX13.Location = new System.Drawing.Point(271, 184);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(105, 23);
            this.labelX13.TabIndex = 139;
            this.labelX13.Text = "孕酮：";
            this.labelX13.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX12.Location = new System.Drawing.Point(641, 84);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(134, 23);
            this.labelX12.TabIndex = 140;
            this.labelX12.Text = "雌二醇：";
            this.labelX12.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX17.Location = new System.Drawing.Point(922, 84);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(97, 23);
            this.labelX17.TabIndex = 145;
            this.labelX17.Text = "( Pmo/L )";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX15.Location = new System.Drawing.Point(641, 132);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(134, 23);
            this.labelX15.TabIndex = 148;
            this.labelX15.Text = "促黄体激素：";
            this.labelX15.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.Transparent;
            this.line6.ForeColor = System.Drawing.Color.White;
            this.line6.Location = new System.Drawing.Point(1192, 53);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(1, 408);
            this.line6.TabIndex = 138;
            this.line6.Text = "line1";
            this.line6.VerticalLine = true;
            // 
            // line7
            // 
            this.line7.BackColor = System.Drawing.Color.Transparent;
            this.line7.ForeColor = System.Drawing.Color.White;
            this.line7.Location = new System.Drawing.Point(228, 53);
            this.line7.Name = "line7";
            this.line7.Size = new System.Drawing.Size(1, 408);
            this.line7.TabIndex = 136;
            this.line7.Text = "line1";
            this.line7.VerticalLine = true;
            // 
            // line9
            // 
            this.line9.BackColor = System.Drawing.Color.Transparent;
            this.line9.ForeColor = System.Drawing.Color.White;
            this.line9.Location = new System.Drawing.Point(84, 53);
            this.line9.Name = "line9";
            this.line9.Size = new System.Drawing.Size(1, 408);
            this.line9.TabIndex = 137;
            this.line9.Text = "line1";
            this.line9.VerticalLine = true;
            // 
            // line10
            // 
            this.line10.BackColor = System.Drawing.Color.Transparent;
            this.line10.ForeColor = System.Drawing.Color.White;
            this.line10.Location = new System.Drawing.Point(85, 460);
            this.line10.Name = "line10";
            this.line10.Size = new System.Drawing.Size(1108, 1);
            this.line10.TabIndex = 135;
            this.line10.Text = "line1";
            // 
            // line11
            // 
            this.line11.BackColor = System.Drawing.Color.Transparent;
            this.line11.ForeColor = System.Drawing.Color.White;
            this.line11.Location = new System.Drawing.Point(85, 228);
            this.line11.Name = "line11";
            this.line11.Size = new System.Drawing.Size(1108, 1);
            this.line11.TabIndex = 133;
            this.line11.Text = "line1";
            // 
            // line12
            // 
            this.line12.BackColor = System.Drawing.Color.Transparent;
            this.line12.ForeColor = System.Drawing.Color.White;
            this.line12.Location = new System.Drawing.Point(85, 53);
            this.line12.Name = "line12";
            this.line12.Size = new System.Drawing.Size(1108, 1);
            this.line12.TabIndex = 134;
            this.line12.Text = "line12";
            // 
            // labelX39
            // 
            this.labelX39.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX39.Font = new System.Drawing.Font("宋体", 12F);
            this.labelX39.Location = new System.Drawing.Point(85, 407);
            this.labelX39.Name = "labelX39";
            this.labelX39.Size = new System.Drawing.Size(145, 23);
            this.labelX39.TabIndex = 131;
            this.labelX39.Text = "血糖";
            this.labelX39.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX38
            // 
            this.labelX38.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX38.Font = new System.Drawing.Font("宋体", 12F);
            this.labelX38.Location = new System.Drawing.Point(83, 293);
            this.labelX38.Name = "labelX38";
            this.labelX38.Size = new System.Drawing.Size(145, 23);
            this.labelX38.TabIndex = 131;
            this.labelX38.Text = "血脂";
            this.labelX38.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX52
            // 
            this.labelX52.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX52.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX52.Font = new System.Drawing.Font("宋体", 12F);
            this.labelX52.Location = new System.Drawing.Point(84, 141);
            this.labelX52.Name = "labelX52";
            this.labelX52.Size = new System.Drawing.Size(145, 23);
            this.labelX52.TabIndex = 131;
            this.labelX52.Text = "雌激素";
            this.labelX52.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // sni_menu
            // 
            this.sni_menu.IsSystemMenu = true;
            this.sni_menu.Name = "sni_menu";
            this.sni_menu.Symbol = "";
            this.sni_menu.Text = "功能菜单";
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem5
            // 
            this.sideNavItem5.Checked = true;
            this.sideNavItem5.Name = "sideNavItem5";
            this.sideNavItem5.Panel = this.sideNavPanel1;
            this.sideNavItem5.Symbol = "";
            this.sideNavItem5.Text = "患者基本信息";
            // 
            // separator3
            // 
            this.separator3.FixedSize = new System.Drawing.Size(3, 1);
            this.separator3.Name = "separator3";
            this.separator3.Padding.Bottom = 2;
            this.separator3.Padding.Left = 6;
            this.separator3.Padding.Right = 6;
            this.separator3.Padding.Top = 2;
            this.separator3.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Panel = this.sideNavPanel3;
            this.sideNavItem1.Symbol = "57344";
            this.sideNavItem1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem1.Text = "一般危险因素";
            // 
            // separator4
            // 
            this.separator4.FixedSize = new System.Drawing.Size(3, 1);
            this.separator4.Name = "separator4";
            this.separator4.Padding.Bottom = 2;
            this.separator4.Padding.Left = 6;
            this.separator4.Padding.Right = 6;
            this.separator4.Padding.Top = 2;
            this.separator4.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem2
            // 
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel4;
            this.sideNavItem2.Symbol = "57345";
            this.sideNavItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem2.Text = "特殊危险因素";
            // 
            // separator5
            // 
            this.separator5.FixedSize = new System.Drawing.Size(3, 1);
            this.separator5.Name = "separator5";
            this.separator5.Padding.Bottom = 2;
            this.separator5.Padding.Left = 6;
            this.separator5.Padding.Right = 6;
            this.separator5.Padding.Top = 2;
            this.separator5.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem3
            // 
            this.sideNavItem3.Name = "sideNavItem3";
            this.sideNavItem3.Panel = this.sideNavPanel5;
            this.sideNavItem3.Symbol = "57346";
            this.sideNavItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.sideNavItem3.Text = "既往史及家族史";
            // 
            // separator6
            // 
            this.separator6.FixedSize = new System.Drawing.Size(3, 1);
            this.separator6.Name = "separator6";
            this.separator6.Padding.Bottom = 2;
            this.separator6.Padding.Left = 6;
            this.separator6.Padding.Right = 6;
            this.separator6.Padding.Top = 2;
            this.separator6.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // UC_patientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.snav_patientInfo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_patientInfo";
            this.Size = new System.Drawing.Size(1416, 568);
            this.Load += new System.EventHandler(this.UC_patientInfo_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_patientInfo_VisibleChanged);
            this.snav_patientInfo.ResumeLayout(false);
            this.snav_patientInfo.PerformLayout();
            this.sideNavPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dti_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_regDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_dateLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_birthday)).EndInit();
            this.sideNavPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dti_lastM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_BMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_eutociaT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_AFM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_TIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_AFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_height)).EndInit();
            this.sideNavPanel5.ResumeLayout(false);
            this.sideNavPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.di_bloodGlucose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_triglyceride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_llipoprotein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_hlipoprotein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_cholesterol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_foll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_pregnendione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_estradiol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_luteinizing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_testosterone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.di_prolactin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.SideNav snav_patientInfo;
        private DevComponents.DotNetBar.Controls.SideNavItem sni_menu;
        private DevComponents.DotNetBar.Separator separator3;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel3;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel5;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel4;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem3;
        private DevComponents.DotNetBar.Separator separator4;
        private DevComponents.DotNetBar.Separator separator5;
        private DevComponents.Editors.DoubleInput dti_weight;
        private DevComponents.Editors.IntegerInput dti_height;
        private DevComponents.DotNetBar.LabelX lb_weight;
        private DevComponents.DotNetBar.LabelX lb_height;
        private DevComponents.DotNetBar.LabelX lb_resident;
        private DevComponents.DotNetBar.LabelX lb_AFM;
        private DevComponents.DotNetBar.LabelX lb_AFP;
        private DevComponents.DotNetBar.LabelX lb_TP;
        private DevComponents.DotNetBar.LabelX lb_TIA;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_menopause;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lb_eutociaT;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_drink;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_smoke;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_occupation;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_otherntumour;
        private DevComponents.DotNetBar.LabelX labelX36;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_diabetes;
        private DevComponents.DotNetBar.LabelX labelX34;
        private DevComponents.DotNetBar.LabelX labelX28;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_coronary;
        private DevComponents.DotNetBar.LabelX labelX32;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_hypertension;
        private DevComponents.DotNetBar.LabelX labelX27;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_familyhistory;
        private DevComponents.DotNetBar.LabelX labelX37;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_otherptt;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_othertt;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_radiotherapy;
        private DevComponents.DotNetBar.LabelX labelX40;
        private DevComponents.DotNetBar.Separator separator6;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem5;
        private DevComponents.Editors.IntegerInput dti_age;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_regDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_dateLeave;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_gender;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_birthday;
        private DevComponents.DotNetBar.LabelX lb_dateLeave;
        private DevComponents.DotNetBar.LabelX lb_regDate;
        private DevComponents.DotNetBar.LabelX lb_age;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_hospitalNo;
        private DevComponents.DotNetBar.LabelX lb_birthday;
        private DevComponents.DotNetBar.LabelX lb_gender;
        private DevComponents.DotNetBar.LabelX lb_hospitalNo;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_patientPhone3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_patientPhone2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_idNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_patientAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_patientName;
        private DevComponents.DotNetBar.LabelX lb_patientName;
        private DevComponents.DotNetBar.LabelX lb_idNumber;
        private DevComponents.DotNetBar.LabelX lb_patientAddress;
        private DevComponents.DotNetBar.LabelX lb_patientPhone2;
        private DevComponents.DotNetBar.LabelX lb_patientPhone3;
        private DevComponents.DotNetBar.Controls.Line line8;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line5;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX43;
        private DevComponents.DotNetBar.LabelX labelX44;
        private DevComponents.DotNetBar.LabelX lb_BMI;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_fht;
        private DevComponents.DotNetBar.LabelX lb_beizhu;
        private DevComponents.DotNetBar.LabelX labelX33;
        private DevComponents.Editors.DoubleInput di_bloodGlucose;
        private DevComponents.DotNetBar.LabelX labelX35;
        private DevComponents.DotNetBar.Controls.Line line13;
        private DevComponents.Editors.DoubleInput di_triglyceride;
        private DevComponents.Editors.DoubleInput di_llipoprotein;
        private DevComponents.DotNetBar.LabelX labelX25;
        private DevComponents.DotNetBar.LabelX labelX24;
        private DevComponents.DotNetBar.LabelX labelX23;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.Editors.DoubleInput di_hlipoprotein;
        private DevComponents.DotNetBar.LabelX labelX26;
        private DevComponents.Editors.DoubleInput di_cholesterol;
        private DevComponents.DotNetBar.LabelX labelX29;
        private DevComponents.DotNetBar.LabelX labelX30;
        private DevComponents.DotNetBar.LabelX labelX31;
        private DevComponents.Editors.DoubleInput di_foll;
        private DevComponents.DotNetBar.LabelX labelX19;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.Editors.DoubleInput di_pregnendione;
        private DevComponents.DotNetBar.LabelX labelX21;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.Editors.DoubleInput di_estradiol;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.Editors.DoubleInput di_luteinizing;
        private DevComponents.Editors.DoubleInput di_testosterone;
        private DevComponents.Editors.DoubleInput di_prolactin;
        private DevComponents.DotNetBar.LabelX labelX20;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.Controls.Line line6;
        private DevComponents.DotNetBar.Controls.Line line7;
        private DevComponents.DotNetBar.Controls.Line line9;
        private DevComponents.DotNetBar.Controls.Line line10;
        private DevComponents.DotNetBar.Controls.Line line11;
        private DevComponents.DotNetBar.Controls.Line line12;
        private DevComponents.DotNetBar.LabelX labelX39;
        private DevComponents.DotNetBar.LabelX labelX38;
        private DevComponents.DotNetBar.LabelX labelX52;
        private DevComponents.Editors.IntegerInput ii_AFP;
        private DevComponents.Editors.IntegerInput ii_TIA;
        private DevComponents.Editors.IntegerInput ii_TP;
        private DevComponents.Editors.IntegerInput ii_AFM;
        private DevComponents.Editors.IntegerInput ii_eutociaT;
        private DevComponents.DotNetBar.Controls.SwitchButton switch_otherptumour;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbe_resident;
        private DevComponents.Editors.ComboItem res_null;
        private DevComponents.Editors.ComboItem res_city;
        private DevComponents.Editors.ComboItem res_country;
        private DevComponents.Editors.DoubleInput dti_BMI;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_wechat;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_email;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX41;
        private DevComponents.DotNetBar.LabelX lb_lastM;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_lastM;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_study;
        private DevComponents.DotNetBar.LabelX lb_study;
    }
}
