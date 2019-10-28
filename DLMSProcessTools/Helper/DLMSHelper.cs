using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace DLMSProcessTools
{
    public class DLMSHelper
    {
        public List<string> GetHistoryApproverList(string procInstId)
        {
            List<string> getListStr = new List<string>();
            string sqlGetHistoryApp = "select * from K2.dbo._ProcInstXml where ProcInstID = '" + procInstId + "'";
            //DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, sqlGetHistoryApp, null);
            //if (dtGet.Rows.Count > 0)
            //{
            //string AppXml = dtGet.Rows[0]["Value"].ToString();
            string AppXml = "<Root>   <Comment>     <Author>zhangh38 (Haiping Zhang, jessie_zhang@baxter.com)</Author>     <Time>8/15/2016 1:51:58 PM</Time>     <Action>Approved</Action>     <Content />   </Comment>   <Comment>     <Author>_wangz2 (ZHENYU WANG, ryan_wang@baxter.com)</Author>    <Time>2016/8/15 14:11:26</Time>     <Action>JDE Submited</Action>     <Content />   </Comment> </Root>";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(AppXml);
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Root").ChildNodes;
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;
                XmlNodeList nls = xe.ChildNodes;
                foreach (XmlNode xn1 in nls)
                {
                    XmlElement xe2 = (XmlElement)xn1;//转换类型 
                    if (xe2.Name == "Author")//如果找到 
                    {
                        string userName = xe2.InnerText.Substring(0, xe2.InnerText.IndexOf('(')).Trim();
                        getListStr.Add(userName);
                        break;
                    }
                }
            }
            //}
            return getListStr;
        }

        public void MatchApproverHistory()
        {
            string sqlGetHistoryApp = "select * from DLMSNew.dbo.TB_Distriubor where StatusID is not in ('200','300','400')";
            DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, sqlGetHistoryApp, null);
            if (dtGet.Rows.Count > 0)
            {
                foreach (DataRow dr in dtGet.Rows)
                {

                }
            }
        }

        public DataTable GetDistributorInfoByDistId(string strDistId)
        {
            try
            {
                string getSql = string.Empty;
                getSql = @"select * from TB_Distriubor where Id = " + strDistId;
                DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, getSql, null);
                return dtGet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUserInfoByEmailAdId(string strUserEmailId)
        {
            string getSql = string.Empty;
            if (!strUserEmailId.Contains('@'))
            {
                getSql = @"select UserName, RealName, NotificationType, RoleCode, BaxterEntity, BaxterGBU, BaxterSBU, Enabled from TB_Users
                        where UserName like '%"
                        + strUserEmailId + "%'";
                DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, getSql, null);
                return dtGet;
            }
            else
                return new DataTable();
        }

        public DataTable GetContractDataByDistId(string strDistId)
        {
            try
            {
                string getSql = string.Empty;
                getSql = @"select * from TB_ContractData_Entity where DistributorId = " + strDistId;
                DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, getSql, null);
                return dtGet;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetContractByDistId(string strDistId)
        {
            try
            {
                string getSql = string.Empty;
                getSql = @"select * from TB_Contract where DistributorId = " + strDistId;
                DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, getSql, null);
                return dtGet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetFileInforByGuid(string strGuid)
        {
            try
            {
                string getSql = string.Empty;
                getSql = @"select * from FileInformation where GroupId = '" + strGuid + "'";
                DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, getSql, null);
                return dtGet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GetEachDistributorApproverList(string strDbId, string newProcInstId)
        {
            string sqlGetDistChanges = "select * from DLMSNew.dbo.TB_Distributor_Changes where DistributorID = '" + strDbId + "'";
            DataTable dtGet = SqlHelper.GetDataTable(CommandType.Text, sqlGetDistChanges, null);
            if (dtGet.Rows.Count > 0)
            {
                foreach (DataRow dr in dtGet.Rows)
                {
                    if (!string.IsNullOrEmpty(dr["ChangesID"].ToString()))
                    {
                        string strProcInstId = dr["ProcInstID"].ToString();
                    }
                }
            }
        }

        public void UpdateProductPriceByItemCodeDistId(string strDistId, string strItemCode, decimal listPrice)
        {
            int i = SqlHelper.UpdateProductPriceByItemCodeDistId(strDistId, strItemCode, listPrice);
            if (i < 0)
            {
                throw new Exception("No Record find in Distributor");
            }
        }

        #region "Dataset XML Methods"
        public string DataSetToXML(DataSet ds)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            string xmlData = string.Empty;

            try
            {
                //begin add to avoid null ItemUnitMeasureCode
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    if (dr["ItemUnitMeasureCode"] == null || dr["ItemUnitMeasureCode"].ToString().Length < 1)
                    {
                        dr["ItemUnitMeasureCode"] = " ";
                    }
                    ds.Tables[0].AcceptChanges();
                }
                //end

                stream = new MemoryStream();
                writer = new XmlTextWriter(stream, Encoding.UTF8);
                ds.WriteXml(writer);

                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);
                UTF8Encoding utf = new UTF8Encoding();
                xmlData = S3.Text.Base64Helper.Base64Encode(utf.GetString(arr).Trim());

                return xmlData;
            }
            catch
            {
                return string.Empty;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        public DataSet XMLToDataSet(string xmlData)
        {
            xmlData = S3.Text.Base64Helper.Base64Decode(xmlData);

            xmlData = System.Text.RegularExpressions.Regex.Replace(xmlData, "^[^<]", "");

            StringReader stream = null;
            XmlTextReader reader = null;

            try
            {
                DataSet ds = new DataSet();
                stream = new StringReader(xmlData);
                reader = new XmlTextReader(stream);
                ds.ReadXml(reader);

                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        #endregion
    }
}
