using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Elegant.Ui.Samples.ControlsSample.Common
{
    class MsgrLogger
    {
        static Object logFileLock = new Object();
        static StreamWriter sw;
        static string LOG_FILE = "C:\\MiniCTI\\log\\Config_";

        /// <summary>
        /// 기존 로그처리함수
        /// </summary>
        /// <param name="_log"></param>
        public static void WriteLog(string _log)
        {
            lock (logFileLock)
            {

                sw = null;
                FileInfo fileInfo = new FileInfo(LOG_FILE + DateTime.Now.ToShortDateString() + ".txt");
                if (!fileInfo.Exists)
                {
                    fileInfo.Create();
                }

                try
                {
                    sw = new StreamWriter(LOG_FILE + DateTime.Now.ToShortDateString() + ".txt", true);
                    sw.WriteLine(_log);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("logFileWriter() 에러 : " + e.ToString());
                }
            }
        }
    }
}
