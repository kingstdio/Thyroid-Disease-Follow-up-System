using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 甲状腺随访系统.MODEL;

namespace 甲状腺随访系统.model
{
    public class Patient
    {
        /// <summary>
        /// 系统编号
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 患者基本信息
        /// </summary>
        public BasicInfo basicInfo = new BasicInfo();

        /// <summary>
        /// 一般危险因素
        /// </summary>
        public NormalRiskFactors normalRiskFactors = new NormalRiskFactors();

        /// <summary>
        /// 特殊危险因素
        /// </summary>
        public SpecialRiskFactors specialRiskFactors = new SpecialRiskFactors();

        /// <summary>
        /// 家族史
        /// </summary>
        public FamilyHistory familyHistory = new FamilyHistory();

        /// <summary>
        /// 影像学检查
        /// </summary>
        public ImageExamination imageExamination = new ImageExamination();

        /// <summary>
        /// 组织学检查
        /// </summary>
        public HistologicalExamination histologicalExamination = new HistologicalExamination();

        /// <summary>
        /// 血液学检查
        /// </summary>
        public HematologicalExamination hematologicalExamination = new HematologicalExamination();

        /// <summary>
        /// 基础手术资料
        /// </summary>
        public BasicOperInfo basicOperInfo = new BasicOperInfo();

        /// <summary>
        /// 分化型甲状腺癌
        /// </summary>
        public DiffereThyrCarc differeThyrCarc = new DiffereThyrCarc();

        /// <summary>
        /// 淋巴结转移
        /// </summary>
        public LympMeta lympMeta = new LympMeta();

        /// <summary>
        /// 其他甲状腺癌及免疫组织化
        /// </summary>
        public OtherThyrCarc otherThyrCarc = new OtherThyrCarc();

        /// <summary>
        /// 术后治疗
        /// </summary>
        public Therapy therapy = new Therapy();

        /// <summary>
        /// 术后并发症
        /// </summary>
        public Complication complication = new Complication();

        /// <summary>
        /// 追踪
        /// </summary>
        public FollowUp followUp = new FollowUp();

        /// <summary>
        /// 复发
        /// </summary>
        public Recurrencecs recurrencecs = new Recurrencecs();

        /// <summary>
        /// 随访
        /// </summary>
        public Visit visit = new Visit();

        /// <summary>
        /// 碘治疗
        /// </summary>
        public RadioIodine radioIodine = new RadioIodine();
    
        /// <summary>
        /// 术后检查
        /// </summary>
        public InspecAfterSurg inspecAfterSurg = new InspecAfterSurg();


        /// <summary>
        /// 最近随访时间
        /// </summary>
        public DateTime lastFollowDate { get; set; }

        /// <summary>
        /// 随访次数
        /// </summary>
        public int followTimes { get; set; }

    }
}
