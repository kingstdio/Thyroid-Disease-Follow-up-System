using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using 甲状腺随访系统.model;
using 甲状腺随访系统.MODEL;

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
            DataTable dtPatientInfo = DAO.PatientInfo.getBasicInfo(pid);
            DataTable dtdiagosis = DAO.PatientInfo.getDiagnosis(pid);
            DataTable dtsurgeryHistory = DAO.PatientInfo.getSurgeryHistory(pid);
            DataTable dtpostOperative = DAO.PatientInfo.getPostOperative(pid);
            DataTable dtfollowUp = DAO.PatientInfo.getFollowUp(pid);
            DataTable dtrecurrencecs = DAO.PatientInfo.getRecurrencecs(pid);
            DataTable dtinspect = DAO.PatientInfo.getInspectionAfterSurgery(pid);
            DataTable dtradio = DAO.PatientInfo.getRadioactiveIodine(pid);
            DataTable dtvisit = DAO.PatientInfo.getVisit(pid);

            //病人信息
            if (dtPatientInfo.Rows.Count > 0)
            {
                TableToModel<BasicInfo>(Conf.currentPatient.basicInfo, dtPatientInfo);
                TableToModel<NormalRiskFactors>(Conf.currentPatient.normalRiskFactors, dtPatientInfo);
                TableToModel<SpecialRiskFactors>(Conf.currentPatient.specialRiskFactors, dtPatientInfo);
                TableToModel<FamilyHistory>(Conf.currentPatient.familyHistory, dtPatientInfo);
            }
            //诊断
            if (dtdiagosis.Rows.Count > 0)
            {
                TableToModel<ImageExamination>(Conf.currentPatient.imageExamination, dtdiagosis);
                TableToModel<HistologicalExamination>(Conf.currentPatient.histologicalExamination, dtdiagosis);
                TableToModel<HematologicalExamination>(Conf.currentPatient.hematologicalExamination, dtdiagosis);
            }
            //手术史
            if (dtsurgeryHistory.Rows.Count > 0)
            {
                TableToModel<BasicOperInfo>(Conf.currentPatient.basicOperInfo, dtsurgeryHistory);
                TableToModel<DiffereThyrCarc>(Conf.currentPatient.differeThyrCarc, dtsurgeryHistory);
                TableToModel<LympMeta>(Conf.currentPatient.lympMeta, dtsurgeryHistory);
                TableToModel<InspecAfterSurg>(Conf.currentPatient.inspecAfterSurg, dtsurgeryHistory);
            }
            //术后
            if (dtpostOperative.Rows.Count > 0)
            {
                TableToModel<Therapy>(Conf.currentPatient.therapy, dtpostOperative);
                TableToModel<Complication>(Conf.currentPatient.complication, dtpostOperative);
                TableToModel<RadioIodine>(Conf.currentPatient.radioIodine, dtpostOperative);
                TableToModel<Complication>(Conf.currentPatient.complication, dtpostOperative);
            }
            //追踪
            if (dtfollowUp.Rows.Count > 0)
            {
                TableToModel<FollowUp>(Conf.currentPatient.followUp, dtfollowUp);
                
            }
            if (dtvisit.Rows.Count > 0)
            {
                TableToModel<Visit>(Conf.currentPatient.visit, dtvisit);
 
            }
            //复发
            if (dtrecurrencecs.Rows.Count > 0)
            {
                TableToModel<Recurrencecs>(Conf.currentPatient.recurrencecs, dtrecurrencecs);
            }


          

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
                        object value = null ;
                        //获取表中该列对应的数据
                        if (dtInfo.Columns[i].DataType == typeof(string))
                        {
                            if (dtInfo.Rows[0][i] == System.DBNull.Value)
                                value = Convert.ToString(null);
                            else
                            value = dtInfo.Rows[0][i].ToString();
                        }
                        
                        //判断是否为bool类型
                        if (dtInfo.Columns[i].DataType == typeof(bool))
                        {

                            if (dtInfo.Rows[0][i] == System.DBNull.Value)
                                value = Convert.ToBoolean(null);
                            else
                                value = Convert.ToBoolean(dtInfo.Rows[0][i]);
                        }
                        //判断是否为DateTime类型
                        else if (dtInfo.Columns[i].DataType == typeof(DateTime) )
                        {
                            if (dtInfo.Rows[0][i] == System.DBNull.Value)
                                value = Convert.ToDateTime(null);
                            else
                            value = Convert.ToDateTime(dtInfo.Rows[0][i]);
                        }
                        //判断是否为int类型
                        else if (dtInfo.Columns[i].DataType == typeof(int) )
                        {
                            if (dtInfo.Rows[0][i] == System.DBNull.Value)
                                value = Convert.ToInt32(null);
                            else
                            value = Convert.ToInt32(dtInfo.Rows[0][i]);
                        }
                        //判断是否为float类型
                        else if (dtInfo.Columns[i].DataType == typeof(float) )
                        {
                            if (dtInfo.Rows[0][i] == System.DBNull.Value)
                                value = Convert.ToDouble(null);
                                
                            else
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
