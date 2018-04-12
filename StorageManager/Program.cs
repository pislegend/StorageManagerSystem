using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
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

            //frmStorageMain fsm = new frmStorageMain();
           // fsm.StartPosition = FormStartPosition.CenterScreen;

               Splasher.Show(typeof(frmSplashStartUp));         
               Application.Run(new frmStorageMain());

        }


    }
}
