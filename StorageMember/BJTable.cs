using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMember
{
    /// <summary>
    /// 备件信息实体类
    /// </summary>
    public class BJTable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public BJTable()
        { }

        #region MODEL
        private string _bjid;
        private string _bjname;
        private string _bjpn;
        private string _bjsn;
        private string _bjfacility;
        private string _bjdepart;
        private string _bjstate;
        private string _bjisinstorage;
        private string _bjpersonincharge;
        private string _bjstoragemanager;

        public string BJID
        {
            set { _bjid = value; }
            get { return _bjid; }
        }

        public string BJNAME
        {
            set { _bjname = value; }
            get { return _bjname; }
        }

        public string BJPN
        {
            set { _bjpn = value; }
            get { return _bjpn; }
        }

        public string BJSN
        {
            set { _bjsn = value; }
            get { return _bjsn; }
        }

        public string BJFACILITY
        {
            set { _bjfacility = value; }
            get { return _bjfacility; }
        }

        public string BJDEPART
        {
            set { _bjdepart = value; }
            get { return _bjdepart; }
        }

        public string BJSTATE
        {
            set { _bjstate = value; }
            get { return _bjstate; }
        }

        public string BJISINSTORAGE
        {
            set { _bjisinstorage = value; }
            get { return _bjisinstorage; }
        }

        public string BJPERSONINCHARGE
        {
            set { _bjpersonincharge = value; }
            get { return _bjpersonincharge; }
        }

        public string BJSTORAGEMANAGER
        {
            set { _bjstoragemanager = value; }
            get { return _bjstoragemanager; }
        }
        #endregion
    }
}
