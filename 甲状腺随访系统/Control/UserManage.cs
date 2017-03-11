using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 甲状腺随访系统.Control 
{
    public class UserManage 
    {
        //获取所有用户
        public static DataTable getAllUser()
        {
            return DAO.UserInfo.getAllUser();
        }
        //新增用户
        public static bool InsertUser()
        {
            return DAO.UserInfo.InsertUser();
        }
        //更新用户
        public static bool UpdateUser()
        {
            return DAO.UserInfo.UpdateUser();
        }
        //删除用户
        public static bool DeleteUser()
        {
            return DAO.UserInfo.DeleteUser();
                        
        }
        //检查重名
        public static bool CheckSameName(string username)
        {
            return DAO.UserInfo.checkSameName(username);

        }


    }
}
