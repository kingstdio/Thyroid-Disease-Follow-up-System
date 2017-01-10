using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.model
{
    class Patient
    {
        /// <summary>
        /// 系统编号
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 患者身份证号
        /// </summary>
        public string idcard { get; set; }
    }
}
