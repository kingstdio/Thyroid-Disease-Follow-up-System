using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 甲状腺随访系统.DAO
{
    public class PatientInfo
    {
        private static string sql = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataRow getBasicInfo(int pid) {
            string sql = @"select id,name,idcard,address,mobile,phone,hosnumber,sex,birthday,hosindate,hosoutdate from tb_patientInfo where id=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
             return SQLHELPER.ExecuteDataRow(sql,param);

        }

        public static DateTime getLastFollowDate(int pid)
        {
            sql = @"select top 1 Vdate from tb_visit where pid=@id order by Vdate desc";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            DateTime Vdate = Convert.ToDateTime(SQLHELPER.ExecuteScalar(sql, param));
            return Vdate;
        }

        public static int getFollowTimes(int pid) 
        {
            sql = @"select Count(Vdate) from tb_visit where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            int num = Convert.ToInt32(SQLHELPER.ExecuteScalar(sql, param));
         
           
            return num;
        }
    }
}
