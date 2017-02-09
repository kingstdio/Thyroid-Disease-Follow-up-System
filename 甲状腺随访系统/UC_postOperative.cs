using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 甲状腺随访系统
{
    public partial class UC_postOperative : UserControl
    {
        DataSet ds = new DataSet();
        DataSet Radiods = new DataSet();
        SqlDataAdapter da, Radioda;
        SqlConnection conn = new SqlConnection(SQLHELPER.connstr);
        public UC_postOperative()
        {
            InitializeComponent();
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillUI);
        }

        private void line8_Click(object sender, EventArgs e)
        {

        }

        private void bt_saveMT_Click(object sender, EventArgs e)
        {

        }

        private void sideNavPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void fillUI(object obj, EventArgs args)
        {
            //术后治疗
            dtb_eut.Value = Conf.currentPatient.therapy.euthyrox;
            rtbe_chemotherapy.Text = Conf.currentPatient.therapy.chemotherapy;
            rtbe_radiotherapy.Text = Conf.currentPatient.therapy.radiotherapy;

            //术后并发症
            cbe_hoarseness.SelectedIndex = cbe_hoarseness.FindString(Conf.currentPatient.complication.hoarseness);
            cbe_dyspnea.SelectedIndex = cbe_dyspnea.FindString(Conf.currentPatient.complication.dyspnea);
            cbe_drinkchok.SelectedIndex = cbe_drinkchok.FindString(Conf.currentPatient.complication.drinkchok);
            cbe_hyperspasmia.SelectedIndex = cbe_hyperspasmia.FindString(Conf.currentPatient.complication.hyperspasmia);
            switch_galactorrhea.Value = Conf.currentPatient.complication.galactorrhea;
            switch_infection.Value = Conf.currentPatient.complication.infection;
            cbe_Bparalysis.SelectedIndex = cbe_Bparalysis.FindString(Conf.currentPatient.complication.Bparalysis);
            cbe_Bhypomotility.SelectedIndex = cbe_Bhypomotility.FindString(Conf.currentPatient.complication.Bhypomotility);
            cbe_PLparalysis.SelectedIndex = cbe_PLparalysis.FindString(Conf.currentPatient.complication.PLparalysis);
            cbe_PLhypomotility.SelectedIndex = cbe_PLhypomotility.FindString(Conf.currentPatient.complication.PLhypomotility);
            cbe_VocalChange.SelectedIndex = cbe_VocalChange.FindString(Conf.currentPatient.complication.VocalChange);
            switch_bleed.Value = Conf.currentPatient.complication.bleed;
            
            dgv_radio.DataSource = DAO.PatientInfo.getRadioactiveIodine(Conf.currentPatient.id);

            conn.Open();
            //术后检查
            SqlCommand com = conn.CreateCommand();
            com.CommandText = "select * from tb_inspectionAfterSurgery t where pid=@id";
            com.Parameters.Add(new SqlParameter("@id", Conf.currentPatient.id));
            da = new SqlDataAdapter(com);
            da.Fill(ds);


            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds);
            this.dgv_inspect.DataSource = ds.Tables[0];

            //碘治疗

            SqlCommand Radiocom = conn.CreateCommand();
            Radiocom.CommandText = "select * from tb_radioactiveIodine t where pid=@id";
            Radiocom.Parameters.Add(new SqlParameter("@id", Conf.currentPatient.id));
            Radioda = new SqlDataAdapter(Radiocom);
            Radioda.Fill(Radiods);


            SqlCommandBuilder Radiobuilder = new SqlCommandBuilder(Radioda);
            Radioda.Update(Radiods);
            this.dgv_radio.DataSource = Radiods.Tables[0];
            conn.Close();


        }

        void InsertData(object obj, EventArgs args)
        {
            //术后治疗
            Conf.currentPatient.therapy.euthyrox = dtb_eut.Value;
            Conf.currentPatient.therapy.chemotherapy = rtbe_chemotherapy.Text;
            Conf.currentPatient.therapy.radiotherapy = rtbe_radiotherapy.Text;

            //术后并发症
            Conf.currentPatient.complication.hoarseness = cbe_hoarseness.Text;
            Conf.currentPatient.complication.dyspnea = cbe_dyspnea.Text;
            Conf.currentPatient.complication.drinkchok = cbe_drinkchok.Text;
            Conf.currentPatient.complication.hyperspasmia = cbe_hyperspasmia.Text;
            Conf.currentPatient.complication.galactorrhea = switch_galactorrhea.Value;
            Conf.currentPatient.complication.infection = switch_infection.Value;
            Conf.currentPatient.complication.Bparalysis = cbe_Bparalysis.Text;
            Conf.currentPatient.complication.Bhypomotility = cbe_Bhypomotility.Text;
            Conf.currentPatient.complication.PLparalysis = cbe_PLparalysis.Text;
            Conf.currentPatient.complication.PLhypomotility = cbe_PLhypomotility.Text;
            Conf.currentPatient.complication.VocalChange = cbe_VocalChange.Text;
            Conf.currentPatient.complication.bleed = switch_bleed.Value;

        }
        //术后检测
        void Update_Click(object sender, EventArgs e)
        {
            if (ds.HasChanges())//如果数据集因我们对datagridview的操作发生改变
            {
                try//捕获异常
                {
                    //DataTable dt = ds.Tables[0];
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        ds.Tables[0].Rows[i]["pid"] = Conf.currentPatient.id;
                    }

                    da.Update(ds.Tables[0]);//以数据集的表更新数据库
                    ds.Tables[0].AcceptChanges();//接受对数据的修改
                    MessageBox.Show("更新成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示更新成功
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "更新失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //出现异常提示更新失败
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("删除测试");

            int delRowIndex = dgv_inspect.CurrentRow.Index;
            this.dgv_inspect.Rows.RemoveAt(delRowIndex);
                try
                {
                    da.Update(ds.Tables[0]);//以数据集的表更新数据库
                    ds.Tables[0].AcceptChanges();//接受对数据的修改
                    MessageBox.Show("更新成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示更新成功
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "更新失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //出现异常提示更新失败
                }
            

        }
        //碘治疗
        void UpdateRadio_Click(object sender, EventArgs e)
        {
            if (Radiods.HasChanges())//如果数据集因我们对datagridview的操作发生改变
            {
                try//捕获异常
                {
                    //DataTable dt = ds.Tables[0];
                    for (int i = 0; i < Radiods.Tables[0].Rows.Count; i++)
                    {

                        Radiods.Tables[0].Rows[i]["pid"] = Conf.currentPatient.id;
                    }

                    Radioda.Update(Radiods.Tables[0]);//以数据集的表更新数据库
                   Radiods.Tables[0].AcceptChanges();//接受对数据的修改
                    MessageBox.Show("更新成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示更新成功
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "更新失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //出现异常提示更新失败
                }
            }
        }

        private void DeleteRadio_Click(object sender, EventArgs e)
        {
            Console.WriteLine("删除测试");

            int delRowIndex = dgv_inspect.CurrentRow.Index;
            this.dgv_radio.Rows.RemoveAt(delRowIndex);
            try
            {
                Radioda.Update(Radiods.Tables[0]);//以数据集的表更新数据库
                Radiods.Tables[0].AcceptChanges();//接受对数据的修改
                MessageBox.Show("更新成功！", "操作结果", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示更新成功
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //出现异常提示更新失败
            }


        }






    }
}
