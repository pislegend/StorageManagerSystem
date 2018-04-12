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
    //定义委托，完成frmStorageMain和frmCrkManage窗体中的label更新
    public delegate void TransfDelegate(String value);

    public partial class frmLogin : frmBase
    {
        #region 子窗体实例化
        private frmRegister frmregister = new frmRegister();
        //private frmCrkmanage frmcrkmanage = new frmCrkmanage();
        #endregion
        public frmLogin()
        {
            InitializeComponent();

        }

        private void llbRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            frmregister.Show();
        }

        //按键登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        //实例化委托
        public event TransfDelegate TransfEvent;
        //登录函数
        private void login()
        {
            //判断输入是否为空
            if(cmbRole.Text.Trim()=="")
            {

                ShowAlertMessage("请选择用户角色！");
                return;
            }
            if(cmbUserName.Text.Trim()=="")
            {
                ShowAlertMessage("请输入用户名！");
                return;
            }
            if(txtPassword.Text.Trim()=="")
            {
                ShowAlertMessage("请输入密码");
                return;
            }

            //获取输入框中输入的数据
            Employees employees = new Employees();
            employees.EMPLOYEERIGHT = cmbRole.Text.Trim();
            employees.EMPLOYEENAME = cmbUserName.Text.Trim();
            employees.EMPLOYEEPASSWORD = txtPassword.Text.Trim();
            DataTable dt = new DataTable();
            //实例化登录控制类
            EmployeesManage empM = new EmployeesManage();
            try
            {

                if (empM.LoginUser(employees,out dt))
                {
                    this.ShowMessage("登录成功！");
                    //frmCrkmanage fck = new frmCrkmanage();
                    //fck.btnScanner.Enabled = true;
                    string UpdateInfo = dt.Rows[0]["EmployeeDepart"].ToString() +"   "+ dt.Rows[0]["EmployeeName"].ToString();
                    TransfEvent(UpdateInfo);//触发事件

                    this.Close();
                }
                else
                {
                    this.ShowErrorMessage("登录失败！");
                }

            }
            catch(Exception e)
            {
                throw e;
            }
 
        }



        //如果输入完密码按回车键也可以实现登录
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                login();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
