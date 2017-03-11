using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace 甲状腺随访系统
{
    public partial class F_login : DevComponents.DotNetBar.OfficeForm
    {
        #region 构造函数
        public F_login()
        {
            InitializeComponent();
            lb_version.Text = "当前系统版本："+Conf.appVersion;
        }
        #endregion

        #region 按esc键退出窗体
        private void F_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27) {
                this.DialogResult = DialogResult.No;
                this.Dispose();
            }
        }
        #endregion

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (!Control.Login.LoginIn(tb_username.Text.Trim(), tb_pwd.Text.Trim()))
            {
                if (Conf.currentUser.username!=null)
                    ToastNotification.Show(this, "用户名或密码不正确！");
                else
                    ToastNotification.Show(this, "该用户不存在！");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
          
            
        }
    }
}