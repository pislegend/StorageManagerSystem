using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMember;
using DatabaseScanner;
using System.Data;

namespace StorageAccessData
{
    /// <summary>
    /// 备件仪表出入库管理类
    /// </summary>
    public class DeviceCrkManage
    {
        /// <summary>
        /// 根据扫描枪的ID信息从数据库中查找对应的数据条目
        /// </summary>
        /// <param name="DeviceID"></param>
        public Devices CxInfofromdatabase(string DeviceID)
        {
            Devices devices = new Devices();
            CommonSql pComm = new CommonSql();
            DataTable dt = new DataTable();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM [Devices] WHERE ");
            strSql.Append("DeviceId=");
            strSql.Append("'"+DeviceID+"'");

            string dtlName = "mydatatable";
            try
            {

                dt = pComm.ExeForDtl(strSql.ToString(),dtlName);
                pComm.Close();
                if (dt!=null&&dt.Rows.Count>0)//从数据库中未查到相关数据的判断
                {
                    devices.DEVICEID = dt.Rows[0]["DeviceId"].ToString().Trim();
                    devices.DEVICENAME = dt.Rows[0]["DeviceName"].ToString().Trim();
                    devices.DEVICEDEPART = dt.Rows[0]["DeviceDepart"].ToString().Trim();
                    devices.DEVICEPN = dt.Rows[0]["DevicePn"].ToString().Trim();
                    devices.DEVICESN = dt.Rows[0]["DeviceSn"].ToString().Trim();
                    devices.DEVICESUM = (int)dt.Rows[0]["DeviceSum"];
                    devices.DEVICERESIDUE = (int)dt.Rows[0]["DeviceResidue"];
                    devices.DEVICEOFINDETECTIONTIME = (DateTime)dt.Rows[0]["DeviceOfInDetectionTime"];
                    devices.DEVICEOFSPDETECTIONTIME = (DateTime)dt.Rows[0]["DeviceOfSpDetectionTime"];
                    devices.DEVICEPICROOT = dt.Rows[0]["DevicePicRoot"].ToString().Trim();
                    devices.DEVICEDEPOTS = dt.Rows[0]["DeviceDepots"].ToString().Trim();

                    return devices;
                }
                else
                {
                    devices = null;
                    return devices;
                }
            }
            catch(Exception e)
            {
                pComm.Close();
                throw e;
            }
        }

        /// <summary>
        /// 根据扫描信息对数据库中的备件仪表进行状态更新
        /// </summary>
        /// <param name="DeviceID"></param>
        public bool UpdateInfotodatebase()
        {
            return true;
        }

        /// <summary>
        /// 根据扫描信息对数据库中的备件仪表进行状态更新
        /// </summary>
        /// <param name="DeviceID"></param>
        /// 
        public void BindData(Devices devices)
        {
 
        }
    }
}
