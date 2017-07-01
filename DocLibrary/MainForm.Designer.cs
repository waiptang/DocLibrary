namespace DocLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.documentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docLibDataSet = new DocLibrary.DocLibDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbBranchCode = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.documentTypesTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.DocumentTypesTableAdapter();
            this.configurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationsTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.ConfigurationsTableAdapter();
            this.tbBranchName = new System.Windows.Forms.TextBox();
            this.configurationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArchive
            // 
            this.btnArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchive.Location = new System.Drawing.Point(25, 17);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(106, 40);
            this.btnArchive.TabIndex = 0;
            this.btnArchive.Text = "归档";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.Location = new System.Drawing.Point(25, 85);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(106, 40);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "移交";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(25, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "销毁";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(127, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArchive);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnTransfer);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDocType);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.tbBranchName);
            this.groupBox2.Controls.Add(this.tbBranchCode);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cmbDocType
            // 
            this.cmbDocType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDocType.DataSource = this.documentTypesBindingSource;
            this.cmbDocType.DisplayMember = "TypeName";
            this.cmbDocType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Location = new System.Drawing.Point(21, 50);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(173, 20);
            this.cmbDocType.TabIndex = 3;
            this.cmbDocType.ValueMember = "TypeCode";
            this.cmbDocType.SelectionChangeCommitted += new System.EventHandler(this.cmbDocType_SelectionChangeCommitted);
            this.cmbDocType.TextChanged += new System.EventHandler(this.cmbDocType_TextChanged);
            // 
            // documentTypesBindingSource
            // 
            this.documentTypesBindingSource.DataMember = "DocumentTypes";
            this.documentTypesBindingSource.DataSource = this.docLibDataSet;
            // 
            // docLibDataSet
            // 
            this.docLibDataSet.DataSetName = "DocLibDataSet";
            this.docLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(21, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(173, 21);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "档案名称";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(21, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(173, 21);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "保管年份";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(21, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 21);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "档案年份";
            // 
            // tbBranchCode
            // 
            this.tbBranchCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "BranchCode", true));
            this.tbBranchCode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBranchCode.Location = new System.Drawing.Point(21, 20);
            this.tbBranchCode.Name = "tbBranchCode";
            this.tbBranchCode.ReadOnly = true;
            this.tbBranchCode.Size = new System.Drawing.Size(57, 21);
            this.tbBranchCode.TabIndex = 1;
            this.tbBranchCode.Text = "网点号";
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Location = new System.Drawing.Point(12, 233);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(67, 24);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.Text = "配置管理";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // documentTypesTableAdapter
            // 
            this.documentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // configurationsBindingSource
            // 
            this.configurationsBindingSource.DataMember = "Configurations";
            this.configurationsBindingSource.DataSource = this.docLibDataSet;
            // 
            // configurationsTableAdapter
            // 
            this.configurationsTableAdapter.ClearBeforeFill = true;
            // 
            // tbBranchName
            // 
            this.tbBranchName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource1, "BranchName", true));
            this.tbBranchName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBranchName.Location = new System.Drawing.Point(84, 20);
            this.tbBranchName.Name = "tbBranchName";
            this.tbBranchName.ReadOnly = true;
            this.tbBranchName.Size = new System.Drawing.Size(110, 21);
            this.tbBranchName.TabIndex = 1;
            this.tbBranchName.Text = "网点号";
            // 
            // configurationsBindingSource1
            // 
            this.configurationsBindingSource1.DataMember = "Configurations";
            this.configurationsBindingSource1.DataSource = this.docLibDataSet;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 269);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "档案柜";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbBranchCode;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ComboBox cmbDocType;
        private DocLibDataSet docLibDataSet;
        private System.Windows.Forms.BindingSource documentTypesBindingSource;
        private DocLibDataSetTableAdapters.DocumentTypesTableAdapter documentTypesTableAdapter;
        private System.Windows.Forms.BindingSource configurationsBindingSource;
        private DocLibDataSetTableAdapters.ConfigurationsTableAdapter configurationsTableAdapter;
        private System.Windows.Forms.TextBox tbBranchName;
        private System.Windows.Forms.BindingSource configurationsBindingSource1;
    }
}

