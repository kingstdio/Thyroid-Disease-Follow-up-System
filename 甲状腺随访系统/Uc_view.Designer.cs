﻿namespace 甲状腺随访系统
{
    partial class Uc_view
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
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.SuspendLayout();
            // 
            // superGridControl1
            // 
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 0);
            this.superGridControl1.Name = "superGridControl1";
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.ShowTreeLines = true;
            this.superGridControl1.Size = new System.Drawing.Size(1416, 568);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // Uc_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.superGridControl1);
            this.Name = "Uc_view";
            this.Size = new System.Drawing.Size(1416, 568);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
    }
}
