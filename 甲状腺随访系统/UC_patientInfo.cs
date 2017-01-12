using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 甲状腺随访系统
{
    public partial class UC_patientInfo : UserControl
    {
        public UC_patientInfo()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        private void UC_patientInfo_Load(object sender, EventArgs e)
        {



            string[] langItems = INIHelper.INIGetAllItems(Conf.langpath, "patientsInfo");
            for (int i = 0; i < langItems.Length; i++)
            {
                String[] strArray = langItems[i].Split('=');
                if (this.Controls.Find(strArray[0], true).Length > 0)
                {
                    this.Controls.Find(strArray[0], true)[0].Text = strArray[1];
                }
            }

        }

        private void warningBox1_CloseClick(object sender, EventArgs e)
        {
            
            //wbox_tips.Visible = false;
        }

        private void bt_saveBasic_Click(object sender, EventArgs e)
        {
            //wbox_tips.Text = "<b >系统提示</b>  <i>用户基本信息保存成功</i>";
            //wbox_tips.ForeColor = Color.Red;
            //wbox_tips.Visible = true;
        }

        void fillUI(object obj, EventArgs args)
        {
            tb_patientName.Text = Conf.currentPatient.basicInfo.name;

        }

        private void sideNavItem5_VisibleChanged(object sender, EventArgs e)
        {

        }



    }
}
