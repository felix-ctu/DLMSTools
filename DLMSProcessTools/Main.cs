using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DLMSProcessTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Intialize();
        }

        private void Intialize()
        {
            string[] strTier1List = { "DLMS", "eGrant", "eMeeting", "eLeave", "QIMS", "CDC" };

            cbTier1.DataSource = strTier1List;
            ResCategoryHelper resHelper = new ResCategoryHelper();
            resHelper.showXml();
            cbTier2.DataSource = resHelper.Tier2List;
            //cbTier1.
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string filter = tbFilter.Text.Trim();
            //string spGetMyTask = "select * from V_MyTasks where Approver like '%" + filter + "'";
            //string spGetMyTask = "select * from V_MyTasks where GBU = 'Renal'";

            int[] DbIdList = new int[] { 6319, 6384, 6520,6428, 6438,6368,6554,6425,
                6351,6400,6322,6256,6407,6385,6459,6371,
                6439,6463,6465,6323,6363,6554,6431};

            using (StreamWriter pStreamWriter = new StreamWriter(@"d:\Wipro\test.txt"))
            {
                pStreamWriter.WriteLine("----------------Title----------------");

                foreach (int dbId in DbIdList)
                {
                    string spGetDistributorInfo = "select * from TB_Distributor where ID = '" + dbId + "'";
                    DataTable dtGetDisInfo = SqlHelper.GetDataTable(System.Data.CommandType.Text, spGetDistributorInfo, null);
                    if (dtGetDisInfo.Rows.Count > 0)
                    {
                        string strPorcInstId = dtGetDisInfo.Rows[0]["ProcInstID"].ToString();
                        pStreamWriter.WriteLine();
                        pStreamWriter.WriteLine(string.Format("Distributor ID : {0} , Proc Inst ID : {1}", dbId, strPorcInstId));
                        pStreamWriter.WriteLine(string.Format("Distributor Name : {0}", dtGetDisInfo.Rows[0]["CNName"].ToString()));
                        DataTable dtApproverList = SqlHelper.GetApproverListByDistributorIdProcInstId(dbId.ToString(), strPorcInstId);

                        if (dtApproverList.Rows.Count > 0)
                        {
                            pStreamWriter.WriteLine("Role,UserName,ApprovalStatus,StartDate,FinishDate");
                            foreach (DataRow drApprover in dtApproverList.Rows)
                            {
                                //    if (isPrintTitle)
                                //{
                                //    pStreamWriter.WriteLine();
                                //    pStreamWriter.WriteLine(string.Format("Distributor ID : {0} , Proc Inst ID : {1}", strDistributorId, strProcInstId));
                                //    pStreamWriter.WriteLine(string.Format("Distributor Name : {0}", dr["CNName"].ToString()));
                                //    pStreamWriter.WriteLine(string.Format("Folio No. : {0}", dr["Title"].ToString()));
                                //    isPrintTitle = false;
                                //}
                                string strRole = drApprover["GroupName"].ToString();
                                string strUser = drApprover["UserName"].ToString();
                                string strStatus = string.Empty;

                                if (drApprover["Status"] != null)
                                {
                                    if (drApprover["Status"].ToString() == "2")
                                        strStatus = "Approved";
                                    else if (drApprover["Status"].ToString() == "0")
                                        strStatus = "Pending";
                                    else if (drApprover["Status"].ToString() == "1")
                                        strStatus = "Expired";
                                    else
                                        strStatus = drApprover["Status"].ToString();
                                }
                                else
                                { strStatus = "Not Approved"; }

                                string strStarDt = drApprover["StartDate"].ToString();
                                string strEndDt = drApprover["FinishDate"].ToString();
                                pStreamWriter.WriteLine(strRole + "," + strUser + "," + strStatus + "," + strStarDt + "," + strEndDt);

                            }
                        }
                    }

                    //DataTable dtTasks = new DataTable();
                    //dtTasks = SqlHelper.GetDataTable(CommandType.Text, spGetMyTask);


                    //    //pStreamWriter.WriteLine("Content");



                    //    if (dtTasks.Rows.Count > 0)
                    //    {
                    //        List<string> listProc = new List<string>();
                    //        foreach (DataRow dr in dtTasks.Rows)
                    //        {
                    //            string strDistributorId = dr["DistID"].ToString();
                    //            string strProcInstId = dr["ProcInstID"].ToString();
                    //            if (listProc.Contains(strProcInstId))
                    //            {
                    //                continue;
                    //            }
                    //            else
                    //                listProc.Add(strProcInstId);
                    //            bool isPrintTitle = true;
                    //            //pStreamWriter.WriteLine(string.Format("Distributor ID : {0} , Proc Inst ID : {1}", strDistributorId, strProcInstId));
                    //            //pStreamWriter.WriteLine(string.Format("Distributor Name : {0}", dr["CNName"].ToString()));
                    //            //pStreamWriter.WriteLine(string.Format("Folio No. : {0}", dr["Title"].ToString()));
                    //            DataTable dtApproverList = SqlHelper.GetApproverListByDistributorIdProcInstId(strDistributorId, strProcInstId);
                    //            if (dtApproverList.Rows.Count > 0)
                    //            {
                    //                foreach (DataRow drApprover in dtApproverList.Rows)
                    //                {
                    //                    int count = dtApproverList.AsEnumerable().Count(row => row.Field<string>("UserName") ==
                    //                        drApprover["UserName"].ToString());
                    //                    if (count > 1 && drApprover["GroupName"].ToString() != "Print" &&
                    //                        drApprover["GroupName"].ToString() != "Upload")
                    //                    {
                    //                        if (isPrintTitle)
                    //                        {
                    //                            pStreamWriter.WriteLine();
                    //                            pStreamWriter.WriteLine(string.Format("Distributor ID : {0} , Proc Inst ID : {1}", strDistributorId, strProcInstId));
                    //                            pStreamWriter.WriteLine(string.Format("Distributor Name : {0}", dr["CNName"].ToString()));
                    //                            pStreamWriter.WriteLine(string.Format("Folio No. : {0}", dr["Title"].ToString()));
                    //                            isPrintTitle = false;
                    //                        }
                    //                        string strStatus = string.Empty;
                    //                        pStreamWriter.WriteLine(string.Format("Role & Approver : {0}, {1}", drApprover["GroupName"], drApprover["UserName"]));
                    //                        if (drApprover["Status"] != null)
                    //                        {
                    //                            if (drApprover["Status"].ToString() == "2")
                    //                                strStatus = "Approved";
                    //                            else if (drApprover["Status"].ToString() == "0")
                    //                                strStatus = "Pending";
                    //                            else
                    //                                strStatus = drApprover["Status"].ToString();
                    //                        }
                    //                        else
                    //                        { strStatus = "Not Approved"; }
                    //                        pStreamWriter.WriteLine(string.Format("Status : {0}", strStatus));
                    //                    }
                    //                }
                    //                //pStreamWriter.WriteLine("----------------D-End----------------");

                    //            }
                    //        }
                    //    }

                    pStreamWriter.WriteLine();
                    pStreamWriter.WriteLine("----------------End------------------");
                    pStreamWriter.Close();
                }
            }
        }


        private void btnOpenSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbGrantNo.Text))
            {
                MessageBox.Show("No Grant Number Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BPMHelper bpmHelper = new BPMHelper();
                string resultFile = "";
                string strGuid = bpmHelper.GetProcInstGuidByGrantNo(tbGrantNo.Text.Trim());

                if (string.IsNullOrEmpty(strGuid))
                {
                    MessageBox.Show("Invalid Grant Number Entered!");
                    return;
                }

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "D:\\Wipro";
                openFileDialog1.Filter = "All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    resultFile = openFileDialog1.FileName;
                    FileInfo openFile = new FileInfo(resultFile);
                    FileStream stream = openFile.OpenRead();
                    //byte[] buffer = new Byte[stream.Length];
                    BinaryReader r = new BinaryReader(stream);

                    r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开

                    byte[] content = r.ReadBytes((int)r.BaseStream.Length);

                    SqlHelper.SaveAttachment(content, strGuid, openFile.Name, openFile.Extension);
                    MessageBox.Show("Saved Successfully!", "Good Job", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //long fileLength = openFile.Length;
                    //byte[] fileByte = new byte[fileLength];
                    //Stream fileStream = openFile.OpenRead();
                    //fileStream.Read(fileByte, 0, fileLength);

                    //entity.AttachmentContent = fileByte;
                }
            }

        }

        private void btnBPMGenerate_Click(object sender, EventArgs e)
        {
            string spGetMyTask = @"select G.GrantNo, G.ProcInstID, G.ProcInstGuid, G.Status from ChinaBPM.dbo.GRANT_TT_Data G
                                    where G.Status in (100,200)";

            DataTable dtGrants = SqlHelper.GetDataTable(CommandType.Text, spGetMyTask);
            //XLWorkbook wb = new XLWorkbook();

            DataTable dtFinal = new DataTable();
            dtFinal.Columns.Add("GrantNo", typeof(string));
            dtFinal.Columns.Add("SubmitedDate", typeof(DateTime));
            dtFinal.Columns.Add("LastApprovedDate", typeof(DateTime));
            dtFinal.Columns.Add("ApproverCount", typeof(int));
            dtFinal.Columns.Add("Amount", typeof(decimal));
            dtFinal.Columns.Add("Status", typeof(string));
            dtFinal.Columns.Add("IfHold", typeof(string));
            dtFinal.Columns.Add("HoldReason", typeof(string));

            if (dtGrants.Rows.Count > 0)
            {
                foreach (DataRow dr in dtGrants.Rows)
                {
                    DataRow drAdd = dtFinal.NewRow();
                    drAdd["GrantNo"] = dr["GrantNo"].ToString();

                    string procGuid = dr["ProcInstGuid"].ToString();
                    string sqlGetCost = "select sum(Amount) from ChinaBPM.dbo.GRANT_TT_Cost where Active = 1 and ProcInstGuid = '" + procGuid + "'";
                    DataTable dtCost = SqlHelper.GetDataTable(CommandType.Text, sqlGetCost);
                    drAdd["Amount"] = dtCost.Rows[0][0];

                    string procInstID = dr["ProcInstID"].ToString();
                    string sqlGetHistory = "select * from  ChinaBPM.dbo.SYS_TT_Comment where ProcInstID = '" + procInstID + "'";
                    DataTable dtHistory = SqlHelper.GetDataTable(CommandType.Text, sqlGetHistory);

                    if (dr["Status"].ToString() == "100")
                        drAdd["Status"] = "Approved";
                    else if (dr["Status"].ToString() == "200")
                        drAdd["Status"] = "Approved&Encoded";

                    drAdd["ApproverCount"] = dtHistory.AsEnumerable().Count(t => t.Field<string>("ActivityName") == "Matrix审批人");
                    DataRow drSubmiter = dtHistory.AsEnumerable().FirstOrDefault(t => t.Field<string>("ActivityName") == "发起人");
                    drAdd["SubmitedDate"] = drSubmiter["CreateDate"];
                    drAdd["LastApprovedDate"] = (from d in dtHistory.AsEnumerable() select d.Field<DateTime>("CreateDate")).Max();

                    DataRow[] drsHold = dtHistory.Select("[Action] = 'Hold'");
                    if (drsHold.Count() > 0)
                    {
                        drAdd["IfHold"] = "Y";
                        string strReason = string.Empty;
                        foreach (DataRow drHold in drsHold)
                        {
                            string userName = drHold["RealName"].ToString().Replace(",", " ");
                            string comment = drHold["Memo"].ToString();
                            strReason += string.Format("{0} : {1} ; ", userName, comment);
                        }
                        drAdd["HoldReason"] = strReason;
                    }
                    else
                    {
                        drAdd["IfHold"] = "N";
                        drAdd["HoldReason"] = string.Empty;
                    }

                    dtFinal.Rows.Add(drAdd);
                }
            }

            //wb.Worksheets.Add(dtFinal, "WorksheetName");

            //wb.SaveAs("temp.xlsx");
            //wb.Dispose();
            SaveDataTableToCSV(dtFinal);
            MessageBox.Show("Generate Successfully");
        }


        private void SaveDataTableToCSV(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();

            string[] columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText("test.csv", sb.ToString(), Encoding.UTF8);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.Show();
        }

        private void btnPatchApprove_Click(object sender, EventArgs e)
        {
            DLMSHelper dlmsHelper = new DLMSHelper();
            List<string> listGet = dlmsHelper.GetHistoryApproverList("19990");
        }

        private void cbTier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResCategoryHelper resHelper = new ResCategoryHelper();
            resHelper.GetTier3ByTier2(cbTier2.SelectedItem.ToString());
            cbTier3.DataSource = resHelper.Tier3List;
            cbTier4.SelectedIndex = -1;
        }

        private void cbTier3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResCategoryHelper resHelper = new ResCategoryHelper();
            resHelper.GetTier4ByTier2Tier3(cbTier1.SelectedItem.ToString(), cbTier2.SelectedItem.ToString(), cbTier3.SelectedItem.ToString());
            cbTier4.DataSource = resHelper.Tier4List;
            SetResOutputText();
        }

        private void SetResOutputText()
        {
            string text = string.Empty;
            if (cbTier1.SelectedIndex > -1)
                text += "Tier1: " + cbTier1.SelectedItem.ToString() + "; ";
            if (cbTier2.SelectedIndex > -1)
                text += "Tier2: " + cbTier2.SelectedItem.ToString() + "; ";
            if (cbTier3.SelectedIndex > -1)
                text += "Tier3: " + cbTier3.SelectedItem.ToString() + "; ";
            if (cbTier4.SelectedIndex > -1)
                text += "Tier4: " + cbTier4.SelectedItem.ToString() + "; ";
            tbResOutput.Text = text;
        }

        private void cbTier4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetResOutputText();
        }

        private void cbTier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetResOutputText();
        }

        private void btnGenerateIncRes_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbResOutput.Text);
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUserEmail.Text))
            {
                if (rbUserInfoBPM.Checked == true)
                {
                    BPMHelper bpmHelper = new BPMHelper();
                    DataTable dtGet = bpmHelper.GetUserInfoByEmailAdId(tbUserEmail.Text);
                    gvUserInfo.DataSource = dtGet;

                    DataTable dtVRGet = bpmHelper.GetVRByAccount(tbUserEmail.Text);
                    grdVR.DataSource = dtVRGet;
                    
                }
                else if (rbUserInfoDLMS.Checked == true)
                {
                    DLMSHelper dlmsHelper = new DLMSHelper();
                    DataTable dtGet = dlmsHelper.GetUserInfoByEmailAdId(tbUserEmail.Text);
                    gvUserInfo.DataSource = dtGet;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strDistID = tbDLMSDistID.Text.Trim();
            DLMSContractDetailsForm contractDetailsForm = new DLMSContractDetailsForm(strDistID);
            contractDetailsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductPriceUpdate form = new ProductPriceUpdate();
            form.ShowDialog();
        }



        //private void SaveAttachment(HttpPostedFile postedFile, string attachmentType, string attachmentTypeName)
        //{
        //    string fileName = System.IO.Path.GetFileName(postedFile.FileName);
        //    string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(postedFile.FileName);
        //    string fileExtension = System.IO.Path.GetExtension(postedFile.FileName);

        //    if (fileName != "")
        //    {
        //        GrantAttachmentInfo entity = WebHelper.SetEntity<GrantAttachmentInfo>("ID");

        //        entity.ProcInstGuid = this.ProcInstGuid;
        //        entity.AttachmentType = attachmentType;
        //        entity.AttachmentTypeName = attachmentTypeName;
        //        entity.FileName = fileName;
        //        entity.FileExtension = fileExtension;
        //        //大于1M，文件保存到服务器
        //        if (postedFile.ContentLength > 1024 * 1024 * GlobalHelper.AttachmentSize)
        //        {
        //            //保存文件到服务器
        //            fileName = fileNameWithoutExtension + "_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + fileExtension;

        //            string filePath = Server.MapPath("~/") + GlobalHelper.AttachmentPath;
        //            if (!Directory.Exists(filePath)) // 判断当前目录是否存在。
        //            {
        //                Directory.CreateDirectory(filePath); // 建立上传文件存放目录。
        //            }
        //            string path = filePath + fileName;
        //            postedFile.SaveAs(path);

        //            entity.AttachmentUrl = path;
        //        }
        //        else
        //        {
        //            int fileLength = postedFile.ContentLength;
        //            byte[] fileByte = new byte[fileLength];
        //            Stream fileStream = postedFile.InputStream;
        //            fileStream.Read(fileByte, 0, fileLength);

        //            entity.AttachmentContent = fileByte;
        //        }
        //        entity.CreateBy = WebContext.Current.CurrentAccount;
        //        entity.Active = true;
        //        GrantAttachmentBLL.SaveData(entity);
        //    }
        //}


    }
}
