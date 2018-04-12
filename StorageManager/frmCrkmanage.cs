using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageAccessData;
using StorageMember;

namespace StorageManager
{
    public partial class frmCrkmanage : frmBase
    {
        public frmCrkmanage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRkmanage_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            this.txtById.Enabled = true;
            this.ActiveControl = txtById;
        }


        private void btnManual_Click(object sender, EventArgs e)
        {
            this.txtById.Enabled = true;
            this.ActiveControl = txtById;
        }

        #region 无用函数
        //private void TransDatatoView(DataTable dtDisplay1,DataTable dtDisplay2)
        //{

        //    Devices devices = new Devices();
        //    DeviceCrkManage dcm = new DeviceCrkManage();

        //    //传入备件仪表ID信息，输出该ID对应的所有信息
        //    devices = dcm.CxInfofromdatabase(this.txtById.Text);


        //    dtDisplay2.Rows.Add(new string[] {devices.DEVICEID, this.grpCz.Text, dtpCz.Value.ToString(), devices.DEVICENAME });
        //    dtDisplay1.Merge(dtDisplay2);

        //    try
        //    {
        //        if (this.grpCz.Text != "")
        //        {
        //            if(devices!=null)
        //            {
                    
        //                this.dgvByCrkInfo.DataSource = dtDisplay1;
        //            }
        //            else
        //            {
        //                ShowAlertMessage("该设备号不正确，请重新输入！");
        //            }                  
        //            }
        //         else
        //         {
        //             ShowAlertMessage("请先登录!");
        //         }
        //    }
        //    catch(Exception e)
        //    {
        //        throw e;
        //    }
        //}
        #endregion
        //将从数据库中读取以及控件中的数据显示在datagridview控件dgvByCrkInfo中
        private void TransDatatoView()
        {
            Devices devices = new Devices();
            DeviceCrkManage dcm = new DeviceCrkManage();

            //传入备件仪表ID信息，输出该ID对应的所有信息
            devices = dcm.CxInfofromdatabase(this.txtById.Text);

            try
            {
                if (this.grpCz.Text != "")
                {
                    if (devices != null)
                    {
                        int index = this.dgvByCrkInfo.Rows.Add();
                        this.dgvByCrkInfo.Rows[index].Cells[0].Value= index+1;
                        this.dgvByCrkInfo.Rows[index].Cells[1].Value = devices.DEVICEID;
                        this.dgvByCrkInfo.Rows[index].Cells[2].Value = this.grpCz.Text;
                        this.dgvByCrkInfo.Rows[index].Cells[3].Value = dtpCz.Value.ToString();
                        this.dgvByCrkInfo.Rows[index].Cells[4].Value = devices.DEVICENAME;
                    }
                    else
                    {
                        ShowAlertMessage("该设备号不正确，请重新输入！");
                    }
                }
                else
                {
                    ShowAlertMessage("请先登录!");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void txtById_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//编号输入之后，回车之后进行查询
            {              
                TransDatatoView();
                #region 无用代码
                //DataTable dtDisplay1 = new DataTable();
                //DataTable dtDisplay2 = new DataTable();
                //DataColumn column1 = new DataColumn();
                //DataColumn column2 = new DataColumn();

                //column1.ColumnName = "序号";
                //column1.AutoIncrement = true;
                //column1.AutoIncrementSeed = 1;
                //column1.AutoIncrementStep = 1;
                //dtDisplay1.Columns.Add(column1);

                //dtDisplay2.Columns.Add("备件仪表编号");
                //dtDisplay2.Columns.Add("操作人信息");
                //dtDisplay2.Columns.Add("操作日期");
                //dtDisplay2.Columns.Add("备件仪表名称（请右击详细信息）");

                //TransDatatoView(dtDisplay1,dtDisplay2);
                #endregion
            }
        }

        private void dgvByCrkInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmByXxInfo fxi = new frmByXxInfo();
            fxi.Show();
        }

    }
}
