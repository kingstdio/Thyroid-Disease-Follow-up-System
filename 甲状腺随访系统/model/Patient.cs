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


        /// <summary>
        /// 居住地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string mobile { get; set; }

        public string phone { get; set; }

        public string hosnumber { get; set; }

        public bool sex { get; set; }
       
    }
}
