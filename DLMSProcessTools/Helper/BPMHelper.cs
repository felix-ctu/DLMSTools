using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DLMSProcessTools
{
    public class BPMHelper
    {
        public string GetProcInstGuidByGrantNo(string strGrantNo)
        {
            string saveSql = @"Select ProcInstGuid from GRANT_TT_Data where GrantNo = '" + strGrantNo + "'";
            DataTable dtGet = SqlHelper.GetBPMDataTable(CommandType.Text, saveSql, null);
            if (dtGet.Rows.Count > 0)
                return dtGet.Rows[0][0].ToString();
            else
                return string.Empty;
        }

        public DataTable GetUserInfoByEmailAdId(string strUserEmailId)
        {
            string getSql = string.Empty;
            if (strUserEmailId.Contains('@'))
                getSql = @"select E.Account, E.NameCN, E.NameEN, E.Phone, E.Mobile, E.EmployeeID, E.Email, E.CountryCode, Sup.NameCN As 'Supervisor', Sup.Account As 'SupervisorId',
                        E.CompanyCode, E.DeptCode, E.LocationCode, E.GBU, E.SBU, E.Enabled, E.Position, E.ReportsTo from SYS_TM_Employee E 
                        left join SYS_TM_Employee Sup on E.ReportsTo = Sup.Position
                        where E.Email like '%"
                    + strUserEmailId + "%'";
            else
                getSql = @"select E.Account, E.NameCN, E.NameEN, E.Phone, E.Mobile, E.EmployeeID, E.Email, E.CountryCode, Sup.NameCN As 'Supervisor', Sup.Account As 'SupervisorId',
                        E.CompanyCode, E.DeptCode, E.LocationCode, E.GBU, E.SBU, E.Enabled, E.Position, E.ReportsTo from SYS_TM_Employee E 
                        left join SYS_TM_Employee Sup on E.ReportsTo = Sup.Position
                        where E.Account like '%"
                    + strUserEmailId + "%'";
            DataTable dtGet = SqlHelper.GetBPMDataTable(CommandType.Text, getSql, null);
            if (dtGet.Rows.Count > 0)
                return dtGet;
            else
                return new DataTable();
        }

        public DataTable GetVRByAccount(string strUserEmailId)
        {
            DataTable dtUserInfo = GetUserInfoByEmailAdId(strUserEmailId);
            string strAccount = string.Empty;
            if (dtUserInfo.Rows.Count > 0)
            {
                strAccount = dtUserInfo.Rows[0]["Account"].ToString();
                string getVRSQL = @"select * from SYS_TM_VirtualRoleUser  where EmployeeAccount = '" + strAccount + "' and " + 
                    "Active = 1";
                DataTable dtGet = SqlHelper.GetBPMDataTable(CommandType.Text, getVRSQL, null);
                if (dtGet.Rows.Count > 0)
                    return dtGet;
                else
                    return new DataTable();
            }

            return null;
        }
    } 
}
