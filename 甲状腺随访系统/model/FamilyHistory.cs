using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class FamilyHistory
    {


        /// <summary>
        /// 是否为高血压
        /// </summary>
        public bool hypertension { get; set; }

        /// <summary>
        /// 是否为糖尿病
        /// </summary>
        public bool diabetes { get; set; }

        /// <summary>
        /// 是否为冠心病
        /// </summary>
        public bool coronary { get; set; }

        /// <summary>
        /// 颈部放射治疗史
        /// </summary>
        public bool radiotherapy { get; set; }

        /// <summary>
        /// 是否有其它恶性肿瘤
        /// </summary>
        public bool otherntumour { get; set; }

        /// <summary>
        /// 其它恶性肿瘤内容
        /// </summary>
        public string otherntumourtext { get; set; }

        /// <summary>
        /// 是否有其它良性肿瘤
        /// </summary>
        public bool otherptumour { get; set; }

        /// <summary>
        /// 其它良性肿瘤内容
        /// </summary>
        public string othernoptumourtext { get; set; }

        /// <summary>
        /// 是否有家族甲状腺病史
        /// </summary>
        public bool familyhistory { get; set; }

        /// <summary>
        /// 家族甲状腺病史内容
        /// </summary>
        public string familyhistorytext { get; set; }
    }
}
