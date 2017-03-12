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
    public partial class UC_diagnosis : UserControl
    {
       
        public UC_diagnosis()
        {      
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
            
        }

 


        private void labelX33_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {

        }

        void fillUI(object obj, EventArgs args)
        {
            //影像学检查
            cbe_TI.SelectedIndex = cbe_TI.FindString(Conf.currentPatient.imageExamination.tirads);
            cbe_TI2.SelectedIndex = cbe_TI2.FindString(Conf.currentPatient.imageExamination.part);
            switch_trans.Value = Conf.currentPatient.imageExamination.tdlymphnodemetastisis;
            tb_remark.Text = Conf.currentPatient.imageExamination.remark;
            cbe_UC.SelectedIndex = cbe_UC.FindString(Conf.currentPatient.imageExamination.ucthyroidcancer);
          

            cbe_EIR.SelectedIndex = cbe_EIR.FindString(Conf.currentPatient.imageExamination.elasticimpactrating);

            switch_CTthyroi.Value = Conf.currentPatient.imageExamination.ctthyroidcancer;
            switch_CTlymp.Value = Conf.currentPatient.imageExamination.ctlymphnodemetastisis;

            cbe_laryngoscope.SelectedIndex = cbe_laryngoscope.FindString(Conf.currentPatient.imageExamination.laryngoscope);
            cbe_op.SelectedIndex = cbe_op.FindString(Conf.currentPatient.imageExamination.diagnosis);

            //组织学检查
            cbe_bethesda.SelectedIndex = cbe_bethesda.FindString(Conf.currentPatient.histologicalExamination.Bethesda);
            cbe_braf.SelectedIndex = cbe_braf.FindString(Conf.currentPatient.histologicalExamination.thyroidbraf);
            cbe_RAS.SelectedIndex = cbe_RAS.FindString(Conf.currentPatient.histologicalExamination.thyroidRAS);
            cbe_TERT.SelectedIndex = cbe_TERT.FindString(Conf.currentPatient.histologicalExamination.thyroidTERT);
            cbe_PTC1.SelectedIndex = cbe_PTC1.FindString(Conf.currentPatient.histologicalExamination.thyroidPTC1);
            cbe_PTC3.SelectedIndex = cbe_PTC3.FindString(Conf.currentPatient.histologicalExamination.thyroidPTC3);
            cbe_PAX8.SelectedIndex = cbe_PAX8.FindString(Conf.currentPatient.histologicalExamination.thyroidPAX8);

            tb_TGE.Text = Conf.currentPatient.histologicalExamination.lymphnodesFNA;
            cbe_braf1.SelectedIndex = cbe_braf1.FindString(Conf.currentPatient.histologicalExamination.lymphnodesbraf);
            di_TG.Value = Conf.currentPatient.histologicalExamination.lymphnodestg;

            //血液检查
            di_TSH.Value = Conf.currentPatient.hematologicalExamination.TSH;
            di_FT3.Value = Conf.currentPatient.hematologicalExamination.FT3;
            di_FT4.Value = Conf.currentPatient.hematologicalExamination.FT4;
            di_ATG.Value = Conf.currentPatient.hematologicalExamination.ATG;
            di_ATPO.Value = Conf.currentPatient.hematologicalExamination.ATPO;
            di_PTH.Value = Conf.currentPatient.hematologicalExamination.PTH;
            di_CT.Value = Conf.currentPatient.hematologicalExamination.CT;
            di_TG1.Value = Conf.currentPatient.hematologicalExamination.TG;
            di_CEA.Value = Conf.currentPatient.hematologicalExamination.CEA;

            di_K.Value = Conf.currentPatient.hematologicalExamination.K;
            di_Na.Value = Conf.currentPatient.hematologicalExamination.Na;
            di_Cl.Value = Conf.currentPatient.hematologicalExamination.Cl;
            di_Ca.Value = Conf.currentPatient.hematologicalExamination.Ca;
            di_P.Value = Conf.currentPatient.hematologicalExamination.P;

        }


        public void InsertData(object sender, EventArgs e)
        {
            //影像学检查
            Conf.currentPatient.imageExamination.tirads = cbe_TI.Text;
            Conf.currentPatient.imageExamination.part = cbe_TI2.Text;
            Conf.currentPatient.imageExamination.tdlymphnodemetastisis = switch_trans.Value;
            Conf.currentPatient.imageExamination.remark = tb_remark.Text;
            Conf.currentPatient.imageExamination.ucthyroidcancer = cbe_UC.Text;


            Conf.currentPatient.imageExamination.elasticimpactrating = cbe_EIR.Text;

            Conf.currentPatient.imageExamination.ctthyroidcancer = switch_CTthyroi.Value;
            Conf.currentPatient.imageExamination.ctlymphnodemetastisis = switch_CTlymp.Value;

            Conf.currentPatient.imageExamination.laryngoscope = cbe_laryngoscope.Text;
            Conf.currentPatient.imageExamination.diagnosis = cbe_op.Text;

            //组织学检查
            Conf.currentPatient.histologicalExamination.Bethesda = cbe_bethesda.Text;
            Conf.currentPatient.histologicalExamination.thyroidbraf = cbe_braf.Text;
            Conf.currentPatient.histologicalExamination.thyroidRAS = cbe_RAS.Text;
            Conf.currentPatient.histologicalExamination.thyroidTERT = cbe_TERT.Text;
            Conf.currentPatient.histologicalExamination.thyroidPTC1 = cbe_PTC1.Text;
            Conf.currentPatient.histologicalExamination.thyroidPTC3 = cbe_PTC3.Text;
            Conf.currentPatient.histologicalExamination.thyroidPAX8 = cbe_PAX8.Text;

            Conf.currentPatient.histologicalExamination.lymphnodesFNA = tb_TGE.Text;
            Conf.currentPatient.histologicalExamination.lymphnodesbraf = cbe_braf1.Text;
            Conf.currentPatient.histologicalExamination.lymphnodestg = di_TG.Value;

            //血液检查
            Conf.currentPatient.hematologicalExamination.TSH = di_TSH.Value;
            Conf.currentPatient.hematologicalExamination.FT3 = di_FT3.Value;
            Conf.currentPatient.hematologicalExamination.FT4 = di_FT4.Value;
            Conf.currentPatient.hematologicalExamination.ATG = di_ATG.Value;
            Conf.currentPatient.hematologicalExamination.ATPO = di_ATPO.Value;
            Conf.currentPatient.hematologicalExamination.PTH = di_PTH.Value;
            Conf.currentPatient.hematologicalExamination.CT = di_CT.Value;
            Conf.currentPatient.hematologicalExamination.TG = di_TG1.Value;
            Conf.currentPatient.hematologicalExamination.CEA = di_CEA.Value;

            Conf.currentPatient.hematologicalExamination.K = di_K.Value;
            Conf.currentPatient.hematologicalExamination.Na = di_Na.Value;
            Conf.currentPatient.hematologicalExamination.Cl = di_Cl.Value;
            Conf.currentPatient.hematologicalExamination.Ca = di_Ca.Value;
            Conf.currentPatient.hematologicalExamination.P = di_P.Value;

            //DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id);

        }


        void RefreshDatabase(object sender, EventArgs e)
        {
            if (DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id))
            {
                ToastNotification.Show(Parent, "系统数据保存成功");

            }
        }
        #region 将回车键绑定TAB键
        /// <summary>
        /// 将回车键绑定TAB键
        /// </summary>
        private void cbe_TI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion

    }
}
