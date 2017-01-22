using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 甲状腺随访系统.Control
{
    /// <summary>
    /// 更新病人信息
    /// </summary>
    public class RefreshPatient
    {

        /// <summary>
        /// 更新病人信息
        /// </summary>
        /// <returns>成功：true；失败：false；</returns>
        public static bool refresh(int pid) 
        {
            Conf.currentPatient.id = pid;
            DataRow dr= DAO.PatientInfo.getBasicInfo(pid);



            Conf.currentPatient.basicInfo.name =  dr["name"].ToString();
            Conf.currentPatient.basicInfo.hosnumber = dr["hosnumber"].ToString();
            Conf.currentPatient.basicInfo.mobile = dr["mobile"].ToString();
            Conf.currentPatient.basicInfo.phone = dr["phone"].ToString();
            Conf.currentPatient.basicInfo.hosindate = Convert.ToDateTime(dr["hosindate"]);
            Conf.currentPatient.basicInfo.sex = Convert.ToBoolean(dr["sex"]);
            Conf.currentPatient.basicInfo.address = dr["address"].ToString();
            Conf.currentPatient.basicInfo.idcard = dr["idcard"].ToString();
            Conf.currentPatient.basicInfo.birthday = Convert.ToDateTime(dr["birthday"]);
            Conf.currentPatient.basicInfo.hosoutdate = Convert.ToDateTime(dr["hosoutdate"]);

            Conf.currentPatient.lastFollowDate = DAO.PatientInfo.getLastFollowDate(pid);
            Conf.currentPatient.followTimes = DAO.PatientInfo.getFollowTimes(pid);

            refreshPaitentBoard(null,EventArgs.Empty);
            return true;
        }

        #region 定义刷新病人信息界面事件
        /// <summary>
        /// 刷新主界面上病人信息
        /// </summary>
        public static event EventHandler refreshPaitentBoard = null;
        protected  void refreshPboard()
        {
            if (refreshPaitentBoard != null)
            {
                refreshPaitentBoard(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}
