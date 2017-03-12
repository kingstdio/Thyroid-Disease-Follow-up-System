using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace 甲状腺随访系统.CONTROL
{
    class VersionControl
    {
        #region 检查是否有新版本
        /// <summary>
        /// 检查是否有新版本
        /// </summary>
        /// <param name="localVersion">本地版本</param>
        /// <param name="remoteVersion">远程版本</param>
        /// <returns></returns>
        public static bool isNewVersionAvailable(string localVersion, string remoteVersion)
        {
            DateTime local = Convert.ToDateTime(localVersion);
            DateTime remote = Convert.ToDateTime(remoteVersion);
            if (local.CompareTo(remote) < 0)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
        #endregion 

        #region 更新软件
        /// <summary>
        /// 更新软件
        /// </summary>
        public static bool updateSoft()
        {
            //判断是否联网

            if (NETHELPER.isConnectToWWW())
            {
                //检查系统更新
                string responsString = NETHELPER.HttpPost(Conf.appServerUir, "", null);

                string[] responsArray = responsString.Split('#');

                if (VersionControl.isNewVersionAvailable(Conf.appVersion, responsArray[0]))
                {
                    Process process = new Process();
                    string appName = Environment.CurrentDirectory + @"\update.exe";
                    Process.Start(appName);

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
        #endregion
    }
}
