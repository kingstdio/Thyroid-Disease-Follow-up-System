using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 甲状腺随访系统.DAO
{
    public class PatientChoose
    {
        public static DataTable fill(string name,string idcard, string phone, string hosnum) 
        {
            string sql = @"select 
                                id as 编号,name as 姓名,
                                (case when sex=1 then '男' when sex=0 then '女' else null end) as 性别,
                                idcard as 身份证号, 
                                mobile as 电话号, 
                                hosnumber as 住院号,
                                address as 地址 from tb_patientInfo where 1=1";
            if (!string.IsNullOrEmpty(name)) { sql += " and name=@name"; }
            if (!string.IsNullOrEmpty(idcard)) { sql += " and idcard=@idcard"; }
            if (!string.IsNullOrEmpty(phone)) { sql += " and mobile=@mobile"; }
            if (!string.IsNullOrEmpty(hosnum)) { sql += " and hosnumber=@hosnumber"; }
            Console.WriteLine(phone);


            SqlParameter[] param = { new SqlParameter("@name",name),new SqlParameter("@idcard",idcard),new SqlParameter("@mobile",phone),new SqlParameter("@hosnumber",hosnum)};

            DataTable dt = SQLHELPER.ExecuteDataTable(sql, param);
            return dt; 
            name = idcard = phone = hosnum = null; 
        }
    }
}
