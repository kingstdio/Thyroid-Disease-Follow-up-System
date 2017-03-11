using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace 甲状腺随访系统
{
    public partial class UC_userManagement : UserControl
    {
        public UC_userManagement()
        {
            InitializeComponent();
            ListUser();
        }
        //展示所有用户
        void ListUser()
        {
            DataTable dt = Control.UserManage.getAllUser();
            sgc_UserInfo.PrimaryGrid.DataSource = dt;
        }
        //填充面板
        void fillInfo()
        {

            tb_name.Text = Conf.manageUser.username;
            tb_pass.Text = Conf.manageUser.password;
            tb_passag.Text = Conf.manageUser.password;
            cbe_privilege.SelectedIndex = cbe_privilege.FindString(Conf.manageUser.privilege);
            switch_forbidden.Value = Conf.manageUser.forbidden;
            tb_phone.Text = Conf.manageUser.phone;
            tb_email.Text = Conf.manageUser.email;
        }
        //获取面板信息
        void getInfo()
        {
            Conf.manageUser.username = tb_name.Text;
            Conf.manageUser.password = tb_pass.Text;
            Conf.manageUser.privilege = cbe_privilege.Text;
            Conf.manageUser.phone = tb_phone.Text;
            Conf.manageUser.email = tb_email.Text;
            Conf.manageUser.forbidden = switch_forbidden.Value;
        }
        private void bt_newuser_Click(object sender, EventArgs e)
        {
            if (tb_pass.Text != tb_passag.Text)
            {
                MessageBox.Show("两次输入密码不一致", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (Control.UserManage.CheckSameName(tb_name.Text))
            {
                MessageBox.Show("该用户已存在！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(tb_name.Text) ||string.IsNullOrWhiteSpace(tb_name.Text) ||string.IsNullOrWhiteSpace(tb_pass.Text)||string.IsNullOrEmpty(tb_pass.Text))
            {
                MessageBox.Show("用户名或密码为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                getInfo();

                Control.UserManage.InsertUser();
                ToastNotification.Show(this, "用户添加成功！");
                ListUser();
                Conf.manageUser = new MODEL.User();
                fillInfo();
            }
        }
        //获取用户信息
        private void sgc_UserInfo_RowDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs e)
        {
            

            SelectedElementCollection col = this.sgc_UserInfo.PrimaryGrid.GetSelectedRows();
            if (col.Count > 0)
            {
                GridRow row = col[0] as GridRow;
                Conf.manageUser.id = Convert.ToInt32(row.Cells[0].Value);
                Conf.manageUser.username = row.Cells[1].Value.ToString();
                Conf.manageUser.password = row.Cells[2].Value.ToString();
                Conf.manageUser.privilege = row.Cells[3].Value.ToString();
                Conf.manageUser.forbidden = Convert.ToBoolean(row.Cells[4].Value);
                Conf.manageUser.phone = row.Cells[6].Value.ToString();
                Conf.manageUser.email = row.Cells[7].Value.ToString();
                
                fillInfo();

            } 
        }
      

        private void bt_updateuser_Click(object sender, EventArgs e)
        {
            
            if (tb_pass.Text != tb_passag.Text)
            {
                MessageBox.Show("两次输入密码不一致", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                getInfo();
                if (Control.UserManage.UpdateUser())
                {
                    ToastNotification.Show(this, "更新成功！");
                    ListUser();
                    Conf.manageUser = new MODEL.User();
                    fillInfo();

                }
            }
            
        }

        private void bt_deleteuser_Click(object sender, EventArgs e)
        {
            getInfo();
            if (Control.UserManage.DeleteUser())
            {
                ToastNotification.Show(this, "删除成功！");
                ListUser();
                Conf.manageUser = new MODEL.User();
                fillInfo();
                //refreshPboard();
            }
        }

        private void tb_passag_Leave(object sender, EventArgs e)
        {
            if (tb_pass.Text != tb_passag.Text)
            {
                MessageBox.Show("两次输入密码不一致", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

       
    }
}
