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
            tb_basicOther.Text = Conf.currentPatient.basicOperInfo.ROTCOthers;

            //常见甲状腺癌
            di_PCmax.Value = Conf.currentPatient.differeThyrCarc.FCmaxtumordiameter;
            di_PCall.Value = Conf.currentPatient.differeThyrCarc.PCalltumordiameter;
            di_PCallrange.Value = Conf.currentPatient.differeThyrCarc.PCalltumorrange;
            di_PCallrange2.Value = Conf.currentPatient.differeThyrCarc.PCall2;
            switch_PCmuli.Value = Conf.currentPatient.differeThyrCarc.PCmulifocality;
            switch_PCbilcancer.Text = Conf.currentPatient.differeThyrCarc.PCbilateralcancer;
            cbe_PCCI.SelectedIndex = cbe_PCCI.FindString(Conf.currentPatient.differeThyrCarc.PCcapsuleinvasion);
            switch_PClymmeta.Value = Conf.currentPatient.differeThyrCarc.PClymphaticmetastasis;
            switch_PClymthy.Value = Conf.currentPatient.differeThyrCarc.PClymphocyticthyroiditis;
            cbe_subtype.SelectedIndex = cbe_subtype.FindString(Conf.currentPatient.differeThyrCarc.PChypotype);

            di_FCmax.Value = Conf.currentPatient.differeThyrCarc.FCmaxtumordiameter;
            di_FCall.Value = Conf.currentPatient.differeThyrCarc.FCalltumordiameter;
            di_FCallrange.Value = Conf.currentPatient.differeThyrCarc.FCalltumorrange;
            di_FCallrange2.Value = Conf.currentPatient.differeThyrCarc.FCall2;
            switch_FCmuli.Value = Conf.currentPatient.differeThyrCarc.FCmulifocality;
            switch_FCbilcancer.Text = Conf.currentPatient.differeThyrCarc.FCbilateralcancer;
            cbe_FCCI.SelectedIndex = cbe_FCCI.FindString(Conf.currentPatient.differeThyrCarc.FCcapsuleinvasion);
            switch_FClymmeta.Value = Conf.currentPatient.differeThyrCarc.FClymphaticmetastasis;
            switch_FClymthy.Value = Conf.currentPatient.differeThyrCarc.FClymphocyticthyroiditis;

            di_MCmax.Value = Conf.currentPatient.differeThyrCarc.MCmaxtumordiameter;
            di_MCall.Value = Conf.currentPatient.differeThyrCarc.MCalltumordiameter;
            di_MCallrange.Value = Conf.currentPatient.differeThyrCarc.MCalltumorrange;
            di_MCallrange2.Value = Conf.currentPatient.differeThyrCarc.MCall2;
            switch_MCmuli.Value = Conf.currentPatient.differeThyrCarc.MCmulifocality;
            switch_MCbilcancer.Text = Conf.currentPatient.differeThyrCarc.MCbilateralcancer;
            cbe_MCCI.SelectedIndex = cbe_PCCI.FindString(Conf.currentPatient.differeThyrCarc.MCcapsuleinvasion);
            switch_MClymmeta.Value = Conf.currentPatient.differeThyrCarc.MClymphaticmetastasis;
            switch_MClymthy.Value = Conf.currentPatient.differeThyrCarc.MClymphocyticthyroiditis;
            //cbe_MCsubtype.SelectedIndex = cbe_subtype.FindString(Conf.currentPatient.differeThyrCarc.MChypotype);
            cbe_sub.SelectedIndex = cbe_sub.FindString(Conf.currentPatient.differeThyrCarc.MChypotype);
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
            di_V1.Value = Conf.currentPatient.lympMeta.V1;
            di_V2.Value = Conf.currentPatient.lympMeta.V2;
            di_R1.Value = Conf.currentPatient.lympMeta.R1;
            di_R2.Value = Conf.currentPatient.lympMeta.R2;

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

        void InsertData(object obj, EventArgs args)
        {
            //基础手术资料
            Conf.currentPatient.basicOperInfo.surgerytime = dti_DS.Value;
            Conf.currentPatient.basicOperInfo.surgerytype = cbe_surgeryType1.Text;
            Conf.currentPatient.basicOperInfo.surgeryfrequency = cbe_surgeryTime.Text;
            Conf.currentPatient.basicOperInfo.doctor = cbe_Doctor.Text;

            Conf.currentPatient.basicOperInfo.leftlobe = cbe_LL.Text;
            Conf.currentPatient.basicOperInfo.rightlobe = cbe_RL.Text;
            Conf.currentPatient.basicOperInfo.leftVI = cbe_LVI.Text;
            Conf.currentPatient.basicOperInfo.rightVI = cbe_RVI.Text;
            Conf.currentPatient.basicOperInfo.rightneck = cbe_LN.Text;
            Conf.currentPatient.basicOperInfo.rightneck = cbe_RN.Text;
            Conf.currentPatient.basicOperInfo.ROTCOthers = tb_basicOther.Text;

            //常见甲状腺癌
            Conf.currentPatient.differeThyrCarc.FCmaxtumordiameter = di_PCmax.Value;
            Conf.currentPatient.differeThyrCarc.PCalltumordiameter = di_PCall.Value;
            Conf.currentPatient.differeThyrCarc.PCalltumorrange = di_PCallrange.Value;
            Conf.currentPatient.differeThyrCarc.PCall2 = di_PCallrange2.Value;
            Conf.currentPatient.differeThyrCarc.PCmulifocality = switch_PCmuli.Value;
            Conf.currentPatient.differeThyrCarc.PCbilateralcancer = switch_PCbilcancer.Text;
            Conf.currentPatient.differeThyrCarc.PCcapsuleinvasion = cbe_PCCI.Text;
            Conf.currentPatient.differeThyrCarc.PClymphaticmetastasis = switch_PClymmeta.Value;
            Conf.currentPatient.differeThyrCarc.PClymphocyticthyroiditis = switch_PClymthy.Value;
            Conf.currentPatient.differeThyrCarc.PChypotype = cbe_subtype.Text;

            Conf.currentPatient.differeThyrCarc.FCmaxtumordiameter = di_FCmax.Value;
            Conf.currentPatient.differeThyrCarc.FCalltumordiameter = di_FCall.Value;
            Conf.currentPatient.differeThyrCarc.FCalltumorrange = di_FCallrange.Value;
            Conf.currentPatient.differeThyrCarc.FCall2 = di_FCallrange2.Value;
            Conf.currentPatient.differeThyrCarc.FCmulifocality = switch_FCmuli.Value;
            Conf.currentPatient.differeThyrCarc.FCbilateralcancer = switch_FCbilcancer.Text;
            Conf.currentPatient.differeThyrCarc.FCcapsuleinvasion = cbe_FCCI.Text;
            Conf.currentPatient.differeThyrCarc.FClymphaticmetastasis = switch_FClymmeta.Value;
            Conf.currentPatient.differeThyrCarc.FClymphocyticthyroiditis = switch_FClymthy.Value;

            Conf.currentPatient.differeThyrCarc.MCmaxtumordiameter = di_MCmax.Value;
            Conf.currentPatient.differeThyrCarc.MCalltumordiameter = di_MCall.Value;
            Conf.currentPatient.differeThyrCarc.MCalltumorrange = di_MCallrange.Value;
            Conf.currentPatient.differeThyrCarc.MCall2 = di_MCallrange2.Value;
            Conf.currentPatient.differeThyrCarc.MCmulifocality = switch_MCmuli.Value;
            Conf.currentPatient.differeThyrCarc.MCbilateralcancer = switch_MCbilcancer.Text;
            Conf.currentPatient.differeThyrCarc.MCcapsuleinvasion = cbe_MCCI.Text;
            Conf.currentPatient.differeThyrCarc.MClymphaticmetastasis = switch_MClymmeta.Value;
            Conf.currentPatient.differeThyrCarc.MClymphocyticthyroiditis = switch_MClymthy.Value;
            //Conf.currentPatient.differeThyrCarc.MChypotype = cbe_MCsubtype.Text;
            Conf.currentPatient.differeThyrCarc.MChypotype = cbe_sub.Text;

            //淋巴结转移
            Console.WriteLine(tb_Iregion1.Text);
            Conf.currentPatient.lympMeta.Ileftn = Convert.ToInt32(string.IsNullOrEmpty(tb_Iregion1.Text) ? "0":tb_Iregion1.Text);
            Conf.currentPatient.lympMeta.Ileftd = Convert.ToInt32(string.IsNullOrEmpty(tb_Iregion2.Text) ? "0" : tb_Iregion2.Text);
            Conf.currentPatient.lympMeta.Irightn = Convert.ToInt32(string.IsNullOrEmpty(tb_Iregion3.Text) ? "0" : tb_Iregion3.Text);
            Conf.currentPatient.lympMeta.Irightd = Convert.ToInt32(string.IsNullOrEmpty(tb_Iregion4.Text) ? "0" : tb_Iregion4.Text);

            Conf.currentPatient.lympMeta.IIleftn = Convert.ToInt32(string.IsNullOrEmpty(tb_IIregion1.Text) ? "0" : tb_IIregion1.Text);
            Conf.currentPatient.lympMeta.IIleftd = Convert.ToInt32(string.IsNullOrEmpty(tb_IIregion2.Text) ? "0" : tb_IIregion2.Text);
            Conf.currentPatient.lympMeta.IIrightn = Convert.ToInt32(string.IsNullOrEmpty(tb_IIregion3.Text) ? "0" : tb_IIregion3.Text);
            Conf.currentPatient.lympMeta.IIrightd = Convert.ToInt32(string.IsNullOrEmpty(tb_IIregion4.Text) ? "0" : tb_IIregion4.Text);

            Conf.currentPatient.lympMeta.IIIleftn = Convert.ToInt32(string.IsNullOrEmpty(tb_IIIregion1.Text) ? "0" : tb_IIIregion1.Text);
            Conf.currentPatient.lympMeta.IIIleftd = Convert.ToInt32(string.IsNullOrEmpty(tb_IIIregion2.Text) ? "0" : tb_IIIregion2.Text);
            Conf.currentPatient.lympMeta.IIIrightn = Convert.ToInt32(string.IsNullOrEmpty(tb_IIIregion3.Text) ? "0" : tb_IIIregion3.Text);
            Conf.currentPatient.lympMeta.IIIrightd = Convert.ToInt32(string.IsNullOrEmpty(tb_IIIregion4.Text) ? "0" : tb_IIIregion4.Text);

            Conf.currentPatient.lympMeta.IVleftn = Convert.ToInt32(string.IsNullOrEmpty(tb_IVregion1.Text) ? "0" : tb_IVregion1.Text);
            Conf.currentPatient.lympMeta.IVleftd = Convert.ToInt32(string.IsNullOrEmpty(tb_IVregion2.Text) ? "0" : tb_IVregion2.Text);
            Conf.currentPatient.lympMeta.IVrightn = Convert.ToInt32(string.IsNullOrEmpty(tb_IVregion3.Text) ? "0" : tb_IVregion3.Text);
            Conf.currentPatient.lympMeta.IVrightd = Convert.ToInt32(string.IsNullOrEmpty(tb_IVregion4.Text) ? "0" : tb_IVregion4.Text);

            Conf.currentPatient.lympMeta.Vleftn = Convert.ToInt32(string.IsNullOrEmpty(tb_Vregion1.Text) ? "0" : tb_Vregion1.Text);
            Conf.currentPatient.lympMeta.Vleftd = Convert.ToInt32(string.IsNullOrEmpty(tb_Vregion2.Text) ? "0" : tb_Vregion2.Text);
            Conf.currentPatient.lympMeta.Vrightn = Convert.ToInt32(string.IsNullOrEmpty(tb_Vregion3.Text) ? "0" : tb_Vregion3.Text);
            Conf.currentPatient.lympMeta.Vrightd = Convert.ToInt32(string.IsNullOrEmpty(tb_Vregion4.Text) ? "0" : tb_Vregion4.Text);

            Conf.currentPatient.lympMeta.VIleftn = Convert.ToInt32(string.IsNullOrEmpty(tb_VIregion1.Text) ? "0" : tb_VIregion1.Text);
            Conf.currentPatient.lympMeta.VIleftd = Convert.ToInt32(string.IsNullOrEmpty(tb_VIregion2.Text) ? "0" : tb_VIregion2.Text);
            Conf.currentPatient.lympMeta.VIrightn = Convert.ToInt32(string.IsNullOrEmpty(tb_VIregion3.Text) ? "0" : tb_VIregion3.Text);
            Conf.currentPatient.lympMeta.VIrightd = Convert.ToInt32(string.IsNullOrEmpty(tb_VIregion4.Text) ? "0" : tb_VIregion4.Text);

            Conf.currentPatient.lympMeta.region = tb_region.Text;
            Conf.currentPatient.lympMeta.regionleftn = Convert.ToInt32(string.IsNullOrEmpty(tb_region1.Text) ? "0" : tb_region1.Text);
            Conf.currentPatient.lympMeta.regionleftd = Convert.ToInt32(string.IsNullOrEmpty(tb_region2.Text) ? "0" : tb_region2.Text);
            Conf.currentPatient.lympMeta.regionrightn = Convert.ToInt32(string.IsNullOrEmpty(tb_region3.Text) ? "0" : tb_region3.Text);
            Conf.currentPatient.lympMeta.regionrightd = Convert.ToInt32(string.IsNullOrEmpty(tb_region4.Text) ? "0" : tb_region4.Text);

            Conf.currentPatient.lympMeta.prelaryngealn = Convert.ToInt32(string.IsNullOrEmpty(tb_prelaryngeal1.Text) ? "0" : tb_prelaryngeal1.Text);
            Conf.currentPatient.lympMeta.prelaryngeald = Convert.ToInt32(string.IsNullOrEmpty(tb_prelaryngeal2.Text) ? "0" : tb_prelaryngeal2.Text);
       
            Conf.currentPatient.lympMeta.carbonnano = switch_carbonnano.Value;
            Conf.currentPatient.lympMeta.primarytumors = cbe_PT.Text;
            Conf.currentPatient.lympMeta.RLNM = cbe_NI.Text;
            Conf.currentPatient.lympMeta.distantmetastasis = cbe_DM.Text;
            Conf.currentPatient.lympMeta.PTNM = cbe_pStage.Text;
            Conf.currentPatient.lympMeta.nerveMonitor = switch__nerveMonitor.Value;
            Conf.currentPatient.lympMeta.V1 = di_V1.Value;
            Conf.currentPatient.lympMeta.V2 = di_V2.Value;
            Conf.currentPatient.lympMeta.R1 = di_R1.Value;
            Conf.currentPatient.lympMeta.R2 = di_R2.Value;

            //其它甲状腺癌及免疫组化

            Conf.currentPatient.otherThyrCarc.otherthyroidcancer = cbe_otherthy.Text;
            Conf.currentPatient.otherThyrCarc.melecularneuropathology = switch_mele.Value;
            Conf.currentPatient.otherThyrCarc.TGT = cbe_TGTTG.Text;
            Conf.currentPatient.otherThyrCarc.CK = cbe_CK.Text;
            Conf.currentPatient.otherThyrCarc.CK19 = cbe_CK19.Text;
            Conf.currentPatient.otherThyrCarc.CD151 = cbe_CD151.Text;
            Conf.currentPatient.otherThyrCarc.galecins3 = cbe_Gal3.Text;
            Conf.currentPatient.otherThyrCarc.calctionin = cbe_calc.Text;
            Conf.currentPatient.otherThyrCarc.braf = cbe_braf.Text;
            Conf.currentPatient.otherThyrCarc.Ki67 = tb_Ki.Text;
            Conf.currentPatient.otherThyrCarc.cyclinD1 = cbe_cyc.Text;
            Conf.currentPatient.otherThyrCarc.HBME1 = cbe_hbme.Text;
            Conf.currentPatient.otherThyrCarc.TTF1 = cbe_TTF.Text;
            Conf.currentPatient.otherThyrCarc.VEGF = tb_VEGF.Text;
            Conf.currentPatient.otherThyrCarc.others = tb_other.Text;

           
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
        private void cbe_surgeryType1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion

        private void sideNavPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelX33_Click(object sender, EventArgs e)
        {

        }

    }

}
