using DevComponents.DotNetBar.Controls;

namespace ��״�����ϵͳ
{
    partial class PatientInfoFiltering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoFiltering));
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterLevel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbFilterImageVisibility = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxShowPanelExpr = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbFilterAlignment = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMatchType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnResetColumnFilters = new DevComponents.DotNetBar.ButtonX();
            this.btnResetPanelFilter = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.spc_plist = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.circularProgressItem6 = new DevComponents.DotNetBar.CircularProgressItem();
            this.cbxUseAgeSlider = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(547, 486);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(113, 18);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "������ƥ�����ͣ�";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(309, 463);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(120, 18);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "����ͼ��ɼ��ԣ�";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(309, 487);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 18);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "����ͼ����룺";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(590, 463);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 18);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "����ˮƽ��";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbFilterLevel
            // 
            this.cbFilterLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterLevel.DisplayMember = "Text";
            this.cbFilterLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterLevel.FormattingEnabled = true;
            this.cbFilterLevel.ItemHeight = 14;
            this.cbFilterLevel.Location = new System.Drawing.Point(666, 462);
            this.cbFilterLevel.Name = "cbFilterLevel";
            this.cbFilterLevel.Size = new System.Drawing.Size(106, 20);
            this.cbFilterLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFilterLevel.TabIndex = 15;
            this.cbFilterLevel.SelectedIndexChanged += new System.EventHandler(this.CbFilterLevelSelectedIndexChanged);
            // 
            // cbFilterImageVisibility
            // 
            this.cbFilterImageVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterImageVisibility.DisplayMember = "Text";
            this.cbFilterImageVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterImageVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterImageVisibility.FormattingEnabled = true;
            this.cbFilterImageVisibility.ItemHeight = 14;
            this.cbFilterImageVisibility.Location = new System.Drawing.Point(435, 462);
            this.cbFilterImageVisibility.Name = "cbFilterImageVisibility";
            this.cbFilterImageVisibility.Size = new System.Drawing.Size(106, 20);
            this.cbFilterImageVisibility.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFilterImageVisibility.TabIndex = 13;
            this.cbFilterImageVisibility.SelectedIndexChanged += new System.EventHandler(this.CbFilterImageVisibilitySelectedIndexChanged);
            // 
            // cbxShowPanelExpr
            // 
            this.cbxShowPanelExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxShowPanelExpr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxShowPanelExpr.Location = new System.Drawing.Point(151, 462);
            this.cbxShowPanelExpr.Name = "cbxShowPanelExpr";
            this.cbxShowPanelExpr.Size = new System.Drawing.Size(152, 21);
            this.cbxShowPanelExpr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxShowPanelExpr.TabIndex = 11;
            this.cbxShowPanelExpr.Text = "��ʾɸѡ�����ʽ";
            this.cbxShowPanelExpr.CheckedChanged += new System.EventHandler(this.CbxShowPanelExprCheckedChanged);
            // 
            // cbFilterAlignment
            // 
            this.cbFilterAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterAlignment.DisplayMember = "Text";
            this.cbFilterAlignment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterAlignment.FormattingEnabled = true;
            this.cbFilterAlignment.ItemHeight = 14;
            this.cbFilterAlignment.Location = new System.Drawing.Point(435, 486);
            this.cbFilterAlignment.Name = "cbFilterAlignment";
            this.cbFilterAlignment.Size = new System.Drawing.Size(106, 20);
            this.cbFilterAlignment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFilterAlignment.TabIndex = 10;
            this.cbFilterAlignment.SelectedIndexChanged += new System.EventHandler(this.CbFilterAlignmentSelectedIndexChanged);
            // 
            // cbMatchType
            // 
            this.cbMatchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMatchType.DisplayMember = "Text";
            this.cbMatchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatchType.FormattingEnabled = true;
            this.cbMatchType.ItemHeight = 14;
            this.cbMatchType.Location = new System.Drawing.Point(666, 486);
            this.cbMatchType.Name = "cbMatchType";
            this.cbMatchType.Size = new System.Drawing.Size(106, 20);
            this.cbMatchType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMatchType.TabIndex = 7;
            this.cbMatchType.SelectedIndexChanged += new System.EventHandler(this.CbMatchTypeSelectedIndexChanged);
            // 
            // btnResetColumnFilters
            // 
            this.btnResetColumnFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetColumnFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetColumnFilters.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetColumnFilters.Location = new System.Drawing.Point(18, 486);
            this.btnResetColumnFilters.Name = "btnResetColumnFilters";
            this.btnResetColumnFilters.Size = new System.Drawing.Size(113, 21);
            this.btnResetColumnFilters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetColumnFilters.TabIndex = 5;
            this.btnResetColumnFilters.Text = "�����й�����";
            this.btnResetColumnFilters.Click += new System.EventHandler(this.BtnResetColumnFiltersClick);
            // 
            // btnResetPanelFilter
            // 
            this.btnResetPanelFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetPanelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetPanelFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetPanelFilter.Location = new System.Drawing.Point(18, 460);
            this.btnResetPanelFilter.Name = "btnResetPanelFilter";
            this.btnResetPanelFilter.Size = new System.Drawing.Size(113, 21);
            this.btnResetPanelFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetPanelFilter.TabIndex = 4;
            this.btnResetPanelFilter.Text = "������������";
            this.btnResetPanelFilter.Click += new System.EventHandler(this.BtnResetPanelFilterClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // spc_plist
            // 
            this.spc_plist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc_plist.BackColor = System.Drawing.Color.White;
            this.spc_plist.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.spc_plist.FilterUseExtendedCustomDialog = true;
            this.spc_plist.ForeColor = System.Drawing.Color.Black;
            this.spc_plist.Location = new System.Drawing.Point(0, 0);
            this.spc_plist.Name = "spc_plist";
            // 
            // 
            // 
            this.spc_plist.PrimaryGrid.AllowEdit = false;
            this.spc_plist.PrimaryGrid.AllowRowHeaderResize = true;
            this.spc_plist.PrimaryGrid.AllowRowResize = true;
            // 
            // 
            // 
            this.spc_plist.PrimaryGrid.ColumnHeader.RowHeight = 30;
            this.spc_plist.PrimaryGrid.DefaultRowHeight = 24;
            this.spc_plist.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.spc_plist.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.spc_plist.PrimaryGrid.EnableColumnFiltering = true;
            this.spc_plist.PrimaryGrid.EnableFiltering = true;
            this.spc_plist.PrimaryGrid.EnableRowFiltering = true;
            // 
            // 
            // 
            this.spc_plist.PrimaryGrid.Filter.Visible = true;
            this.spc_plist.PrimaryGrid.NullString = "<<null>>";
            this.spc_plist.PrimaryGrid.RowHeaderWidth = 45;
            this.spc_plist.PrimaryGrid.ShowRowGridIndex = true;
            this.spc_plist.PrimaryGrid.ShowTreeButtons = true;
            this.spc_plist.PrimaryGrid.ShowTreeLines = true;
            // 
            // 
            // 
            this.spc_plist.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.spc_plist.Size = new System.Drawing.Size(784, 449);
            this.spc_plist.TabIndex = 0;
            this.spc_plist.Text = "superGridControl1";
            // 
            // circularProgressItem6
            // 
            this.circularProgressItem6.Diameter = 48;
            this.circularProgressItem6.Name = "circularProgressItem6";
            this.circularProgressItem6.ProgressTextVisible = true;
            // 
            // cbxUseAgeSlider
            // 
            this.cbxUseAgeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxUseAgeSlider.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxUseAgeSlider.Location = new System.Drawing.Point(151, 489);
            this.cbxUseAgeSlider.Name = "cbxUseAgeSlider";
            this.cbxUseAgeSlider.Size = new System.Drawing.Size(152, 21);
            this.cbxUseAgeSlider.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxUseAgeSlider.TabIndex = 19;
            this.cbxUseAgeSlider.Text = "Use Slider for Age Filter";
            this.cbxUseAgeSlider.Visible = false;
            // 
            // PatientInfoFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 519);
            this.Controls.Add(this.cbxUseAgeSlider);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbFilterLevel);
            this.Controls.Add(this.cbFilterImageVisibility);
            this.Controls.Add(this.cbxShowPanelExpr);
            this.Controls.Add(this.cbFilterAlignment);
            this.Controls.Add(this.cbMatchType);
            this.Controls.Add(this.btnResetColumnFilters);
            this.Controls.Add(this.btnResetPanelFilter);
            this.Controls.Add(this.spc_plist);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(565, 294);
            this.Name = "PatientInfoFiltering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "��������";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl spc_plist;
        private DevComponents.DotNetBar.ButtonX btnResetPanelFilter;
        private DevComponents.DotNetBar.ButtonX btnResetColumnFilters;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMatchType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterAlignment;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxShowPanelExpr;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterImageVisibility;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterLevel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem6;
        private CheckBoxX cbxUseAgeSlider;
    }
}