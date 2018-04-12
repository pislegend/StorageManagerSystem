using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMember
{
    /// <summary>
    /// 备件仪表信息实体类
    /// </summary>
    public class Devices
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Devices()
        { }

        #region MODEL
        private string _deviceid;
        private string _devicename;
        private string _devicedepart;
        private string _devicepn;
        private string _devicesn;
        private int _devicesum;
        private int _deviceresidue;
        private DateTime _deviceofindetectiontime;
        private DateTime _deviceofspdetectiontime;
        private string _devicepicroot;
        private string _devicedepots;

        public string DEVICEID
        {
            set { _deviceid = value; }
            get { return _deviceid; }
        }

        public string DEVICENAME
        {
            set { _devicename = value; }
            get { return _devicename; }
        }

        public string DEVICEDEPART
        {
            set { _devicedepart = value; }
            get { return _devicedepart; }
        }

        public string DEVICEPN
        {
            set { _devicepn = value; }
            get { return _devicepn; }
        }

        public string DEVICESN
        {
            set { _devicesn = value; }
            get { return _devicesn; }
        }

        public int DEVICESUM
        {
            set { _devicesum = value; }
            get { return _devicesum; }
        }

        public int DEVICERESIDUE
        {
            set { _deviceresidue = value; }
            get { return _deviceresidue; }
        }

        public DateTime DEVICEOFINDETECTIONTIME
        {
            set { _deviceofindetectiontime = value; }
            get { return _deviceofindetectiontime; }
        }

        public DateTime DEVICEOFSPDETECTIONTIME
        {
            set { _deviceofspdetectiontime = value; }
            get { return _deviceofspdetectiontime; }
        }

        public string DEVICEPICROOT
        {
            set { _devicepicroot = value; }
            get { return _devicepicroot; }
        }

        public string DEVICEDEPOTS
        {
            set { _devicedepots = value; }
            get { return _devicedepots; }
        }
        #endregion
    }
}
