using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int id { get; set; } 


        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public string privilege { get; set; }

        /// <summary>
        /// 是否被禁
        /// </summary>
        public bool forbidden { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime lastlogintime { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string email { get; set; } 
    }
}
