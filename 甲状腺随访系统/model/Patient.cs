using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public Imageology imageology = new Imageology();

    }
}
