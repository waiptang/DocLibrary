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
            this.docLibDataSet = new DocLibrary.DocLibDataSet();
            this.configurationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationsTableAdapter = new DocLibrary.DocLibDataSetTableAdapters.ConfigurationsTableAdapter();
            this.tableAdapterManager = new DocLibrary.DocLibDataSetTableAdapters.TableAdapterManager();
            this.branchCodeTextBox = new System.Windows.Forms.TextBox();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            branchCodeLabel = new System.Windows.Forms.Label();
            branchNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).BeginInit();
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
            branchNameLabel.Location = new System.Drawing.Point(25, 47);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new System.Drawing.Size(53, 12);
            branchNameLabel.TabIndex = 3;
            branchNameLabel.Text = "网点名称";
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
            this.branchCodeTextBox.Size = new System.Drawing.Size(150, 21);
            this.branchCodeTextBox.TabIndex = 2;
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationsBindingSource, "BranchName", true));
            this.branchNameTextBox.Location = new System.Drawing.Point(83, 44);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(150, 21);
            this.branchNameTextBox.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(189, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(245, 130);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(branchNameLabel);
            this.Controls.Add(this.branchNameTextBox);
            this.Controls.Add(branchCodeLabel);
            this.Controls.Add(this.branchCodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docLibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationsBindingSource)).EndInit();
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
    }
}