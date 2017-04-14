using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class BasicOperInfo
    {
        /// <summary>
        /// 手术时间
        /// </summary>
        public DateTime surgerytime { get; set; }

        /// <summary>
        /// 手术类型
        /// </summary>
        public string surgerytype { get; set; }

        /// <summary>
        /// 手术次数
        /// </summary>
        public string surgeryfrequency { get; set; }

        /// <summary>
        /// 术者
        /// </summary>
        public string doctor { get; set; }

        /// <summary>
        /// （甲状腺根治术）左叶
        /// </summary>
        public string leftlobe { get; set; }

        /// <summary>
        /// 右叶
        /// </summary>
        public string rightlobe { get; set; }

        /// <summary>
        /// 左VI区
        /// </summary>
        public string leftVI { get; set; }

        /// <summary>
        /// 右VI区
        /// </summary>
        public string rightVI { get; set; }

        /// <summary>
        /// 左侧颈
        /// </summary>
        public string leftneck { get; set; }

        /// <summary>
        /// 右侧颈
        /// </summary>
        public string rightneck { get; set; }

        /// <summary>
        /// 其它
        /// </summary>
        public string ROTCOthers { get; set; }

       



      



    }
}
