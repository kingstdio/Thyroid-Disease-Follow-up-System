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
        public static DataTable getBasicInfo(int pid) {
            //string sql = @"select id,name,idcard,address,mobile,phone,hosnumber,sex,birthday,hosindate,hosoutdate from tb_patientInfo where id=@id";
            string sql = @"select * from tb_patientInfo where id=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
             return SQLHELPER.ExecuteDataTable(sql,param);
        }

        public static DataTable getDiagnosis(int pid)
        {
            string sql = @"select * from tb_diagnosis where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getSurgeryHistory(int pid)
        {
            string sql = @"select * from tb_surgeryHistory where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getPostOperative(int pid)
        {
            string sql = @"select * from tb_postOperative where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getFollowUp(int pid)
        {
            string sql = @"select * from tb_followUp where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getRecurrencecs(int pid)
        {
            string sql = @"select * from tb_recurrencecs where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getInspectionAfterSurgery(int pid)
        {
            string sql = @"select t.days,t.PTH,t.Ca,t.P,t.AP,t.D,t.D2,t.D3 from tb_inspectionAfterSurgery t where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getRadioactiveIodine(int pid)
        {
            string sql = @"select t.TS,t.FT3,t.FT4,t.sTG,t.ATG,t.iodrate from tb_radioactiveIodine t where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static DataTable getVisit(int pid)
        {
            string sql = @"select t.Vdate,t.TSH,t.FT3,t.FT4,t.TPO,t.PTH,t.ATG,t.TG,t.TGAb,t.Ca,t.P,t.euthyrox,t.Cadosage,t.sideeffect,t.others from tb_visit t where pid=@id";
            SqlParameter[] param = { new SqlParameter("@id", pid) };
            return SQLHELPER.ExecuteDataTable(sql, param);
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
