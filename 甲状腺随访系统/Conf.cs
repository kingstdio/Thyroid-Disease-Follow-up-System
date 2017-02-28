using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 甲状腺随访系统.model;

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
        public static string conn = @"Data Source=127.0.0.1;Initial Catalog=follw_up_DB;User ID=sa;Password =saadmin";

        public static string sqliteConn = @"Data Source=./dbs/his.db;Pooling=true;FailIfMissing=false";

        public static Patient currentPatient = new Patient();


        public static RF_main mainForm;
    }
}
