using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseScanner;

namespace StorageMember
{
    /// <summary>
    /// 用户登录实体类
    /// </summary>
    public class Employees
    {
        //构造函数
        public Employees()
        { }
        #region MODEL
        private string _employeeId;
        private string _employeeName;
        private string _employeePassword;
        private string _employeeDepart;
        private string _employeeRight;

        public string EMPLOYEEID
        {
            set { _employeeId = value;}
            get { return _employeeId; }
        }

        public string EMPLOYEENAME
        {
            set { _employeeName = value;}
            get { return _employeeName; }
        }

        public string EMPLOYEEPASSWORD
        {
            set { _employeePassword = value; }
            get { return _employeePassword; }
        }

        public string EMPLOYEEDEPART
        {
            set { _employeeDepart = value; }
            get { return _employeeDepart; }
        }

        public string EMPLOYEERIGHT
        {
            set { _employeeRight = value; }
            get { return _employeeRight; }
        }
        #endregion
    }
}
