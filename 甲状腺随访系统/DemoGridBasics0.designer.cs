namespace SuperGridDemo
{
    partial class DemoGridBasics0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoGridBasics0));
            DevComponents.DotNetBar.SuperGrid.Style.Background background6 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding8 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding9 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background7 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding10 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background8 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding11 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding12 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background9 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding13 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding14 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background10 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxHeader = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxTitle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxFooter = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxCaption = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxGridIndex = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxRowHeaders = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnPurgeRows = new DevComponents.DotNetBar.ButtonX();
            this.btnShowDeleted = new DevComponents.DotNetBar.ButtonX();
            this.btnHideDeleted = new DevComponents.DotNetBar.ButtonX();
            this.cbxAutoDelete = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.TheMachine = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn9 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn10 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.cbxRenderBack = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColorRichTextBox = System.Drawing.Color.White;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBox1.Size = new System.Drawing.Size(780, 119);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbxHeader);
            this.groupBox1.Controls.Add(this.cbxTitle);
            this.groupBox1.Controls.Add(this.cbxGridIndex);
            this.groupBox1.Controls.Add(this.cbxFooter);
            this.groupBox1.Controls.Add(this.cbxCaption);
            this.groupBox1.Controls.Add(this.cbxRowHeaders);
            this.groupBox1.Location = new System.Drawing.Point(12, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 80);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show";
            // 
            // cbxHeader
            // 
            this.cbxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxHeader.Location = new System.Drawing.Point(85, 19);
            this.cbxHeader.Name = "cbxHeader";
            this.cbxHeader.Size = new System.Drawing.Size(61, 23);
            this.cbxHeader.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxHeader.TabIndex = 10;
            this.cbxHeader.Text = "Header";
            this.cbxHeader.CheckedChanged += new System.EventHandler(this.CbxHeaderCheckedChanged);
            // 
            // cbxTitle
            // 
            this.cbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxTitle.Location = new System.Drawing.Point(15, 48);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(48, 23);
            this.cbxTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxTitle.TabIndex = 9;
            this.cbxTitle.Text = "Title";
            this.cbxTitle.CheckedChanged += new System.EventHandler(this.CbxTitleCheckedChanged);
            // 
            // cbxFooter
            // 
            this.cbxFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxFooter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxFooter.Location = new System.Drawing.Point(85, 48);
            this.cbxFooter.Name = "cbxFooter";
            this.cbxFooter.Size = new System.Drawing.Size(58, 23);
            this.cbxFooter.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxFooter.TabIndex = 11;
            this.cbxFooter.Text = "Footer";
            this.cbxFooter.CheckedChanged += new System.EventHandler(this.CbxFooterCheckedChanged);
            // 
            // cbxCaption
            // 
            this.cbxCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxCaption.Checked = true;
            this.cbxCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCaption.CheckValue = "Y";
            this.cbxCaption.Location = new System.Drawing.Point(15, 19);
            this.cbxCaption.Name = "cbxCaption";
            this.cbxCaption.Size = new System.Drawing.Size(64, 23);
            this.cbxCaption.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxCaption.TabIndex = 8;
            this.cbxCaption.Text = "Caption";
            this.cbxCaption.CheckedChanged += new System.EventHandler(this.CbxCaptionCheckedChanged);
            // 
            // cbxGridIndex
            // 
            this.cbxGridIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxGridIndex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxGridIndex.Checked = true;
            this.cbxGridIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGridIndex.CheckValue = "Y";
            this.cbxGridIndex.Location = new System.Drawing.Point(173, 48);
            this.cbxGridIndex.Name = "cbxGridIndex";
            this.cbxGridIndex.Size = new System.Drawing.Size(93, 23);
            this.cbxGridIndex.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxGridIndex.TabIndex = 14;
            this.cbxGridIndex.Text = "Grid Indexes";
            this.cbxGridIndex.CheckedChanged += new System.EventHandler(this.CbxGridIndexCheckedChanged);
            // 
            // cbxRowHeaders
            // 
            this.cbxRowHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxRowHeaders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxRowHeaders.Checked = true;
            this.cbxRowHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRowHeaders.CheckValue = "Y";
            this.cbxRowHeaders.Location = new System.Drawing.Point(173, 19);
            this.cbxRowHeaders.Name = "cbxRowHeaders";
            this.cbxRowHeaders.Size = new System.Drawing.Size(93, 23);
            this.cbxRowHeaders.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxRowHeaders.TabIndex = 13;
            this.cbxRowHeaders.Text = "Row Headers";
            this.cbxRowHeaders.CheckedChanged += new System.EventHandler(this.CbxRowHeadersCheckedChanged);
            // 
            // btnPurgeRows
            // 
            this.btnPurgeRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPurgeRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurgeRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPurgeRows.Location = new System.Drawing.Point(548, 569);
            this.btnPurgeRows.Name = "btnPurgeRows";
            this.btnPurgeRows.Size = new System.Drawing.Size(109, 26);
            this.btnPurgeRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnPurgeRows.TabIndex = 15;
            this.btnPurgeRows.Text = "Purge Deleted Rows";
            this.btnPurgeRows.Click += new System.EventHandler(this.BtnPurgeRowsClick);
            // 
            // btnShowDeleted
            // 
            this.btnShowDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowDeleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowDeleted.Location = new System.Drawing.Point(663, 569);
            this.btnShowDeleted.Name = "btnShowDeleted";
            this.btnShowDeleted.Size = new System.Drawing.Size(109, 26);
            this.btnShowDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnShowDeleted.TabIndex = 7;
            this.btnShowDeleted.Text = "Show Deleted Rows";
            this.btnShowDeleted.Click += new System.EventHandler(this.BtnShowDelRowsClick);
            // 
            // btnHideDeleted
            // 
            this.btnHideDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHideDeleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHideDeleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHideDeleted.Location = new System.Drawing.Point(663, 537);
            this.btnHideDeleted.Name = "btnHideDeleted";
            this.btnHideDeleted.Size = new System.Drawing.Size(109, 26);
            this.btnHideDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnHideDeleted.TabIndex = 6;
            this.btnHideDeleted.Text = "Hide Deleted Rows";
            this.btnHideDeleted.Click += new System.EventHandler(this.BtnHideDelRowsClick);
            // 
            // cbxAutoDelete
            // 
            this.cbxAutoDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxAutoDelete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAutoDelete.Checked = true;
            this.cbxAutoDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoDelete.CheckValue = "Y";
            this.cbxAutoDelete.Location = new System.Drawing.Point(333, 530);
            this.cbxAutoDelete.Name = "cbxAutoDelete";
            this.cbxAutoDelete.Size = new System.Drawing.Size(170, 23);
            this.cbxAutoDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxAutoDelete.TabIndex = 5;
            this.cbxAutoDelete.Text = "Auto Hide Deleted Rows";
            this.cbxAutoDelete.CheckedChanged += new System.EventHandler(this.CbxAutoDeleteCheckedChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ErrorTriangle.png");
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.BackColor = System.Drawing.Color.White;
            this.superGridControl1.DefaultVisualStyles.FooterStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(0, 129);
            this.superGridControl1.Name = "superGridControl1";
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.AllowRowDelete = true;
            this.superGridControl1.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl1.PrimaryGrid.AllowRowInsert = true;
            this.superGridControl1.PrimaryGrid.AllowRowResize = true;
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.Caption.Text = "(Caption)<div align=\"vcenter\">Wolf Power and Machine Works Inc.</div>";
            this.superGridControl1.PrimaryGrid.Columns.Add(this.TheMachine);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn7);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn8);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn9);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn10);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 0;
            background6.Color1 = System.Drawing.Color.AliceBlue;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = background6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            padding8.Right = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.ImagePadding = padding8;
            padding9.Bottom = 6;
            padding9.Left = 6;
            padding9.Right = 6;
            padding9.Top = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = padding9;
            background7.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.SelectedMouseOver.Background = background7;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopLeft;
            padding10.Bottom = 4;
            padding10.Left = 4;
            padding10.Right = 4;
            padding10.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Margin = padding10;
            background8.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.SelectedMouseOver.Background = background8;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.None;
            padding11.Right = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImagePadding = padding11;
            padding12.Bottom = 4;
            padding12.Left = 4;
            padding12.Right = 4;
            padding12.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Margin = padding12;
            background9.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.SelectedMouseOver.Background = background9;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            padding13.Right = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.ImagePadding = padding13;
            padding14.Bottom = 4;
            padding14.Left = 4;
            padding14.Right = 4;
            padding14.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Margin = padding14;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.TextColor = System.Drawing.Color.Navy;
            background10.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.SelectedMouseOver.Background = background10;
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.Footer.Text = "(Footer)<div align=\"vcenter\">Check with your Supervisor if you have <b>ANY</b> qu" +
    "estions.</div>";
            this.superGridControl1.PrimaryGrid.Footer.Visible = false;
            this.superGridControl1.PrimaryGrid.FrozenColumnCount = 1;
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.Header.Text = "(Header) <div align=\"vcenter\">Make sure operator is a <b><font color=\"#ED1C24\">SA" +
    "FE DISTANCE</font> </b>away from the machine power panel before starting machine" +
    ".</div>";
            this.superGridControl1.PrimaryGrid.Header.Visible = false;
            this.superGridControl1.PrimaryGrid.ImageList = this.imageList1;
            this.superGridControl1.PrimaryGrid.ImmediateResize = true;
            this.superGridControl1.PrimaryGrid.RowDragBehavior = DevComponents.DotNetBar.SuperGrid.RowDragBehavior.Move;
            this.superGridControl1.PrimaryGrid.ShowInsertRow = true;
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.PrimaryGrid.Title.Text = "(Title)<div align=\"vcenter\">Check operators manual for suggested maintanance inte" +
    "rvals</div>";
            this.superGridControl1.PrimaryGrid.Title.Visible = false;
            this.superGridControl1.PrimaryGrid.UseAlternateRowStyle = true;
            this.superGridControl1.Size = new System.Drawing.Size(784, 380);
            this.superGridControl1.TabIndex = 4;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // TheMachine
            // 
            this.TheMachine.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.TheMachine.CellStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.TheMachine.DefaultNewRowCellValue = "Machine Name";
            this.TheMachine.Name = "Machine";
            this.TheMachine.SortCycle = DevComponents.DotNetBar.SuperGrid.SortCycle.AscDescNone;
            // 
            // gridColumn7
            // 
            this.gridColumn7.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn7.DefaultNewRowCellValue = "false";
            this.gridColumn7.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            this.gridColumn7.Name = "Dual Voltage";
            // 
            // gridColumn8
            // 
            this.gridColumn8.DefaultNewRowCellValue = false;
            this.gridColumn8.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridSwitchButtonEditControl);
            this.gridColumn8.Name = "Power State";
            // 
            // gridColumn9
            // 
            this.gridColumn9.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn9.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            this.gridColumn9.Name = "Last Maintance";
            this.gridColumn9.Width = 140;
            // 
            // gridColumn10
            // 
            this.gridColumn10.DefaultNewRowCellValue = "Start";
            this.gridColumn10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            this.gridColumn10.MarkRowDirtyOnCellValueChange = false;
            this.gridColumn10.Name = "Start/Stop";
            // 
            // gridColumn1
            // 
            this.gridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridRatingStarEditControl);
            this.gridColumn1.Name = "Condition";
            // 
            // cbxRenderBack
            // 
            this.cbxRenderBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxRenderBack.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxRenderBack.Location = new System.Drawing.Point(333, 559);
            this.cbxRenderBack.Name = "cbxRenderBack";
            this.cbxRenderBack.Size = new System.Drawing.Size(180, 23);
            this.cbxRenderBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbxRenderBack.TabIndex = 16;
            this.cbxRenderBack.Text = "User Render Row Background";
            this.cbxRenderBack.CheckedChanged += new System.EventHandler(this.cbxRenderBack_CheckedChanged);
            // 
            // DemoGridBasics0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 603);
            this.Controls.Add(this.cbxRenderBack);
            this.Controls.Add(this.btnPurgeRows);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowDeleted);
            this.Controls.Add(this.btnHideDeleted);
            this.Controls.Add(this.cbxAutoDelete);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoGridBasics0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Basic Components";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAutoDelete;
        private DevComponents.DotNetBar.ButtonX btnHideDeleted;
        private DevComponents.DotNetBar.ButtonX btnShowDeleted;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxCaption;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxTitle;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxHeader;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxFooter;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxRowHeaders;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxGridIndex;
        private DevComponents.DotNetBar.ButtonX btnPurgeRows;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn TheMachine;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn9;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn10;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxRenderBack;
    }
}