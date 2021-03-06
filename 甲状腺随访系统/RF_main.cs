﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Threading;
using System.Diagnostics;

namespace 甲状腺随访系统
{
    public partial class RF_main : DevComponents.DotNetBar.RibbonForm
    {

        UC_patientInfo uC_patientInfo = new UC_patientInfo();
        UC_diagnosis uC_diagnosis = new UC_diagnosis();
        UC_surgeryHistory uC_surgeryHistory = new UC_surgeryHistory();
        UC_postOperative uC_postOperative = new UC_postOperative();
        UC_followUp uC_followUp = new UC_followUp();
        UC_recurrencecs uC_recurrencecs = new UC_recurrencecs();
        UC_userManagement uC_userManagement = new UC_userManagement();
        PatientInfoFiltering demoExtendedFiltering = new PatientInfoFiltering();
        

        #region 初始化
        public RF_main()
        {
            InitializeComponent();

            //设置程序版本
            bt_version.Text = Conf.appVersion;

            //设置当前用户名
            bt_user.Text = "当前用户："+Conf.currentUser.username;
            
            Control.RefreshPatient.refreshPaitentBoard += new EventHandler(fillPaitentBoard); //注册更新病人信息面板事件
            Control.RefreshPatient.newPaitentAction += new EventHandler(newPaitentAction);
            Control.RefreshPatient.refreshlastFDate += new EventHandler(lastFollowDate);//更新最后随访日期
            
            //添加功能面板
            panEX_main.Controls.Add(uC_patientInfo);
            panEX_main.Controls.Add(uC_diagnosis);
            panEX_main.Controls.Add(uC_surgeryHistory);
            panEX_main.Controls.Add(uC_postOperative);
            panEX_main.Controls.Add(uC_followUp);
            panEX_main.Controls.Add(uC_recurrencecs);
            panEX_main.Controls.Add(uC_userManagement);

            demoExtendedFiltering.TopLevel = false;
            demoExtendedFiltering.Parent = this;
            panEX_main.Controls.Add(demoExtendedFiltering);

            //设置缩放属性
            uC_patientInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_diagnosis.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_surgeryHistory.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_postOperative.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_followUp.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_recurrencecs.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uC_userManagement.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;


            //设置功能面板的可见性
            uC_diagnosis.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_postOperative.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            uC_userManagement.Visible = false;
            demoExtendedFiltering.Visible = false;


            fillPaitentBoard(null, null);

            //备份文件的扩展名
            dia_save.Filter = "数据库备份文件（*.bak）|*.bak|数据文件（*.mdf）|*.mdf|日志文件（*.ldf）|*.ldf";
            dia_save.FileName = "dbbackup" + DateTime.Now.ToBinary();

            dia_open.Filter = "数据库备份文件（*.bak）|*.bak|数据文件（*.mdf）|*.mdf|日志文件（*.ldf）|*.ldf";
        }
        #endregion 

        #region 更新功能面板事件
        /// <summary>
        /// 更新功能面板
        /// </summary>
        void fillPaitentBoard(object obj, EventArgs args) {

            tb_name.Text = Conf.currentPatient.basicInfo.name;
            tb_hosno.Text = Conf.currentPatient.basicInfo.hosnumber;
            tb_phone.Text = Conf.currentPatient.basicInfo.mobile;
            
            tb_idcard.Text = Conf.currentPatient.basicInfo.idcard;
            if (Conf.currentPatient.id == 0)
            {
                tb_sex.Text = string.Empty;
                tb_birthday.Text = string.Empty;
                tb_hosoutdate.Text = string.Empty;
                tb_FUNear.Text = string.Empty;
                tb_FUTimes.Text = string.Empty;
                tb_hosindate.Text = string.Empty;
            }
            else
            {
                
                tb_sex.Text = Conf.currentPatient.basicInfo.sex ? "男" : "女";
                tb_birthday.Text = Conf.currentPatient.basicInfo.birthday.ToShortDateString();
                tb_hosoutdate.Text = Conf.currentPatient.basicInfo.hosoutdate.ToShortDateString();
                tb_FUNear.Text = Conf.currentPatient.lastFollowDate.ToShortDateString();
                tb_FUTimes.Text = Conf.currentPatient.followTimes.ToString();
                tb_hosindate.Text = Conf.currentPatient.basicInfo.hosindate.ToShortDateString();
            }  
        }
        //更新最后随访日期
        void lastFollowDate(object obj, EventArgs args)
        {
            tb_FUNear.Text = Conf.currentPatient.lastFollowDate.ToShortDateString();
        }



        #endregion

        #region 界面按钮操作
        private void bt_patientInfo_Click(object sender, EventArgs e)
        {
            changeUI("uC_patientInfo");
        }

        private void bt_diagnosis_Click_1(object sender, EventArgs e)
        {
            changeUI("uC_diagnosis");            
        }

        private void bt_SH_Click(object sender, EventArgs e)
        {
            changeUI("uC_surgeryHistory");
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            changeUI("uC_patientInfo");
            Conf.currentPatient = new model.Patient();
            Control.RefreshPatient.refresh(0);
        }

        /// <summary>
        /// 按钮-术后
        /// </summary>
        private void bt_pOperative_Click(object sender, EventArgs e)
        {
            changeUI("uC_postOperative");
        }

        /// <summary>
        /// 按钮-追踪
        /// </summary>
        private void bt_followUp_Click(object sender, EventArgs e)
        {
            changeUI("uC_followUp");
            F_patientChoose fchoosePatient = new F_patientChoose();
            fchoosePatient.ShowDialog();
        }
       

        private void bt_recurrencecs_Click(object sender, EventArgs e)
        {
            changeUI("uC_recurrencecs");            
        }
        //系统管理
        private void bt_UserMa_Click(object sender, EventArgs e)
        {
            changeUI("uC_userManagement");
            panel_patientInfo.Visible = false;
        }

        //查询界面
        private void buttonItem2_Click(object sender, EventArgs e)
        {
           // new System.Threading.Thread(new System.Threading.ThreadStart(LoadImg)).Start();
            changeUI("PatientInfoFiltering");
            panel_patientInfo.Visible = false;
            //cp_wait.Visible = true;
        }
        //    private void LoadImg()
        //{
        //    Image img = Image.FromFile(@".\甲状腺随访系统\data\ui\PatientAdd.png");
        //    PictureBox pb_load = new PictureBox();
        //   // pb_load.Load(@".\Resources\timg.gif");
        //    pb_load.Image = img;                
        //}


        /// <summary>
        /// 删除按钮操作
        /// </summary>
        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (Conf.currentPatient.id == 0)
            {
                MessageBox.Show("没有可删除病患！", "系统提示",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                DialogResult diaResult = MessageBox.Show("确定要删除该患者吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (diaResult == DialogResult.Yes)
                {

                    if (DAO.DeletePatient.DelPatient(Conf.currentPatient.id))
                    {
                        ToastNotification.Show(this, "删除成功");
                    }
                    Conf.currentPatient = new model.Patient();
                    Conf.currentPatient.id = 0;
                    Control.RefreshPatient.refresh(0);

                }
            }
        }
        #endregion

        #region 根据名称改变控件的可见性
        /// <summary>
        /// 根据名称改变控件的可见性
        /// </summary>
        /// <param name="controlName">控件名称</param>
        private void changeUI(string controlName) {

            uC_patientInfo.Visible = false;
            uC_diagnosis.Visible = false;
            uC_postOperative.Visible = false;
            uC_surgeryHistory.Visible = false;
            uC_followUp.Visible = false;
            uC_recurrencecs.Visible = false;
            panel_patientInfo.Visible = true;
            demoExtendedFiltering.Visible = false;
            panEX_main.Controls.Find(controlName, false)[0].Visible = true;
        }
        #endregion

        #region 关闭程序时保存数据
        /// <summary>
        /// 关闭程序时保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RF_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            uC_followUp.Validate();
            uC_postOperative.Validate();
            if (DAO.InsertPatient.InsertBasicInfo(Conf.currentPatient.id))
            {
                ToastNotification.Show(this, "系统数据保存成功");
            }
        }
        #endregion

        #region 新建用户时跳转界面
        /// <summary>
        /// 新建用户时跳转界面
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        void newPaitentAction(object obj, EventArgs args)
        {      
            Conf.currentPatient = new model.Patient();
            changeUI("uC_patientInfo");
            Control.RefreshPatient.refresh(0);
        }
        #endregion

        #region 改变窗口大小同步事件
        /// <summary>
        /// 改变窗口大小同步事件
        /// </summary>
        private void RF_main_SizeChanged(object sender, EventArgs e)
        {
            if (demoExtendedFiltering.Visible)
            {
                demoExtendedFiltering.WindowState = FormWindowState.Normal;
                demoExtendedFiltering.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        #region 导出excel
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            demoExtendedFiltering.ExportExcel();
        }
        #endregion

        #region 数据库备份与恢复
        private void bt_backupDB_Click(object sender, EventArgs e)
        {
            string savePath = string.Empty;
         
          
            if (dia_save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    savePath = dia_save.FileName;
                    String sql = @"backup database follw_up_DB to disk='" + savePath + "'";
                    SQLHELPER.ExecuteNoneQuery(sql);
                    MessageBox.Show("操作成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void 数据库恢复_Click(object sender, EventArgs e)
        {
            string openPath = string.Empty;
            //dia_open.ShowDialog();
            openPath = dia_open.FileName;
            if (dia_open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String sql = "use master Exec dbo.KillSpByDbName 'follw_up_DB' restore database follw_up_DB  from disk='" + openPath + "'  with replace use follw_up_DB";
                    SQLHELPER.ExecuteNoneQuery(sql);
                    MessageBox.Show("恢复成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion





    }
}