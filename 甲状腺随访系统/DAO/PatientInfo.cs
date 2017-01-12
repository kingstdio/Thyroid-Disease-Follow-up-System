using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 甲状腺随访系统.DAO
{
    public class PatientInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public static DataRow getBasicInfo(int pid) {
            string sql = @"select * from tb_patientInfo";
             return SQLHELPER.ExecuteDataRow(sql);

        }
    }
}
