using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DLMSProcessTools
{
    public partial class ProductPriceUpdate : Form
    {
        public ProductPriceUpdate()
        {
            InitializeComponent();
            IntializeListViewProPrice();
        }

        private DLMSHelper helper = new DLMSHelper();

        private void IntializeListViewProPrice()
        {
            //ColumnHeader ch = new ColumnHeader();
            //ch.Text = "Item Code";
            //ch.Width = 50;
            //lvProductList.Columns.Add(ch);

            //ColumnHeader ch2 = new ColumnHeader();
            //ch2.Text = "Product Price";
            //ch2.Width = 50;
            //lvProductList.Columns.Add(ch2);
        }

        private void btnAddProductPrice_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = tbItemCode.Text.Trim();
            item.SubItems.Add(tbProductPrice.Text.Trim());
            lvProductList.Items.Add(item);

            tbItemCode.Text = tbProductPrice.Text = string.Empty;
        }


        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            lvProductList.Items.Remove(lvProductList.FocusedItem);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] ListDistId = rtbDistID.Text.Trim().Split(';');
            foreach (string DistID in ListDistId)
            {
                foreach (ListViewItem item in lvProductList.Items)
                {
                    string strItemCode = item.SubItems[0].Text;
                    decimal listPrice = decimal.Parse(item.SubItems[1].Text);

                    UpdateProductPrice(DistID, strItemCode, listPrice);
                }
            }
        }

        private void UpdateProductPrice(string strDistId, string stritemCode, decimal productPrice)
        {
            helper.UpdateProductPriceByItemCodeDistId(strDistId, stritemCode, productPrice);
            ContractProductProcess(strDistId, stritemCode, productPrice);
        }

        private void ContractProductProcess(string disID, string strItemCode, decimal listPrice)
        {
            DataTable dtContract = helper.GetContractDataByDistId(disID);
            string ProductList = string.Empty;
            if (dtContract.Rows.Count > 0)
            {
                ProductList = dtContract.Rows[0]["ProductListData"].ToString();
            }


            DataSet dsProduct = helper.XMLToDataSet(ProductList);

            if (dsProduct.Tables.Count > 0)
            {
                foreach (DataRow dr in dsProduct.Tables[0].Rows)
                {
                    if (dr["ItemCode"].ToString() == strItemCode)
                    {
                        dr["PriceWithVAT"] = listPrice.ToString();
                        dr["PriceWithoutVAT"] = Math.Round(listPrice / Decimal.Parse("1.17"), 4).ToString();
                        dsProduct.Tables[0].AcceptChanges();
                        continue;
                    }
                }                
            }

            string encryData = helper.DataSetToXML(dsProduct);
            //encryData = S3.Text.Base64Helper.Base64Encode(encryData);

            if (SqlHelper.UpdateContractDataProductByDistId(disID, encryData) < 0)
            {
                MessageBox.Show("Updated Product List Data Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            lvProductList.Items.Clear();

            FileStream fs = new FileStream("ProductListPriceUpdate.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s;
            s = sr.ReadLine();
            if (s.StartsWith("ItemCode"))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    string[] proList = s.Split(',');
                    if (proList.Length == 2)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = proList[0];
                        item.SubItems.Add(proList[1]);
                        lvProductList.Items.Add(item);
                    }
                    
                }
            }
        }
    }
}
