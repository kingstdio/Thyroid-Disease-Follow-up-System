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

        public RF_main()
        {
            InitializeComponent();
            panEX_main.Controls.Add(uC_patientInfo);
            panEX_main.Controls.Add(uC_diagnosis);
            panEX_main.Controls.Add(uC_surgeryHistory);
            panEX_main.Controls.Add(uC_postOperative);
            panEX_main.Controls.Add(uC_followUp);
            panEX_main.Controls.Add(uC_recurrencecs);

            uC_patientInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_diagnosis.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_surgeryHistory.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_postOperative.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_followUp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_recurrencecs.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            //uC_patientInfo.Visible = true;
            uC_diagnosis.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
        }


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

    }
}