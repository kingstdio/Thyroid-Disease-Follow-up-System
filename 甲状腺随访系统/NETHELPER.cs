using System;
using System.IO;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;

namespace 甲状腺随访系统
{
    public static class NETHELPER
    {

        #region 判断是否连接网络
        //导入判断网络是否连接的 .dll  
        [DllImport("wininet.dll", EntryPoint = "InternetGetConnectedState")]
        //判断网络状况的方法,返回值true为连接，false为未连接  
        public extern static bool InternetGetConnectedState(out int conState, int reder);

        /// <summary>
        /// 判断是否联网
        /// </summary>
        public static bool isConnectToWWW() 
        {
            int n = 0;
            if (InternetGetConnectedState(out n, 0)) { return true; } else { return false; }
        }
        #endregion

        #region 发送请求
        /// <summary>
        /// 发送post请求
        /// </summary>
        /// <param name="Url">网址</param>
        /// <param name="postDataStr">post的数据</param>
        /// <param name="cookie">cookie</param>
        /// <returns>返回的结果</returns>
        public static string HttpPost(string Url, string postDataStr, CookieContainer cookie)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            request.CookieContainer = cookie;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (cookie != null)
            {
                response.Cookies = cookie.GetCookies(response.ResponseUri);
            }
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.Default);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public static string HttpGet(string Url, string postDataStr)
        {
            int count = 0;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                request.Timeout= 3000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.Default);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            catch (Exception ex ) {
                Console.WriteLine(ex.Message);
                count++;
                if (count >= 6)
                {
                    return "";
                }
                else
                {
                    HttpGet(Url, postDataStr);
                }
                return "";
            }
        }
        #endregion
    }
}
