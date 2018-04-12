using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLibrary.WinControls;
using WeifenLuo.WinFormsUI.Docking;
namespace StorageManager
{


    public partial class frmOutLookNavBar : DockContent
    {
        #region 窗体实例化

        private frmByManage frmbymanage = new frmByManage();
        private frmCrkmanage frmcrkmanage = new frmCrkmanage();
        private frmInfoCx frminfocx = new frmInfoCx();
        private OutlookBar outlookBar1 = null;
        #endregion
        public frmOutLookNavBar()
        {
            InitializeComponent();
            InitializeOutlookbar();
            
        }

        private void InitializeOutlookbar()
        {
            outlookBar1 = new OutlookBar();
            #region 导航条设计
            OutlookBarBand outlookShortcutsBand = new OutlookBarBand("备件仪表管理");

            outlookShortcutsBand.SmallImageList = this.imageList1;
            outlookShortcutsBand.LargeImageList = this.imageList1;
            outlookShortcutsBand.Items.Add(new OutlookBarItem("备件仪表出入库",0));
            outlookShortcutsBand.Items.Add(new OutlookBarItem("备件仪表信息与查询", 1));
            outlookShortcutsBand.Items.Add(new OutlookBarItem("备件仪表综合管理", 2));
            #endregion

            outlookShortcutsBand.Background = SystemColors.AppWorkspace;
            outlookShortcutsBand.TextColor = Color.White;
            outlookBar1.Bands.Add(outlookShortcutsBand);

            outlookBar1.Dock = DockStyle.Fill;
            outlookBar1.SetCurrentBand(0);
            outlookBar1.ItemClicked += new OutlookBarItemClickedHandler(OnOutlookBarItemClicked);
            outlookBar1.ItemDropped += new OutlookBarItemDroppedHandler(OnOutlookBarItemDropped);

            this.panel1.Controls.AddRange(new Control[]{outlookBar1});           
        }

        private void OnOutlookBarItemClicked(OutlookBarBand band,OutlookBarItem item)
        {
            frmStorageMain frmstoragemain = new frmStorageMain();
            switch (item.Text)
            {
                case "备件仪表出入库":
                    
                    break;
                case "备件仪表信息与查询":
                    if (frminfocx.Visible == true)
                    {
                        frminfocx.Hide();
                    }
                    else
                    {
                        frminfocx.Show(frmstoragemain.dockPanel);
                    }
                    break;
                case "备件仪表综合管理":
                    if (frmbymanage.Visible == true)
                    {
                        frmbymanage.Hide();
                    }
                    else
                    {
                        frmbymanage.Show(frmstoragemain.dockPanel);
                    }
                    break;
                default:
                    break;

            }

        }
        private void OnOutlookBarItemDropped(OutlookBarBand band,OutlookBarItem item)
        { }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
