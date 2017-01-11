using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace 甲状腺随访系统
{
    public partial class F_patientChoose : Form
    {
        DataTable pinfo = new DataTable();
        private string hosNumber=string.Empty;
        private string name = string.Empty;
        private string idcardno = string.Empty;
        private string mobile = string.Empty;

        public F_patientChoose()
        {
            InitializeComponent();
        }

        private void bt_query_Click(object sender, EventArgs e)
        {
            ToastNotification.Show(this, "系统数据保存成功");
        }
    }
}
