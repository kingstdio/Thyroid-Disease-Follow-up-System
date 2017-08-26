using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class Recurrencecs
    {
        /// <summary>
        /// 是否考虑复发
        /// </summary>
        public bool recurrent { get; set; }

        /// <summary>
        /// （血清学指标）TG
        /// </summary>
        public string TG { get; set; }

        /// <summary>
        /// TGAB
        /// </summary>
        public string TGAB { get; set; }

        /// <summary>
        /// CEA
        /// </summary>
        public string CEA { get; set; }

        /// <summary>
        /// 降钙素
        /// </summary>
        public string calcitonin { get; set; }

        /// <summary>
        /// （影响学指标）CT
        /// </summary>
        public string CT { get; set; }

        /// <summary>
        /// MRI
        /// </summary>
        public string MRI { get; set; }

        /// <summary>
        /// I131
        /// </summary>
        public string I131 { get; set; }

        /// <summary>
        /// PETCT
        /// </summary>
        public string PETCT { get; set; }

        /// <summary>
        /// （组织病理学）FNA
        /// </summary>
        public string FNA { get; set; }

        /// <summary>
        /// B-raf
        /// </summary>
        public bool braf { get; set; }

        /// <summary>
        /// TG洗脱液
        /// </summary>
        public string TGeluant { get; set; }

        /// <summary>
        /// （肿瘤）位置
        /// </summary>
        public string tumorlocation { get; set; }

        /// <summary>
        /// （肿瘤）大小
        /// </summary>
        public string tumorsize { get; set; }

        /// <summary>
        /// （淋巴结）位置
        /// </summary>
        public string lymphadenlocation { get; set; }

        /// <summary>
        /// （淋巴结）大小
        /// </summary>
        public string lymphadensize { get; set; }

    }
}
