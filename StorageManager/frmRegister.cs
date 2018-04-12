using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageMember;
using StorageAccessData;
namespace StorageManager
{
    public partial class frmRegister : frmBase
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            {
                employees.EMPLOYEEDEPART = cmbDepart.Text.Trim();
                employees.EMPLOYEERIGHT = cmbRight.Text.Trim();
                employees.EMPLOYEENAME = txtUserName.Text.Trim();
                employees.EMPLOYEEPASSWORD = txtPassword.Text.Trim();
            }

            EmployeesManage empM = new EmployeesManage();
            if (empM.Add(employees))
            {
                this.ShowMessage("注册成功！");
                this.Close();
            }
            else
            {
                this.ShowErrorMessage("注册失败，请重新注册！");
            }
        }
    }
}
