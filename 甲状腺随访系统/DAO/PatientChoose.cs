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
                                p.id as 编号,p.name as 姓名,
                                (case when p.sex=1 then '男' when p.sex=0 then '女' else null end) as 性别,
                                p.hosage as 年龄,
                                t.surgerytime as 手术时间,
                                p.idcard as 身份证号, 
                                p.mobile as 电话号, 
                                p.hosnumber as 住院号,
                                p.address as 地址 from tb_patientInfo p
                                left join tb_surgeryHistory t 
                                on p.id = t.pid where 1=1";
            if (!string.IsNullOrEmpty(name)) { sql += " and p.name=@name"; }
            if (!string.IsNullOrEmpty(idcard)) { sql += " and p.idcard=@idcard"; }
            if (!string.IsNullOrEmpty(phone)) { sql += " and p.mobile=@mobile"; }
            if (!string.IsNullOrEmpty(hosnum)) { sql += " and p.hosnumber=@hosnumber"; }
            Console.WriteLine(phone);


            SqlParameter[] param = { new SqlParameter("@name",name),new SqlParameter("@idcard",idcard),new SqlParameter("@mobile",phone),new SqlParameter("@hosnumber",hosnum)};

            DataTable dt = SQLHELPER.ExecuteDataTable(sql, param);
            return dt; 
            
        }
    }
}
