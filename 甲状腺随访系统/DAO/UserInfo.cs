using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 甲状腺随访系统.DAO
{
    class UserInfo
    {
        private static string sql = string.Empty;

        #region 查询
        public static DataTable getUserInfo(string username)
        {         
            sql = @"select * from tb_user where username=@username";
            SqlParameter[] param = { new SqlParameter("@username", username) };
            return SQLHELPER.ExecuteDataTable(sql, param);
        }

        public static bool UpdateUserTime()
        {
            sql = @"update tb_user set lastlogintime ='" + Conf.currentUser.lastlogintime + "' where id=@id";
            SqlParameter[] param = { new SqlParameter( "@id", Conf.currentUser.id)};
            SQLHELPER.ExecuteNoneQuery(sql, param);
            return true;
        }

        public static DataTable getAllUser()
        {
            sql = @"select * from tb_user";
            return SQLHELPER.ExecuteDataTable(sql);
                
        }

        public static bool checkSameName(string username)
        {
            sql = @"select username from tb_user where username=@username";
            SqlParameter[] param = { new SqlParameter("@username", username) };
            DataTable dt = SQLHELPER.ExecuteDataTable(sql,param);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region 增加新用户
        public static bool InsertUser()
        {
            sql = @"insert into tb_user values('" + Conf.manageUser.username + "','" + Conf.manageUser.password + "','" + Conf.manageUser.privilege + "','" + Conf.manageUser.forbidden + "',null,'" + Conf.manageUser.phone + "','" + Conf.manageUser.email + "')";
            SQLHELPER.ExecuteNoneQuery(sql);
            return true;
        }
        #endregion

        #region 更新用户
        public static bool UpdateUser()
        {
            sql = @"update tb_user set username = '" + Conf.manageUser.username + "',password = '" + Conf.manageUser.password + "',privilege= '" + Conf.manageUser.privilege + "',forbidden = '" + Conf.manageUser.forbidden + "',phone ='" + Conf.manageUser.phone + "',email = '" + Conf.manageUser.email + "'where id =@id";
            SqlParameter[] param = { new SqlParameter("@id", Conf.manageUser.id)};
            SQLHELPER.ExecuteNoneQuery(sql,param);
            return true;
        }
        #endregion

        #region 删除用户
        public static bool DeleteUser()
        {
            sql = @"delete tb_user where id=@id";
            SqlParameter[] param = { new SqlParameter("@id", Conf.manageUser.id) };
            SQLHELPER.ExecuteNoneQuery(sql, param);
            return true;
        }
        #endregion
    }
}
