using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMember
{
    /// <summary>
    /// 仪表工具信息实体类
    /// </summary>
    public class YBTools
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public YBTools()
        { }

        #region MODEL
        private string _ybtoolid;
        private string _ybtoolname;
        private string _ybtooltype;
        private DateTime _ybtoolbuytime;
        private string _ybtooldepart;
        private string _ybtoolstate;
        private DateTime _ybtooljytime;
        private DateTime _ybtooltesttime;
        private string _ybtoolpos;
        private string _ybtoolisinstorage;
        private string _ybtoolpersonincharge;
        private string _ybtoolstoragemanager;

        public string YBTOOLID
        {
            set { _ybtoolid = value; }
            get { return _ybtoolid; }
        }

        public string YBTOOLNAME
        {
            set { _ybtoolname = value; }
            get { return _ybtoolname; }
        }

        public string YBTOOLTYPE
        {
            set { _ybtooltype = value; }
            get { return _ybtooltype; }
        }

        public DateTime YBTOOLBUYTIME
        {
            set { _ybtoolbuytime = value; }
            get { return _ybtoolbuytime; }
        }

        public string YBTOOLDEPART
        {
            set { _ybtooldepart = value; }
            get { return _ybtooldepart; }
        }

        public string YBTOOLSTATE
        {
            set { _ybtoolstate = value; }
            get { return _ybtoolstate; }
        }

        public DateTime YBTOOLJYTIME
        {
            set { _ybtooljytime = value; }
            get { return _ybtooljytime; }
        }

        public DateTime YBTOOLTESTTIME
        {
            set { _ybtooltesttime = value; }
            get { return _ybtooltesttime; }
        }

        public string YBTOOLPOS
        {
            set { _ybtoolpos = value; }
            get { return _ybtoolpos; }
        }

        public string YBTOOLISINSTORAGE
        {
            set { _ybtoolisinstorage = value; }
            get { return _ybtoolisinstorage; }
        }

        public string YBTOOLPERSONINCHARGE
        {
            set { _ybtoolpersonincharge = value; }
            get { return _ybtoolpersonincharge; }
        }

        public string YBTOOLSTORAGEMANAGER
        {
            set { _ybtoolstoragemanager = value; }
            get { return _ybtoolstoragemanager; }
        }
        #endregion
    }
}
