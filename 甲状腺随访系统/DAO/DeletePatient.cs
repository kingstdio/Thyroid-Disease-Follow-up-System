using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using 甲状腺随访系统.model;
using System.Threading;
using DevComponents.DotNetBar;

namespace 甲状腺随访系统.DAO
{
    public class DeletePatient
    {
        public static bool DelPatient(int pid)
        {
      
            try
            {
                    string sql = "delete tb_patientInfo where id =@id;delete tb_diagnosis where id =@id;delete tb_surgeryHistory where id =@id;delete tb_postOperative where id =@id;delete tb_followUp where id =@id;delete tb_recurrencecs where id =@id;delete tb_visit where pid=@id;delete tb_inspectionAfterSurgery where pid=@id;delete tb_radioactiveIodine where pid=@id;";
                    SqlParameter[] param = { new SqlParameter("@id", pid) };
                    SQLHELPER.ExecuteNoneQuery(sql, param);
                    return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                //出现异常提示更新失败
            }
            
        }
    }
}
