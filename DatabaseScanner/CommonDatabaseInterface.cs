using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DatabaseScanner
{
    public interface CommonDatabaseInterface
    {
        /// <summary>
        /// 开始一个事务
        /// </summary>
        void BeginTrans();

        /// <summary>
        /// 提交事务
        /// </summary>
        void CommitTrans();

        /// <summary>
        /// 回滚一个事务
        /// </summary>
        void RollbackTrans();

        /// <summary>
        /// 打开数据库
        /// </summary>
        void Open();

        /// <summary>
        /// 关闭数据库
        /// </summary>
        void Close();

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        void Execute(String sql);

        /// <summary>
        /// 使用datareader方法读取数据库
        /// </summary>
        ///void ExeForDrd(String QueryString);

        /// <summary>
        /// 使用dataset方法读取数据库,填充到指定的datatable，返回dataset
        /// </summary>
        DataSet ExeForDst(String QueryString, String strTable);

        /// <summary>
        /// 使用datatable方法读取数据库
        /// </summary>
        DataTable ExeForDtl(String QueryString, String TableName);
    }
}
