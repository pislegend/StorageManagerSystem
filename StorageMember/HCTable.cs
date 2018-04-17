using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMember
{
    /// <summary>
    /// 耗材信息实体类
    /// </summary>
    public class HCTable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public HCTable()
        { }

        #region
        private string _hcid;
        private string _hcname;
        private string _hctype;
        private string _hcresidue;
        private string _hcposition;
        private DateTime _hcbuytime;
        private string _hcstoragemanager;
        private string _hcnote;

        public string HCID
        {
            set { _hcid = value; }
            get { return _hcid; }
        }

        public string HCNAME
        {
            set { _hcname = value; }
            get { return _hcname; }
        }

        public string HCTYPE
        {
            set { _hctype = value; }
            get { return _hctype; }
        }

        public string HCRESIDUE
        {
            set { _hcresidue = value; }
            get { return _hcresidue; }
        }

        public string HCPOSITION
        {
            set { _hcposition = value; }
            get { return _hcposition; }
        }

        public DateTime HCBUYTIME
        {
            set { _hcbuytime = value; }
            get { return _hcbuytime; }
        }

        public string HCSTORAGEMANAGER
        {
            set { _hcstoragemanager = value; }
            get { return _hcstoragemanager; }
        }

        public string HCNOTE
        {
            set { _hcnote = value; }
            get { return _hcnote; }
        }



        #endregion
    }
}
