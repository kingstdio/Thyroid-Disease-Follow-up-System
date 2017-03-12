using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Net;
using DevComponents.DotNetBar.Controls;
using System.Threading;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace 更新程序
{
    public partial class F_main : DevComponents.DotNetBar.RibbonForm
    {
        private string baseUrl = @"http://auth.xxeasy.net/softbase/thyroid/";
        private string infoUrl = @"http://auth.xxeasy.net/softInfo.php";
        private  string [] downloadlist;
        private string currentFolder = Application.StartupPath+@"\";
        private string downloadFolder = Application.StartupPath + @"\updateFile\";
        private string backupFolder = Application.StartupPath+@"\backupFile\";
        private Mutex mutex = new Mutex();

        public F_main()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            init();
        }

        void init()
        {
            if (NETHELPER.isConnectToWWW())
            {
                string reponsData = NETHELPER.HttpPost(infoUrl, "", null);
                downloadlist = reponsData.Split('#');
            }
            else
            {
                MessageBox.Show("网络连接错误，请稍后再试", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Thread updateThread = new Thread(new ThreadStart(doUpdate));
            updateThread.Start();
        }


        void doUpdate() {
            download();
        }

        void download() {

            if (!Directory.Exists(downloadFolder))
            {
                Directory.CreateDirectory(downloadFolder);
            }
            else 
            {
                Directory.Delete(downloadFolder,true);
                Directory.CreateDirectory(downloadFolder);
            }

            if (downloadlist.Length <= 1)
            {
                return;
            }

            for (int i = 1; i < downloadlist.Length; i++) {
                mutex.WaitOne();
                DownloadFile(baseUrl+downloadlist[i],downloadFolder + downloadlist[i],pbg_main,labelX1);        
            }
            if(!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }
            for (int i = 1; i < downloadlist.Length; i++) {
                string oldFile = currentFolder + downloadlist[i];
                string newFile = downloadFolder + downloadlist[i];
                File.Copy(newFile, oldFile,true);
            }
            labelX1.Text = "更新成功";
            string appName = Environment.CurrentDirectory + @"\thyroidSoft.exe";
            Process.Start(appName);
            Directory.Delete(downloadFolder, true);
            Application.Exit();
        }



        #region 下载文件
        /// <summary>        
        /// c#,.net 下载文件        
        /// </summary>        
        /// <param name="URL">下载文件地址</param>       
        /// 
        /// <param name="Filename">下载后的存放地址</param>        
        /// <param name="Prog">用于显示的进度条</param>        
        /// 
        public void DownloadFile(string URL, string filename, ProgressBarX prog, LabelX label1)
        {
            float percent = 0;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                   // System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    label1.Text = "当前补丁下载进度" + percent.ToString() + "%";
                    //System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
                mutex.ReleaseMutex();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        #endregion
    }
}


