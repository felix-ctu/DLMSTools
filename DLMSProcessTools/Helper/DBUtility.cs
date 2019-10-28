using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DLMSProcessTools
{

    /// <summary>
    /// The SqlHelper class is intended to encapsulate high performance, 
    /// scalable best practices for common uses of SqlClient.
    /// </summary>
    public abstract class SqlHelper
    {

        //Database connection strings
        public static readonly string DLMSConnectionString = ConfigurationManager.ConnectionStrings["DLMS"].ConnectionString;
        public static readonly string BPMConnectionString = ConfigurationManager.ConnectionStrings["BPM"].ConnectionString;


        // Hashtable to store cached parameters
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

        /// <summary>
        /// Execute a SqlCommand (that returns no resultset) against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>an int representing the number of rows affected by the command</returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// Execute a SqlCommand (that returns no resultset) against an existing database connection 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="conn">an existing database connection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>an int representing the number of rows affected by the command</returns>
        public static int ExecuteNonQuery(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// Execute a SqlCommand (that returns no resultset) using an existing SQL Transaction 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="trans">an existing sql transaction</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>an int representing the number of rows affected by the command</returns>
        public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// Execute a SqlCommand that returns a resultset against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  SqlDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>A SqlDataReader containing the results</returns>
        public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        public static DataTable GetDataTable(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlConnection conn = new SqlConnection(DLMSConnectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                // SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                da.Fill(dt);
                return dt;
                // return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        public static DataTable GetBPMDataTable(CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlConnection conn = new SqlConnection(BPMConnectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                // SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                da.Fill(dt);
                return dt;
                // return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }


        public static DataSet GetDataSet(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlConnection conn = new SqlConnection(connectionString);

            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                // SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //cmd.Parameters.Clear();
                da.Fill(ds);
                return ds;
                // return rdr;
            }
            catch
            {
                // conn.Close();
                throw;
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
            }
        }

        /// <summary>
        /// Execute a SqlCommand that returns the first column of the first record against the database specified in the connection string 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">a valid connection string for a SqlConnection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>An object that should be converted to the expected type using Convert.To{Type}</returns>
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// Execute a SqlCommand that returns the first column of the first record against an existing database connection 
        /// using the provided parameters.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="conn">an existing database connection</param>
        /// <param name="commandType">the CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">the stored procedure name or T-SQL command</param>
        /// <param name="commandParameters">an array of SqlParamters used to execute the command</param>
        /// <returns>An object that should be converted to the expected type using Convert.To{Type}</returns>
        public static object ExecuteScalar(SqlConnection connection, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
        {

            SqlCommand cmd = new SqlCommand();

            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// add parameter array to the cache
        /// </summary>
        /// <param name="cacheKey">Key to the parameter cache</param>
        /// <param name="cmdParms">an array of SqlParamters to be cached</param>
        public static void CacheParameters(string cacheKey, params SqlParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }

        /// <summary>
        /// Retrieve cached parameters
        /// </summary>
        /// <param name="cacheKey">key used to lookup parameters</param>
        /// <returns>Cached SqlParamters array</returns>
        public static SqlParameter[] GetCachedParameters(string cacheKey)
        {
            SqlParameter[] cachedParms = (SqlParameter[])parmCache[cacheKey];

            if (cachedParms == null)
                return null;

            SqlParameter[] clonedParms = new SqlParameter[cachedParms.Length];

            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (SqlParameter)((ICloneable)cachedParms[i]).Clone();

            return clonedParms;
        }

        /// <summary>
        /// Prepare a command for execution
        /// </summary>
        /// <param name="cmd">SqlCommand object</param>
        /// <param name="conn">SqlConnection object</param>
        /// <param name="trans">SqlTransaction object</param>
        /// <param name="cmdType">Cmd type e.g. stored procedure or text</param>
        /// <param name="cmdText">Command text, e.g. Select * from Products</param>
        /// <param name="cmdParms">SqlParameters to use in the command</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }


        public static byte[] DataTableToBytes(DataTable dataTable)
        {
            MemoryStream ms = new MemoryStream();

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, dataTable);

            return ms.ToArray();
        }

        public static int SaveReport(byte[] reportBytes, string reportCategory, string reportAgencyCode)
        {
            SqlParameter[] paras = new SqlParameter[]
           {
               new SqlParameter("@p_agencycode", reportAgencyCode),
               new SqlParameter("@p_year", 2014),
               new SqlParameter("@p_month", 10)
           ,new SqlParameter("@p_version", 1)
           ,new SqlParameter("@p_report", reportBytes)
           ,new SqlParameter("@p_category", reportCategory)
           ,new SqlParameter("@p_dategenerated", DateTime.Now)
           ,new SqlParameter("@p_contenttype", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
           };



            return ExecuteNonQuery(DLMSConnectionString, CommandType.StoredProcedure, "P_PerformanceReports_I",
                paras);

        }

        public static int SaveAttachment(byte[] content, string Guid, string strFileName, string strFileExt)
        {
            string saveSql = @"INSERT INTO ChinaBPM.dbo.SYS_TT_Attachment(
                               ProcInstID, Guid,ProcessName,ActivityName,[FileName],Extension,
                               AttachmentType,AttachmentUser,AttachmentContent,AttachmentUrl,AttachmentDescription,CreateBy,LastUpdateBy,CreateDate,LastUpdateDate,Active
                            ) VALUES (
                               @ProcInstID, @Guid, @ProcessName, @ActivityName, @FileName, @Extension, @AttachmentType, @AttachmentUser
                               ,@AttachmentContent, @AttachmentUrl, @AttachmentDescription, 'sysadmin','sysadmin',getdate(),getdate(),1
                            )";
            SqlParameter[] paras = new SqlParameter[]
           {
               new SqlParameter("@ProcInstID", "0"),
               new SqlParameter("@Guid", Guid),
               new SqlParameter("@ProcessName", "AP\\Grant")
               ,new SqlParameter("@ActivityName", "管理员")
               ,new SqlParameter("@FileName", strFileName)
               ,new SqlParameter("@Extension", strFileExt)
               ,new SqlParameter("@AttachmentType", DBNull.Value)
               ,new SqlParameter("@AttachmentUser", "global\\_zhangy27")
               ,new SqlParameter("@AttachmentContent", content)
               ,new SqlParameter("@AttachmentUrl", DBNull.Value)
               ,new SqlParameter("@AttachmentDescription", "")
           };
            return ExecuteNonQuery(BPMConnectionString, CommandType.Text, saveSql, paras);
        }

        public static int UpdateContractDataProductByDistId(string disID, string encryData)
        {
            string saveSql = @"Update TB_ContractData_Entity set ProductListData = @encryData where DistributorId = @disID";
            SqlParameter[] paras = new SqlParameter[]
            {
               new SqlParameter("@disID", disID),
               new SqlParameter("@encryData", encryData)
            };
            return ExecuteNonQuery(DLMSConnectionString, CommandType.Text, saveSql, paras);
        }

        public static DataTable GetApproverListByDistributorIdProcInstId(string strDbId, string strProcInstId)
        {
            DataSet dsGet = new DataSet();
            SqlParameter[] paras = new SqlParameter[]
           {
               new SqlParameter("@DistributorID", strDbId),
               new SqlParameter("@ProcInstID", strProcInstId),
               new SqlParameter("@URProcInstID", -1)
           };

            dsGet = GetDataSet(DLMSConnectionString, CommandType.StoredProcedure, "DLMSNew.dbo.SP_GetWorkflowApprovalList", paras);
            if (dsGet.Tables.Count > 1)
            {
                return dsGet.Tables[1];
            }
            else
                return new DataTable();
        }

        public static int UpdateProductPriceByItemCodeDistId(string distID, string strItemCode, decimal listPrice)
        {
            string updatesql = @"update TB_ProductPrice
                            set NetPriceWithVAT = @listprice, NetPriceWithoutVAT = convert(decimal(10,4),@listprice/1.17),
                            NetPrice = convert(decimal(10,4),@listprice/1.17), PriceWithoutVAT = convert(decimal(10,4),@listprice/1.17),
                            PriceWithVAT = @listprice, ItemListPrice = @listprice where ItemCode = @itemCode and DistributorID = @DistId";
            SqlParameter[] paras = new SqlParameter[]
                {
                   new SqlParameter("@listprice", listPrice),
                   new SqlParameter("@itemCode", strItemCode),
                   new SqlParameter("@DistId", distID)
                };

            return ExecuteNonQuery(DLMSConnectionString, CommandType.Text, updatesql, paras);

        }
    }
}
