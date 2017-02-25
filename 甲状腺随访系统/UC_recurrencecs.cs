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
    public partial class UC_recurrencecs : UserControl
    {
        public UC_recurrencecs()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        private void lb_CEUS_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void sideNavPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void switchButton10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sideNav1_Click(object sender, EventArgs e)
        {

        }

        private void sni_recurrencecs_Click(object sender, EventArgs e)
        {

        }

        private void sideNav1_Click_1(object sender, EventArgs e)
        {

        }

        private void lb_MRI_Click(object sender, EventArgs e)
        {

        }
        void fillUI(object obj, EventArgs args)
        {
            //复发检查
            tb_TG.Text = Conf.currentPatient.recurrencecs.TG;
            tb_TGAB.Text = Conf.currentPatient.recurrencecs.TGAB;
            tb_CEA.Text = Conf.currentPatient.recurrencecs.CEA;
            tb_calcitonin.Text = Conf.currentPatient.recurrencecs.calcitonin;

            tb_CT.Text = Conf.currentPatient.recurrencecs.CT;
            tb_MRI.Text = Conf.currentPatient.recurrencecs.MRI;
            tb_I131.Text = Conf.currentPatient.recurrencecs.I131;
            tb_PET.Text = Conf.currentPatient.recurrencecs.PETCT;

            tb_FNA.Text = Conf.currentPatient.recurrencecs.FNA;
            switch_braf.Value = Conf.currentPatient.recurrencecs.braf;
            tb_TGEluant.Text = Conf.currentPatient.recurrencecs.TGeluant;

            tb_location.Text = Conf.currentPatient.recurrencecs.tumorlocation;
            tb_size.Text = Conf.currentPatient.recurrencecs.tumorsize;

            tb_lymphadenLoc.Text = Conf.currentPatient.recurrencecs.lymphadenlocation;
            tb_lymphadenSize.Text = Conf.currentPatient.recurrencecs.lymphadensize;
        }
        void InsertData(object obj, EventArgs args)
        {
            //复发检查
            Conf.currentPatient.recurrencecs.TG = tb_TG.Text;
            Conf.currentPatient.recurrencecs.TGAB = tb_TGAB.Text;
            Conf.currentPatient.recurrencecs.CEA = tb_CEA.Text;
            Conf.currentPatient.recurrencecs.calcitonin = tb_calcitonin.Text;

            Conf.currentPatient.recurrencecs.CT = tb_CT.Text;
            Conf.currentPatient.recurrencecs.MRI = tb_MRI.Text;
            Conf.currentPatient.recurrencecs.I131 = tb_I131.Text;
            Conf.currentPatient.recurrencecs.PETCT = tb_PET.Text;

            Conf.currentPatient.recurrencecs.FNA = tb_FNA.Text;
            Conf.currentPatient.recurrencecs.braf = switch_braf.Value;
            Conf.currentPatient.recurrencecs.TGeluant = tb_TGEluant.Text;

            Conf.currentPatient.recurrencecs.tumorlocation = tb_location.Text;
            Conf.currentPatient.recurrencecs.tumorsize = tb_size.Text;

            Conf.currentPatient.recurrencecs.lymphadenlocation = tb_lymphadenLoc.Text;
            Conf.currentPatient.recurrencecs.lymphadensize = tb_lymphadenSize.Text;

            
        }



        void RefreshDatabase(object sender, EventArgs e)
        {
            if (DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id))
            {
                ToastNotification.Show(Parent, "系统数据保存成功");

            }
        }


    }
}
