using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using System.Data.SqlClient;

namespace 甲状腺随访系统
{
    public partial class UC_followUp : UserControl
    {
        public UC_followUp()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void superGridControl1_Click(object sender, EventArgs e)
        {
           
        }
        void fillUI(object obj, EventArgs args)
        {
            //追踪
            dti_DLC.Value = Conf.currentPatient.followUp.lastconnect;
            cbe_VS.SelectedIndex = cbe_VS.FindString(Conf.currentPatient.followUp.vitalstatus);
            cbe_DM.SelectedIndex = cbe_DM.FindString(Conf.currentPatient.followUp.distantmetastasis);
            dti_dismetadate.Value = Conf.currentPatient.followUp.diatantmetasisdate;
            cbe_LDM.SelectedIndex = cbe_LDM.FindString(Conf.currentPatient.followUp.distantmetastasislocation);
            dti_DD.Value = Conf.currentPatient.followUp.deathdate;
            cbe_CD.SelectedIndex = cbe_CD.FindString(Conf.currentPatient.followUp.deathcause);
           // sgc_visit.PrimaryGrid.DataSource = Conf.currentPatient.visit;
           // Application.DoEvents();

            sgc_visit.PrimaryGrid.DataSource = DAO.PatientInfo.getVisit(Conf.currentPatient.id);
           
         
        }

    }
}
