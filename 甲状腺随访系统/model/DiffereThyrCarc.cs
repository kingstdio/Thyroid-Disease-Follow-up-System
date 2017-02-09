using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class DiffereThyrCarc
    {
        /// <summary>
        /// （乳头状癌）最大肿瘤直径
        /// </summary>
        public Double PCmaxtumordiameter { get; set; }

        /// <summary>
        /// 所有肿瘤直径和
        /// </summary>
        public Double PCalltumordiameter { get; set; }

        /// <summary>
        /// 所有肿瘤直径范围
        /// </summary>
        public Double PCalltumorrange { get; set; }

        /// <summary>
        /// 多灶性
        /// </summary>
        public bool PCmulifocality { get; set; }

        /// <summary>
        /// 双侧癌
        /// </summary>
        public bool PCbilateralcancer { get; set; }

        /// <summary>
        /// 被膜侵犯
        /// </summary>
        public string PCcapsuleinvasion { get; set; }

        /// <summary>
        /// 淋巴结转移
        /// </summary>
        public bool PClymphaticmetastasis { get; set; }

        /// <summary>
        /// 伴淋巴细胞甲状腺炎
        /// </summary>
        public bool PClymphocyticthyroiditis { get; set; }

        /// <summary>
        /// 亚型
        /// </summary>
        public string PChypotype { get; set; }

        /// <summary>
        /// （滤泡性癌）最大肿瘤直径
        /// </summary>
        public Double FCmaxtumordiameter { get; set; }

        /// <summary>
        /// 所有肿瘤直径和
        /// </summary>
        public Double FCalltumordiameter { get; set; }

        /// <summary>
        /// 所有肿瘤直径范围
        /// </summary>
        public Double FCalltumorrange { get; set; }

        /// <summary>
        /// 多灶性
        /// </summary>
        public bool FCmulifocality { get; set; }

        /// <summary>
        /// 双侧癌
        /// </summary>
        public bool FCbilateralcancer { get; set; }

        /// <summary>
        /// 被膜侵犯
        /// </summary>
        public string FCcapsuleinvasion { get; set; }

        /// <summary>
        /// 淋巴结转移
        /// </summary>
        public bool FClymphaticmetastasis { get; set; }

        /// <summary>
        /// 伴淋巴细胞甲状腺炎
        /// </summary>
        public bool FClymphocyticthyroiditis { get; set; }
    }
}
