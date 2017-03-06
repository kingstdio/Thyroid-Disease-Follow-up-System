using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
namespace 甲状腺随访系统
{
    partial class RF_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RF_main));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_new = new DevComponents.DotNetBar.ButtonItem();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.ribbonBar8 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_recurrencecs = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_followUp = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar6 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_pOperative = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_SH = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_diagnosis = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.bt_patientInfo = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.rti_search = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panEX_main = new DevComponents.DotNetBar.PanelEx();
            this.panel_patientInfo = new DevComponents.DotNetBar.PanelEx();
            this.tb_hosno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FUNear = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_hosoutdate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_FUTimes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_hosindate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_birthday = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_phone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_idcard = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_sex = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_FUNear = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lb_hosoutdate = new DevComponents.DotNetBar.LabelX();
            this.lb_FUTimes = new DevComponents.DotNetBar.LabelX();
            this.tb_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.lb_birthday = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lb_idcard = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.panEX_main.SuspendLayout();
            this.panel_patientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.rti_search});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(1408, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "甲状腺疾病随风系统-吉林大学白求恩第一附属医院";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar4);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1408, 98);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.DragDropSupport = true;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(86, 95);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar4.TabIndex = 0;
            this.ribbonBar4.Text = "检索";
            // 
            // 
            // 
            this.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "buttonItem2";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.buttonX1);
            this.ribbonPanel1.Controls.Add(this.ribbonBar8);
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar6);
            this.ribbonPanel1.Controls.Add(this.ribbonBar5);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1408, 98);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_new});
            this.ribbonBar2.Location = new System.Drawing.Point(477, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(80, 95);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 9;
            this.ribbonBar2.Text = "新建档案";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_new
            // 
            this.bt_new.Image = ((System.Drawing.Image)(resources.GetObject("bt_new.Image")));
            this.bt_new.Name = "bt_new";
            this.bt_new.SubItemsExpandWidth = 14;
            this.bt_new.Text = "buttonItem3";
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(1278, 31);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(92, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "删除患者";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // ribbonBar8
            // 
            this.ribbonBar8.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar8.ContainerControlProcessDialogKey = true;
            this.ribbonBar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar8.DragDropSupport = true;
            this.ribbonBar8.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_recurrencecs});
            this.ribbonBar8.Location = new System.Drawing.Point(398, 0);
            this.ribbonBar8.Name = "ribbonBar8";
            this.ribbonBar8.Size = new System.Drawing.Size(79, 95);
            this.ribbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar8.TabIndex = 6;
            this.ribbonBar8.Text = "复发";
            // 
            // 
            // 
            this.ribbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_recurrencecs
            // 
            this.bt_recurrencecs.Image = ((System.Drawing.Image)(resources.GetObject("bt_recurrencecs.Image")));
            this.bt_recurrencecs.Name = "bt_recurrencecs";
            this.bt_recurrencecs.SubItemsExpandWidth = 14;
            this.bt_recurrencecs.Text = "buttonItem2";
            this.bt_recurrencecs.Click += new System.EventHandler(this.bt_recurrencecs_Click);
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.DragDropSupport = true;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_followUp});
            this.ribbonBar7.Location = new System.Drawing.Point(319, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(79, 95);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar7.TabIndex = 5;
            this.ribbonBar7.Text = "追踪";
            // 
            // 
            // 
            this.ribbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_followUp
            // 
            this.bt_followUp.Image = ((System.Drawing.Image)(resources.GetObject("bt_followUp.Image")));
            this.bt_followUp.Name = "bt_followUp";
            this.bt_followUp.SubItemsExpandWidth = 14;
            this.bt_followUp.Text = "buttonItem2";
            this.bt_followUp.Click += new System.EventHandler(this.bt_followUp_Click);
            // 
            // ribbonBar6
            // 
            this.ribbonBar6.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar6.ContainerControlProcessDialogKey = true;
            this.ribbonBar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar6.DragDropSupport = true;
            this.ribbonBar6.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_pOperative});
            this.ribbonBar6.Location = new System.Drawing.Point(240, 0);
            this.ribbonBar6.Name = "ribbonBar6";
            this.ribbonBar6.Size = new System.Drawing.Size(79, 95);
            this.ribbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar6.TabIndex = 4;
            this.ribbonBar6.Text = "术后";
            // 
            // 
            // 
            this.ribbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_pOperative
            // 
            this.bt_pOperative.Image = ((System.Drawing.Image)(resources.GetObject("bt_pOperative.Image")));
            this.bt_pOperative.Name = "bt_pOperative";
            this.bt_pOperative.SubItemsExpandWidth = 14;
            this.bt_pOperative.Text = "buttonItem2";
            this.bt_pOperative.Click += new System.EventHandler(this.bt_pOperative_Click);
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar5.ContainerControlProcessDialogKey = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.DragDropSupport = true;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_SH});
            this.ribbonBar5.Location = new System.Drawing.Point(161, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(79, 95);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar5.TabIndex = 3;
            this.ribbonBar5.Text = "手术";
            // 
            // 
            // 
            this.ribbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_SH
            // 
            this.bt_SH.Image = ((System.Drawing.Image)(resources.GetObject("bt_SH.Image")));
            this.bt_SH.Name = "bt_SH";
            this.bt_SH.SubItemsExpandWidth = 14;
            this.bt_SH.Text = "外科手术史";
            this.bt_SH.Click += new System.EventHandler(this.bt_SH_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.DragDropSupport = true;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_diagnosis});
            this.ribbonBar3.Location = new System.Drawing.Point(82, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(79, 95);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 2;
            this.ribbonBar3.Text = "诊断";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_diagnosis
            // 
            this.bt_diagnosis.Image = ((System.Drawing.Image)(resources.GetObject("bt_diagnosis.Image")));
            this.bt_diagnosis.Name = "bt_diagnosis";
            this.bt_diagnosis.SubItemsExpandWidth = 14;
            this.bt_diagnosis.Text = "诊断";
            this.bt_diagnosis.Click += new System.EventHandler(this.bt_diagnosis_Click_1);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bt_patientInfo});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(79, 95);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "患者档案";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // bt_patientInfo
            // 
            this.bt_patientInfo.Image = ((System.Drawing.Image)(resources.GetObject("bt_patientInfo.Image")));
            this.bt_patientInfo.Name = "bt_patientInfo";
            this.bt_patientInfo.SubItemsExpandWidth = 14;
            this.bt_patientInfo.Text = "新增患者信息";
            this.bt_patientInfo.Click += new System.EventHandler(this.bt_patientInfo_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "患者档案";
            // 
            // rti_search
            // 
            this.rti_search.Checked = true;
            this.rti_search.Name = "rti_search";
            this.rti_search.Panel = this.ribbonPanel2;
            this.rti_search.Text = "病例检索";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "版本号：2017-2-28";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // panEX_main
            // 
            this.panEX_main.CanvasColor = System.Drawing.SystemColors.Control;
            this.panEX_main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panEX_main.Controls.Add(this.panel_patientInfo);
            this.panEX_main.DisabledBackColor = System.Drawing.Color.Empty;
            this.panEX_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panEX_main.Location = new System.Drawing.Point(5, 155);
            this.panEX_main.Name = "panEX_main";
            this.panEX_main.Size = new System.Drawing.Size(1408, 661);
            this.panEX_main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panEX_main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panEX_main.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.panEX_main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panEX_main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panEX_main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panEX_main.Style.GradientAngle = 90;
            this.panEX_main.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(103)))));
            this.panEX_main.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(135)))));
            this.panEX_main.StyleMouseDown.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.panEX_main.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.panEX_main.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(135)))));
            this.panEX_main.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            this.panEX_main.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(212)))), ((int)(((byte)(73)))));
            this.panEX_main.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(57)))), ((int)(((byte)(120)))));
            this.panEX_main.TabIndex = 1;
            this.panEX_main.Click += new System.EventHandler(this.panEX_main_Click);
            // 
            // panel_patientInfo
            // 
            this.panel_patientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_patientInfo.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_patientInfo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_patientInfo.Controls.Add(this.tb_hosno);
            this.panel_patientInfo.Controls.Add(this.tb_FUNear);
            this.panel_patientInfo.Controls.Add(this.tb_hosoutdate);
            this.panel_patientInfo.Controls.Add(this.tb_FUTimes);
            this.panel_patientInfo.Controls.Add(this.tb_hosindate);
            this.panel_patientInfo.Controls.Add(this.tb_birthday);
            this.panel_patientInfo.Controls.Add(this.tb_phone);
            this.panel_patientInfo.Controls.Add(this.tb_idcard);
            this.panel_patientInfo.Controls.Add(this.tb_sex);
            this.panel_patientInfo.Controls.Add(this.lb_FUNear);
            this.panel_patientInfo.Controls.Add(this.labelX6);
            this.panel_patientInfo.Controls.Add(this.lb_hosoutdate);
            this.panel_patientInfo.Controls.Add(this.lb_FUTimes);
            this.panel_patientInfo.Controls.Add(this.tb_name);
            this.panel_patientInfo.Controls.Add(this.labelX7);
            this.panel_patientInfo.Controls.Add(this.lb_birthday);
            this.panel_patientInfo.Controls.Add(this.labelX3);
            this.panel_patientInfo.Controls.Add(this.lb_idcard);
            this.panel_patientInfo.Controls.Add(this.labelX4);
            this.panel_patientInfo.Controls.Add(this.labelX1);
            this.panel_patientInfo.DisabledBackColor = System.Drawing.Color.Empty;
            this.panel_patientInfo.Location = new System.Drawing.Point(0, 567);
            this.panel_patientInfo.Name = "panel_patientInfo";
            this.panel_patientInfo.Size = new System.Drawing.Size(1408, 99);
            this.panel_patientInfo.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_patientInfo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_patientInfo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_patientInfo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_patientInfo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_patientInfo.Style.GradientAngle = 90;
            this.panel_patientInfo.TabIndex = 0;
            // 
            // tb_hosno
            // 
            // 
            // 
            // 
            this.tb_hosno.Border.Class = "TextBoxBorder";
            this.tb_hosno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_hosno.DisabledBackColor = System.Drawing.Color.White;
            this.tb_hosno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_hosno.Location = new System.Drawing.Point(111, 18);
            this.tb_hosno.Name = "tb_hosno";
            this.tb_hosno.PreventEnterBeep = true;
            this.tb_hosno.ReadOnly = true;
            this.tb_hosno.Size = new System.Drawing.Size(162, 26);
            this.tb_hosno.TabIndex = 1;
            this.tb_hosno.TabStop = false;
            this.tb_hosno.Text = "101845";
            this.tb_hosno.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_FUNear
            // 
            // 
            // 
            // 
            this.tb_FUNear.Border.Class = "TextBoxBorder";
            this.tb_FUNear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FUNear.DisabledBackColor = System.Drawing.Color.White;
            this.tb_FUNear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_FUNear.Location = new System.Drawing.Point(1175, 56);
            this.tb_FUNear.Name = "tb_FUNear";
            this.tb_FUNear.PreventEnterBeep = true;
            this.tb_FUNear.ReadOnly = true;
            this.tb_FUNear.Size = new System.Drawing.Size(162, 26);
            this.tb_FUNear.TabIndex = 1;
            this.tb_FUNear.TabStop = false;
            this.tb_FUNear.Text = "2016-08-12";
            this.tb_FUNear.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_hosoutdate
            // 
            // 
            // 
            // 
            this.tb_hosoutdate.Border.Class = "TextBoxBorder";
            this.tb_hosoutdate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_hosoutdate.DisabledBackColor = System.Drawing.Color.White;
            this.tb_hosoutdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_hosoutdate.Location = new System.Drawing.Point(909, 56);
            this.tb_hosoutdate.Name = "tb_hosoutdate";
            this.tb_hosoutdate.PreventEnterBeep = true;
            this.tb_hosoutdate.ReadOnly = true;
            this.tb_hosoutdate.Size = new System.Drawing.Size(162, 26);
            this.tb_hosoutdate.TabIndex = 1;
            this.tb_hosoutdate.TabStop = false;
            this.tb_hosoutdate.Text = "2016-08-12";
            this.tb_hosoutdate.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_FUTimes
            // 
            // 
            // 
            // 
            this.tb_FUTimes.Border.Class = "TextBoxBorder";
            this.tb_FUTimes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_FUTimes.DisabledBackColor = System.Drawing.Color.White;
            this.tb_FUTimes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_FUTimes.Location = new System.Drawing.Point(1175, 18);
            this.tb_FUTimes.Name = "tb_FUTimes";
            this.tb_FUTimes.PreventEnterBeep = true;
            this.tb_FUTimes.ReadOnly = true;
            this.tb_FUTimes.Size = new System.Drawing.Size(162, 26);
            this.tb_FUTimes.TabIndex = 1;
            this.tb_FUTimes.TabStop = false;
            this.tb_FUTimes.Text = "2016-07-21";
            this.tb_FUTimes.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_hosindate
            // 
            // 
            // 
            // 
            this.tb_hosindate.Border.Class = "TextBoxBorder";
            this.tb_hosindate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_hosindate.DisabledBackColor = System.Drawing.Color.White;
            this.tb_hosindate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_hosindate.Location = new System.Drawing.Point(909, 18);
            this.tb_hosindate.Name = "tb_hosindate";
            this.tb_hosindate.PreventEnterBeep = true;
            this.tb_hosindate.ReadOnly = true;
            this.tb_hosindate.Size = new System.Drawing.Size(162, 26);
            this.tb_hosindate.TabIndex = 1;
            this.tb_hosindate.TabStop = false;
            this.tb_hosindate.Text = "2016-07-21";
            this.tb_hosindate.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_birthday
            // 
            // 
            // 
            // 
            this.tb_birthday.Border.Class = "TextBoxBorder";
            this.tb_birthday.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_birthday.DisabledBackColor = System.Drawing.Color.White;
            this.tb_birthday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_birthday.Location = new System.Drawing.Point(643, 57);
            this.tb_birthday.Name = "tb_birthday";
            this.tb_birthday.PreventEnterBeep = true;
            this.tb_birthday.ReadOnly = true;
            this.tb_birthday.Size = new System.Drawing.Size(162, 26);
            this.tb_birthday.TabIndex = 1;
            this.tb_birthday.TabStop = false;
            this.tb_birthday.Text = "2016-08-12";
            this.tb_birthday.WatermarkColor = System.Drawing.Color.Maroon;
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
            this.tb_phone.Location = new System.Drawing.Point(643, 18);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.PreventEnterBeep = true;
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(162, 26);
            this.tb_phone.TabIndex = 1;
            this.tb_phone.TabStop = false;
            this.tb_phone.Text = "13800138000";
            this.tb_phone.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_idcard
            // 
            // 
            // 
            // 
            this.tb_idcard.Border.Class = "TextBoxBorder";
            this.tb_idcard.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_idcard.DisabledBackColor = System.Drawing.Color.White;
            this.tb_idcard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_idcard.Location = new System.Drawing.Point(377, 58);
            this.tb_idcard.Name = "tb_idcard";
            this.tb_idcard.PreventEnterBeep = true;
            this.tb_idcard.ReadOnly = true;
            this.tb_idcard.Size = new System.Drawing.Size(162, 26);
            this.tb_idcard.TabIndex = 1;
            this.tb_idcard.TabStop = false;
            this.tb_idcard.Text = "130722189705136653X";
            this.tb_idcard.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // tb_sex
            // 
            // 
            // 
            // 
            this.tb_sex.Border.Class = "TextBoxBorder";
            this.tb_sex.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_sex.DisabledBackColor = System.Drawing.Color.White;
            this.tb_sex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_sex.Location = new System.Drawing.Point(111, 57);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.PreventEnterBeep = true;
            this.tb_sex.ReadOnly = true;
            this.tb_sex.Size = new System.Drawing.Size(162, 26);
            this.tb_sex.TabIndex = 1;
            this.tb_sex.TabStop = false;
            this.tb_sex.Text = "男";
            this.tb_sex.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // lb_FUNear
            // 
            // 
            // 
            // 
            this.lb_FUNear.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_FUNear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_FUNear.Location = new System.Drawing.Point(1092, 58);
            this.lb_FUNear.Name = "lb_FUNear";
            this.lb_FUNear.Size = new System.Drawing.Size(90, 23);
            this.lb_FUNear.TabIndex = 0;
            this.lb_FUNear.Text = "最近随访：";
            this.lb_FUNear.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.Location = new System.Drawing.Point(28, 20);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(90, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "住院号：";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_hosoutdate
            // 
            // 
            // 
            // 
            this.lb_hosoutdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_hosoutdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_hosoutdate.Location = new System.Drawing.Point(826, 58);
            this.lb_hosoutdate.Name = "lb_hosoutdate";
            this.lb_hosoutdate.Size = new System.Drawing.Size(90, 23);
            this.lb_hosoutdate.TabIndex = 0;
            this.lb_hosoutdate.Text = "出院日期：";
            this.lb_hosoutdate.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_FUTimes
            // 
            // 
            // 
            // 
            this.lb_FUTimes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_FUTimes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_FUTimes.Location = new System.Drawing.Point(1092, 20);
            this.lb_FUTimes.Name = "lb_FUTimes";
            this.lb_FUTimes.Size = new System.Drawing.Size(90, 23);
            this.lb_FUTimes.TabIndex = 0;
            this.lb_FUTimes.Text = "随访次数：";
            this.lb_FUTimes.TextAlignment = System.Drawing.StringAlignment.Far;
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
            this.tb_name.Location = new System.Drawing.Point(377, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.PreventEnterBeep = true;
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(162, 26);
            this.tb_name.TabIndex = 1;
            this.tb_name.TabStop = false;
            this.tb_name.Text = "欧阳伟民";
            this.tb_name.WatermarkColor = System.Drawing.Color.Maroon;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX7.Location = new System.Drawing.Point(826, 20);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(90, 23);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "住院日期：";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_birthday
            // 
            // 
            // 
            // 
            this.lb_birthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_birthday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_birthday.Location = new System.Drawing.Point(560, 59);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(90, 23);
            this.lb_birthday.TabIndex = 0;
            this.lb_birthday.Text = "出生日期：";
            this.lb_birthday.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.Location = new System.Drawing.Point(560, 20);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(90, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "联系电话：";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lb_idcard
            // 
            // 
            // 
            // 
            this.lb_idcard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_idcard.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_idcard.Location = new System.Drawing.Point(294, 60);
            this.lb_idcard.Name = "lb_idcard";
            this.lb_idcard.Size = new System.Drawing.Size(90, 23);
            this.lb_idcard.TabIndex = 0;
            this.lb_idcard.Text = "身份证号：";
            this.lb_idcard.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.Location = new System.Drawing.Point(28, 59);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(90, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "性别：";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(294, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "姓名：";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // RF_main
            // 
            this.ClientSize = new System.Drawing.Size(1418, 818);
            this.Controls.Add(this.panEX_main);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RF_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "甲状腺疾病随访系统-吉林大学白求恩第一附属医院";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RF_main_FormClosing);
            this.SizeChanged += new System.EventHandler(this.RF_main_SizeChanged);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.panEX_main.ResumeLayout(false);
            this.panel_patientInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem rti_search;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem bt_patientInfo;
        private DevComponents.DotNetBar.PanelEx panEX_main;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem bt_SH;
        private DevComponents.DotNetBar.ButtonItem bt_diagnosis;
        private DevComponents.DotNetBar.RibbonBar ribbonBar6;
        private DevComponents.DotNetBar.RibbonBar ribbonBar8;
        private DevComponents.DotNetBar.ButtonItem bt_recurrencecs;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem bt_followUp;
        private DevComponents.DotNetBar.ButtonItem bt_pOperative;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.PanelEx panel_patientInfo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_name;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_idcard;
        private DevComponents.DotNetBar.LabelX lb_idcard;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_phone;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_sex;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_hosno;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_birthday;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lb_birthday;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_hosoutdate;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_hosindate;
        private DevComponents.DotNetBar.LabelX lb_hosoutdate;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FUNear;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_FUTimes;
        private DevComponents.DotNetBar.LabelX lb_FUNear;
        private DevComponents.DotNetBar.LabelX lb_FUTimes;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem bt_new;

    }
}