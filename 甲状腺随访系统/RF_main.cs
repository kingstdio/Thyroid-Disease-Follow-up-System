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
    public partial class RF_main : DevComponents.DotNetBar.RibbonForm
    {

        UC_patientInfo uC_patientInfo = new UC_patientInfo();
        UC_diagnosis uC_diagnosis = new UC_diagnosis();
        UC_surgeryHistory uC_surgeryHistory = new UC_surgeryHistory();
        UC_postOperative uC_postOperative = new UC_postOperative();
        UC_followUp uC_followUp = new UC_followUp();
        UC_recurrencecs uC_recurrencecs = new UC_recurrencecs();


        #region 初始化
        public RF_main()
        {
            InitializeComponent();

            
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillPaitentBoard); //注册更新病人信息面板事件
            
            //添加功能面板
            panEX_main.Controls.Add(uC_patientInfo);
            panEX_main.Controls.Add(uC_diagnosis);
            panEX_main.Controls.Add(uC_surgeryHistory);
            panEX_main.Controls.Add(uC_postOperative);
            panEX_main.Controls.Add(uC_followUp);
            panEX_main.Controls.Add(uC_recurrencecs);

            //设置缩放属性
            uC_patientInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_diagnosis.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_surgeryHistory.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_postOperative.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_followUp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_recurrencecs.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            //设置功能面板的可见性
            uC_diagnosis.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
        }
        #endregion 

        #region 更新功能面板事件
        /// <summary>
        /// 更新功能面板
        /// </summary>
        void fillPaitentBoard(object obj, EventArgs args) {
            tb_name.Text = Conf.currentPatient.basicInfo.name;
            tb_hosno.Text = Conf.currentPatient.basicInfo.hosnumber;
            tb_phone.Text = Conf.currentPatient.basicInfo.mobile;
            tb_hosindate.Text = Conf.currentPatient.basicInfo.hosindate.ToShortDateString();
            tb_sex.Text = Conf.currentPatient.basicInfo.sex?"男":"女";
            tb_idcard.Text = Conf.currentPatient.basicInfo.idcard;
            tb_birthday.Text = Conf.currentPatient.basicInfo.birthday.ToShortDateString();
            tb_hosoutdate.Text = Conf.currentPatient.basicInfo.hosoutdate.ToShortDateString();
            tb_FUNear.Text = Conf.currentPatient.lastFollowDate.ToShortDateString();
            tb_FUTimes.Text = Conf.currentPatient.followTimes.ToString();

           
           
        }
        #endregion

        #region 界面按钮操作
        private void bt_patientAdd_Click(object sender, EventArgs e)
        {
            
            uC_diagnosis.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            uC_patientInfo.Visible = true;
        }



        private void bt_riskFator_Click(object sender, EventArgs e)
        {
            uC_patientInfo.Visible = false;       
            uC_diagnosis.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            
        }


        private void bt_diagnosis_Click_1(object sender, EventArgs e)
        {
            uC_patientInfo.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            uC_diagnosis.Visible = true;
            
        }



        private void bt_SH_Click(object sender, EventArgs e)
        {
            uC_patientInfo.Visible = false;
            uC_diagnosis.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            uC_surgeryHistory.Visible = true;
        }


        private void bt_pOperative_Click(object sender, EventArgs e)
        {
            uC_patientInfo.Visible = false;
            uC_diagnosis.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            uC_postOperative.Visible = true;
        }

        /// <summary>
        /// 界面追踪按钮
        /// </summary>
        private void bt_followUp_Click(object sender, EventArgs e)
        {
            uC_patientInfo.Visible = false;
            uC_diagnosis.Visible = false;
            uC_postOperative.Visible = false;
            uC_surgeryHistory.Visible = false;         
            uC_recurrencecs.Visible = false;         
            uC_followUp.Visible = true;

            F_patientChoose fchoosePatient = new F_patientChoose();
            fchoosePatient.ShowDialog();
        }

        private void bt_recurrencecs_Click(object sender, EventArgs e)
        {
            uC_patientInfo.Visible = false;
            uC_diagnosis.Visible = false;
            uC_postOperative.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = true;
            
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ToastNotification.Show(this,"系统数据保存成功");
        }
        #endregion

        private void panEX_main_Click(object sender, EventArgs e)
        {

        }




    }
}