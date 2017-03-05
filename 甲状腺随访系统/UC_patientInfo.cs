using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace 甲状腺随访系统
{
    public partial class UC_patientInfo : UserControl
    {
        public UC_patientInfo()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);

            lb_beizhu.Visible = false;
            tb_fht.Visible = tb_othertt.Visible = tb_otherptt.Visible = false;
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
            //患者基本信息
            tb_patientName.Text = Conf.currentPatient.basicInfo.name;
            tb_idNumber.Text = Conf.currentPatient.basicInfo.idcard;
            tb_patientAddress.Text = Conf.currentPatient.basicInfo.address;
            tb_patientPhone2.Text = Conf.currentPatient.basicInfo.mobile;
            tb_patientPhone3.Text = Conf.currentPatient.basicInfo.phone;

            tb_hospitalNo.Text = Conf.currentPatient.basicInfo.hosnumber;
            switch_gender.Value = Conf.currentPatient.basicInfo.sex;
            dti_birthday.Value = Conf.currentPatient.basicInfo.birthday;
            dti_age.Value = Conf.currentPatient.basicInfo.hosage;
            dti_regDate.Value = Conf.currentPatient.basicInfo.hosindate;
            dti_dateLeave.Value = Conf.currentPatient.basicInfo.hosoutdate;

            //一般危险因素
            cbe_resident.SelectedIndex = cbe_resident.FindString(Conf.currentPatient.normalRiskFactors.resident);
            ii_AFM.Value = Conf.currentPatient.normalRiskFactors.menophaniaage;
            ii_AFP.Value = Conf.currentPatient.normalRiskFactors.pregnancyage;
            ii_TP.Value = Conf.currentPatient.normalRiskFactors.pregnancytimes;
            ii_TIA.Value = Conf.currentPatient.normalRiskFactors.abortiontimes;
            ii_eutociaT.Value = Conf.currentPatient.normalRiskFactors.deliverytimes;
            switch_menopause.Value = Conf.currentPatient.normalRiskFactors.menopause;

            switch_smoke.Value = Conf.currentPatient.normalRiskFactors.smoke;
            switch_drink.Value = Conf.currentPatient.normalRiskFactors.drink;
            tb_occupation.Text = Conf.currentPatient.normalRiskFactors.occupation;
            dti_height.Value = Conf.currentPatient.normalRiskFactors.height;
            dti_weight.Value = Conf.currentPatient.normalRiskFactors.weight;
            //BMI计算
            if (dti_height.Value != 0 && dti_weight.Value != 0)
            {
                double bmi = Convert.ToDouble(dti_weight.Value) / (Convert.ToDouble(dti_height.Value) * Convert.ToDouble(dti_height.Value));
                bmi = bmi * 10000;
                Console.WriteLine(bmi);
                dti_BMI.Value = bmi;
            }
            //tb_BMI.Text = Conf.currentPatient.normalRiskFactors.constitutional;
           // tb_BMI.Text = Convert.ToString(Conf.currentPatient.normalRiskFactors.constitutional);

            //特殊危险因素
            di_prolactin.Value = Conf.currentPatient.specialRiskFactors.prolactin;
            di_testosterone.Value = Conf.currentPatient.specialRiskFactors.testosterone;
            di_pregnendione.Value = Conf.currentPatient.specialRiskFactors.pregnendione;
            di_estradiol.Value = Conf.currentPatient.specialRiskFactors.estradiol;
            di_luteinizing.Value = Conf.currentPatient.specialRiskFactors.luteinizing;
            di_foll.Value = Conf.currentPatient.specialRiskFactors.folliclestimulating;

            di_cholesterol.Value = Conf.currentPatient.specialRiskFactors.cholesterol;
            di_triglyceride.Value = Conf.currentPatient.specialRiskFactors.triglyceride;
            di_llipoprotein.Value = Conf.currentPatient.specialRiskFactors.llipoprotein;
            di_hlipoprotein.Value = Conf.currentPatient.specialRiskFactors.hlipoprotein;
            di_bloodGlucose.Value = Conf.currentPatient.specialRiskFactors.bloodGlucose;

            //既往史及家族史
            switch_hypertension.Value = Conf.currentPatient.familyHistory.hypertension;
            switch_diabetes.Value = Conf.currentPatient.familyHistory.diabetes;
            switch_coronary.Value = Conf.currentPatient.familyHistory.coronary;
            switch_radiotherapy.Value = Conf.currentPatient.familyHistory.radiotherapy;
            switch_otherntumour.Value = Conf.currentPatient.familyHistory.otherntumour;

            //其它恶性肿瘤
            if (Conf.currentPatient.familyHistory.otherntumour)
            {
                switch_otherntumour.Value = true;              
                tb_othertt.Visible = true;
                
                tb_othertt.Text = Conf.currentPatient.familyHistory.otherntumourtext;
            }
            else {
                tb_othertt.Visible = false;
            }
            
            //其它良性肿瘤
            if (Conf.currentPatient.familyHistory.otherptumour)
            {
                switch_otherptumour.Value = true;
                tb_otherptt.Visible = true;
                tb_otherptt.Text = Conf.currentPatient.familyHistory.othernoptumourtext;
            } 
            else 
            {
                tb_otherptt.Visible = false;
            }

            //家族史
            if (Conf.currentPatient.familyHistory.familyhistory)
            { switch_familyhistory.Value = true; tb_fht.Visible = true; tb_fht.Text = Conf.currentPatient.familyHistory.familyhistorytext; } else { tb_fht.Visible = false; }
            
 
            

        }

        void InsertData(object sender, EventArgs e)
        {
            //患者基本信息
            Conf.currentPatient.basicInfo.name = tb_patientName.Text;
            Conf.currentPatient.basicInfo.idcard = tb_idNumber.Text;
            Conf.currentPatient.basicInfo.address = tb_patientAddress.Text;
            Conf.currentPatient.basicInfo.mobile = tb_patientPhone2.Text;
            Conf.currentPatient.basicInfo.phone = tb_patientPhone3.Text;

            Conf.currentPatient.basicInfo.hosnumber = tb_hospitalNo.Text;
            Conf.currentPatient.basicInfo.sex = switch_gender.Value;
            Conf.currentPatient.basicInfo.birthday = dti_birthday.Value;
            Conf.currentPatient.basicInfo.hosage = dti_age.Value;
            Conf.currentPatient.basicInfo.hosindate = dti_regDate.Value;
            Conf.currentPatient.basicInfo.hosoutdate = dti_dateLeave.Value;

            //一般危险因素
            Conf.currentPatient.normalRiskFactors.resident = cbe_resident.Text;
            Conf.currentPatient.normalRiskFactors.menophaniaage = ii_AFM.Value;
            Conf.currentPatient.normalRiskFactors.pregnancyage = ii_AFP.Value;
            Conf.currentPatient.normalRiskFactors.pregnancytimes = ii_TP.Value;
            Conf.currentPatient.normalRiskFactors.abortiontimes = ii_TIA.Value;
            Conf.currentPatient.normalRiskFactors.deliverytimes = ii_eutociaT.Value;
            Conf.currentPatient.normalRiskFactors.menopause = switch_menopause.Value;

            Conf.currentPatient.normalRiskFactors.smoke = switch_smoke.Value;
            Conf.currentPatient.normalRiskFactors.drink = switch_drink.Value;
            Conf.currentPatient.normalRiskFactors.occupation = tb_occupation.Text;
            Conf.currentPatient.normalRiskFactors.height = dti_height.Value;
            Conf.currentPatient.normalRiskFactors.weight = dti_weight.Value ;
            Conf.currentPatient.normalRiskFactors.constitutional = Convert.ToDouble(dti_BMI.Value);

            //特殊危险因素
            Conf.currentPatient.specialRiskFactors.prolactin = di_prolactin.Value;
            Conf.currentPatient.specialRiskFactors.testosterone = di_testosterone.Value;
            Conf.currentPatient.specialRiskFactors.pregnendione = di_pregnendione.Value;
            Conf.currentPatient.specialRiskFactors.estradiol = di_estradiol.Value;
            Conf.currentPatient.specialRiskFactors.luteinizing = di_luteinizing.Value;
            Conf.currentPatient.specialRiskFactors.folliclestimulating = di_foll.Value;

            Conf.currentPatient.specialRiskFactors.cholesterol = di_cholesterol.Value;
            Conf.currentPatient.specialRiskFactors.triglyceride = di_triglyceride.Value;
            Conf.currentPatient.specialRiskFactors.llipoprotein = di_llipoprotein.Value;
            Conf.currentPatient.specialRiskFactors.hlipoprotein = di_hlipoprotein.Value;
            Conf.currentPatient.specialRiskFactors.bloodGlucose = di_bloodGlucose.Value;

            //既往史及家族史
            Conf.currentPatient.familyHistory.hypertension = switch_hypertension.Value;
            Conf.currentPatient.familyHistory.diabetes = switch_diabetes.Value;
            Conf.currentPatient.familyHistory.coronary = switch_coronary.Value;
            Conf.currentPatient.familyHistory.radiotherapy = switch_radiotherapy.Value;
            Conf.currentPatient.familyHistory.otherntumour = switch_otherntumour.Value;
            Conf.currentPatient.familyHistory.otherntumourtext = tb_othertt.Text;
            Conf.currentPatient.familyHistory.otherptumour = switch_otherptumour.Value;
            Conf.currentPatient.familyHistory.othernoptumourtext = tb_otherptt.Text;
            Conf.currentPatient.familyHistory.familyhistory = switch_familyhistory.Value;
            Conf.currentPatient.familyHistory.familyhistorytext = tb_fht.Text;
         
            


        }


        void RefreshDatabase(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_patientName.Text) || string.IsNullOrEmpty(tb_idNumber.Text))
            {
                ToastNotification.Show(Parent, "患者姓名或身份证号目前为空！");
            }
            if (DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id))
            {
                ToastNotification.Show(Parent, "系统数据保存成功");                 
            }
        }

        private void tb_idNumber_Leave(object sender, EventArgs e)
        {

            Conf.currentPatient.basicInfo.name = tb_patientName.Text;
            Conf.currentPatient.basicInfo.idcard = tb_idNumber.Text;

            DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id);

            Control.RefreshPatient.refresh(Conf.currentPatient.id);

        }

        private void switch_otherntumour_Leave(object sender, EventArgs e)
        {
            if (switch_otherntumour.Value == true)
            {
                tb_othertt.ReadOnly = false;
            }
            else
            {
                tb_othertt.ReadOnly = true;
            }
        }

        private void switch_otherptumour_Leave(object sender, EventArgs e)
        {
            if (switch_otherptumour.Value == true)
            {
                tb_otherptt.ReadOnly = false;
            }
            else
            {
                tb_otherptt.ReadOnly = true;
            }
        }


        private void dti_height_Leave(object sender, EventArgs e)
        {
            if (dti_height.Value != 0 && dti_weight.Value != 0)
            {
                double bmi = Convert.ToDouble(dti_weight.Value) / (Convert.ToDouble(dti_height.Value) * Convert.ToDouble(dti_height.Value));
                bmi = bmi * 10000;
                Console.WriteLine(bmi);
                dti_BMI.Value = bmi;
            }
            else
            {
                //dti_BMI.Value = 0;
            }
        }

        private void dti_weight_Leave(object sender, EventArgs e)
        {
            if (dti_height.Value != 0 && dti_weight.Value != 0)
            {
                double bmi = Convert.ToDouble(dti_weight.Value) / (Convert.ToDouble(dti_height.Value) * Convert.ToDouble(dti_height.Value));
                bmi = bmi * 10000;
                Console.WriteLine(bmi);
                dti_BMI.Value = bmi;
            }
            else
            {
                //dti_BMI.Value = 0;
            }
        }

        private void switch_familyhistory_ValueChanged(object sender, EventArgs e)
        {
            if (switch_familyhistory.Value)
            {
                tb_fht.Visible = true;
                lb_beizhu.Visible = true;
            }
            else {
                tb_fht.Visible = false;
                lb_beizhu.Visible = false;
            }
        }

        private void switch_otherptumour_ValueChanged(object sender, EventArgs e)
        {
            if (switch_otherptumour.Value) { tb_otherptt.Visible = true; } else { tb_otherptt.Visible = false; }
        }

        private void switch_otherntumour_ValueChanged(object sender, EventArgs e)
        {
            if (switch_otherntumour.Value) { tb_othertt.Visible = true; } else { tb_othertt.Visible = false; }
        }

        private void UC_patientInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                sideNavItem5.Select();
                tb_patientName.Select();
            }
        }




         
    }
}
