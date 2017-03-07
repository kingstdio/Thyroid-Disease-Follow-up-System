using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 甲状腺随访系统.model;
using System.Configuration;

namespace 甲状腺随访系统
{
    public class Conf
    {
        /// <summary>
        /// 语言配置文件路径
        /// </summary>
        public static string langpath = Environment.CurrentDirectory + @"\data\conf\lang\CN.ini";

        /// <summary>
        /// 数据库连接字符串SQLSERVER
        /// </summary>
        public static string conn = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public static string sqliteConn = @"Data Source=./data/dbs/his.db;Pooling=true;FailIfMissing=false";

        /// <summary>
        /// 当前操作用户
        /// </summary>
        public static Patient currentPatient = new Patient();


        /// <summary>
        /// 主窗口
        /// </summary>
        public static RF_main mainForm;

        /// <summary>
        /// 获得程序版本
        /// </summary>
        public static string appVersion = ConfigurationManager.AppSettings.GetValues(0)[0].ToString();


    }
}
