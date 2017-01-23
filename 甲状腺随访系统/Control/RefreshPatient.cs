using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using 甲状腺随访系统.model;

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
            DataTable dtPatientInfo= DAO.PatientInfo.getBasicInfo(pid);

            TableToModel<BasicInfo>(Conf.currentPatient.basicInfo, dtPatientInfo);
            TableToModel<NormalRiskFactors>(Conf.currentPatient.normalRiskFactors, dtPatientInfo);
            TableToModel<SpecialRiskFactors>(Conf.currentPatient.specialRiskFactors, dtPatientInfo);
            TableToModel<FamilyHistory>(Conf.currentPatient.familyHistory, dtPatientInfo);
            TableToModel<Imageology>(Conf.currentPatient.imageology, dtPatientInfo);

           // dr.Table.Columns.Contains("列名");
           // dr[1].Equals
            
           /* Conf.currentPatient.basicInfo.name =  dr["name"].ToString();
            Conf.currentPatient.basicInfo.hosnumber = dr["hosnumber"].ToString();
            Conf.currentPatient.basicInfo.mobile = dr["mobile"].ToString();
            Conf.currentPatient.basicInfo.phone = dr["phone"].ToString();
            Conf.currentPatient.basicInfo.hosindate = Convert.ToDateTime(dr["hosindate"]);
            Conf.currentPatient.basicInfo.sex = Convert.ToBoolean(dr["sex"]);
            Conf.currentPatient.basicInfo.address = dr["address"].ToString();
            Conf.currentPatient.basicInfo.idcard = dr["idcard"].ToString();
            Conf.currentPatient.basicInfo.birthday = Convert.ToDateTime(dr["birthday"]);
            Conf.currentPatient.basicInfo.hosoutdate = Convert.ToDateTime(dr["hosoutdate"]);*/
            




            Conf.currentPatient.lastFollowDate = DAO.PatientInfo.getLastFollowDate(pid);
            Conf.currentPatient.followTimes = DAO.PatientInfo.getFollowTimes(pid);

            refreshPaitentBoard(null,EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// 将DataTable中的每一列赋值给model中的同名属性
        /// DataTable中只有一行数据
        /// </summary>
        /// <typeparam name="T">泛型：model的类型</typeparam>
        /// <param name="objmodel">model的实例</param>
        /// <param name="dtInfo">DataTable表</param>
        public static void TableToModel<T>(T objmodel, DataTable dtInfo)
        {
            //获取model的类型
            Type modelType = typeof(T);

            //获取model中的属性
            PropertyInfo[] modelpropertys = modelType.GetProperties();

            //遍历DataTable的每一列
            for (Int32 i = 0; i < dtInfo.Columns.Count; i++)
            {
                //遍历model的每一个属性
                foreach (PropertyInfo pi in modelpropertys)
                {
                    String name = pi.Name;  //获取属性名称
                    //若model属性名称与表中的列名相同
                    if (name == dtInfo.Columns[i].ColumnName)
                    {        
                        //获取表中该列对应的数据
                        object value = dtInfo.Rows[0][i].ToString();
                        //判断是否为bool类型
                        if (dtInfo.Columns[i].DataType == typeof(bool))
                        {
                            value = Convert.ToBoolean(dtInfo.Rows[0][i]);
                        }
                        //判断是否为DateTime类型
                        else if (dtInfo.Columns[i].DataType == typeof(DateTime))
                        {
                            value = Convert.ToDateTime(dtInfo.Rows[0][i]);
                        }
                        //判断是否为int类型
                        else if (dtInfo.Columns[i].DataType == typeof(int))
                        {
                            value = Convert.ToInt32(dtInfo.Rows[0][i]);
                            //value = isDBNull.Value? null : (int?)(dtInfo.Rows[0][i]);
                        }
                        //判断是否为float类型
                        else if (dtInfo.Columns[i].DataType == typeof(float))
                        {
                            value = Convert.ToDouble(dtInfo.Rows[0][i]);
                        }
                        //将表中该列下的数据赋值给model中的同名属性
                        modelType.GetProperty(name).SetValue(objmodel, value, null);
                    }
                }
            }
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
