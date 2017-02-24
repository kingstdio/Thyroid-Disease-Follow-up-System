using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using 甲状腺随访系统.MODEL;
using System.Windows.Forms;

namespace 甲状腺随访系统.DAO
{
    public class InsertPatient
    {
        //private static string sql = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static bool InsertBasicInfo(int pid)
        {
            int currentID = Conf.currentPatient.id;   
            //病人信息
            BasicInfo bi = Conf.currentPatient.basicInfo;
            NormalRiskFactors nrf = Conf.currentPatient.normalRiskFactors;
            SpecialRiskFactors srf = Conf.currentPatient.specialRiskFactors;
            FamilyHistory fh = Conf.currentPatient.familyHistory;
            //诊断
            ImageExamination ie = Conf.currentPatient.imageExamination;
            HematologicalExamination he = Conf.currentPatient.hematologicalExamination;
            HistologicalExamination hie = Conf.currentPatient.histologicalExamination;
            //手术史
            BasicOperInfo boi = Conf.currentPatient.basicOperInfo;
            DiffereThyrCarc dtc = Conf.currentPatient.differeThyrCarc;
            LympMeta lm = Conf.currentPatient.lympMeta;
            OtherThyrCarc otc = Conf.currentPatient.otherThyrCarc;
            //术后
            Therapy t = Conf.currentPatient.therapy;
            Complication c = Conf.currentPatient.complication;
            //追踪
            FollowUp fu = Conf.currentPatient.followUp;
            //复发
            Recurrencecs re = Conf.currentPatient.recurrencecs;
            //判断当前病患是否存在，若不存在则新增记录

            //if(!string.IsNullOrEmpty(bi.name)&&!string.IsNullOrWhiteSpace(bi.name)) 
            if ((!string.IsNullOrEmpty(bi.name) && !string.IsNullOrWhiteSpace(bi.name)) || (!string.IsNullOrEmpty(bi.idcard) && !string.IsNullOrWhiteSpace(bi.idcard)) || (!string.IsNullOrEmpty(bi.mobile) && !string.IsNullOrWhiteSpace(bi.mobile)) || (!string.IsNullOrEmpty(bi.hosnumber) && !string.IsNullOrWhiteSpace(bi.hosnumber)))
            {

                if (pid == 0)
                {
                    try
                    {
                        
                        //患者基本信息
                        string sql = "insert into tb_patientInfo values ('" + bi.name + "','" + bi.idcard + "','" + bi.address + "','" + bi.mobile + "','" + bi.phone + "','" + bi.hosnumber + "','" + bi.sex + "','" + bi.birthday + "','" + bi.hosage + "','" + bi.hosindate + "','" + bi.hosoutdate + "','" + nrf.resident + "','" + nrf.menophaniaage + "','" + nrf.pregnancyage + "','" + nrf.pregnancytimes + "','" + nrf.abortiontimes + "','" + nrf.deliverytimes + "','" + nrf.menopause + "','" + nrf.smoke + "','" + nrf.drink + "','" + nrf.occupation + "','" + nrf.height + "','" + nrf.weight + "','" + nrf.constitutional + "','" + srf.prolactin + "','" + srf.estradiol + "','" + srf.pregnendione + "','" + srf.testosterone + "','" + srf.luteinizing + "','" + srf.folliclestimulating + "','" + srf.cholesterol + "','" + srf.llipoprotein + "','" + srf.hlipoprotein + "','" + srf.triglyceride + "','" + srf.bloodGlucose + "','" + fh.hypertension + "','" + fh.diabetes + "','" + fh.coronary + "','" + fh.radiotherapy + "','" + fh.otherntumour + "','" + fh.otherntumourtext + "','" + fh.otherptumour + "','" + fh.othernoptumourtext + "','" + fh.familyhistory + "','" + fh.familyhistorytext + "');select @@identity";
                        //("'@Conf.currentPatient.basicInfo.name.ToString()'","' + Conf.currentPatient.basicInfo.idcard.ToString() + '","' + Conf.currentPatient.basicInfo.address.ToString() + '",'"+ Conf.currentPatient.basicInfo.mobile.ToString() + "')";
                        currentID = SQLHELPER.GetSingleResultInt(sql);

                        //诊断
                        string sqlD = "insert into tb_diagnosis values ('" + currentID + "','" + ie.tirads + "','" + ie.part + "','" + ie.tdlymphnodemetastisis + "','" + ie.remark + "','" + ie.ucthyroidcancer + "','" + ie.elasticimpactrating + "','" + ie.ctthyroidcancer + "','" + ie.ctlymphnodemetastisis + "','" + ie.laryngoscope + "','" + ie.diagnosis + "','" + hie.Bethesda + "','" + hie.thyroidbraf + "','" + hie.thyroidRAS + "','" + hie.thyroidTERT + "','" + hie.thyroidPTC1 + "','" + hie.thyroidPTC3 + "','" + hie.thyroidPAX8 + "','" + hie.lymphnodesFNA + "','" + hie.lymphnodesbraf + "','" + hie.lymphnodestg + "','" + he.TSH + "','" + he.ATG + "','" + he.CT + "','" + he.FT3 + "','" + he.ATPO + "','" + he.TG + "','" + he.FT4 + "','" + he.PTH + "','" + he.CEA + "','" + he.K + "','" + he.Ca + "','" + he.Na + "','" + he.P + "','" + he.Cl + "')";
                        SQLHELPER.ExecuteNoneQuery(sqlD);

                        //手术史
                        string sqlSH = "insert into tb_surgeryHistory values ('" + currentID + "','" + boi.surgerytime + "','" + boi.surgerytype + "','" + boi.surgeryfrequency + "','" + boi.doctor + "','" + boi.leftlobe + "','" + boi.rightlobe + "','" + boi.leftVI + "','" + boi.rightVI + "','" + boi.leftneck + "','" + boi.rightneck + "','" + dtc.PCmaxtumordiameter + "','" + dtc.PCalltumordiameter + "','" + dtc.PCalltumorrange + "','" + dtc.PCmulifocality + "','" + dtc.PCbilateralcancer + "','" + dtc.PCcapsuleinvasion + "','" + dtc.PClymphaticmetastasis + "','" + dtc.PClymphocyticthyroiditis + "','" + dtc.PChypotype + "','" + dtc.FCmaxtumordiameter + "','" + dtc.FCalltumordiameter + "','" + dtc.FCalltumorrange + "','" + dtc.FCmulifocality + "','" + dtc.FCbilateralcancer + "','" + dtc.FCcapsuleinvasion + "','" + dtc.FClymphaticmetastasis + "','" + dtc.FClymphocyticthyroiditis + "','" + lm.Ileftn + "','" + lm.Ileftd + "','" + lm.Irightn + "','" + lm.Irightd + "','" + lm.IIleftn + "','" + lm.IIleftd + "','" + lm.IIrightn + "','" + lm.IIrightd + "','" + lm.IIIleftn + "','" + lm.IIIleftd + "','" + lm.IIIrightn + "','" + lm.IIIrightd + "','" + lm.IVleftn + "','" + lm.IVleftd + "','" + lm.IVrightn + "','" + lm.IVrightd + "','" + lm.Vleftn + "','" + lm.Vleftd + "','" + lm.Vrightn + "','" + lm.Vrightd + "','" + lm.VIleftn + "','" + lm.VIleftd + "','" + lm.VIrightn + "','" + lm.VIrightd + "','" + lm.prelaryngealn + "','" + lm.prelaryngeald + "','" + lm.region + "','" + lm.regionleftn + "','" + lm.regionleftd + "','" + lm.regionrightn + "','" + lm.regionrightd + "','" + lm.carbonnano + "','" + lm.primarytumors + "','" + lm.RLNM + "','" + lm.distantmetastasis + "','" + lm.PTNM + "','" + otc.otherthyroidcancer + "','" + otc.melecularneuropathology + "','" + otc.TGT + "','" + otc.CK + "','" + otc.CK19 + "','" + otc.CD151 + "','" + otc.galecins3 + "','" + otc.calctionin + "','" + otc.braf + "','" + otc.Ki67 + "','" + otc.cyclinD1 + "','" + otc.HBME1 + "','" + otc.TTF1 + "','" + otc.VEGF + "','" + otc.others + "')";
                        SQLHELPER.ExecuteNoneQuery(sqlSH);

                        //术后
                        string sqlPO = "insert into tb_postOperative values('" + currentID + "','" + t.euthyrox + "','" + t.chemotherapy + "','" + t.radiotherapy + "','" + c.hoarseness + "','" + c.dyspnea + "','" + c.drinkchok + "','" + c.hyperspasmia + "','" + c.galactorrhea + "','" + c.infection + "','" + c.Bparalysis + "','" + c.Bhypomotility + "','" + c.PLparalysis + "','" + c.PLhypomotility + "','" + c.VocalChange + "','" + c.bleed + "')";
                        SQLHELPER.ExecuteNoneQuery(sqlPO);

                        //追踪
                        string sqlFU = "insert into tb_followUp values('" + currentID + "','" + fu.lastconnect + "','" + fu.distantmetastasislocation + "','" + fu.vitalstatus + "','" + fu.deathdate + "','" + fu.distantmetastasis + "','" + fu.deathcause + "','" + fu.diatantmetasisdate + "')";
                        SQLHELPER.ExecuteNoneQuery(sqlFU);

                        //复发
                        string sqlRe = "insert into tb_recurrencecs values('" + currentID + "','" + re.TG + "','" + re.TGAB + "','" + re.CEA + "','" + re.calcitonin + "','" + re.CT + "','" + re.MRI + "','" + re.I131 + "','" + re.PETCT + "','" + re.FNA + "','" + re.braf + "','" + re.TGeluant + "','" + re.tumorlocation + "','" + re.tumorsize + "','" + re.lymphadenlocation + "','" + re.lymphadensize + "')";
                        SQLHELPER.ExecuteNoneQuery(sqlRe);

                        Conf.currentPatient.id = currentID;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "更新失败！"+ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                        //出现异常提示更新失败
                    }
                }
                else
                {
                    try
                    {
                        //患者基本信息
                        string sql = "update tb_patientInfo set name = '" + bi.name + "',idcard = '" + bi.idcard + "',address = '" + bi.address + "',mobile = '" + bi.mobile + "' ,phone = '" + bi.phone + "',hosnumber = '" + bi.hosnumber + "',sex = '" + bi.sex + "',birthday = '" + bi.birthday + "',hosage = '" + bi.hosage + "',hosindate = '" + bi.hosindate + "',hosoutdate = '" + bi.hosoutdate + "',resident = '" + nrf.resident + "',menophaniaage = '" + nrf.menophaniaage + "',pregnancyage = '" + nrf.pregnancyage + "',pregnancytimes = '" + nrf.pregnancytimes + "',abortiontimes = '" + nrf.abortiontimes + "',deliverytimes = '" + nrf.deliverytimes + "',menopause = '" + nrf.menopause + "',smoke = '" + nrf.smoke + "',drink = '" + nrf.drink + "',occupation = '" + nrf.occupation + "',height = '" + nrf.height + "',weight = '" + nrf.weight + "',constitutional = '" + nrf.constitutional + "',prolactin = '" + srf.prolactin + "',estradiol = '" + srf.estradiol + "',pregnendione = '" + srf.pregnendione + "',testosterone = '" + srf.testosterone + "',luteinizing = '" + srf.luteinizing + "',folliclestimulating = '" + srf.folliclestimulating + "',cholesterol = '" + srf.cholesterol + "',llipoprotein = '" + srf.llipoprotein + "',hlipoprotein = '" + srf.hlipoprotein + "',triglyceride = '" + srf.triglyceride + "',bloodGlucose = '" + srf.bloodGlucose + "',hypertension = '" + fh.hypertension + "',diabetes = '" + fh.diabetes + "',coronary = '" + fh.coronary + "',radiotherapy = '" + fh.radiotherapy + "',otherntumour = '" + fh.otherntumour + "',otherntumourtext = '" + fh.otherntumourtext + "',otherptumour = '" + fh.otherptumour + "',othernoptumourtext = '" + fh.othernoptumourtext + "',familyhistory = '" + fh.familyhistory + "',familyhistorytext = '" + fh.familyhistorytext + "'where id = @id";
                        SqlParameter[] param = { new SqlParameter("@id", pid) };
                        SQLHELPER.ExecuteNoneQuery(sql, param);

                        //诊断
                        string sqlDU = "update tb_diagnosis set pid = '" + pid + "',tirads = '" + ie.tirads + "',part = '" + ie.part + "',tdlymphnodemetastisis = '" + ie.tdlymphnodemetastisis + "',remark = '" + ie.remark + "',ucthyroidcancer = '" + ie.ucthyroidcancer + "',elasticimpactrating = '" + ie.elasticimpactrating + "',ctthyroidcancer = '" + ie.ctthyroidcancer + "',ctlymphnodemetastisis = '" + ie.ctlymphnodemetastisis + "',laryngoscope = '" + ie.laryngoscope + "',diagnosis = '" + ie.diagnosis + "',Bethesda = '" + hie.Bethesda + "',thyroidbraf = '" + hie.thyroidbraf + "', thyroidRAS = '" + hie.thyroidRAS + "',thyroidTERT = '" + hie.thyroidTERT + "',thyroidPTC1 = '" + hie.thyroidPTC1 + "',thyroidPTC3 = '" + hie.thyroidPTC3 + "',thyroidPAX8 = '" + hie.thyroidPAX8 + "',lymphnodesFNA = '" + hie.lymphnodesFNA + "',lymphnodesbraf = '" + hie.lymphnodesbraf + "',lymphnodestg = '" + hie.lymphnodestg + "',TSH  = '" + he.TSH + "',ATG = '" + he.ATG + "',CT = '" + he.CT + "',FT3 = '" + he.FT3 + "',ATPO = '" + he.ATPO + "',TG = '" + he.TG + "',FT4 = '" + he.FT4 + "',PTH = '" + he.PTH + "',CEA = '" + he.CEA + "',K = '" + he.K + "',Ca = '" + he.Ca + "',Na = '" + he.Na + "',P = '" + he.P + "',Cl = '" + he.Cl + "'where pid = @id";
                        SqlParameter[] param1 = { new SqlParameter("@id", pid) };
                        SQLHELPER.ExecuteNoneQuery(sqlDU, param1);

                        //手术史
                        string sqlSHU = "update tb_surgeryHistory set pid = '" + pid + "',surgerytime = '" + boi.surgerytime + "',surgerytype = '" + boi.surgerytype + "',surgeryfrequency = '" + boi.surgeryfrequency + "',doctor = '" + boi.doctor + "',leftlobe = '" + boi.leftlobe + "',rightlobe = '" + boi.rightlobe + "',leftVI = '" + boi.leftVI + "',rightVI = '" + boi.rightVI + "',leftneck = '" + boi.leftneck + "',rightneck = '" + boi.rightneck + "',PCmaxtumordiameter = '" + dtc.PCmaxtumordiameter + "',PCalltumordiameter = '" + dtc.PCalltumordiameter + "',PCalltumorrange = '" + dtc.PCalltumorrange + "',PCmulifocality = '" + dtc.PCmulifocality + "',PCbilateralcancer = '" + dtc.PCbilateralcancer + "',PCcapsuleinvasion  = '" + dtc.PCcapsuleinvasion + "',PClymphaticmetastasis = '" + dtc.PClymphaticmetastasis + "',PClymphocyticthyroiditis = '" + dtc.PClymphocyticthyroiditis + "',PChypotype = '" + dtc.PChypotype + "',FCmaxtumordiameter = '" + dtc.FCmaxtumordiameter + "',FCalltumordiameter = '" + dtc.FCalltumordiameter + "',FCalltumorrange = '" + dtc.FCalltumorrange + "',FCmulifocality = '" + dtc.FCmulifocality + "',FCbilateralcancer = '" + dtc.FCbilateralcancer + "',FCcapsuleinvasion = '" + dtc.FCcapsuleinvasion + "',FClymphaticmetastasis = '" + dtc.FClymphaticmetastasis + "',FClymphocyticthyroiditis = '" + dtc.FClymphocyticthyroiditis + "',Ileftn = '" + lm.Ileftn + "',Ileftd = '" + lm.Ileftd + "',Irightn = '" + lm.Irightn + "',Irightd = '" + lm.Irightd + "',IIleftn = '" + lm.IIleftn + "',IIleftd = '" + lm.IIleftd + "',IIrightn = '" + lm.IIrightn + "',IIrightd = '" + lm.IIrightd + "',IIIleftn = '" + lm.IIIleftn + "',IIIleftd = '" + lm.IIIleftd + "',IIIrightn = '" + lm.IIIrightn + "',IIIrightd = '" + lm.IIIrightd + "',IVleftn = '" + lm.IVleftn + "',IVleftd = '" + lm.IVleftd + "',IVrightn = '" + lm.IVrightn + "',IVrightd = '" + lm.IVrightd + "',Vleftn = '" + lm.Vleftn + "',Vleftd = '" + lm.Vleftd + "',Vrightn = '" + lm.Vrightn + "',Vrightd = '" + lm.Vrightd + "',VIleftn = '" + lm.VIleftn + "',VIleftd = '" + lm.VIleftd + "',VIrightn = '" + lm.VIrightn + "',VIrightd = '" + lm.VIrightd + "',prelaryngealn = '" + lm.prelaryngealn + "',prelaryngeald = '" + lm.prelaryngeald + "',region = '" + lm.region + "',regionleftn = '" + lm.regionleftn + "',regionleftd = '" + lm.regionleftd + "',regionrightn = '" + lm.regionrightn + "',regionrightd = '" + lm.regionrightd + "',carbonnano = '" + lm.carbonnano + "',primarytumors = '" + lm.primarytumors + "',RLNM = '" + lm.RLNM + "',distantmetastasis = '" + lm.distantmetastasis + "',PTNM = '" + lm.PTNM + "',otherthyroidcancer = '" + otc.otherthyroidcancer + "',melecularneuropathology = '" + otc.melecularneuropathology + "',TGT = '" + otc.TGT + "',CK = '" + otc.CK + "',CK19 = '" + otc.CK19 + "',CD151 = '" + otc.CD151 + "',galecins3 = '" + otc.galecins3 + "',calctionin = '" + otc.calctionin + "',braf = '" + otc.braf + "',Ki67 = '" + otc.Ki67 + "',cyclinD1 = '" + otc.cyclinD1 + "',HBME1 = '" + otc.HBME1 + "',TTF1 = '" + otc.TTF1 + "',VEGF = '" + otc.VEGF + "',others = '" + otc.others + "'where pid = @id";
                        SqlParameter[] param2 = { new SqlParameter("@id", pid) };
                        SQLHELPER.ExecuteNoneQuery(sqlSHU, param2);

                        //术后
                        string sqlPOU = "update tb_postOperative set pid = '" + pid + "',euthyrox = '" + t.euthyrox + "',chemotherapy = '" + t.chemotherapy + "',radiotherapy = '" + t.radiotherapy + "',hoarseness = '" + c.hoarseness + "',dyspnea = '" + c.dyspnea + "',drinkchok = '" + c.drinkchok + "',hyperspasmia = '" + c.hyperspasmia + "',galactorrhea = '" + c.galactorrhea + "',infection = '" + c.infection + "',Bparalysis = '" + c.Bparalysis + "',Bhypomotility = '" + c.Bhypomotility + "',PLparalysis = '" + c.PLparalysis + "',PLhypomotility = '" + c.PLhypomotility + "',VocalChange = '" + c.VocalChange + "',bleed = '" + c.bleed + "'where pid = @id";
                        SqlParameter[] param3 = { new SqlParameter("@id", pid) };
                        SQLHELPER.ExecuteNoneQuery(sqlPOU, param3);

                        //追踪
                        string sqlFUU = "update tb_followUp set pid = '" + pid + "',lastconnect = '" + fu.lastconnect + "',distantmetastasislocation = '" + fu.distantmetastasislocation + "',vitalstatus = '" + fu.vitalstatus + "',deathdate = '" + fu.deathdate + "',distantmetastasis = '" + fu.distantmetastasis + "',deathcause = '" + fu.deathcause + "',diatantmetasisdate = '" + fu.diatantmetasisdate + "'where pid = @id ";
                        SqlParameter[] param4 = { new SqlParameter("@id", pid) };
                        SQLHELPER.ExecuteNoneQuery(sqlFUU, param4);

                        //复发
                        string sqlReU = "update tb_recurrencecs set pid = '" + pid + "',TG = '" + re.TG + "',TGAB = '" + re.TGAB + "',CEA = '" + re.CEA + "',calcitonin = '" + re.calcitonin + "',CT = '" + re.CT + "',MRI = '" + re.MRI + "',I131 = '" + re.I131 + "',PETCT = '" + re.PETCT + "',FNA = '" + re.FNA + "',braf = '" + re.braf + "',TGeluant = '" + re.TGeluant + "',tumorlocation = '" + re.tumorlocation + "',tumorsize = '" + re.tumorsize + "',lymphadenlocation = '" + re.lymphadenlocation + "',lymphadensize = '" + re.lymphadensize + "'where pid = @id";
                        SqlParameter[] param5 = { new SqlParameter("@id", pid) };
                        SQLHELPER.ExecuteNoneQuery(sqlFUU, param5);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "更新失败！" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

       

    }
}
