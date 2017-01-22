using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    class ImageExamination
    {
        /// <summary>
        /// （二维超声）TI-RADS级
        /// </summary>
        public string tirads { get; set; }

        /// <summary>
        /// 部
        /// </summary>
        public string part { get; set; }

        /// <summary>
        /// 淋巴结转移
        /// </summary>
        public bool tdlymphnodemetastisis { get; set; }

        /// <summary>
        /// 备注（区）
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// （超声造影）是否考虑为甲状腺癌
        /// </summary>
        public bool ucthyroidcancer { get; set; }

        /// <summary>
        /// 弹性影响评分
        /// </summary>
        public int elasticimpactrating { get; set; }

        /// <summary>
        /// （CT/MRI）是否考虑为甲状腺癌
        /// </summary>
        public bool ctthyroidcancer { get; set; }

        /// <summary>
        /// 是否考虑为淋巴结转移
        /// </summary>
        public bool ctlymphnodemetastisis { get; set; }

        /// <summary>
        /// （术前喉镜）喉镜情况
        /// </summary>
        public string laryngoscope { get; set; }

        /// <summary>
        /// 诊断
        /// </summary>
        public string diagnosis { get; set; }

       

       



    }


}
