using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace StorageManager
{
    public partial class frmStorageMain : frmBase
    {
        #region 子窗口初始化变量实例化
        private frmOutLookNavBar frmoutlooknavbar = new frmOutLookNavBar();
        private frmByManage frmbymanage = new frmByManage();
        private frmCrkmanage frmcrkmanage = new frmCrkmanage();
        private frmInfoCx frminfocx = new frmInfoCx();
        //private frmLogin frmlogin = null;
        private frmLogin frmlogin = new frmLogin();
        private frmRegister frmregister = new frmRegister();
        private frmBackup frmbackup = new frmBackup();
        private bool timeflag = false;
        #endregion
        public frmStorageMain()
        {
            InitializeComponent();
            #region 启动界面开始
            Splasher.Status = "正在处理......";
            System.Threading.Thread.Sleep(100);
            #endregion
            
            ///加载程序代码开始
            frmoutlooknavbar.Show(this.dockPanel,DockState.DockLeft);
            frmcrkmanage.Show(this.dockPanel);           
            frminfocx.Show(this.dockPanel); 
            frmbymanage.Show(this.dockPanel);
            frmbackup.Show(this.dockPanel);
            timeflag = true;
            tsrbTime.Text = DateTime.Now.ToString();
            tsrslblTime.Text = DateTime.Now.ToString();
            ///加载程序代码接收
            #region 启动界面结束
            Splasher.Status = "初始化完毕......";
            System.Threading.Thread.Sleep(100);

            Splasher.Close();
            #endregion
        }
        #region 工具条按钮功能区和时间显示
        private void tsrbNav_Click(object sender, EventArgs e)
        {
            if(frmoutlooknavbar.Visible)
            {
                frmoutlooknavbar.Hide();
            }
            else
            {
                frmoutlooknavbar.Show();
            }
        }

        private void tsrbCrk_Click(object sender, EventArgs e)
        {
            if (frmcrkmanage.Visible)
                frmcrkmanage.Hide();
            else
                frmcrkmanage.Show();
        }

        private void tsrbBym_Click(object sender, EventArgs e)
        {
            if (frmbymanage.Visible)
                frmbymanage.Hide();
            else
                frmbymanage.Show();
        }



        private void tsrbInfocx_Click(object sender, EventArgs e)
        {
            if (frminfocx.Visible)
                frminfocx.Hide();
            else
                frminfocx.Show();
        }

        private void tsrbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(timeflag)
            {
                tsrbTime.Text = DateTime.Now.ToString();
                tsrslblTime.Text = DateTime.Now.ToString();
             }
        }

        private void tsrbBackup_Click(object sender, EventArgs e)
        {
            if (frmbackup.Visible)
                frmbackup.Hide();
            else
                frmbackup.Show();
        }
        #endregion
        #region
        private void 登录LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frmlogin.IsDisposed)
            {
                frmlogin = new frmLogin();
                //注册事件，用于登陆成功之后科室用户名的显示
                frmlogin.TransfEvent += frmlogin_TransfEvent;
                frmlogin.TransfEvent += frmlogin_TransfEvent1;
                frmlogin.Show();
                frmlogin.Focus();
            }
            else
            {
                //注册事件，用于登陆成功之后科室用户名的显示
                frmlogin.TransfEvent += frmlogin_TransfEvent;
                frmlogin.TransfEvent += frmlogin_TransfEvent1;
                frmlogin.Show();
                frmlogin.Focus();
            }
            //frmlogin.Show(this);
        }

        //主窗体的状态栏,用于登陆成功之后科室用户名的显示事件处理方法
        void frmlogin_TransfEvent(string value)
        {
            this.tsrslblUserName.Text = value;
        }
        //出入库窗口中label，用于登陆成功之后科室用户名的显示事件处理方法
        void frmlogin_TransfEvent1(string value)
        {
            frmcrkmanage.grpCz.Text = "操作人："+value;
        }
        #endregion

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



     



    }
}
