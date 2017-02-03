using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class RadioIodine
    {
        /// <summary>
        /// TS
        /// </summary>
        public Double TS { get; set; }

        /// <summary>
        /// FT3
        /// </summary>
        public Double FT3 { get; set; }

        /// <summary>
        /// FT4
        /// </summary>
        public Double FT4 { get; set; }

        /// <summary>
        ///sTG
        /// </summary>
        public Double sTG { get; set; }

        /// <summary>
        /// ATG
        /// </summary>
        public Double ATG { get; set; }

        /// <summary>
        /// 吸碘率（%）
        /// </summary>
        public Double iodineuptakerate { get; set; }

    }
}
