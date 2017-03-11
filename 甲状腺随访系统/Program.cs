using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 甲状腺随访系统.CONTROL;

namespace 甲状腺随访系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (!VersionControl.updateSoft())
            {
                F_login loginForm = new F_login();
                DialogResult diaresult = loginForm.ShowDialog();
                if (diaresult == DialogResult.OK)
                {
                    Application.Run(Conf.mainForm = new RF_main());
                }
            }
            
        }
    }
}
