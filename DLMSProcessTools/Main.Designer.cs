namespace DLMSProcessTools
{
    partial class Main
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInc = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTier4 = new System.Windows.Forms.ComboBox();
            this.cbTier3 = new System.Windows.Forms.ComboBox();
            this.cbTier2 = new System.Windows.Forms.ComboBox();
            this.btnGenerateIncRes = new System.Windows.Forms.Button();
            this.cbTier1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResOutput = new System.Windows.Forms.TextBox();
            this.tabDLMS = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDLMSDistID = new System.Windows.Forms.TextBox();
            this.btnPatchApprove = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabBPM = new System.Windows.Forms.TabPage();
            this.tbGrantNo = new System.Windows.Forms.TextBox();
            this.radLabel1 = new System.Windows.Forms.Label();
            this.btnOpenSave = new System.Windows.Forms.Button();
            this.btnBPMGenerate = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbUserInfoBPM = new System.Windows.Forms.RadioButton();
            this.rbUserInfoDLMS = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdVR = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvUserInfo = new System.Windows.Forms.DataGridView();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDLMS.SuspendLayout();
            this.tabBPM.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInc);
            this.tabControl1.Controls.Add(this.tabDLMS);
            this.tabControl1.Controls.Add(this.tabBPM);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 455);
            this.tabControl1.TabIndex = 5;
            // 
            // tabInc
            // 
            this.tabInc.Controls.Add(this.panel1);
            this.tabInc.Location = new System.Drawing.Point(4, 25);
            this.tabInc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInc.Name = "tabInc";
            this.tabInc.Size = new System.Drawing.Size(876, 426);
            this.tabInc.TabIndex = 2;
            this.tabInc.Text = "Incidents/WO";
            this.tabInc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbTier4);
            this.panel1.Controls.Add(this.cbTier3);
            this.panel1.Controls.Add(this.cbTier2);
            this.panel1.Controls.Add(this.btnGenerateIncRes);
            this.panel1.Controls.Add(this.cbTier1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbResOutput);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 263);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tier 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tier 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tier 2";
            // 
            // cbTier4
            // 
            this.cbTier4.AllowDrop = true;
            this.cbTier4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTier4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTier4.FormattingEnabled = true;
            this.cbTier4.Location = new System.Drawing.Point(98, 137);
            this.cbTier4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTier4.Name = "cbTier4";
            this.cbTier4.Size = new System.Drawing.Size(438, 33);
            this.cbTier4.TabIndex = 12;
            this.cbTier4.SelectedIndexChanged += new System.EventHandler(this.cbTier4_SelectedIndexChanged);
            // 
            // cbTier3
            // 
            this.cbTier3.AllowDrop = true;
            this.cbTier3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTier3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTier3.FormattingEnabled = true;
            this.cbTier3.Location = new System.Drawing.Point(98, 98);
            this.cbTier3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTier3.Name = "cbTier3";
            this.cbTier3.Size = new System.Drawing.Size(438, 33);
            this.cbTier3.TabIndex = 11;
            this.cbTier3.SelectedIndexChanged += new System.EventHandler(this.cbTier3_SelectedIndexChanged);
            // 
            // cbTier2
            // 
            this.cbTier2.AllowDrop = true;
            this.cbTier2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTier2.FormattingEnabled = true;
            this.cbTier2.Location = new System.Drawing.Point(98, 57);
            this.cbTier2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTier2.Name = "cbTier2";
            this.cbTier2.Size = new System.Drawing.Size(438, 33);
            this.cbTier2.TabIndex = 10;
            this.cbTier2.SelectedIndexChanged += new System.EventHandler(this.cbTier2_SelectedIndexChanged);
            // 
            // btnGenerateIncRes
            // 
            this.btnGenerateIncRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateIncRes.Location = new System.Drawing.Point(579, 137);
            this.btnGenerateIncRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerateIncRes.Name = "btnGenerateIncRes";
            this.btnGenerateIncRes.Size = new System.Drawing.Size(174, 32);
            this.btnGenerateIncRes.TabIndex = 9;
            this.btnGenerateIncRes.Text = "Copy Clipboard";
            this.btnGenerateIncRes.UseVisualStyleBackColor = true;
            this.btnGenerateIncRes.Click += new System.EventHandler(this.btnGenerateIncRes_Click);
            // 
            // cbTier1
            // 
            this.cbTier1.AllowDrop = true;
            this.cbTier1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTier1.FormattingEnabled = true;
            this.cbTier1.Location = new System.Drawing.Point(98, 15);
            this.cbTier1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTier1.Name = "cbTier1";
            this.cbTier1.Size = new System.Drawing.Size(438, 33);
            this.cbTier1.TabIndex = 2;
            this.cbTier1.SelectedIndexChanged += new System.EventHandler(this.cbTier1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tier 1";
            // 
            // tbResOutput
            // 
            this.tbResOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResOutput.Location = new System.Drawing.Point(32, 203);
            this.tbResOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResOutput.Name = "tbResOutput";
            this.tbResOutput.Size = new System.Drawing.Size(767, 30);
            this.tbResOutput.TabIndex = 0;
            // 
            // tabDLMS
            // 
            this.tabDLMS.Controls.Add(this.button3);
            this.tabDLMS.Controls.Add(this.button2);
            this.tabDLMS.Controls.Add(this.button1);
            this.tabDLMS.Controls.Add(this.label7);
            this.tabDLMS.Controls.Add(this.tbDLMSDistID);
            this.tabDLMS.Controls.Add(this.btnPatchApprove);
            this.tabDLMS.Controls.Add(this.btnProductAdd);
            this.tabDLMS.Controls.Add(this.label1);
            this.tabDLMS.Controls.Add(this.tbFilter);
            this.tabDLMS.Controls.Add(this.btnGenerate);
            this.tabDLMS.Location = new System.Drawing.Point(4, 25);
            this.tabDLMS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDLMS.Name = "tabDLMS";
            this.tabDLMS.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDLMS.Size = new System.Drawing.Size(876, 426);
            this.tabDLMS.TabIndex = 0;
            this.tabDLMS.Text = "Distributor Lifecycle Management System";
            this.tabDLMS.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Product Price Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Contract Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Distributor ID";
            // 
            // tbDLMSDistID
            // 
            this.tbDLMSDistID.Location = new System.Drawing.Point(140, 82);
            this.tbDLMSDistID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDLMSDistID.Name = "tbDLMSDistID";
            this.tbDLMSDistID.Size = new System.Drawing.Size(89, 25);
            this.tbDLMSDistID.TabIndex = 10;
            // 
            // btnPatchApprove
            // 
            this.btnPatchApprove.Location = new System.Drawing.Point(555, 27);
            this.btnPatchApprove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPatchApprove.Name = "btnPatchApprove";
            this.btnPatchApprove.Size = new System.Drawing.Size(140, 27);
            this.btnPatchApprove.TabIndex = 9;
            this.btnPatchApprove.Text = "Patch Approver";
            this.btnPatchApprove.UseVisualStyleBackColor = true;
            this.btnPatchApprove.Click += new System.EventHandler(this.btnPatchApprove_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(427, 27);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(100, 27);
            this.btnProductAdd.TabIndex = 8;
            this.btnProductAdd.Text = "Product Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-163, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Approver ID:";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(19, 27);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(211, 25);
            this.tbFilter.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(304, 27);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 27);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabBPM
            // 
            this.tabBPM.Controls.Add(this.tbGrantNo);
            this.tabBPM.Controls.Add(this.radLabel1);
            this.tabBPM.Controls.Add(this.btnOpenSave);
            this.tabBPM.Controls.Add(this.btnBPMGenerate);
            this.tabBPM.Location = new System.Drawing.Point(4, 25);
            this.tabBPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabBPM.Name = "tabBPM";
            this.tabBPM.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabBPM.Size = new System.Drawing.Size(876, 426);
            this.tabBPM.TabIndex = 1;
            this.tabBPM.Text = "BPM";
            this.tabBPM.UseVisualStyleBackColor = true;
            // 
            // tbGrantNo
            // 
            this.tbGrantNo.Location = new System.Drawing.Point(108, 31);
            this.tbGrantNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbGrantNo.Name = "tbGrantNo";
            this.tbGrantNo.Size = new System.Drawing.Size(204, 25);
            this.tbGrantNo.TabIndex = 11;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(32, 33);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(67, 21);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "BPM No.";
            // 
            // btnOpenSave
            // 
            this.btnOpenSave.Location = new System.Drawing.Point(407, 29);
            this.btnOpenSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenSave.Name = "btnOpenSave";
            this.btnOpenSave.Size = new System.Drawing.Size(136, 27);
            this.btnOpenSave.TabIndex = 9;
            this.btnOpenSave.Text = "Save Attachment";
            this.btnOpenSave.UseVisualStyleBackColor = true;
            this.btnOpenSave.Click += new System.EventHandler(this.btnOpenSave_Click);
            // 
            // btnBPMGenerate
            // 
            this.btnBPMGenerate.Location = new System.Drawing.Point(594, 29);
            this.btnBPMGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBPMGenerate.Name = "btnBPMGenerate";
            this.btnBPMGenerate.Size = new System.Drawing.Size(156, 27);
            this.btnBPMGenerate.TabIndex = 0;
            this.btnBPMGenerate.Text = "Generate Report";
            this.btnBPMGenerate.UseVisualStyleBackColor = true;
            this.btnBPMGenerate.Click += new System.EventHandler(this.btnBPMGenerate_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.panel2);
            this.tabUser.Controls.Add(this.groupBox2);
            this.tabUser.Controls.Add(this.groupBox1);
            this.tabUser.Controls.Add(this.btnUserSearch);
            this.tabUser.Controls.Add(this.tbUserEmail);
            this.tabUser.Controls.Add(this.label5);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(876, 426);
            this.tabUser.TabIndex = 3;
            this.tabUser.Text = "User Info";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbUserInfoBPM);
            this.panel2.Controls.Add(this.rbUserInfoDLMS);
            this.panel2.Location = new System.Drawing.Point(510, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 37);
            this.panel2.TabIndex = 8;
            // 
            // rbUserInfoBPM
            // 
            this.rbUserInfoBPM.AutoSize = true;
            this.rbUserInfoBPM.Location = new System.Drawing.Point(104, 12);
            this.rbUserInfoBPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbUserInfoBPM.Name = "rbUserInfoBPM";
            this.rbUserInfoBPM.Size = new System.Drawing.Size(52, 19);
            this.rbUserInfoBPM.TabIndex = 1;
            this.rbUserInfoBPM.TabStop = true;
            this.rbUserInfoBPM.Text = "BPM";
            this.rbUserInfoBPM.UseVisualStyleBackColor = true;
            // 
            // rbUserInfoDLMS
            // 
            this.rbUserInfoDLMS.AutoSize = true;
            this.rbUserInfoDLMS.Location = new System.Drawing.Point(19, 12);
            this.rbUserInfoDLMS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbUserInfoDLMS.Name = "rbUserInfoDLMS";
            this.rbUserInfoDLMS.Size = new System.Drawing.Size(60, 19);
            this.rbUserInfoDLMS.TabIndex = 0;
            this.rbUserInfoDLMS.TabStop = true;
            this.rbUserInfoDLMS.Text = "DLMS";
            this.rbUserInfoDLMS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdVR);
            this.groupBox2.Location = new System.Drawing.Point(4, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(861, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Virtual Role";
            // 
            // grdVR
            // 
            this.grdVR.AllowUserToAddRows = false;
            this.grdVR.AllowUserToDeleteRows = false;
            this.grdVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVR.Location = new System.Drawing.Point(8, 47);
            this.grdVR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdVR.Name = "grdVR";
            this.grdVR.Size = new System.Drawing.Size(845, 194);
            this.grdVR.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvUserInfo);
            this.groupBox1.Location = new System.Drawing.Point(4, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(861, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Profile";
            // 
            // gvUserInfo
            // 
            this.gvUserInfo.AllowUserToAddRows = false;
            this.gvUserInfo.AllowUserToDeleteRows = false;
            this.gvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserInfo.Location = new System.Drawing.Point(8, 31);
            this.gvUserInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gvUserInfo.Name = "gvUserInfo";
            this.gvUserInfo.Size = new System.Drawing.Size(845, 72);
            this.gvUserInfo.TabIndex = 6;
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSearch.Location = new System.Drawing.Point(759, 12);
            this.btnUserSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(100, 27);
            this.btnUserSearch.TabIndex = 4;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserEmail.Location = new System.Drawing.Point(133, 12);
            this.tbUserEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(351, 26);
            this.tbUserEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email /AD Id :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "Print Dist Protocol";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabInc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDLMS.ResumeLayout(false);
            this.tabDLMS.PerformLayout();
            this.tabBPM.ResumeLayout(false);
            this.tabBPM.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDLMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabPage tabBPM;
        private System.Windows.Forms.Button btnBPMGenerate;
        private System.Windows.Forms.Button btnOpenSave;
        private System.Windows.Forms.TextBox tbGrantNo;
        private System.Windows.Forms.Label radLabel1;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnPatchApprove;
        private System.Windows.Forms.TabPage tabInc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTier1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTier4;
        private System.Windows.Forms.ComboBox cbTier3;
        private System.Windows.Forms.ComboBox cbTier2;
        private System.Windows.Forms.Button btnGenerateIncRes;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbUserInfoBPM;
        private System.Windows.Forms.RadioButton rbUserInfoDLMS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdVR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvUserInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDLMSDistID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

