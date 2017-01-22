using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    class Visit
    {
        /// <summary>
        /// 随访日期
        /// </summary>
        public DateTime Vdate { get; set; }

        /// <summary>
        /// TSH
        /// </summary>
        public float TSH { get; set; }

        /// <summary>
        /// FT3
        /// </summary>
        public float FT3 { get; set; }

        /// <summary>
        /// FT4
        /// </summary>
        public float FT4 { get; set; }

        /// <summary>
        /// TPO
        /// </summary>
        public float TPO { get; set; }

        /// <summary>
        /// PTH
        /// </summary>
        public float PTH { get; set; }

        /// <summary>
        /// ATG
        /// </summary>
        public float ATG { get; set; }

        /// <summary>
        /// TG
        /// </summary>
        public float TG { get; set; }

        /// <summary>
        /// TGAb
        /// </summary>
        public float TGAb { get; set; }

        /// <summary>
        /// Ca
        /// </summary>
        public float Ca { get; set; }

        /// <summary>
        /// P
        /// </summary>
        public float P { get; set; }

        /// <summary>
        /// 优甲乐剂量
        /// </summary>
        public float euthyrox { get; set; }

        /// <summary>
        /// 钙剂量
        /// </summary>
        public float Cadosage { get; set; }

        /// <summary>
        ///副作用
        /// </summary>
        public string sideeffect { get; set; }
    }
}
