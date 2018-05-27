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
            //将从数据库中读取的数据存入dt中之后，再存入实体类中，便于报表调用数据
            BJTable bjtable = new BJTable();
            YBTools ybtools = new YBTools();
            HCTable hcttable = new HCTable();

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
                    #region 将dt中的数据存入实体类中，便于报表调用
                    bjtable.BJID = dt.Rows[0][0].ToString();
                    bjtable.BJNAME = dt.Rows[0][1].ToString();
                    bjtable.BJPN = dt.Rows[0][2].ToString();
                    bjtable.BJSN = dt.Rows[0][3].ToString();
                    bjtable.BJFACILITY = dt.Rows[0][4].ToString();
                    bjtable.BJDEPART = dt.Rows[0][5].ToString();
                    bjtable.BJSTATE = dt.Rows[0][6].ToString();
                    bjtable.BJISINSTORAGE = dt.Rows[0][7].ToString();
                    bjtable.BJPERSONINCHARGE = dt.Rows[0][8].ToString();
                    bjtable.BJSTORAGEMANAGER = dt.Rows[0][9].ToString();
                    #endregion
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
                    #region

                    #endregion
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
        /// <param name="flag">操作时出库还是入库的标志变量</param>
        /// <param name="hcnumber">更新的耗材数量</param>
        /// <param name="id">项目的ID号</param>
        /// <param name="number">0备件，1仪表还是2耗材</param>
        public bool UpdateInfotodatebase(string flag,int number,string id,int hcnumber)
        {
            try
            {
                CommonSql pComm = new CommonSql();
                string strSql = null;
                pComm.Open();

                switch(number){
                    case 1://备件
                        if (flag == "c")
                        {
                            strSql = "UPDATE BJTable SET BJIsInStorage='0' WHERE BJId='id'";
                            pComm.Execute(strSql);
                            pComm.Close();
                        }else if(flag=="r")
                        {
                            strSql = "UPDATE BJTable SET BJIsInStorage='1' WHERE BJId='id'";
                            pComm.Execute(strSql);
                            pComm.Close();
                        }
                        break;
                    case 2://仪表
                        if (flag == "c")
                        {
                            strSql = "UPDATE YBTools SET YBToolsIsInStorage='0' WHERE YBToolId='id'";
                            pComm.Execute(strSql);
                            pComm.Close();
                        }else if(flag=="r")
                        {
                            strSql = "UPDATE BJTable SET YBToolsIsInStorage='1' WHERE YBToolId='id'";
                            pComm.Execute(strSql);
                            pComm.Close();
                        }
                        break;
                    case 3://耗材
                        if (flag == "c")
                        {
                            strSql = "UPDATE HCTable SET HCResidue=HCResidue-hcnumber WHERE HCId='id'";
                            pComm.Execute(strSql);
                            pComm.Close();
                        }else if(flag=="r")
                        {
                            strSql = "UPDATE HCTable SET HCResidue=HCResidue+hcnumber WHERE HCId='id'";
                            pComm.Execute(strSql);
                            pComm.Close();
                        }
                        break;
                }
                return true; 
            }
            catch
            {    
                return false;
            }
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
