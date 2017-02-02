using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class FollowUp
    {
        /// <summary>
        /// 最后联系时间
        /// </summary>
        public DateTime lastconnect { get; set; }

        /// <summary>
        /// 远处转移位置
        /// </summary>
        public string distantmetastasislocation { get; set; }

        /// <summary>
        /// 生死状态
        /// </summary>
        public string vitalstatus { get; set; }

        /// <summary>
        /// 死亡日期
        /// </summary>
        public DateTime deathdate { get; set; }

        /// <summary>
        /// 远处转移
        /// </summary>
        public string distantmetastasis { get; set; }

        /// <summary>
        /// 死亡原因
        /// </summary>
        public string deathcause { get; set; }

        /// <summary>
        /// 远处转移日期
        /// </summary>
        public DateTime diatantmetasisdate { get; set; }
    }
}
