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
    public partial class UC_surgeryHistory : UserControl
    {
        public UC_surgeryHistory()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        private void sideNavPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbe_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void fillUI(object obj, EventArgs args)
        {
            //基础手术资料
            dti_DS.Value = Conf.currentPatient.basicOperInfo.surgerytime;
            cbe_surgeryType1.SelectedIndex = cbe_surgeryType1.FindString(Conf.currentPatient.basicOperInfo.surgerytype);
            cbe_surgeryTime.SelectedIndex = cbe_surgeryTime.FindString(Conf.currentPatient.basicOperInfo.surgeryfrequency);
            cbe_Doctor.SelectedIndex = cbe_Doctor.FindString(Conf.currentPatient.basicOperInfo.doctor);

            cbe_LL.SelectedIndex = cbe_LL.FindString(Conf.currentPatient.basicOperInfo.leftlobe);
            cbe_RL.SelectedIndex = cbe_RL.FindString(Conf.currentPatient.basicOperInfo.rightlobe);
            cbe_LVI.SelectedIndex = cbe_RVI.FindString(Conf.currentPatient.basicOperInfo.leftVI);
            cbe_RVI.SelectedIndex = cbe_RVI.FindString(Conf.currentPatient.basicOperInfo.rightVI);
            cbe_LN.SelectedIndex = cbe_LN.FindString(Conf.currentPatient.basicOperInfo.rightneck);
            cbe_RN.SelectedIndex = cbe_RN.FindString(Conf.currentPatient.basicOperInfo.rightneck);

            //分化型甲状腺癌
            di_PCmax.Value = Conf.currentPatient.differeThyrCarc.FCmaxtumordiameter;
            di_PCall.Value = Conf.currentPatient.differeThyrCarc.PCalltumordiameter;
            di_PCallrange.Value = Conf.currentPatient.differeThyrCarc.PCalltumorrange;
            switch_PCmuli.Value = Conf.currentPatient.differeThyrCarc.PCmulifocality;
            switch_PCbilcancer.Value = Conf.currentPatient.differeThyrCarc.PCbilateralcancer;
            cbe_PCCI.SelectedIndex = cbe_PCCI.FindString(Conf.currentPatient.differeThyrCarc.PCcapsuleinvasion);
            switch_PClymmeta.Value = Conf.currentPatient.differeThyrCarc.PClymphaticmetastasis;
            switch_PClymthy.Value = Conf.currentPatient.differeThyrCarc.PClymphocyticthyroiditis;
            cbe_subtype.SelectedIndex = cbe_subtype.FindString(Conf.currentPatient.differeThyrCarc.PChypotype);

            di_FCmax.Value = Conf.currentPatient.differeThyrCarc.FCmaxtumordiameter;
            di_FCall.Value = Conf.currentPatient.differeThyrCarc.FCalltumordiameter;
            di_FCallrange.Value = Conf.currentPatient.differeThyrCarc.FCalltumorrange;
            switch_FCmuli.Value = Conf.currentPatient.differeThyrCarc.FCmulifocality;
            switch_FCbilcancer.Value = Conf.currentPatient.differeThyrCarc.FCbilateralcancer;
            cbe_FCCI.SelectedIndex = cbe_FCCI.FindString(Conf.currentPatient.differeThyrCarc.FCcapsuleinvasion);
            switch_FClymmeta.Value = Conf.currentPatient.differeThyrCarc.FClymphaticmetastasis;
            switch_FClymthy.Value = Conf.currentPatient.differeThyrCarc.FClymphocyticthyroiditis;
            //淋巴结转移
            tb_Iregion1.Text = Convert.ToString(Conf.currentPatient.lympMeta.Ileftn);
            tb_Iregion2.Text = Convert.ToString(Conf.currentPatient.lympMeta.Ileftd);
            tb_Iregion3.Text = Convert.ToString(Conf.currentPatient.lympMeta.Irightn);
            tb_Iregion4.Text = Convert.ToString(Conf.currentPatient.lympMeta.Irightd);

            tb_IIregion1.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIleftn);
            tb_IIregion2.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIleftd);
            tb_IIregion3.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIrightn);
            tb_IIregion4.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIrightd);

            tb_IIIregion1.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIIleftn);
            tb_IIIregion2.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIIleftd);
            tb_IIIregion3.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIIrightn);
            tb_IIIregion4.Text = Convert.ToString(Conf.currentPatient.lympMeta.IIIrightd);

            tb_IVregion1.Text = Convert.ToString(Conf.currentPatient.lympMeta.IVleftn);
            tb_IVregion2.Text = Convert.ToString(Conf.currentPatient.lympMeta.IVleftd);
            tb_IVregion3.Text = Convert.ToString(Conf.currentPatient.lympMeta.IVrightn);
            tb_IVregion4.Text = Convert.ToString(Conf.currentPatient.lympMeta.IVrightd);

            tb_Vregion1.Text = Convert.ToString(Conf.currentPatient.lympMeta.Vleftn);
            tb_Vregion2.Text = Convert.ToString(Conf.currentPatient.lympMeta.Vleftd);
            tb_Vregion3.Text = Convert.ToString(Conf.currentPatient.lympMeta.Vrightn);
            tb_Vregion4.Text = Convert.ToString(Conf.currentPatient.lympMeta.Vrightd);

            tb_VIregion1.Text = Convert.ToString(Conf.currentPatient.lympMeta.VIleftn);
            tb_VIregion2.Text = Convert.ToString(Conf.currentPatient.lympMeta.VIleftd);
            tb_VIregion3.Text = Convert.ToString(Conf.currentPatient.lympMeta.VIrightn);
            tb_VIregion4.Text = Convert.ToString(Conf.currentPatient.lympMeta.VIrightd);

            tb_region.Text = Conf.currentPatient.lympMeta.region;
            tb_region1.Text = Convert.ToString(Conf.currentPatient.lympMeta.regionleftn);
            tb_region2.Text = Convert.ToString(Conf.currentPatient.lympMeta.regionleftd);
            tb_region3.Text = Convert.ToString(Conf.currentPatient.lympMeta.regionrightn);
            tb_region4.Text = Convert.ToString(Conf.currentPatient.lympMeta.regionrightd);

            tb_prelaryngeal1.Text = Convert.ToString(Conf.currentPatient.lympMeta.prelaryngealn);
            tb_prelaryngeal2.Text = Convert.ToString(Conf.currentPatient.lympMeta.prelaryngeald);

            switch_carbonnano.Value = Conf.currentPatient.lympMeta.carbonnano;
            cbe_PT.SelectedIndex = cbe_PT.FindString(Conf.currentPatient.lympMeta.primarytumors);
            cbe_NI.SelectedIndex = cbe_NI.FindString(Conf.currentPatient.lympMeta.RLNM);
            cbe_DM.SelectedIndex = cbe_DM.FindString(Conf.currentPatient.lympMeta.distantmetastasis);
            cbe_pStage.SelectedIndex = cbe_pStage.FindString(Conf.currentPatient.lympMeta.PTNM);

            //其它甲状腺癌及免疫组化

            cbe_otherthy.SelectedIndex = cbe_otherthy.FindString(Conf.currentPatient.otherThyrCarc.otherthyroidcancer);
            switch_mele.Value = Conf.currentPatient.otherThyrCarc.melecularneuropathology;
            cbe_TGTTG.SelectedIndex = cbe_TGTTG.FindString(Conf.currentPatient.otherThyrCarc.TGT);
            cbe_CK.SelectedIndex = cbe_CK.FindString(Conf.currentPatient.otherThyrCarc.CK);
            cbe_CK19.SelectedIndex = cbe_CK19.FindString(Conf.currentPatient.otherThyrCarc.CK19);
            cbe_CD151.SelectedIndex = cbe_CD151.FindString(Conf.currentPatient.otherThyrCarc.CD151);
            cbe_Gal3.SelectedIndex = cbe_Gal3.FindString(Conf.currentPatient.otherThyrCarc.galecins3);
            cbe_calc.SelectedIndex = cbe_calc.FindString(Conf.currentPatient.otherThyrCarc.calctionin);
            cbe_braf.SelectedIndex = cbe_braf.FindString(Conf.currentPatient.otherThyrCarc.braf);
            tb_Ki.Text = Conf.currentPatient.otherThyrCarc.Ki67;
            cbe_cyc.SelectedIndex = cbe_cyc.FindString(Conf.currentPatient.otherThyrCarc.cyclinD1);
            cbe_hbme.SelectedIndex = cbe_hbme.FindString(Conf.currentPatient.otherThyrCarc.HBME1);
            cbe_TTF.SelectedIndex = cbe_TTF.FindString(Conf.currentPatient.otherThyrCarc.TTF1);
            tb_VEGF.Text = Conf.currentPatient.otherThyrCarc.VEGF;
            tb_other.Text = Conf.currentPatient.otherThyrCarc.others;
        }


    }
}
