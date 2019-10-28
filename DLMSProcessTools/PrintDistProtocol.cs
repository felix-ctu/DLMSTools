using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DLMSProcessTools
{
    public partial class PrintDistProtocol : Form
    {
        public PrintDistProtocol()
        {
            InitializeComponent();
        }

        public DLMSHelper helper = new DLMSHelper();

        private string GetFileNameByDistId(string strDisId)
        {
            DataTable dtGet = helper.GetDistributorInfoByDistId(strDisId);
            if (dtGet.Rows.Count > 0)
            {
                string DistName = dtGet.Rows[0]["CNName"].ToString();
                string GBU = dtGet.Rows[0]["BaxterGBUCode"].ToString();
                string SBU = dtGet.Rows[0]["BaxterSBUCode"].ToString();

                return strDisId + "-" + DistName + "-" + GBU + "-" + SBU;
            }

            return "NoDistName";
        }
        
        private string getScanAttachmentByDistId(string strDistId)
        {
            DataTable dtGet = helper.GetContractByDistId(strDistId);
            if (dtGet.Rows.Count > 0)
            {
                if (dtGet.Rows[0]["ScanAttachmentGroup"] != null)
                {
                    return dtGet.Rows[0]["ScanAttachmentGroup"].ToString();
                }
            }
            return string.Empty;
        }

        private string getFileUrlByGuid(string strGuid)
        {
            DataTable dtGet = helper.GetFileInforByGuid(strGuid);
            if (dtGet.Rows.Count > 0)
            {
                if (dtGet.Rows[0]["FileAbsUrl"] != null)
                {
                    return dtGet.Rows[0]["FileAbsUrl"].ToString();
                }
            }
            return string.Empty;
        }

        private void DownloadFile(string strUrl, string fileName)
        {
            CreateDownloadFolder();

            //Create a WebClient to use as our download proxy for the program.
            WebClient webClient = new WebClient();

            webClient.UseDefaultCredentials = true;
            webClient.Credentials = new NetworkCredential("_zhangy27", "iPhone6sP", "global");

            //Attach the DownloadFileCompleted event to your new AsyncCompletedEventHandler Completed
            //so when the event occurs the method is called.
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

            //Attach the DownloadProgressChanged event to your DownloadProgressChangedEventHandler ProgressChanged,
            //so again when the event occurs the method is called.
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            //Attempt to actually download the file, this is where the error that you
            //won't see is probably occurring, this is because it checks the url in 
            //the blocking function internally and won't execute the download itself 
            //until this clears.

            Uri downUri = new Uri(strUrl);

            if (downUri.Host == "cnsnapp05")
            {
                return;
            }

            string fileExtension = downUri.Segments.LastOrDefault();
            FileInfo fileInfo = new FileInfo(fileExtension);
            fileName += fileInfo.Extension;

            webClient.DownloadFile(downUri, Path.Combine("ProPrint", fileName));

            //webClient.DownloadFile(new Uri(strUrl), "ProPrint");
        }

        //Method that just increments the progressBar every time the DownloadProgressChangedEvent from webClient fires.
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        //This is your method that will pop when the AsyncCompletedEvent is fired,
        //this doesn't mean that the download was successful though which is why
        //it's misleading, it just means that the Async process completed.
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }

        private void CreateDownloadFolder()
        {
            DirectoryInfo dir = new DirectoryInfo("ProPrint");
            if (!dir.Exists)
            {
                dir.Create();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string[] strDistList = rtbDistList.Text.Trim().Split(';');
            foreach (string strDist in strDistList)
            {
                string strGuid = getScanAttachmentByDistId(strDist);
                if (!string.IsNullOrEmpty(strGuid))
                {
                    string fileUrl = getFileUrlByGuid(strGuid);
                    if (!string.IsNullOrEmpty(fileUrl))
                    {
                        string fileName = GetFileNameByDistId(strDist);
                        DownloadFile(fileUrl, fileName);
                    }
                }
            }

            MessageBox.Show("Download completed!");
        }
    }
}
