using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMember;
using DatabaseScanner;
using System.Data;
using System.Xml;
//using System.Windows.Forms;


namespace StorageAccessData
{
    /// <summary>
    /// 用户登录管理控制类
    /// </summary>
    public class EmployeesManage
    {
        /// <summary>
        /// 注册实现方法
        /// </summary>
        /// <param name="employees">用户实体类成员</param>
        public bool Add(Employees employees)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Employees](");
            strSql.Append("EmployeeName,EmployeeRight,EmployeePassword,EmployeeDepart");
            strSql.Append(")");
            strSql.Append("values(");
            strSql.Append("'"+employees.EMPLOYEENAME+"',");
            strSql.Append("'" + employees.EMPLOYEERIGHT + "',");
            strSql.Append("'" + employees.EMPLOYEEPASSWORD + "',");
            strSql.Append("'" + employees.EMPLOYEEDEPART + "'");
            strSql.Append(")");

            //CommonDatabaseInterface pComm = new CommonSql();
            CommonSql pComm = new CommonSql();
            try
            {
                pComm.Execute(strSql.ToString());
                pComm.Close();
                return true;
            }
            catch(Exception e)
            {
                pComm.Close();
                throw e;
            }      
        }

        /// <summary>
        ///用户登录方法实现
        /// </summary>
        /// <param name="employees">用户实体类</param>
        public bool  LoginUser(Employees employees,out DataTable dt)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT * FROM [Employees] WHERE ");
            strSql.Append("EmployeeName=");
            strSql.Append("'" + employees.EMPLOYEENAME + "'");//特别留意该处语法

            CommonSql pComm = new CommonSql();
            string dtlName = "mydatatable";
            try
            {
                dt= pComm.ExeForDtl(strSql.ToString(),dtlName);
                pComm.Close();
                //将从数据库中读取的用户数据写入xml文件中
                //WriteUserInfoXML(dt);
                //检验权限
                //校验密码正确性
                if (dt.Rows.Count > 0)
                {

                        if (employees.EMPLOYEEPASSWORD == dt.Rows[0]["EmployeePassword"].ToString().Trim())
                         {
                            return true;
                         }
                         else
                        {
                            return false;
                        }


                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                pComm.Close();
                throw e;
            }
        }

        ///// <summary>
        /////将从数据库中读取的用户数据存入XML文件中，便于使用
        ///// </summary>
        ///// <param name="dtlName">读取数据库的DataTable名称</param>
        //public void WriteUserInfoXML(DataTable dtlName)
        //{
        //    string fileName = Application.StartupPath+ @"\HistoryUserInfo.xml";

        //    XmlDocument myXmlDocument = new XmlDocument();
        //    myXmlDocument.Load(fileName);
        //    XmlNode rootNode = myXmlDocument.DocumentElement;
        //    //
        //    rootNode.ChildNodes[0].ChildNodes[0].Attributes["value"].Value = dtlName.Rows[0]["EmployeeRight"].ToString();
        //    //
        //    rootNode.ChildNodes[0].ChildNodes[1].Attributes["value"].Value = dtlName.Rows[0]["EmployeeName"].ToString();
        //    //
        //    rootNode.ChildNodes[0].ChildNodes[2].Attributes["value"].Value = dtlName.Rows[0]["EmployeePassword"].ToString();
        //    //
        //    rootNode.ChildNodes[0].ChildNodes[3].Attributes["value"].Value = dtlName.Rows[0]["EmployeeDepart"].ToString();
        //    myXmlDocument.Save(fileName);
        //}
        ///// <summary>
        /////从XML文件中，读取数据
        ///// </summary>
        ///// 
        //public void ReadFromXml()
        //{
        //    string fileName = Application.StartupPath + @"\HistoryUserInfo.xml";

        //    XmlDocument myXmlDocument = new XmlDocument();
        //    myXmlDocument.Load(fileName);
        //    XmlNode rootNode = myXmlDocument.DocumentElement;

        //    string userright = rootNode.ChildNodes[0].ChildNodes[0].Attributes["value"].Value;
        //    string username = rootNode.ChildNodes[0].ChildNodes[1].Attributes["value"].Value;
        //    string userpassword = rootNode.ChildNodes[0].ChildNodes[2].Attributes["value"].Value;
        //    string userdepart = rootNode.ChildNodes[0].ChildNodes[3].Attributes["value"].Value;
        //}
        
    }
}
