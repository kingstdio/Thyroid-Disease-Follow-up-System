using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace 甲状腺随访系统
{
    public partial class UC_followUp : UserControl
    {
        
        DataSet ds;
        SqlDataAdapter da;
        SqlConnection conn = new SqlConnection(SQLHELPER.connstr);
        public UC_followUp()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        void fillUI(object obj, EventArgs args)
        {
           
           
            //追踪
            dti_DLC.Value = Conf.currentPatient.followUp.lastconnect;
            cbe_VS.SelectedIndex = cbe_VS.FindString(Conf.currentPatient.followUp.vitalstatus);
            cbe_DM.SelectedIndex = cbe_DM.FindString(Conf.currentPatient.followUp.distantmetastasis);
            dti_dismetadate.Value = Conf.currentPatient.followUp.diatantmetasisdate;
            cbe_LDM.SelectedIndex = cbe_LDM.FindString(Conf.currentPatient.followUp.distantmetastasislocation);
            dti_DD.Value = Conf.currentPatient.followUp.deathdate;
            cbe_CD.SelectedIndex = cbe_CD.FindString(Conf.currentPatient.followUp.deathcause);

            conn.Open();

            SqlCommand com = conn.CreateCommand();
            com.CommandText = "select t.id,t.pid,t.Vdate,t.TSH,t.FT3,t.FT4,t.TPO,t.PTH,t.ATG,t.TG,t.TGAb,t.Ca,t.P,t.euthyrox,t.Cadosage,t.sideeffect,t.others from tb_visit t where pid=@id";
            com.Parameters.Add(new SqlParameter("@id", Conf.currentPatient.id));
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);


            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds);
        





            
            this.sgc_visit.PrimaryGrid.DataSource = ds.Tables[0];




            conn.Close();
         
        }


        void fillSGC()
        {
             conn.Open();

            SqlCommand com = conn.CreateCommand();
            com.CommandText = "select t.id,t.pid,t.Vdate,t.TSH,t.FT3,t.FT4,t.TPO,t.PTH,t.ATG,t.TG,t.TGAb,t.Ca,t.P,t.euthyrox,t.Cadosage,t.sideeffect,t.others from tb_visit t where pid=@id";
            com.Parameters.Add(new SqlParameter("@id", Conf.currentPatient.id));
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);


            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds);
            //this.sgc_visit.PrimaryGrid.Rows.Clear(); 
            this.sgc_visit.PrimaryGrid.DataSource = ds.Tables[0];


            conn.Close();
        }





        

        void InsertData(object obj, EventArgs args)
        {
            //追踪
            Conf.currentPatient.followUp.lastconnect = dti_DLC.Value;
            Conf.currentPatient.followUp.vitalstatus = cbe_VS.Text;
            Conf.currentPatient.followUp.distantmetastasis = cbe_DM.Text;
            Conf.currentPatient.followUp.diatantmetasisdate = dti_dismetadate.Value;
            Conf.currentPatient.followUp.distantmetastasislocation = cbe_LDM.Text;
            Conf.currentPatient.followUp.deathdate = dti_DD.Value;
            Conf.currentPatient.followUp.deathcause = cbe_CD.Text;

            
            
        }


        #region 删除一行记录
        private void sgc_visit_RowDeleted(object sender, GridRowDeletedEventArgs e)
        {
            fillSGC();

            foreach (GridRow item in this.sgc_visit.PrimaryGrid.DeletedRows)
            {
                //sgc_visit.PrimaryGrid.Rows.RemoveAt(item.Index);

                try
                {

                    ds.Tables[0].Rows[item.Index].Delete();
                    da.Update(ds.Tables[0]);//以数据集的表更新数据库
                    ds.Tables[0].AcceptChanges();//接受对数据的修改
                    ToastNotification.Show(Parent, "删除成功");
                }
                catch (Exception ex)
                {
                    ToastNotification.Show(Parent, "删除失败" + ex.Message);
                    //出现异常提示更新失败
                }
            }
            fillSGC();
        }
        #endregion

        #region 离开当前页时更新数据库
        void RefreshDatabase(object sender, EventArgs e)
        {
            if (ds == null)
                return;
            //离开时更新supergridcontrol
            if (ds.HasChanges())//如果数据集因我们对datagridview的操作发生改变
            {
                try//捕获异常
                {
                    DataTable dt = ds.Tables[0];
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        ds.Tables[0].Rows[i]["pid"] = Conf.currentPatient.id;
                    }

                    da.Update(ds.Tables[0]);//以数据集的表更新数据库
                    ds.Tables[0].AcceptChanges();//接受对数据的修改
                    ToastNotification.Show(Parent, "系统数据保存成功");
                }
                catch (Exception ex)
                {
                    ToastNotification.Show(Parent, "更新失败！" + ex.Message);
                }

            }
            fillSGC();

            if (DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id))
            {
                ToastNotification.Show(Parent, "系统数据保存成功");

            }
        }
        #endregion

        private void UC_followUp_Validated(object sender, EventArgs e)
        {
            RefreshDatabase(sender, e);
        }

        private void sgc_visit_Click(object sender, EventArgs e)
        {
            if (ds == null)
                return;
            //离开时更新supergridcontrol
            if (ds.HasChanges())//如果数据集因我们对datagridview的操作发生改变
            {
                try//捕获异常
                {
                    DataTable dt = ds.Tables[0];
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        ds.Tables[0].Rows[i]["pid"] = Conf.currentPatient.id;
                    }

                    da.Update(ds.Tables[0]);//以数据集的表更新数据库
                    ds.Tables[0].AcceptChanges();//接受对数据的修改
                    ToastNotification.Show(Parent, "系统数据保存成功");
                    fillSGC();
                }
                catch (Exception ex)
                {
                    ToastNotification.Show(Parent, "更新失败！" + ex.Message);
                }

            }
            
        }
        #region 将回车键绑定TAB键
        /// <summary>
        /// 将回车键绑定TAB键
        /// </summary>
        private void cbe_VS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion












    }
}
