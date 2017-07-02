namespace DocLibrary
{
    partial class ConfigForm
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
            System.Windows.Forms.Label branchCodeLabel;
            System.Windows.Forms.Label branchNameLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.docLibDataSet = new DocLibrary.DocLibDataSet();
            this.configurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationsTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.ConfigurationsTableAdapter();
            this.tableAdapterManager = new DocLibrary.DocLibDataSetTableAdapters.TableAdapterManager();
            this.branchCodeTextBox = new System.Windows.Forms.TextBox();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTypesTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.DocumentTypesTableAdapter();
            branchCodeLabel = new System.Windows.Forms.Label();
            branchNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // branchCodeLabel
            // 
            branchCodeLabel.AutoSize = true;
            branchCodeLabel.Location = new System.Drawing.Point(37, 16);
            branchCodeLabel.Name = "branchCodeLabel";
            branchCodeLabel.Size = new System.Drawing.Size(41, 12);
            branchCodeLabel.TabIndex = 1;
            branchCodeLabel.Text = "网点号";
            // 
            // branchNameLabel
            // 
            branchNameLabel.AutoSize = true;
            branchNameLabel.Location = new System.Drawing.Point(278, 16);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new System.Drawing.Size(53, 12);
            branchNameLabel.TabIndex = 3;
            branchNameLabel.Text = "网点名称";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 12);
            label1.TabIndex = 3;
            label1.Text = "档案类别";
            // 
            // docLibDataSet
            // 
            this.docLibDataSet.DataSetName = "DocLibDataSet";
            this.docLibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfigurationsTableAdapter = this.configurationsTableAdapter;
            this.tableAdapterManager.DocumentsTableAdapter = null;
            this.tableAdapterManager.DocumentTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DocLibrary.DocLibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branchCodeTextBox
            // 
            this.branchCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "BranchCode", true));
            this.branchCodeTextBox.Location = new System.Drawing.Point(84, 13);
            this.branchCodeTextBox.Name = "branchCodeTextBox";
            this.branchCodeTextBox.Size = new System.Drawing.Size(166, 21);
            this.branchCodeTextBox.TabIndex = 2;
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "BranchName", true));
            this.branchNameTextBox.Location = new System.Drawing.Point(336, 13);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(166, 21);
            this.branchNameTextBox.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 278);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 33);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(305, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.typeCodeDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(418, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeCodeDataGridViewTextBoxColumn
            // 
            this.typeCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.typeCodeDataGridViewTextBoxColumn.DataPropertyName = "TypeCode";
            this.typeCodeDataGridViewTextBoxColumn.HeaderText = "类代码";
            this.typeCodeDataGridViewTextBoxColumn.Name = "typeCodeDataGridViewTextBoxColumn";
            this.typeCodeDataGridViewTextBoxColumn.Width = 66;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "类名称";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "类说明";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // documentTypesBindingSource
            // 
            this.documentTypesBindingSource.DataMember = "DocumentTypes";
            this.documentTypesBindingSource.DataSource = this.docLibDataSet;
            // 
            // documentTypesTableAdapter
            // 
            this.documentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(514, 321);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(label1);
            this.Controls.Add(branchNameLabel);
            this.Controls.Add(this.branchNameTextBox);
            this.Controls.Add(branchCodeLabel);
            this.Controls.Add(this.branchCodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "一般配置";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DocLibDataSet docLibDataSet;
        private System.Windows.Forms.BindingSource configurationsBindingSource;
        private DocLibDataSetTableAdapters.ConfigurationsTableAdapter configurationsTableAdapter;
        private DocLibDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox branchCodeTextBox;
        private System.Windows.Forms.TextBox branchNameTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource documentTypesBindingSource;
        private DocLibDataSetTableAdapters.DocumentTypesTableAdapter documentTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}