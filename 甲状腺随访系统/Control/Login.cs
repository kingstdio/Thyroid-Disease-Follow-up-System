using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using 甲状腺随访系统.MODEL;

namespace 甲状腺随访系统.Control
{ 
   public class Login
    {
        public static bool LoginIn(string username,string password) 
        {
            DataTable dtUser = DAO.UserInfo.getUserInfo(username);
            if (dtUser.Rows.Count > 0)
            {
                Control.RefreshPatient.TableToModel<User>(Conf.currentUser, dtUser);
                if (Conf.currentUser.password == password)
                {
                    Conf.currentUser.lastlogintime = System.DateTime.Now;
                    Console.WriteLine(Conf.currentUser.lastlogintime);
                    Console.WriteLine(Conf.currentUser.id);
                    return true;

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
         
        }
        public static void UpdateLastLTime()
        {
            DAO.UserInfo.UpdateUserTime();
        }
       
           
    }
}
