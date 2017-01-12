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
        /// <summary>
        /// 病人信息表格
        /// </summary>
        DataTable pinfo = new DataTable();

        /// <summary>
        /// 住院号
        /// </summary>
        private string hosNumber=string.Empty;
        /// <summary>
        /// 病人姓名
        /// </summary>
        private string name = string.Empty;
        /// <summary>
        /// 身份证号
        /// </summary>
        private string idcardno = string.Empty;
        /// <summary>
        /// 电话号
        /// </summary>
        private string mobile = string.Empty;

        public F_patientChoose()
        {
            InitializeComponent();
        }

        private void bt_query_Click(object sender, EventArgs e)
        {
            hosNumber = tb_hosno.Text.Trim() == "" ? string.Empty : tb_hosno.Text.Trim();
            name = tb_name.Text.Trim() == "" ? string.Empty : tb_name.Text.Trim();
            idcardno = tb_idcard.Text.Trim() == "" ? string.Empty : tb_idcard.Text.Trim();
            mobile = tb_tel.Text.Trim() == "" ? string.Empty : lb_phone.Text.Trim();

            if (hosNumber == string.Empty && name == string.Empty && idcardno == string.Empty && mobile == string.Empty)
            {
                MessageBox.Show("请输入至少一个查询条件", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pinfo = DAO.PatientChoose.fill(name, idcardno, mobile, hosNumber);
            dgv_show.DataSource = pinfo;
        }


        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_show.RowCount > 0)
            {
                int pid = (int)dgv_show.CurrentRow.Cells["编号"].Value;
                Control.RefreshPatient.refresh(pid);
                this.Close();
            }

           
        }
    }
}
