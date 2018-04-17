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
        #region 全局变量 枚举
        DataTable dt = new DataTable();
        int typenumber = 0;
        enum BJTable_E { 备件编号,备件名称,备件部件号,备件序列号,备件所属设备,备件所属部门,备件状态,备件是否在仓库,备件责任人,备件管理员};
        enum YBTools_E { 仪表工具编号,仪表工具名称,仪表工具类型,仪表工具购买时间,仪表工具所属科室,仪表工具状态,仪表工具校验时间,仪表工具季度充电时间,仪表备件位置,仪表工具是否在库,仪表工具责任人,仪表工具管理员};
        enum HCTable_E { 耗材编号,耗材名称,耗材类型,耗材剩余数量,耗材位置,耗材购买时间,耗材管理员,耗材备注};
        #endregion

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
        private void TransDatatoView(int typenumber)
        {
            //BJTable bjtable = new BJTable();
            //HCTable hcttable = new HCTable();
            //YBTools ybtools = new YBTools();
            //Devices devices = new Devices();

            DeviceCrkManage dcm = new DeviceCrkManage();
            //DataTable dt = new DataTable();
            //传入备件仪表ID信息，输出该ID对应的所有信息
            dt=dcm.CxInfofromdatabase(this.txtById.Text, typenumber);
            try
            {
                if (this.grpCz.Text != "")
                {
                    if (dt != null)
                    {
                        int index = this.dgvByCrkInfo.Rows.Add();
                        this.dgvByCrkInfo.Rows[index].Cells[0].Value= index+1;
                        this.dgvByCrkInfo.Rows[index].Cells[1].Value = dt.Rows[0][0].ToString().Trim();
                        this.dgvByCrkInfo.Rows[index].Cells[2].Value = this.grpCz.Text;
                        this.dgvByCrkInfo.Rows[index].Cells[3].Value = dtpCz.Value.ToString();
                        this.dgvByCrkInfo.Rows[index].Cells[4].Value = dt.Rows[0][1].ToString().Trim();
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

                if(cmbType.Text=="")
                { ShowAlertMessage("请选择类型！"); }
                else if (cmbType.Text == "备件")
                { typenumber = 1; }
                else if (cmbType.Text == "仪表")
                { typenumber = 2; }
                else
                { typenumber = 3; }
                TransDatatoView(typenumber);
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
                if(typenumber==1)
                {
                    foreach(int mycode in Enum.GetValues(typeof(BJTable_E)) )
                    {
                        string strName = Enum.GetName(typeof(BJTable_E),mycode);
                        //string strValue = mycode.ToString();
                        fxi.dgvXxInfo.Rows[mycode].Cells[0].Value = strName;
                        fxi.dgvXxInfo.Rows[mycode].Cells[1].Value = dt.Rows[0][mycode];
                    }
                }
                else if (typenumber == 2)
                {
                    foreach (int mycode in Enum.GetValues(typeof(YBTools_E)))
                    {
                        string strName = Enum.GetName(typeof(YBTools_E), mycode);
                        //string strValue = mycode.ToString();
                        fxi.dgvXxInfo.Rows[mycode].Cells[0].Value = strName;
                        fxi.dgvXxInfo.Rows[mycode].Cells[1].Value = dt.Rows[0][mycode];
                    }
                }
                else
                {
                    foreach (int mycode in Enum.GetValues(typeof(HCTable_E)))
                    {
                        string strName = Enum.GetName(typeof(HCTable_E), mycode);
                        //string strValue = mycode.ToString();
                        fxi.dgvXxInfo.Rows[mycode].Cells[0].Value = strName;
                        fxi.dgvXxInfo.Rows[mycode].Cells[1].Value = dt.Rows[0][mycode];
                    }
                }
  

            fxi.Show();
        }

        private void btnRk_Click(object sender, EventArgs e)
        {

        }

        private void btnCk_Click(object sender, EventArgs e)
        {

        }

    }
}
