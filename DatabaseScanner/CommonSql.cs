using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseScanner
{
    /// <summary>
    /// 用于数据库连接方式的类
    /// </summary>
    public class CommonSql:CommonDatabaseInterface
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlTransaction trans = null;
        private String connstr = null;

        /// <summary>
        /// 构造方法
        /// </summary>
        public CommonSql()
        {
            connstr = CommonDataConfig.ConnectionDefaultStr;
            Initial();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initial()
        {
            try
            {
                if (connstr == null)
                {
                    throw (new Exception("数据库连接字符串没有在StorageManager命名空间的App.config里面设置"));
                }
                this.conn = new SqlConnection(connstr);
                this.cmd = new SqlCommand();
                cmd.Connection = this.conn;
                this.conn.Open();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 开始一个事务
        /// </summary>
        public void BeginTrans()
        {
            trans = conn.BeginTransaction();
            cmd.Transaction = trans;
        }

        /// <summary>
        /// 提交一个事务
        /// </summary>
        public void CommitTrans()
        {
            trans.Commit();
        }

        /// <summary>
        /// 回滚一个事务
        /// </summary>
        public void RollbackTrans()
        {
            trans.Rollback();
        }

        /// <summary>
        /// 打开一个数据库
        /// </summary>
        public void Open()
        {
            if (conn.State.ToString().ToUpper() != "OPEN")
            {
                this.conn.Open();
            }
        }

        /// <summary>
        /// 关闭一个数据库
        /// </summary>
        public void Close()
        {
            if(conn.State.ToString().ToUpper()=="OPEN")
            {
                this.conn.Close();
            }
        }


        /// <summary>
        /// 执行SQL语句,无返回
        /// </summary>
        /// <param name="sql">SQL语句</param>
        public void Execute(String sql)
        {
            try
            {
                cmd.CommandType=CommandType.Text;
                cmd.CommandText=sql;
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 执行SQL语句,填充到指定的datatable，返回dataset
        /// </summary>
        /// <param name="QueryString">SQL语句</param>
        /// <param name="strTable">DataTable的名称</param>
        /// <returns>DataSet数据集合</returns>
        public DataSet ExeForDst(String QueryString,String strTable)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = QueryString;
            try
            {
                ad.SelectCommand = cmd;
                ad.Fill(ds,strTable);
            }
            catch(Exception e)
            {
                throw e;
            }
            return ds;
        }

        /// <summary>
        /// 执行SQL语句,返回datatable
        /// </summary>
        /// <param name="QueryString">SQL语句</param>
        /// <param name="TableName">DataTable的名称</param>
        /// <returns>DataTable数据集合</returns>
        public DataTable ExeForDtl(String QueryString,String TableName)
        {
            try
            {
                DataSet ds;
                DataTable dt;
                ds = ExeForDst(QueryString, TableName);
                dt = ds.Tables[TableName];
                ds = null;
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            { }
        }

        

    }
}
