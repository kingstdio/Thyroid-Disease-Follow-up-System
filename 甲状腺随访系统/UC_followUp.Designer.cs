﻿using System;
using DevComponents.DotNetBar.SuperGrid;
namespace 甲状腺随访系统
{
    partial class UC_followUp
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
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel3 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sgc_visit = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.VDate = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.TSH = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.FT3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.FT4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.TPO = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.PTH = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.ATG = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.TG = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.TGAb = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.Ca = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.P = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.euthyrox = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.adjustEuthyrox = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.Cadosage = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.sideeffect = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.others = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.id = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.pid = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dti_DLC = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbe_DM = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.null_DM = new DevComponents.Editors.ComboItem();
            this.yes_DM = new DevComponents.Editors.ComboItem();
            this.no_DM = new DevComponents.Editors.ComboItem();
            this.cbe_CD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.null_CD = new DevComponents.Editors.ComboItem();
            this.TC_CD = new DevComponents.Editors.ComboItem();
            this.OC_CD = new DevComponents.Editors.ComboItem();
            this.OD_CD = new DevComponents.Editors.ComboItem();
            this.cbe_LDM = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.null_LDM = new DevComponents.Editors.ComboItem();
            this.brain_LDM = new DevComponents.Editors.ComboItem();
            this.lung_LDM = new DevComponents.Editors.ComboItem();
            this.liver_LDM = new DevComponents.Editors.ComboItem();
            this.bone_LDM = new DevComponents.Editors.ComboItem();
            this.cbe_VS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.null_VS = new DevComponents.Editors.ComboItem();
            this.death_VS = new DevComponents.Editors.ComboItem();
            this.alive_VS = new DevComponents.Editors.ComboItem();
            this.LTFU_VS = new DevComponents.Editors.ComboItem();
            this.dti_DD = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dti_dismetadate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lb_CD = new DevComponents.DotNetBar.LabelX();
            this.lb_DD = new DevComponents.DotNetBar.LabelX();
            this.lb_LDM = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lb_DM = new DevComponents.DotNetBar.LabelX();
            this.lb_VS = new DevComponents.DotNetBar.LabelX();
            this.lb_DLC = new DevComponents.DotNetBar.LabelX();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator3 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem4 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator2 = new DevComponents.DotNetBar.Separator();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tb_PTH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TPO = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TGAb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_OS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_SR = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_CaD = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_ED = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_P = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_Ca = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_ATG = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FT4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FT3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_TSH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dti_FUD = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lb_FUD = new DevComponents.DotNetBar.LabelX();
            this.lb_PTH = new DevComponents.DotNetBar.LabelX();
            this.lb_TPO = new DevComponents.DotNetBar.LabelX();
            this.lb_TGAb = new DevComponents.DotNetBar.LabelX();
            this.lb_OS = new DevComponents.DotNetBar.LabelX();
            this.lb_SR = new DevComponents.DotNetBar.LabelX();
            this.lb_CaD = new DevComponents.DotNetBar.LabelX();
            this.lb_ED = new DevComponents.DotNetBar.LabelX();
            this.lb_P = new DevComponents.DotNetBar.LabelX();
            this.lb_Ca = new DevComponents.DotNetBar.LabelX();
            this.lb_TG = new DevComponents.DotNetBar.LabelX();
            this.lb_ATG = new DevComponents.DotNetBar.LabelX();
            this.lb_FT4 = new DevComponents.DotNetBar.LabelX();
            this.lb_FT3 = new DevComponents.DotNetBar.LabelX();
            this.lb_TSH = new DevComponents.DotNetBar.LabelX();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sideNav1.SuspendLayout();
            this.sideNavPanel3.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dti_DLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_DD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_dismetadate)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dti_FUD)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNav1
            // 
            this.sideNav1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sideNav1.Controls.Add(this.sideNavPanel3);
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNavItem1,
            this.separator3,
            this.sideNavItem4,
            this.separator1,
            this.sideNavItem2,
            this.separator2});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1);
            this.sideNav1.Size = new System.Drawing.Size(1413, 566);
            this.sideNav1.TabIndex = 0;
            this.sideNav1.Text = "sideNav1";
            // 
            // sideNavPanel3
            // 
            this.sideNavPanel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sideNavPanel3.Controls.Add(this.sgc_visit);
            this.sideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel3.Location = new System.Drawing.Point(96, 36);
            this.sideNavPanel3.Name = "sideNavPanel3";
            this.sideNavPanel3.Size = new System.Drawing.Size(1312, 529);
            this.sideNavPanel3.TabIndex = 10;
            // 
            // sgc_visit
            // 
            this.sgc_visit.Dock = System.Windows.Forms.DockStyle.Top;
            this.sgc_visit.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_visit.Location = new System.Drawing.Point(0, 0);
            this.sgc_visit.Name = "sgc_visit";
            // 
            // 
            // 
            this.sgc_visit.PrimaryGrid.AllowRowDelete = true;
            this.sgc_visit.PrimaryGrid.AllowRowInsert = true;
            this.sgc_visit.PrimaryGrid.Columns.Add(this.VDate);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.TSH);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.FT3);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.FT4);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.TPO);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.PTH);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.ATG);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.TG);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.TGAb);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.Ca);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.P);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.euthyrox);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.adjustEuthyrox);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.Cadosage);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.sideeffect);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.others);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.id);
            this.sgc_visit.PrimaryGrid.Columns.Add(this.pid);
            this.sgc_visit.PrimaryGrid.MultiSelect = false;
            this.sgc_visit.PrimaryGrid.ShowInsertRow = true;
            this.sgc_visit.PrimaryGrid.UseAlternateColumnStyle = true;
            this.sgc_visit.PrimaryGrid.UseAlternateRowStyle = true;
            this.sgc_visit.Size = new System.Drawing.Size(1312, 532);
            this.sgc_visit.TabIndex = 1;
            this.sgc_visit.TabSelection = DevComponents.DotNetBar.SuperGrid.TabSelection.CellSameRow;
            this.sgc_visit.Text = "superGridControl1";
            this.sgc_visit.RowDeleted += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDeletedEventArgs>(this.sgc_visit_RowDeleted);
            this.sgc_visit.Click += new System.EventHandler(this.sgc_visit_Click);
            this.sgc_visit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbe_VS_KeyDown);
            this.sgc_visit.Leave += new System.EventHandler(this.RefreshDatabase);
            // 
            // VDate
            // 
            //this.VDate.DefaultNewRowCellValue = new System.DateTime(2017, 8, 26, 0, 0, 0, 0);
            this.VDate.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl);
            this.VDate.HeaderText = "随访日期";
            this.VDate.Name = "Vdate";
            // 
            // TSH
            // 
            this.TSH.EditorType = null;
            this.TSH.Name = "TSH";
            // 
            // FT3
            // 
            this.FT3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.FT3.HeaderText = "FT3(pmol/L)";
            this.FT3.Name = "FT3";
            // 
            // FT4
            // 
            this.FT4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.FT4.HeaderText = "FT4(pmol/L)";
            this.FT4.Name = "FT4";
            // 
            // TPO
            // 
            this.TPO.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.TPO.HeaderText = "TPO(IU/ml)";
            this.TPO.Name = "TPO";
            // 
            // PTH
            // 
            this.PTH.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.PTH.HeaderText = "PTH(pg/ml)";
            this.PTH.Name = "PTH";
            // 
            // ATG
            // 
            this.ATG.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.ATG.HeaderText = "A-TG(IU/ml)";
            this.ATG.Name = "ATG";
            // 
            // TG
            // 
            this.TG.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.TG.HeaderText = "TG(IU/ml)";
            this.TG.Name = "TG";
            // 
            // TGAb
            // 
            this.TGAb.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.TGAb.HeaderText = "TG-Ab(IU/ml)";
            this.TGAb.Name = "TGAb";
            // 
            // Ca
            // 
            this.Ca.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.Ca.HeaderText = "Ca(mol/l)";
            this.Ca.Name = "Ca";
            // 
            // P
            // 
            this.P.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.P.HeaderText = "P(mmol/l)";
            this.P.Name = "P";
            // 
            // euthyrox
            // 
            this.euthyrox.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.euthyrox.HeaderText = "优甲乐剂量";
            this.euthyrox.Name = "euthyrox";
            // 
            // adjustEuthyrox
            // 
            this.adjustEuthyrox.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.adjustEuthyrox.HeaderText = "优甲乐调整后剂量";
            this.adjustEuthyrox.Name = "adjustEuthyrox";
            // 
            // Cadosage
            // 
            this.Cadosage.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            this.Cadosage.HeaderText = "钙计量";
            this.Cadosage.Name = "Cadosage";
            // 
            // sideeffect
            // 
            this.sideeffect.HeaderText = "副作用";
            this.sideeffect.Name = "sideeffect";
            // 
            // others
            // 
            this.others.HeaderText = "其它症状";
            this.others.Name = "others";
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // pid
            // 
            this.pid.Name = "pid";
            this.pid.Visible = false;
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Controls.Add(this.groupPanel1);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(96, 36);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(1312, 529);
            this.sideNavPanel1.TabIndex = 2;
            this.sideNavPanel1.Visible = false;
            this.sideNavPanel1.Leave += new System.EventHandler(this.RefreshDatabase);
            this.sideNavPanel1.MouseLeave += new System.EventHandler(this.InsertData);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dti_DLC);
            this.groupPanel1.Controls.Add(this.cbe_DM);
            this.groupPanel1.Controls.Add(this.cbe_CD);
            this.groupPanel1.Controls.Add(this.cbe_LDM);
            this.groupPanel1.Controls.Add(this.cbe_VS);
            this.groupPanel1.Controls.Add(this.dti_DD);
            this.groupPanel1.Controls.Add(this.dti_dismetadate);
            this.groupPanel1.Controls.Add(this.lb_CD);
            this.groupPanel1.Controls.Add(this.lb_DD);
            this.groupPanel1.Controls.Add(this.lb_LDM);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.lb_DM);
            this.groupPanel1.Controls.Add(this.lb_VS);
            this.groupPanel1.Controls.Add(this.lb_DLC);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(234, 76);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(774, 332);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "追踪";
            // 
            // dti_DLC
            // 
            // 
            // 
            // 
            this.dti_DLC.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_DLC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DLC.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_DLC.ButtonDropDown.Visible = true;
            this.dti_DLC.Font = new System.Drawing.Font("宋体", 12F);
            this.dti_DLC.IsPopupCalendarOpen = false;
            this.dti_DLC.Location = new System.Drawing.Point(242, 49);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_DLC.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DLC.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_DLC.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_DLC.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DLC.MonthCalendar.DisplayMonth = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dti_DLC.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dti_DLC.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_DLC.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_DLC.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_DLC.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DLC.MonthCalendar.TodayButtonVisible = true;
            this.dti_DLC.Name = "dti_DLC";
            this.dti_DLC.Size = new System.Drawing.Size(121, 26);
            this.dti_DLC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_DLC.TabIndex = 19;
            // 
            // cbe_DM
            // 
            this.cbe_DM.DisplayMember = "Text";
            this.cbe_DM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbe_DM.Font = new System.Drawing.Font("宋体", 12F);
            this.cbe_DM.FormattingEnabled = true;
            this.cbe_DM.ItemHeight = 20;
            this.cbe_DM.Items.AddRange(new object[] {
            this.null_DM,
            this.yes_DM,
            this.no_DM});
            this.cbe_DM.Location = new System.Drawing.Point(242, 149);
            this.cbe_DM.Name = "cbe_DM";
            this.cbe_DM.Size = new System.Drawing.Size(121, 26);
            this.cbe_DM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbe_DM.TabIndex = 3;
            this.cbe_DM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbe_VS_KeyDown);
            // 
            // yes_DM
            // 
            this.yes_DM.Text = "是";
            this.yes_DM.Value = "是";
            // 
            // no_DM
            // 
            this.no_DM.Text = "否";
            this.no_DM.Value = "否";
            // 
            // cbe_CD
            // 
            this.cbe_CD.DisplayMember = "Text";
            this.cbe_CD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbe_CD.Font = new System.Drawing.Font("宋体", 12F);
            this.cbe_CD.FormattingEnabled = true;
            this.cbe_CD.ItemHeight = 20;
            this.cbe_CD.Items.AddRange(new object[] {
            this.null_CD,
            this.TC_CD,
            this.OC_CD,
            this.OD_CD});
            this.cbe_CD.Location = new System.Drawing.Point(558, 147);
            this.cbe_CD.Name = "cbe_CD";
            this.cbe_CD.Size = new System.Drawing.Size(121, 26);
            this.cbe_CD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbe_CD.TabIndex = 7;
            this.cbe_CD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbe_VS_KeyDown);
            // 
            // TC_CD
            // 
            this.TC_CD.Text = "甲状腺癌";
            this.TC_CD.Value = "甲状腺癌";
            // 
            // OC_CD
            // 
            this.OC_CD.Text = "其它癌症";
            this.OC_CD.Value = "其它癌症";
            // 
            // OD_CD
            // 
            this.OD_CD.Text = "其它疾病";
            this.OD_CD.Value = "其它疾病";
            // 
            // cbe_LDM
            // 
            this.cbe_LDM.DisplayMember = "Text";
            this.cbe_LDM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbe_LDM.Font = new System.Drawing.Font("宋体", 12F);
            this.cbe_LDM.FormattingEnabled = true;
            this.cbe_LDM.ItemHeight = 20;
            this.cbe_LDM.Items.AddRange(new object[] {
            this.null_LDM,
            this.brain_LDM,
            this.lung_LDM,
            this.liver_LDM,
            this.bone_LDM});
            this.cbe_LDM.Location = new System.Drawing.Point(558, 49);
            this.cbe_LDM.Name = "cbe_LDM";
            this.cbe_LDM.Size = new System.Drawing.Size(121, 26);
            this.cbe_LDM.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbe_LDM.TabIndex = 5;
            this.cbe_LDM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbe_VS_KeyDown);
            // 
            // brain_LDM
            // 
            this.brain_LDM.Text = "头部";
            this.brain_LDM.Value = "头部";
            // 
            // lung_LDM
            // 
            this.lung_LDM.Text = "肺部";
            this.lung_LDM.Value = "肺部";
            // 
            // liver_LDM
            // 
            this.liver_LDM.Text = "肝脏";
            this.liver_LDM.Value = "肝脏";
            // 
            // bone_LDM
            // 
            this.bone_LDM.Text = "骨骼";
            this.bone_LDM.Value = "骨骼";
            // 
            // cbe_VS
            // 
            this.cbe_VS.DisplayMember = "Text";
            this.cbe_VS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbe_VS.Font = new System.Drawing.Font("宋体", 12F);
            this.cbe_VS.FormattingEnabled = true;
            this.cbe_VS.ItemHeight = 20;
            this.cbe_VS.Items.AddRange(new object[] {
            this.null_VS,
            this.death_VS,
            this.alive_VS,
            this.LTFU_VS});
            this.cbe_VS.Location = new System.Drawing.Point(242, 100);
            this.cbe_VS.Name = "cbe_VS";
            this.cbe_VS.Size = new System.Drawing.Size(121, 26);
            this.cbe_VS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbe_VS.TabIndex = 2;
            this.cbe_VS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbe_VS_KeyDown);
            // 
            // death_VS
            // 
            this.death_VS.Text = "死亡";
            this.death_VS.Value = "死亡";
            // 
            // alive_VS
            // 
            this.alive_VS.Text = "活着";
            this.alive_VS.Value = "活着";
            // 
            // LTFU_VS
            // 
            this.LTFU_VS.Text = "失联";
            this.LTFU_VS.Value = "失联";
            // 
            // dti_DD
            // 
            // 
            // 
            // 
            this.dti_DD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_DD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DD.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_DD.ButtonDropDown.Visible = true;
            this.dti_DD.Font = new System.Drawing.Font("宋体", 12F);
            this.dti_DD.IsPopupCalendarOpen = false;
            this.dti_DD.Location = new System.Drawing.Point(558, 98);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_DD.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DD.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_DD.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_DD.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DD.MonthCalendar.DisplayMonth = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dti_DD.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dti_DD.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_DD.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_DD.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_DD.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_DD.MonthCalendar.TodayButtonVisible = true;
            this.dti_DD.Name = "dti_DD";
            this.dti_DD.Size = new System.Drawing.Size(121, 26);
            this.dti_DD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_DD.TabIndex = 6;
            // 
            // dti_dismetadate
            // 
            // 
            // 
            // 
            this.dti_dismetadate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_dismetadate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dismetadate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_dismetadate.ButtonDropDown.Visible = true;
            this.dti_dismetadate.Font = new System.Drawing.Font("宋体", 12F);
            this.dti_dismetadate.IsPopupCalendarOpen = false;
            this.dti_dismetadate.Location = new System.Drawing.Point(242, 198);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_dismetadate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dismetadate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_dismetadate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_dismetadate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dismetadate.MonthCalendar.DisplayMonth = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dti_dismetadate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dti_dismetadate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_dismetadate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_dismetadate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_dismetadate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_dismetadate.MonthCalendar.TodayButtonVisible = true;
            this.dti_dismetadate.Name = "dti_dismetadate";
            this.dti_dismetadate.Size = new System.Drawing.Size(121, 26);
            this.dti_dismetadate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_dismetadate.TabIndex = 4;
            // 
            // lb_CD
            // 
            this.lb_CD.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_CD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_CD.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_CD.Location = new System.Drawing.Point(459, 148);
            this.lb_CD.Name = "lb_CD";
            this.lb_CD.Size = new System.Drawing.Size(93, 23);
            this.lb_CD.TabIndex = 18;
            this.lb_CD.Text = "死亡原因：";
            this.lb_CD.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_DD
            // 
            this.lb_DD.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_DD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_DD.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_DD.Location = new System.Drawing.Point(459, 101);
            this.lb_DD.Name = "lb_DD";
            this.lb_DD.Size = new System.Drawing.Size(93, 23);
            this.lb_DD.TabIndex = 17;
            this.lb_DD.Text = "死亡日期：";
            this.lb_DD.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_LDM
            // 
            this.lb_LDM.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_LDM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_LDM.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_LDM.Location = new System.Drawing.Point(420, 54);
            this.lb_LDM.Name = "lb_LDM";
            this.lb_LDM.Size = new System.Drawing.Size(132, 23);
            this.lb_LDM.TabIndex = 16;
            this.lb_LDM.Text = "远处转移位置：";
            this.lb_LDM.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("宋体", 12F);
            this.labelX5.Location = new System.Drawing.Point(49, 198);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(187, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "远处转移日期（Y/M/D):";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_DM
            // 
            this.lb_DM.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_DM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_DM.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_DM.Location = new System.Drawing.Point(143, 149);
            this.lb_DM.Name = "lb_DM";
            this.lb_DM.Size = new System.Drawing.Size(93, 23);
            this.lb_DM.TabIndex = 14;
            this.lb_DM.Text = "远处转移：";
            this.lb_DM.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_VS
            // 
            this.lb_VS.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_VS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_VS.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_VS.Location = new System.Drawing.Point(143, 100);
            this.lb_VS.Name = "lb_VS";
            this.lb_VS.Size = new System.Drawing.Size(93, 23);
            this.lb_VS.TabIndex = 11;
            this.lb_VS.Text = "生死状态：";
            this.lb_VS.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lb_VS.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_DLC
            // 
            this.lb_DLC.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_DLC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_DLC.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_DLC.Location = new System.Drawing.Point(33, 51);
            this.lb_DLC.Name = "lb_DLC";
            this.lb_DLC.Size = new System.Drawing.Size(203, 23);
            this.lb_DLC.TabIndex = 10;
            this.lb_DLC.Text = "最后联系日期（Y/M/D):";
            this.lb_DLC.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.IsSystemMenu = true;
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Symbol = "";
            this.sideNavItem1.Text = "功能菜单";
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
            // sideNavItem4
            // 
            this.sideNavItem4.Checked = true;
            this.sideNavItem4.Name = "sideNavItem4";
            this.sideNavItem4.Panel = this.sideNavPanel3;
            this.sideNavItem4.Symbol = "";
            this.sideNavItem4.Text = "随访";
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
            // sideNavItem2
            // 
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel1;
            this.sideNavItem2.Symbol = "";
            this.sideNavItem2.Text = "追踪";
            // 
            // separator2
            // 
            this.separator2.FixedSize = new System.Drawing.Size(3, 1);
            this.separator2.Name = "separator2";
            this.separator2.Padding.Bottom = 2;
            this.separator2.Padding.Left = 6;
            this.separator2.Padding.Right = 6;
            this.separator2.Padding.Top = 2;
            this.separator2.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.tb_PTH);
            this.groupPanel2.Controls.Add(this.tb_TPO);
            this.groupPanel2.Controls.Add(this.tb_TGAb);
            this.groupPanel2.Controls.Add(this.tb_OS);
            this.groupPanel2.Controls.Add(this.tb_SR);
            this.groupPanel2.Controls.Add(this.tb_CaD);
            this.groupPanel2.Controls.Add(this.tb_ED);
            this.groupPanel2.Controls.Add(this.tb_P);
            this.groupPanel2.Controls.Add(this.tb_Ca);
            this.groupPanel2.Controls.Add(this.tb_TG);
            this.groupPanel2.Controls.Add(this.tb_ATG);
            this.groupPanel2.Controls.Add(this.tb_FT4);
            this.groupPanel2.Controls.Add(this.tb_FT3);
            this.groupPanel2.Controls.Add(this.tb_TSH);
            this.groupPanel2.Controls.Add(this.dti_FUD);
            this.groupPanel2.Controls.Add(this.lb_FUD);
            this.groupPanel2.Controls.Add(this.lb_PTH);
            this.groupPanel2.Controls.Add(this.lb_TPO);
            this.groupPanel2.Controls.Add(this.lb_TGAb);
            this.groupPanel2.Controls.Add(this.lb_OS);
            this.groupPanel2.Controls.Add(this.lb_SR);
            this.groupPanel2.Controls.Add(this.lb_CaD);
            this.groupPanel2.Controls.Add(this.lb_ED);
            this.groupPanel2.Controls.Add(this.lb_P);
            this.groupPanel2.Controls.Add(this.lb_Ca);
            this.groupPanel2.Controls.Add(this.lb_TG);
            this.groupPanel2.Controls.Add(this.lb_ATG);
            this.groupPanel2.Controls.Add(this.lb_FT4);
            this.groupPanel2.Controls.Add(this.lb_FT3);
            this.groupPanel2.Controls.Add(this.lb_TSH);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(149, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(823, 472);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "追踪记录";
            // 
            // tb_PTH
            // 
            // 
            // 
            // 
            this.tb_PTH.Border.Class = "TextBoxBorder";
            this.tb_PTH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_PTH.DisabledBackColor = System.Drawing.Color.White;
            this.tb_PTH.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_PTH.Location = new System.Drawing.Point(196, 251);
            this.tb_PTH.Name = "tb_PTH";
            this.tb_PTH.PreventEnterBeep = true;
            this.tb_PTH.Size = new System.Drawing.Size(152, 26);
            this.tb_PTH.TabIndex = 50;
            // 
            // tb_TPO
            // 
            // 
            // 
            // 
            this.tb_TPO.Border.Class = "TextBoxBorder";
            this.tb_TPO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TPO.DisabledBackColor = System.Drawing.Color.White;
            this.tb_TPO.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_TPO.Location = new System.Drawing.Point(196, 204);
            this.tb_TPO.Name = "tb_TPO";
            this.tb_TPO.PreventEnterBeep = true;
            this.tb_TPO.Size = new System.Drawing.Size(152, 26);
            this.tb_TPO.TabIndex = 49;
            // 
            // tb_TGAb
            // 
            // 
            // 
            // 
            this.tb_TGAb.Border.Class = "TextBoxBorder";
            this.tb_TGAb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TGAb.DisabledBackColor = System.Drawing.Color.White;
            this.tb_TGAb.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_TGAb.Location = new System.Drawing.Point(196, 387);
            this.tb_TGAb.Name = "tb_TGAb";
            this.tb_TGAb.PreventEnterBeep = true;
            this.tb_TGAb.Size = new System.Drawing.Size(152, 26);
            this.tb_TGAb.TabIndex = 48;
            // 
            // tb_OS
            // 
            // 
            // 
            // 
            this.tb_OS.Border.Class = "TextBoxBorder";
            this.tb_OS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_OS.DisabledBackColor = System.Drawing.Color.White;
            this.tb_OS.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_OS.Location = new System.Drawing.Point(589, 254);
            this.tb_OS.Name = "tb_OS";
            this.tb_OS.PreventEnterBeep = true;
            this.tb_OS.Size = new System.Drawing.Size(152, 26);
            this.tb_OS.TabIndex = 47;
            // 
            // tb_SR
            // 
            // 
            // 
            // 
            this.tb_SR.Border.Class = "TextBoxBorder";
            this.tb_SR.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_SR.DisabledBackColor = System.Drawing.Color.White;
            this.tb_SR.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_SR.Location = new System.Drawing.Point(589, 213);
            this.tb_SR.Name = "tb_SR";
            this.tb_SR.PreventEnterBeep = true;
            this.tb_SR.Size = new System.Drawing.Size(152, 26);
            this.tb_SR.TabIndex = 46;
            // 
            // tb_CaD
            // 
            // 
            // 
            // 
            this.tb_CaD.Border.Class = "TextBoxBorder";
            this.tb_CaD.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_CaD.DisabledBackColor = System.Drawing.Color.White;
            this.tb_CaD.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_CaD.Location = new System.Drawing.Point(589, 167);
            this.tb_CaD.Name = "tb_CaD";
            this.tb_CaD.PreventEnterBeep = true;
            this.tb_CaD.Size = new System.Drawing.Size(152, 26);
            this.tb_CaD.TabIndex = 45;
            // 
            // tb_ED
            // 
            // 
            // 
            // 
            this.tb_ED.Border.Class = "TextBoxBorder";
            this.tb_ED.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_ED.DisabledBackColor = System.Drawing.Color.White;
            this.tb_ED.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_ED.Location = new System.Drawing.Point(589, 118);
            this.tb_ED.Name = "tb_ED";
            this.tb_ED.PreventEnterBeep = true;
            this.tb_ED.Size = new System.Drawing.Size(152, 26);
            this.tb_ED.TabIndex = 44;
            // 
            // tb_P
            // 
            // 
            // 
            // 
            this.tb_P.Border.Class = "TextBoxBorder";
            this.tb_P.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_P.DisabledBackColor = System.Drawing.Color.White;
            this.tb_P.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_P.Location = new System.Drawing.Point(589, 75);
            this.tb_P.Name = "tb_P";
            this.tb_P.PreventEnterBeep = true;
            this.tb_P.Size = new System.Drawing.Size(152, 26);
            this.tb_P.TabIndex = 43;
            // 
            // tb_Ca
            // 
            // 
            // 
            // 
            this.tb_Ca.Border.Class = "TextBoxBorder";
            this.tb_Ca.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_Ca.DisabledBackColor = System.Drawing.Color.White;
            this.tb_Ca.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_Ca.Location = new System.Drawing.Point(589, 34);
            this.tb_Ca.Name = "tb_Ca";
            this.tb_Ca.PreventEnterBeep = true;
            this.tb_Ca.Size = new System.Drawing.Size(152, 26);
            this.tb_Ca.TabIndex = 42;
            // 
            // tb_TG
            // 
            // 
            // 
            // 
            this.tb_TG.Border.Class = "TextBoxBorder";
            this.tb_TG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TG.DisabledBackColor = System.Drawing.Color.White;
            this.tb_TG.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_TG.Location = new System.Drawing.Point(196, 347);
            this.tb_TG.Name = "tb_TG";
            this.tb_TG.PreventEnterBeep = true;
            this.tb_TG.Size = new System.Drawing.Size(152, 26);
            this.tb_TG.TabIndex = 41;
            // 
            // tb_ATG
            // 
            // 
            // 
            // 
            this.tb_ATG.Border.Class = "TextBoxBorder";
            this.tb_ATG.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_ATG.DisabledBackColor = System.Drawing.Color.White;
            this.tb_ATG.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_ATG.Location = new System.Drawing.Point(196, 304);
            this.tb_ATG.Name = "tb_ATG";
            this.tb_ATG.PreventEnterBeep = true;
            this.tb_ATG.Size = new System.Drawing.Size(152, 26);
            this.tb_ATG.TabIndex = 40;
            // 
            // tb_FT4
            // 
            // 
            // 
            // 
            this.tb_FT4.Border.Class = "TextBoxBorder";
            this.tb_FT4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FT4.DisabledBackColor = System.Drawing.Color.White;
            this.tb_FT4.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_FT4.Location = new System.Drawing.Point(196, 160);
            this.tb_FT4.Name = "tb_FT4";
            this.tb_FT4.PreventEnterBeep = true;
            this.tb_FT4.Size = new System.Drawing.Size(152, 26);
            this.tb_FT4.TabIndex = 39;
            // 
            // tb_FT3
            // 
            // 
            // 
            // 
            this.tb_FT3.Border.Class = "TextBoxBorder";
            this.tb_FT3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FT3.DisabledBackColor = System.Drawing.Color.White;
            this.tb_FT3.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_FT3.Location = new System.Drawing.Point(196, 114);
            this.tb_FT3.Name = "tb_FT3";
            this.tb_FT3.PreventEnterBeep = true;
            this.tb_FT3.Size = new System.Drawing.Size(152, 26);
            this.tb_FT3.TabIndex = 38;
            // 
            // tb_TSH
            // 
            // 
            // 
            // 
            this.tb_TSH.Border.Class = "TextBoxBorder";
            this.tb_TSH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_TSH.DisabledBackColor = System.Drawing.Color.White;
            this.tb_TSH.Font = new System.Drawing.Font("宋体", 12F);
            this.tb_TSH.Location = new System.Drawing.Point(196, 72);
            this.tb_TSH.Name = "tb_TSH";
            this.tb_TSH.PreventEnterBeep = true;
            this.tb_TSH.Size = new System.Drawing.Size(152, 26);
            this.tb_TSH.TabIndex = 37;
            // 
            // dti_FUD
            // 
            // 
            // 
            // 
            this.dti_FUD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_FUD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_FUD.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_FUD.ButtonDropDown.Visible = true;
            this.dti_FUD.Font = new System.Drawing.Font("宋体", 12F);
            this.dti_FUD.IsPopupCalendarOpen = false;
            this.dti_FUD.Location = new System.Drawing.Point(589, 301);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dti_FUD.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_FUD.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_FUD.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_FUD.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_FUD.MonthCalendar.DisplayMonth = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dti_FUD.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dti_FUD.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_FUD.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_FUD.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_FUD.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_FUD.MonthCalendar.TodayButtonVisible = true;
            this.dti_FUD.Name = "dti_FUD";
            this.dti_FUD.Size = new System.Drawing.Size(152, 26);
            this.dti_FUD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_FUD.TabIndex = 30;
            // 
            // lb_FUD
            // 
            this.lb_FUD.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_FUD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_FUD.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_FUD.Location = new System.Drawing.Point(429, 304);
            this.lb_FUD.Name = "lb_FUD";
            this.lb_FUD.Size = new System.Drawing.Size(93, 23);
            this.lb_FUD.TabIndex = 27;
            this.lb_FUD.Text = "追踪日期：";
            // 
            // lb_PTH
            // 
            this.lb_PTH.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_PTH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_PTH.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_PTH.Location = new System.Drawing.Point(43, 254);
            this.lb_PTH.Name = "lb_PTH";
            this.lb_PTH.Size = new System.Drawing.Size(93, 23);
            this.lb_PTH.TabIndex = 26;
            this.lb_PTH.Text = "PTH pg/ml:";
            // 
            // lb_TPO
            // 
            this.lb_TPO.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TPO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TPO.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_TPO.Location = new System.Drawing.Point(43, 210);
            this.lb_TPO.Name = "lb_TPO";
            this.lb_TPO.Size = new System.Drawing.Size(93, 23);
            this.lb_TPO.TabIndex = 25;
            this.lb_TPO.Text = "TPO IU/ml:";
            // 
            // lb_TGAb
            // 
            this.lb_TGAb.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TGAb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TGAb.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_TGAb.Location = new System.Drawing.Point(43, 390);
            this.lb_TGAb.Name = "lb_TGAb";
            this.lb_TGAb.Size = new System.Drawing.Size(129, 23);
            this.lb_TGAb.TabIndex = 24;
            this.lb_TGAb.Text = "TG-Ab IU/ml:";
            // 
            // lb_OS
            // 
            this.lb_OS.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_OS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_OS.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_OS.Location = new System.Drawing.Point(429, 257);
            this.lb_OS.Name = "lb_OS";
            this.lb_OS.Size = new System.Drawing.Size(93, 23);
            this.lb_OS.TabIndex = 23;
            this.lb_OS.Text = "其它症状：";
            // 
            // lb_SR
            // 
            this.lb_SR.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_SR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_SR.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_SR.Location = new System.Drawing.Point(429, 216);
            this.lb_SR.Name = "lb_SR";
            this.lb_SR.Size = new System.Drawing.Size(93, 23);
            this.lb_SR.TabIndex = 22;
            this.lb_SR.Text = "副作用：";
            // 
            // lb_CaD
            // 
            this.lb_CaD.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_CaD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_CaD.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_CaD.Location = new System.Drawing.Point(429, 170);
            this.lb_CaD.Name = "lb_CaD";
            this.lb_CaD.Size = new System.Drawing.Size(93, 23);
            this.lb_CaD.TabIndex = 21;
            this.lb_CaD.Text = "Ca计量：";
            // 
            // lb_ED
            // 
            this.lb_ED.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_ED.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_ED.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_ED.Location = new System.Drawing.Point(429, 121);
            this.lb_ED.Name = "lb_ED";
            this.lb_ED.Size = new System.Drawing.Size(174, 23);
            this.lb_ED.TabIndex = 20;
            this.lb_ED.Text = "优甲乐计量（ug/d）：";
            // 
            // lb_P
            // 
            this.lb_P.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_P.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_P.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_P.Location = new System.Drawing.Point(429, 75);
            this.lb_P.Name = "lb_P";
            this.lb_P.Size = new System.Drawing.Size(93, 23);
            this.lb_P.TabIndex = 19;
            this.lb_P.Text = "P mmol/l:";
            // 
            // lb_Ca
            // 
            this.lb_Ca.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_Ca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_Ca.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_Ca.Location = new System.Drawing.Point(429, 34);
            this.lb_Ca.Name = "lb_Ca";
            this.lb_Ca.Size = new System.Drawing.Size(93, 23);
            this.lb_Ca.TabIndex = 18;
            this.lb_Ca.Text = "Ca mmol/l:";
            // 
            // lb_TG
            // 
            this.lb_TG.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TG.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TG.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_TG.Location = new System.Drawing.Point(43, 350);
            this.lb_TG.Name = "lb_TG";
            this.lb_TG.Size = new System.Drawing.Size(93, 23);
            this.lb_TG.TabIndex = 17;
            this.lb_TG.Text = "TG IU/ml:";
            // 
            // lb_ATG
            // 
            this.lb_ATG.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_ATG.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_ATG.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_ATG.Location = new System.Drawing.Point(43, 304);
            this.lb_ATG.Name = "lb_ATG";
            this.lb_ATG.Size = new System.Drawing.Size(118, 23);
            this.lb_ATG.TabIndex = 16;
            this.lb_ATG.Text = "A-TG IU/ml:";
            // 
            // lb_FT4
            // 
            this.lb_FT4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_FT4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_FT4.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_FT4.Location = new System.Drawing.Point(43, 170);
            this.lb_FT4.Name = "lb_FT4";
            this.lb_FT4.Size = new System.Drawing.Size(118, 23);
            this.lb_FT4.TabIndex = 15;
            this.lb_FT4.Text = "FT4 pmol/L:";
            // 
            // lb_FT3
            // 
            this.lb_FT3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_FT3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_FT3.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_FT3.Location = new System.Drawing.Point(43, 121);
            this.lb_FT3.Name = "lb_FT3";
            this.lb_FT3.Size = new System.Drawing.Size(118, 23);
            this.lb_FT3.TabIndex = 14;
            this.lb_FT3.Text = "FT3 pmol/L:";
            // 
            // lb_TSH
            // 
            this.lb_TSH.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lb_TSH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_TSH.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_TSH.Location = new System.Drawing.Point(43, 75);
            this.lb_TSH.Name = "lb_TSH";
            this.lb_TSH.Size = new System.Drawing.Size(118, 23);
            this.lb_TSH.TabIndex = 13;
            this.lb_TSH.Text = "TSH uIU/ml:";
            // 
            // UC_followUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideNav1);
            this.Name = "UC_followUp";
            this.Size = new System.Drawing.Size(1416, 568);
            this.Validated += new System.EventHandler(this.UC_followUp_Validated);
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.sideNavPanel3.ResumeLayout(false);
            this.sideNavPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dti_DLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_DD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dti_dismetadate)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dti_FUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_DD;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_dismetadate;
        private DevComponents.DotNetBar.LabelX lb_CD;
        private DevComponents.DotNetBar.LabelX lb_DD;
        private DevComponents.DotNetBar.LabelX lb_LDM;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lb_DM;
        private DevComponents.DotNetBar.LabelX lb_VS;
        private DevComponents.DotNetBar.LabelX lb_DLC;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbe_CD;
        private DevComponents.Editors.ComboItem null_CD;
        private DevComponents.Editors.ComboItem TC_CD;
        private DevComponents.Editors.ComboItem OC_CD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbe_LDM;
        private DevComponents.Editors.ComboItem null_LDM;
        private DevComponents.Editors.ComboItem brain_LDM;
        private DevComponents.Editors.ComboItem lung_LDM;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbe_VS;
        private DevComponents.Editors.ComboItem null_VS;
        private DevComponents.Editors.ComboItem death_VS;
        private DevComponents.Editors.ComboItem alive_VS;
        private DevComponents.Editors.ComboItem LTFU_VS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbe_DM;
        private DevComponents.Editors.ComboItem null_DM;
        private DevComponents.Editors.ComboItem yes_DM;
        private DevComponents.Editors.ComboItem no_DM;
        private DevComponents.Editors.ComboItem liver_LDM;
        private DevComponents.Editors.ComboItem bone_LDM;
        private DevComponents.Editors.ComboItem OD_CD;
        private DevComponents.DotNetBar.Separator separator2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_PTH;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TPO;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TGAb;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_OS;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_SR;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CaD;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_ED;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_P;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Ca;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TG;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_ATG;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FT4;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FT3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_TSH;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_FUD;
        private DevComponents.DotNetBar.LabelX lb_FUD;
        private DevComponents.DotNetBar.LabelX lb_PTH;
        private DevComponents.DotNetBar.LabelX lb_TPO;
        private DevComponents.DotNetBar.LabelX lb_TGAb;
        private DevComponents.DotNetBar.LabelX lb_OS;
        private DevComponents.DotNetBar.LabelX lb_SR;
        private DevComponents.DotNetBar.LabelX lb_CaD;
        private DevComponents.DotNetBar.LabelX lb_ED;
        private DevComponents.DotNetBar.LabelX lb_P;
        private DevComponents.DotNetBar.LabelX lb_Ca;
        private DevComponents.DotNetBar.LabelX lb_TG;
        private DevComponents.DotNetBar.LabelX lb_ATG;
        private DevComponents.DotNetBar.LabelX lb_FT4;
        private DevComponents.DotNetBar.LabelX lb_FT3;
        private DevComponents.DotNetBar.LabelX lb_TSH;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel3;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_visit;
        private DevComponents.DotNetBar.SuperGrid.GridColumn VDate;
        private DevComponents.DotNetBar.SuperGrid.GridColumn TSH;
        private DevComponents.DotNetBar.SuperGrid.GridColumn FT3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn FT4;
        private DevComponents.DotNetBar.SuperGrid.GridColumn TPO;
        private DevComponents.DotNetBar.SuperGrid.GridColumn PTH;
        private DevComponents.DotNetBar.SuperGrid.GridColumn ATG;
        private DevComponents.DotNetBar.SuperGrid.GridColumn TG;
        private DevComponents.DotNetBar.SuperGrid.GridColumn TGAb;
        private DevComponents.DotNetBar.SuperGrid.GridColumn Ca;
        private DevComponents.DotNetBar.SuperGrid.GridColumn P;
        private DevComponents.DotNetBar.SuperGrid.GridColumn euthyrox;
        private DevComponents.DotNetBar.SuperGrid.GridColumn Cadosage;
        private DevComponents.DotNetBar.SuperGrid.GridColumn sideeffect;
        private DevComponents.DotNetBar.SuperGrid.GridColumn others;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem4;
        private DevComponents.DotNetBar.Separator separator3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn pid;
        private DevComponents.DotNetBar.SuperGrid.GridColumn id;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_DLC;
        private DevComponents.DotNetBar.SuperGrid.GridColumn adjustEuthyrox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

       
    }
}
