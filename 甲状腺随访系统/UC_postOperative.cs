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
    public partial class UC_postOperative : UserControl
    {
        public UC_postOperative()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        private void line8_Click(object sender, EventArgs e)
        {

        }

        private void bt_saveMT_Click(object sender, EventArgs e)
        {

        }

        private void sideNavPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void fillUI(object obj, EventArgs args)
        {
            //术后治疗
            dtb_eut.Value = Conf.currentPatient.therapy.euthyrox;
            Console.WriteLine(Conf.currentPatient.therapy.euthyrox);
            rtbe_chemotherapy.Text = Conf.currentPatient.therapy.chemotherapy;
            rtbe_radiotherapy.Text = Conf.currentPatient.therapy.radiotherapy;

            //术后并发症
            cbe_hoarseness.SelectedIndex = cbe_hoarseness.FindString(Conf.currentPatient.complication.hoarseness);
            cbe_dyspnea.SelectedIndex = cbe_dyspnea.FindString(Conf.currentPatient.complication.dyspnea);
            cbe_drinkchok.SelectedIndex = cbe_drinkchok.FindString(Conf.currentPatient.complication.drinkchok);
            cbe_hyperspasmia.SelectedIndex = cbe_hyperspasmia.FindString(Conf.currentPatient.complication.hyperspasmia);
            switch_galactorrhea.Value = Conf.currentPatient.complication.galactorrhea;
            switch_infection.Value = Conf.currentPatient.complication.infection;
            cbe_Bparalysis.SelectedIndex = cbe_Bparalysis.FindString(Conf.currentPatient.complication.Bparalysis);
            cbe_Bhypomotility.SelectedIndex = cbe_Bhypomotility.FindString(Conf.currentPatient.complication.Bhypomotility);
            cbe_PLparalysis.SelectedIndex = cbe_PLparalysis.FindString(Conf.currentPatient.complication.PLparalysis);
            cbe_PLhypomotility.SelectedIndex = cbe_PLhypomotility.FindString(Conf.currentPatient.complication.PLhypomotility);
            cbe_VocalChange.SelectedIndex = cbe_VocalChange.FindString(Conf.currentPatient.complication.VocalChange);
            switch_bleed.Value = Conf.currentPatient.complication.bleed;
            dgv_inspect.DataSource = DAO.PatientInfo.getInspectionAfterSurgery(Conf.currentPatient.id);
            dgv_radio.DataSource = DAO.PatientInfo.getRadioactiveIodine(Conf.currentPatient.id);
        }

    }
}
