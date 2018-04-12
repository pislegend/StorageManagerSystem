using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class frmSplashStartUp : Form, ISplashForm
    {
        public frmSplashStartUp()
        {
            InitializeComponent();
        }

        void ISplashForm.SetStatusInfo(string NewStatusInfo)
        {
            lblNewStatusInfo.Text = NewStatusInfo;
        }



    }
}
