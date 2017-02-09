using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class Visit
    {
        /// <summary>
        /// 随访日期
        /// </summary>
        public DateTime Vdate { get; set; }

        /// <summary>
        /// TSH
        /// </summary>
        public Double TSH { get; set; }

        /// <summary>
        /// FT3
        /// </summary>
        public Double FT3 { get; set; }

        /// <summary>
        /// FT4
        /// </summary>
        public Double FT4 { get; set; }

        /// <summary>
        /// TPO
        /// </summary>
        public Double TPO { get; set; }

        /// <summary>
        /// PTH
        /// </summary>
        public Double PTH { get; set; }

        /// <summary>
        /// ATG
        /// </summary>
        public Double ATG { get; set; }

        /// <summary>
        /// TG
        /// </summary>
        public Double TG { get; set; }

        /// <summary>
        /// TGAb
        /// </summary>
        public Double TGAb { get; set; }

        /// <summary>
        /// Ca
        /// </summary>
        public Double Ca { get; set; }

        /// <summary>
        /// P
        /// </summary>
        public Double P { get; set; }

        /// <summary>
        /// 优甲乐剂量
        /// </summary>
        public Double euthyrox { get; set; }

        /// <summary>
        /// 钙剂量
        /// </summary>
        public Double Cadosage { get; set; }

        /// <summary>
        ///副作用
        /// </summary>
        public string sideeffect { get; set; }
    }
}
