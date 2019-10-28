namespace DLMSProcessTools
{
    partial class ProductAddForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDescCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescEN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUnitEN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUnitCN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCurrencyCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGBU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSBU = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbSBU);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbGBU);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbItemPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbCurrencyCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbUnitCN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbUnitEN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDescCN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDescEN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbItemCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 283);
            this.panel1.TabIndex = 0;
            // 
            // tbDescCN
            // 
            this.tbDescCN.Location = new System.Drawing.Point(104, 90);
            this.tbDescCN.Name = "tbDescCN";
            this.tbDescCN.Size = new System.Drawing.Size(264, 20);
            this.tbDescCN.TabIndex = 5;
            this.tbDescCN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " 中文描述";
            // 
            // tbDescEN
            // 
            this.tbDescEN.Location = new System.Drawing.Point(104, 55);
            this.tbDescEN.Name = "tbDescEN";
            this.tbDescEN.Size = new System.Drawing.Size(264, 20);
            this.tbDescEN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " 英文描述";
            // 
            // tbItemCode
            // 
            this.tbItemCode.Location = new System.Drawing.Point(104, 17);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Size = new System.Drawing.Size(100, 20);
            this.tbItemCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // tbUnitEN
            // 
            this.tbUnitEN.Location = new System.Drawing.Point(104, 126);
            this.tbUnitEN.Name = "tbUnitEN";
            this.tbUnitEN.Size = new System.Drawing.Size(100, 20);
            this.tbUnitEN.TabIndex = 7;
            this.tbUnitEN.Text = "EA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "英文计量单位";
            // 
            // tbUnitCN
            // 
            this.tbUnitCN.Location = new System.Drawing.Point(391, 129);
            this.tbUnitCN.Name = "tbUnitCN";
            this.tbUnitCN.Size = new System.Drawing.Size(100, 20);
            this.tbUnitCN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "中文计量单位";
            // 
            // tbCurrencyCode
            // 
            this.tbCurrencyCode.Location = new System.Drawing.Point(104, 160);
            this.tbCurrencyCode.Name = "tbCurrencyCode";
            this.tbCurrencyCode.Size = new System.Drawing.Size(100, 20);
            this.tbCurrencyCode.TabIndex = 11;
            this.tbCurrencyCode.Text = "CNY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "货币单位";
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(391, 160);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(100, 20);
            this.tbItemPrice.TabIndex = 13;
            this.tbItemPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "产品单价";
            // 
            // tbGBU
            // 
            this.tbGBU.Location = new System.Drawing.Point(104, 200);
            this.tbGBU.Name = "tbGBU";
            this.tbGBU.Size = new System.Drawing.Size(100, 20);
            this.tbGBU.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "GBU";
            // 
            // tbSBU
            // 
            this.tbSBU.Location = new System.Drawing.Point(391, 196);
            this.tbSBU.Name = "tbSBU";
            this.tbSBU.Size = new System.Drawing.Size(230, 20);
            this.tbSBU.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "SBU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 285);
            this.Controls.Add(this.panel1);
            this.Name = "ProductAddForm";
            this.Text = "Product Add Form";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDescCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUnitEN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCurrencyCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUnitCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSBU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGBU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}