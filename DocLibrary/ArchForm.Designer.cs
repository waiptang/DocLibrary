namespace DocLibrary
{
    partial class ArchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchForm));
            this.tbBranchCode = new System.Windows.Forms.TextBox();
            this.configurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docLibDataSet = new DocLibrary.DocLibDataSet();
            this.tbBranchName = new System.Windows.Forms.TextBox();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.documentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbYearOfCreation = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYofC = new System.Windows.Forms.Label();
            this.lblYofR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRetention = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.documentTypesTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.DocumentTypesTableAdapter();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.configurationsTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.ConfigurationsTableAdapter();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new DocLibrary.DocLibDataSetTableAdapters.QueriesTableAdapter();
            this.documentsTableAdapter1 = new DocLibrary.DocLibDataSetTableAdapters.DocumentsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSeq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBranchCode
            // 
            this.tbBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "BranchCode", true));
            this.tbBranchCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBranchCode.Location = new System.Drawing.Point(75, 8);
            this.tbBranchCode.Name = "tbBranchCode";
            this.tbBranchCode.ReadOnly = true;
            this.tbBranchCode.Size = new System.Drawing.Size(57, 21);
            this.tbBranchCode.TabIndex = 7;
            this.tbBranchCode.Text = "网点号";
            // 
            // configurationsBindingSource
            // 
            this.configurationsBindingSource.DataMember = "Configurations";
            this.configurationsBindingSource.DataSource = this.docLibDataSet;
            // 
            // docLibDataSet
            // 
            this.docLibDataSet.DataSetName = "DocLibDataSet";
            this.docLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBranchName
            // 
            this.tbBranchName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "BranchName", true));
            this.tbBranchName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBranchName.Location = new System.Drawing.Point(138, 8);
            this.tbBranchName.Name = "tbBranchName";
            this.tbBranchName.ReadOnly = true;
            this.tbBranchName.Size = new System.Drawing.Size(110, 21);
            this.tbBranchName.TabIndex = 8;
            this.tbBranchName.Text = "网点名称";
            // 
            // tbSerial
            // 
            this.tbSerial.Enabled = false;
            this.tbSerial.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSerial.ForeColor = System.Drawing.Color.Black;
            this.tbSerial.Location = new System.Drawing.Point(18, 266);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(230, 31);
            this.tbSerial.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(75, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(173, 21);
            this.tbName.TabIndex = 3;
            // 
            // cmbDocType
            // 
            this.cmbDocType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocType.DataSource = this.documentTypesBindingSource;
            this.cmbDocType.DisplayMember = "TypeCode";
            this.cmbDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocType.ForeColor = System.Drawing.Color.Black;
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Location = new System.Drawing.Point(75, 66);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(57, 20);
            this.cmbDocType.TabIndex = 2;
            this.cmbDocType.ValueMember = "TypeCode";
            // 
            // documentTypesBindingSource
            // 
            this.documentTypesBindingSource.DataMember = "DocumentTypes";
            this.documentTypesBindingSource.DataSource = this.docLibDataSet;
            // 
            // cmbYearOfCreation
            // 
            this.cmbYearOfCreation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearOfCreation.ForeColor = System.Drawing.Color.Black;
            this.cmbYearOfCreation.FormattingEnabled = true;
            this.cmbYearOfCreation.Location = new System.Drawing.Point(75, 37);
            this.cmbYearOfCreation.MaxLength = 4;
            this.cmbYearOfCreation.Name = "cmbYearOfCreation";
            this.cmbYearOfCreation.Size = new System.Drawing.Size(57, 20);
            this.cmbYearOfCreation.TabIndex = 0;
            this.cmbYearOfCreation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRetention_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(183, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(112, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(40, 12);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(29, 12);
            this.lblBranch.TabIndex = 6;
            this.lblBranch.Text = "网点";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(16, 70);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "档案分类";
            // 
            // lblYofC
            // 
            this.lblYofC.AutoSize = true;
            this.lblYofC.Location = new System.Drawing.Point(28, 41);
            this.lblYofC.Name = "lblYofC";
            this.lblYofC.Size = new System.Drawing.Size(41, 12);
            this.lblYofC.TabIndex = 9;
            this.lblYofC.Text = "属年份";
            // 
            // lblYofR
            // 
            this.lblYofR.AutoSize = true;
            this.lblYofR.Location = new System.Drawing.Point(138, 41);
            this.lblYofR.Name = "lblYofR";
            this.lblYofR.Size = new System.Drawing.Size(53, 12);
            this.lblYofR.TabIndex = 12;
            this.lblYofR.Text = "保管年份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "档案名称";
            // 
            // tbRetention
            // 
            this.tbRetention.ForeColor = System.Drawing.Color.Black;
            this.tbRetention.Location = new System.Drawing.Point(196, 37);
            this.tbRetention.MaxLength = 4;
            this.tbRetention.Name = "tbRetention";
            this.tbRetention.Size = new System.Drawing.Size(52, 21);
            this.tbRetention.TabIndex = 1;
            this.tbRetention.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRetention_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "档案说明";
            // 
            // documentTypesTableAdapter
            // 
            this.documentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tbTypeName
            // 
            this.tbTypeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentTypesBindingSource, "TypeName", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tbTypeName.ForeColor = System.Drawing.Color.Black;
            this.tbTypeName.Location = new System.Drawing.Point(138, 67);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.ReadOnly = true;
            this.tbTypeName.Size = new System.Drawing.Size(110, 21);
            this.tbTypeName.TabIndex = 15;
            this.tbTypeName.Text = "分类名称";
            // 
            // configurationsTableAdapter
            // 
            this.configurationsTableAdapter.ClearBeforeFill = true;
            // 
            // tbRemark
            // 
            this.tbRemark.ForeColor = System.Drawing.Color.Black;
            this.tbRemark.Location = new System.Drawing.Point(75, 122);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(173, 81);
            this.tbRemark.TabIndex = 4;
            // 
            // btnGen
            // 
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Location = new System.Drawing.Point(134, 237);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(114, 23);
            this.btnGen.TabIndex = 17;
            this.btnGen.Text = "生成档案序号";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // documentsTableAdapter1
            // 
            this.documentsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "序号";
            this.label1.Visible = false;
            // 
            // tbSeq
            // 
            this.tbSeq.ForeColor = System.Drawing.Color.Black;
            this.tbSeq.Location = new System.Drawing.Point(52, 238);
            this.tbSeq.MaxLength = 4;
            this.tbSeq.Name = "tbSeq";
            this.tbSeq.Size = new System.Drawing.Size(52, 21);
            this.tbSeq.TabIndex = 1;
            this.tbSeq.Text = "0001";
            this.tbSeq.Visible = false;
            this.tbSeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRetention_KeyPress);
            // 
            // ArchForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(265, 361);
            this.ControlBox = false;
            this.Controls.Add(this.tbSeq);
            this.Controls.Add(this.tbRetention);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblYofR);
            this.Controls.Add(this.lblYofC);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbYearOfCreation);
            this.Controls.Add(this.cmbDocType);
            this.Controls.Add(this.tbBranchCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.tbBranchName);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.tbSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArchForm";
            this.Text = "归档";
            this.Load += new System.EventHandler(this.ArchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBranchCode;
        private System.Windows.Forms.TextBox tbBranchName;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cmbDocType;
        private System.Windows.Forms.ComboBox cmbYearOfCreation;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblYofC;
        private System.Windows.Forms.Label lblYofR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRetention;
        private System.Windows.Forms.Label label7;
        private DocLibDataSet docLibDataSet;
        private System.Windows.Forms.BindingSource documentTypesBindingSource;
        private DocLibDataSetTableAdapters.DocumentTypesTableAdapter documentTypesTableAdapter;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.BindingSource configurationsBindingSource;
        private DocLibDataSetTableAdapters.ConfigurationsTableAdapter configurationsTableAdapter;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Button btnGen;
        private DocLibDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DocLibDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeq;
    }
}