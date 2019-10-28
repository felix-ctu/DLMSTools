namespace DLMSProcessTools
{
    partial class ProductPriceUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDistID = new System.Windows.Forms.RichTextBox();
            this.grpProductPrice = new System.Windows.Forms.GroupBox();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProductPrice = new System.Windows.Forms.Button();
            this.lvProductList = new System.Windows.Forms.ListView();
            this.headerItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpProductPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDistID);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distributor ID List (;)";
            // 
            // rtbDistID
            // 
            this.rtbDistID.Location = new System.Drawing.Point(6, 24);
            this.rtbDistID.Name = "rtbDistID";
            this.rtbDistID.Size = new System.Drawing.Size(514, 83);
            this.rtbDistID.TabIndex = 0;
            this.rtbDistID.Text = "";
            // 
            // grpProductPrice
            // 
            this.grpProductPrice.Controls.Add(this.btnImport);
            this.grpProductPrice.Controls.Add(this.btnDelProduct);
            this.grpProductPrice.Controls.Add(this.tbProductPrice);
            this.grpProductPrice.Controls.Add(this.label2);
            this.grpProductPrice.Controls.Add(this.tbItemCode);
            this.grpProductPrice.Controls.Add(this.label1);
            this.grpProductPrice.Controls.Add(this.btnAddProductPrice);
            this.grpProductPrice.Controls.Add(this.lvProductList);
            this.grpProductPrice.Location = new System.Drawing.Point(12, 181);
            this.grpProductPrice.Name = "grpProductPrice";
            this.grpProductPrice.Size = new System.Drawing.Size(526, 362);
            this.grpProductPrice.TabIndex = 1;
            this.grpProductPrice.TabStop = false;
            this.grpProductPrice.Text = "Product LIst";
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Location = new System.Drawing.Point(426, 262);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(92, 23);
            this.btnDelProduct.TabIndex = 6;
            this.btnDelProduct.Text = "Delete";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(421, 215);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(97, 25);
            this.tbProductPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Price";
            // 
            // tbItemCode
            // 
            this.tbItemCode.Location = new System.Drawing.Point(423, 139);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Size = new System.Drawing.Size(97, 25);
            this.tbItemCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Code";
            // 
            // btnAddProductPrice
            // 
            this.btnAddProductPrice.Location = new System.Drawing.Point(423, 53);
            this.btnAddProductPrice.Name = "btnAddProductPrice";
            this.btnAddProductPrice.Size = new System.Drawing.Size(97, 23);
            this.btnAddProductPrice.TabIndex = 1;
            this.btnAddProductPrice.Text = "Add";
            this.btnAddProductPrice.UseVisualStyleBackColor = true;
            this.btnAddProductPrice.Click += new System.EventHandler(this.btnAddProductPrice_Click);
            // 
            // lvProductList
            // 
            this.lvProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerItemCode,
            this.headerProductPrice});
            this.lvProductList.Location = new System.Drawing.Point(6, 24);
            this.lvProductList.Name = "lvProductList";
            this.lvProductList.Size = new System.Drawing.Size(411, 319);
            this.lvProductList.TabIndex = 0;
            this.lvProductList.UseCompatibleStateImageBehavior = false;
            this.lvProductList.View = System.Windows.Forms.View.Details;
            // 
            // headerItemCode
            // 
            this.headerItemCode.Text = "Item Code";
            this.headerItemCode.Width = 169;
            // 
            // headerProductPrice
            // 
            this.headerProductPrice.Text = "Product Price";
            this.headerProductPrice.Width = 178;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(353, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(426, 303);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(92, 23);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ProductPriceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 595);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpProductPrice);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductPriceUpdate";
            this.Text = "ProductPriceUpdate";
            this.groupBox1.ResumeLayout(false);
            this.grpProductPrice.ResumeLayout(false);
            this.grpProductPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDistID;
        private System.Windows.Forms.GroupBox grpProductPrice;
        private System.Windows.Forms.Button btnAddProductPrice;
        private System.Windows.Forms.ListView lvProductList;
        private System.Windows.Forms.ColumnHeader headerItemCode;
        private System.Windows.Forms.ColumnHeader headerProductPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnImport;
    }
}