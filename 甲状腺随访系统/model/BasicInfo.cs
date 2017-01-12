using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.model
{
    public class BasicInfo
    {
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 患者身份证号
        /// </summary>
        public string idcard { get; set; }

        /// <summary>
        /// 居住地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 备用电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 住院号
        /// </summary>
        public string hosnumber { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool sex { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime birthday { get; set; }

        /// <summary>
        /// 住院年龄
        /// </summary>
        public int hosage { get; set; }

        /// <summary>
        /// 住院日期
        /// </summary>
        public DateTime hosindate { get; set; }

        /// <summary>
        /// 出院日期
        /// </summary>
        public DateTime hosoutdate { get; set; }
    }
}
