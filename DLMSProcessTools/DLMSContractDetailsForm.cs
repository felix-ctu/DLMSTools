using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using S3.Text;

namespace DLMSProcessTools
{
    public partial class DLMSContractDetailsForm : Form
    {
        public DLMSContractDetailsForm(string strDistributorID)
        {
            InitializeComponent();
            strDisID = strDistributorID;
            ShowContractProduct(strDisID);            
        }

        private string strDisID = string.Empty;
        private DLMSHelper helper = new DLMSHelper();
        private string[] removeCodeList = new string[] { "114800", "114807", "114815", "114817", "114816", "114801", "LOC17754",
            "113080", "115319", "115317", "955057", "110356", "115311", "115308", "955057" };

        private string[] processDistList = new string[] {"7020","7019","7018","7012","7011","6993","6988","6986","7006",
        "7016", "7015", "7005","7004","7000","6999","6870","6872","6868","6869","6867","6866", "7017", "7021"};

        private void ShowContractProduct(string strDisId)
        {
            //rtbContractProduct.Text = strDisId;

            //DataTable dtContract = helper.GetContractDataByDistId(strDisId);
            //string ProductList = string.Empty;
            //if (dtContract.Rows.Count > 0)
            //{
            //    ProductList = dtContract.Rows[0]["ProductListData"].ToString();
            //}

            //rtbContractProduct.Text = S3.Text.Base64Helper.Base64Decode(ProductList);

            //DataSet dsProduct = helper.XMLToDataSet(rtbContractProduct.Text);
            //gvProductList.DataSource = dsProduct;
            foreach (string strDId in processDistList)
            { BatchProcess(strDisID); }
            
        }

        private void BatchProcess(string disID)
        {
            DataTable dtContract = helper.GetContractDataByDistId(disID);
            string ProductList = string.Empty;
            if (dtContract.Rows.Count > 0)
            {
                ProductList = dtContract.Rows[0]["ProductListData"].ToString();
            }

            //rtbContractProduct.Text = S3.Text.Base64Helper.Base64Decode(ProductList);

            DataSet dsProduct = helper.XMLToDataSet(ProductList);

            if (dsProduct.Tables.Count > 0)
            {
                foreach (DataRow dr in dsProduct.Tables[0].Rows)
                {
                    if (removeCodeList.Contains(dr["ItemCode"].ToString()))
                    {
                        dr.Delete();
                    }
                }
                dsProduct.Tables[0].AcceptChanges();
            }
            gvProductList.DataSource = dsProduct;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encryData = string.Empty;
            encryData = S3.Text.Base64Helper.Base64Encode(rtbContractProduct.Text.Trim());

            if (SqlHelper.UpdateContractDataProductByDistId(strDisID, encryData) > 0)
            {
                MessageBox.Show("Updated Successfully!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Updated Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
