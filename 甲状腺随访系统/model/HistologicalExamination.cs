using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class HistologicalExamination
    {
        /// <summary>
        /// （甲状腺FNA）Bethesda报告级别
        /// </summary>
        public string Bethesda { get; set; }

        /// <summary>
        /// Braf基因
        /// </summary>
        public string thyroidbraf { get; set; }

        /// <summary>
        /// RAS基因
        /// </summary>
        public string thyroidRAS { get; set; }

        /// <summary>
        /// TERT基因
        /// </summary>
        public string thyroidTERT { get; set; }

        /// <summary>
        /// RET/PTC1
        /// </summary>
        public string thyroidPTC1 { get; set; }

        /// <summary>
        /// RET/PTC3
        /// </summary>
        public string thyroidPTC3 { get; set; }

        /// <summary>
        /// PAX8/PPARG
        /// </summary>
        public string thyroidPAX8 { get; set; }

        /// <summary>
        /// （淋巴结FNA）FNA
        /// </summary>
        public string lymphnodesFNA { get; set; }

        /// <summary>
        /// B-raf基因
        /// </summary>
        public string lymphnodesbraf { get; set; }

        /// <summary>
        /// Tg洗脱液
        /// </summary>
        public float lymphnodestg { get; set; }
    }
}
