using System;
using System.Threading;
using System.Windows.Forms;
using ZBM.Utility;
using ZBM.ZITaker.Log;

namespace WinClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ExceptionLog.Instance.WriteLog(e.Exception,LogType.UI);
            ZBMMessageBox.ShowError(e.Exception);
        }
    }
}
