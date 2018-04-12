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
    public partial class frmBase : DockContent
    {
        /// <summary>
        /// 所用窗体的父类窗体
        /// </summary>
        public frmBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示警告信息
        /// </summary>
        /// <param name="stemessage">需要输出的信息</param>
        public void ShowAlertMessage(string strmessage)
        {
            MessageBox.Show(strmessage,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="stemessage">需要输出的信息</param>
        public void ShowMessage(string strmessage)
        {
            MessageBox.Show(strmessage,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="stemessage">需要输出的信息</param>
        public void ShowErrorMessage(string strmessage)
        {
            MessageBox.Show(strmessage,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
    
}
