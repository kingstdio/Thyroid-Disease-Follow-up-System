using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 甲状腺随访系统.DAO
{
    public class PatientInfo
    {
        private static string sql = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataTable getBasicInfo(int pid) {
            //string sql = @"select id,name,idcard,address,mobile,phone,hosnumber,sex,birthday,hosindate,hosoutdate from tb_patientInfo where id=@id";
            string sql = @"select * from tb_patientInfo where id=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
             return SQLHELPER.ExecuteDataTable(sql,param);
        }

        public static DataTable getDiagnosis(int pid)
        {
            string sql = @"select * from tb_diagnosis where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getSurgeryHistory(int pid)
        {
            string sql = @"select * from tb_surgeryHistory where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getPostOperative(int pid)
        {
            string sql = @"select * from tb_postOperative where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getFollowUp(int pid)
        {
            string sql = @"select * from tb_followUp where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getRecurrencecs(int pid)
        {
            string sql = @"select * from tb_recurrencecs where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getInspectionAfterSurgery(int pid)
        {
            string sql = @"select t.days,t.PTH,t.Ca,t.P,t.AP,t.D,t.D2,t.D3 from tb_inspectionAfterSurgery t where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getRadioactiveIodine(int pid)
        {
            string sql = @"select t.TSH,t.FT3,t.FT4,t.sTG,t.ATG,t.iodrate from tb_radioactiveIodine t where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getVisit(int pid)
        {
            string sql = @"select t.Vdate,t.TSH,t.FT3,t.FT4,t.TPO,t.PTH,t.ATG,t.TG,t.TGAb,t.Ca,t.P,t.euthyrox,t.Cadosage,t.sideeffect,t.others from tb_visit t where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DateTime getLastFollowDate(int pid)
        {
            sql = @"select top 1 Vdate from tb_visit where pid=@id order by Vdate desc";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            DateTime Vdate = Convert.ToDateTime(SQLHELPER.ExecuteScalar(sql, param));
            return Vdate;
        }

        public static int getFollowTimes(int pid) 
        {
            sql = @"select Count(Vdate) from tb_visit where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            int num = Convert.ToInt32(SQLHELPER.ExecuteScalar(sql, param));
         
           
            return num;
        }

        public static DataTable getVisit()
        {
            //string sql = @"select * from tb_visit";
            string sql = @"select id as '编号自增',
                    pid as '患者编号',
                    Vdate as '随访日期',
                    TSH as 'TSH',
                    FT3 as 'FT3',
                    FT4 as 'FT4',
                    TPO as 'TPO',
                    PTH as 'PTH',
                    ATG as 'A-TG',
                    TG as 'TG',
                    TGAb as 'TG-Ab',
                    Ca as 'Ca',
                    P as 'P',
                    euthyrox as '优甲乐剂量',
                    Cadosage as '钙剂量',
                    sideeffect as '副作用',
                    others as '其它'
                    from tb_visit";
            return SQLHELPER.ExecuteDataTable(sql);
        }

 


        public static DataTable getInfo()
        {
            string sql = @"select t.id   as '编号自增',
		t.name   as '患者姓名',
		t.idcard   as '身份证号',
		t.[address]   as '居住地址',
		t.mobile   as '移动电话',
		t.phone   as '备用电话',
        t.email   as '电子邮件',
        t.wechat  as '微信号',
		t.hosnumber   as ' 住院号',
		(case when t.sex=1 then '男' when t.sex=0 then '女' else null end) as 性别,
		t.birthday   as '出生日期',
		t.hosage   as '住院年龄',
		t.hosindate   as '住院日期',
		t.hosoutdate   as '出院日期',
		t.resident   as '居住区域',
		t.menophaniaage   as '初潮年龄',
		t.pregnancyage   as '初孕年龄',
		t.pregnancytimes   as '怀孕次数',
		t.abortiontimes   as '流产次数',
		t.deliverytimes   as '正常分娩次数',
		t.menopause   as '是否绝经',
        t.lastmenstr as '末次月经',
		t.smoke   as '是否吸烟',
		t.drink   as '是否饮酒',
		t.occupation   as '职业',
		t.height   as '身高',
		t.weight   as '体重',
		t.constitutional   as '体质指数',
		t.prolactin   as '泌乳素',
		t.estradiol   as '雌二醇',
		t.pregnendione   as '孕酮',
		t.testosterone   as '睾酮',
		t.luteinizing   as '促黄体激素',
		t.folliclestimulating   as '促卵泡刺激素',
		t.cholesterol   as '胆固醇',
		t.llipoprotein   as '低密度脂蛋白',
		t.hlipoprotein   as '高密度脂蛋白',
		t.triglyceride   as '甘油三酯',
		t.bloodGlucose   as '血糖',
		t.hypertension   as '是否为高血压',
		t.diabetes   as '是否为糖尿病',
		t.coronary   as '是否为冠心病',
		t.radiotherapy   as '颈部放射治疗史',
		t.otherntumour   as '是否有其它恶性肿瘤',
		t.otherntumourtext   as '其它恶性肿瘤内容',
		t.otherptumour   as '是否有其它良性肿瘤',
		t.othernoptumourtext   as '其它良性肿瘤内容',
		t.familyhistory   as '是否有家族甲状腺病史',
		t.familyhistorytext   as '家族甲状腺病史内容',
        d.tirads as '（二维超声）TI-RADS级',
        d.part  as '部',
        d.tdlymphnodemetastisis as '淋巴结转移',
        d.remark  as '备注（区）',
        d.ucthyroidcancer as '（超声造影）是否考虑为甲状腺癌',
        d.elasticimpactrating as '弹性影响评分',
        d.ctthyroidcancer as '（CT/MRI）是否考虑为甲状腺癌',
        d.ctlymphnodemetastisis as '是否考虑为淋巴结转移',
        d.laryngoscope as '（术前喉镜）喉镜情况',
        d.diagnosis  as '诊断',
        d.Bethesda as '（甲状腺FNA）Bethesda报告级别',
        d.thyroidbraf as 'Braf基因',
        d.thyroidRAS as 'RAS基因',
        d.thyroidTERT as 'TERT基因',
        d.thyroidPTC1 as 'RET/PTC1',
        d.thyroidPTC3 as 'RET/PTC3',
        d.thyroidPAX8 as 'PAX8/PPARG',
        d.lymphnodesFNA  as '（淋巴结FNA）FNA',
        d.lymphnodesbraf as 'B-raf基因',
        d.lymphnodestg as 'Tg洗脱液',
        d.TSH as '（甲功）TSH',
        d.ATG as 'ATG',
        d.CT as 'CT',
        d.FT3 as 'FT3',
        d.ATPO as 'A-TPO',
        d.TG as 'TG',
        d.FT4 as 'FT4',
        d.PTH as 'PTH',
        d.CEA as 'CEA',
        d.K as '（离子）K',
        d.Ca as 'Ca',
        d.Na as 'Na',
        d.P as 'P',
        d.Cl as 'Cl',
        d.uI as 'uI',
        s.surgerytime as '手术时间',
        s.surgerytype as '手术类型',
        s.surgeryfrequency as '手术次数',
        s.doctor as '术者',
        s.leftlobe as '（甲状腺根治术）左叶',
        s.rightlobe as '右叶',
        s.leftVI as '左VI区',
        s.rightVI as '右VI区',
        s.leftneck as '左侧颈',
        s.rightneck as '右侧颈',
        s.ROTCOthers as '其它（甲根）',
        s.PCmaxtumordiameter as '（乳头状癌）最大肿瘤直径',
        s.PCalltumordiameter as 'P所有肿瘤直径和',
        s.PCalltumorrange as 'P所有肿瘤直径范围（小）',
        s.PCall2 as 'P所有肿瘤直径范围（大）',
        s.PCmulifocality as 'P多灶性',
        s.PCbilateralcancer as 'P双侧癌',
        s.PCcapsuleinvasion as 'P被膜侵犯',
        s.PClymphaticmetastasis as 'P淋巴结转移',
        s.PClymphocyticthyroiditis as 'P伴淋巴细胞甲状腺炎',
        s.PChypotype as 'P亚型',
        s.FCmaxtumordiameter as '（滤泡性癌）最大肿瘤直径',
        s.FCalltumordiameter as 'F所有肿瘤直径和',
        s.FCalltumorrange as 'F所有肿瘤直径范围（小）',
        s.FCall2 as 'F所有肿瘤直径范围（大）',
        s.FCmulifocality as 'F多灶性',
        s.FCbilateralcancer as 'F双侧癌',
        s.FCcapsuleinvasion as 'F被膜侵犯',
        s.FClymphaticmetastasis as 'F淋巴结转移',
        s.FClymphocyticthyroiditis as 'F伴淋巴细胞甲状腺炎',
        s.MCmaxtumordiameter as '（髓样癌）最大肿瘤直径',
        s.MCalltumordiameter as 'M所有肿瘤直径和',
        s.MCalltumorrange as 'M所有肿瘤直径范围（小）',
        s.MCall2 as 'M所有肿瘤直径范围（大）',
        s.MCmulifocality as 'M多灶性',
        s.MCbilateralcancer as 'M双侧癌',
        s.MCcapsuleinvasion as 'M被膜侵犯',
        s.MClymphaticmetastasis as 'M淋巴结转移',
        s.MClymphocyticthyroiditis as 'M伴淋巴细胞甲状腺炎',
        s.MChypotype as 'M亚型',
        s.Ileftn as 'I区左',
        s.Ileftd as ' ',
        s.Irightn as 'I区右',
        s.Irightd as ' ',
        s.IIleftn as 'II区左',
        s.IIleftd as ' ',
        s.IIrightn as 'II区右',
        s.IIrightd as  ' ',
        s.IIIleftn as 'III区左',
        s.IIIleftd as ' ',
        s.IIIrightn as 'III区右',
        s.IIIrightd as ' ',
        s.IVleftn as 'IV区左',
        s.IVleftd as ' ',
        s.IVrightn as 'IV区右',
        s.IVrightd as ' ',
        s.Vleftn as 'V区左',
        s.Vleftd as ' ',
        s.Vrightn as 'V区右',
        s.Vrightd as ' ',
        s.VIleftn as 'VI区左',
        s.VIleftd as ' ',
        s.VIrightn as 'VI去右',
        s.VIrightd as ' ',
        s.prelaryngealn as '喉前',
        s.prelaryngeald as ' ',
        s.region as '区',
        s.regionleftn as '区左',
        s.regionleftd as ' ',
        s.regionrightn as '区右',
        s.regionrightd as ' ',
        s.carbonnano as '是否使用碳纳米',
        s.primarytumors as '原发性肿瘤T',
        s.RLNM as '区域淋巴转移N',
        s.distantmetastasis as '远处转移M',
        s.PTNM as 'PTNM分期',
        s.nerveMonitor as '是否使用神经监测',
        s.V1 as 'V1',
        s.V2 as 'V2',
        s.R1 as 'R1',
        s.R2 as 'R2',
        s.otherthyroidcancer as '其它甲状腺癌',
        s.melecularneuropathology as '分子病理',
        s.TGT as '（免疫组化）TGT/TG',
        s.CK as 'CK',
        s.CK19 as 'CK19',
        s.CD151 as 'CD151',
        s.galecins3 as '半乳凝素-3',
        s.calctionin as '降钙素',
        s.braf as 'Braf',
        s.Ki67 as 'Ki67（%）',
        s.cyclinD1 as 'CyclingD1',
        s.HBME1 as 'HBME-1',
        s.TTF1 as 'TTF-1',
        s.VEGF as 'VEGF',
        s.others as '其它',
        p.euthyrox as '（药物治疗）优甲乐',
        p.chemotherapy as '化疗方案及计量',
        p.radiotherapy as '放疗方案及计量',
        p.hoarseness as '（常规项）声音嘶哑',
        p.dyspnea as '呼吸困难',
        p.drinkchok as '饮水呛咳',
        p.hyperspasmia as '抽搐',
        p.galactorrhea as '淋巴漏或乳漏',
        p.infection as '感染',
        p.Bparalysis as '（术后声带B超）麻痹',
        p.Bhypomotility as '运动减弱',
        p.PLparalysis as '（术后喉镜）麻痹',
        p.PLhypomotility as '运动减弱',
        p.VocalChange as '    语调改变',
        p.bleed as '出血',
        r.TG as '（血清学指标）TG',
        r.TGAB as 'TGAB',
        r.CEA as 'CEA',
        r.calcitonin as '降钙素',
        r.CT as '（影响学指标）CT',
        r.MRI as 'MRI',
        r.I131 as 'I131',
        r.PETCT as 'PET-CT',
        r.FNA as '（组织病理学）FNA',
        r.braf as 'B-raf',
        r.TGeluant as 'TG洗脱液',
        r.tumorlocation as '（肿瘤）位置',
        r.tumorsize as '（肿瘤）大小',
        r.lymphadenlocation as '（淋巴结）位置',
        r.lymphadensize as '（淋巴结）大小'
		from tb_patientInfo t
        left join tb_diagnosis d
        on t.id = d.pid
        left join tb_surgeryHistory s
        on t.id = s.pid
        left join tb_postOperative p
        on t.id = p.pid
        left join tb_recurrencecs r
        on t.id = r.pid";
            return SQLHELPER.ExecuteDataTable(sql);
        }

    }
}
