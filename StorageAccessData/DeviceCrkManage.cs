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
        /// <param name="DeviceID">输入界面中编号</param>
        /// <param name="typenumber">输入界面中类型</param>
        public DataTable CxInfofromdatabase(string DeviceID,int typenumber)
        {
            //Devices devices = new Devices();
            CommonSql pComm = new CommonSql();
            DataTable dt = new DataTable();
            StringBuilder strSql = new StringBuilder();
            string dtlName = "mydatatable";

            /// <summary>
            /// 根据输入页面输入的不同，操作不同的数据库表
            /// </summary>
            switch(typenumber){
                case 1://备件
                    strSql.Append("SELECT * FROM [BJTable] WHERE ");
                    strSql.Append("BJId=");
                    strSql.Append("'"+DeviceID+"'");
                    dt = pComm.ExeForDtl(strSql.ToString(), dtlName);
                    pComm.Close();
                    break;
                #region 无用代码
                //if (dt != null && dt.Rows.Count > 0)//从数据库中未查到相关数据的判断
                        //{
                        //    bjtable.BJID = dt.Rows[0]["BJId"].ToString().Trim();
                        //    bjtable.BJNAME = dt.Rows[1]["BJName"].ToString().Trim();
                        //    bjtable.BJPN = dt.Rows[2]["BJPn"].ToString().Trim();
                        //    bjtable.BJSN = dt.Rows[3]["BJSn"].ToString().Trim();
                        //    bjtable.BJFACILITY = dt.Rows[4]["BJFacility"].ToString().Trim();
                        //    bjtable.BJDEPART = dt.Rows[5]["BJDepart"].ToString().Trim();
                        //    bjtable.BJSTATE = dt.Rows[6]["BJState"].ToString().Trim();
                        //    bjtable.BJISINSTORAGE = dt.Rows[7]["BJIsInStorage"].ToString().Trim();
                        //    bjtable.BJPERSONINCHARGE = dt.Rows[8]["BJPersonInCharge"].ToString().Trim();
                        //    bjtable.BJSTORAGEMANAGER = dt.Rows[9]["BJStorageManager"].ToString().Trim();

                        //    return bjtable;
                        //}
                        //else
                        //{
                        //    devices = null;
                        //    return devices;
                //} 
                #endregion
                case 2://仪表
                    strSql.Append("SELECT * FROM [YBTools] WHERE ");
                    strSql.Append("YBToolId=");
                    strSql.Append("'"+DeviceID+"'");
                    dt = pComm.ExeForDtl(strSql.ToString(), dtlName);
                    pComm.Close();
                    break;
                case 3://耗材
                    strSql.Append("SELECT * FROM [HCTable] WHERE ");
                    strSql.Append("HCId=");
                    strSql.Append("'"+DeviceID+"'");
                    dt = pComm.ExeForDtl(strSql.ToString(), dtlName);
                    pComm.Close();
                    break;
            }
            return dt;//return只能放在最后，不能放在case下面
            #region 无用代码
            //strSql.Append("SELECT * FROM [Devices] WHERE ");
            //strSql.Append("DeviceId=");
            //strSql.Append("'"+DeviceID+"'");

            ////string dtlName = "mydatatable";
            //try
            //{

            //    dt = pComm.ExeForDtl(strSql.ToString(),dtlName);
            //    pComm.Close();
            //    if (dt!=null&&dt.Rows.Count>0)//从数据库中未查到相关数据的判断
            //    {
            //        devices.DEVICEID = dt.Rows[0]["DeviceId"].ToString().Trim();
            //        devices.DEVICENAME = dt.Rows[0]["DeviceName"].ToString().Trim();
            //        devices.DEVICEDEPART = dt.Rows[0]["DeviceDepart"].ToString().Trim();
            //        devices.DEVICEPN = dt.Rows[0]["DevicePn"].ToString().Trim();
            //        devices.DEVICESN = dt.Rows[0]["DeviceSn"].ToString().Trim();
            //        devices.DEVICESUM = (int)dt.Rows[0]["DeviceSum"];
            //        devices.DEVICERESIDUE = (int)dt.Rows[0]["DeviceResidue"];
            //        devices.DEVICEOFINDETECTIONTIME = (DateTime)dt.Rows[0]["DeviceOfInDetectionTime"];
            //        devices.DEVICEOFSPDETECTIONTIME = (DateTime)dt.Rows[0]["DeviceOfSpDetectionTime"];
            //        devices.DEVICEPICROOT = dt.Rows[0]["DevicePicRoot"].ToString().Trim();
            //        devices.DEVICEDEPOTS = dt.Rows[0]["DeviceDepots"].ToString().Trim();

            //        return devices;
            //    }
            //    else
            //    {
            //        devices = null;
            //        return devices;
            //    }
            //}
            //catch(Exception e)
            //{
            //    pComm.Close();
            //    throw e;
            //}
            #endregion
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
