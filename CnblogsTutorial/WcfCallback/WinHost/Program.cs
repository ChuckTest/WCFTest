using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ZBM.Utility;
using ZBM.ZITaker.Log;

namespace WinHost
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            ExceptionLog.Instance.WriteLog(ex, LogType.UI);
            ZBMMessageBox.ShowError(ex);
        }
    }
}
