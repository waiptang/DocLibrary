using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocLibrary
{
    public partial class ArchForm : Form
    {
        public ArchForm()
        {
            InitializeComponent();
        }

        #region GUI
        private void resetControl(Control cntl, string txt)
        {
            cntl.ForeColor = Color.LightGray;
            cntl.Text = txt;
        }
        #endregion

        private void ArchForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“docLibDataSet.Configurations”中。您可以根据需要移动或删除它。
            this.configurationsTableAdapter.Fill(this.docLibDataSet.Configurations);
            // TODO: 这行代码将数据加载到表“docLibDataSet.DocumentTypes”中。您可以根据需要移动或删除它。
            this.documentTypesTableAdapter.Fill(this.docLibDataSet.DocumentTypes);

            for (int i = DateTime.Now.Year-15; i <= DateTime.Now.Year ; i++)
            {
                this.cmbYearOfCreation.Items.Add(i);
            }            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                NewArchive();
                this.documentsTableAdapter1.Update(this.docLibDataSet.Documents);
                MessageBox.Show("保存成功");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"保存出错");
                this.Close();
            }            
        }

        private void tbRetention_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateSerial()
        {
            string nextcode ="";
            try
            {
                nextcode = this.queriesTableAdapter1.GetNextCode(this.tbBranchCode.Text, Convert.ToInt16(this.cmbYearOfCreation.Text), this.cmbDocType.Text, Convert.ToInt16(this.tbRetention.Text));                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "资料缺失或有误");
                return;
            }
            if (nextcode == "")
            {
                nextcode = this.tbSeq.Text;
            }
            else
            {
                this.tbSeq.Text = nextcode;
            }
            this.tbSerial.Text = this.tbBranchCode.Text + this.cmbYearOfCreation.Text + this.cmbDocType.Text + this.tbRetention.Text + nextcode;
        }

        private bool IsReady()
        {
            bool isReady = true;
            this.lblBranch.ForeColor = Color.Black;
            this.lblType.ForeColor = Color.Black;
            this.lblYofC.ForeColor = Color.Black;
            this.lblYofR.ForeColor = Color.Black;
            if (this.tbBranchCode.Text.Trim().Length < 1)
            {
                this.lblBranch.ForeColor = Color.Red;
                isReady = false;
            }
            if (this.cmbYearOfCreation.Text.Trim().Length < 1)
            {
                this.lblYofC.ForeColor = Color.Red;
                isReady = false;
            }
            if (this.cmbDocType.Text.Trim().Length < 1)
            {
                this.lblType.ForeColor = Color.Red;
                isReady = false;
            }
            if (this.tbRetention.Text.Trim().Length < 1)
            {
                this.lblYofR.ForeColor = Color.Red;
                isReady = false;
            }
            return isReady;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (IsReady())
            {
                this.UpdateSerial();
            }
        }

        private void NewArchive()
        {
            this.UpdateSerial();
            DocLibDataSet.DocumentsRow dr = this.docLibDataSet.Documents.NewDocumentsRow();
            dr["BranchCode"] = this.tbBranchCode.Text;
            dr["YearOfCreation"] = this.cmbYearOfCreation.Text;
            dr["DocType"] = this.cmbDocType.Text;
            dr["DocRetention"] = this.tbRetention.Text;
            dr["DocCode"] = this.tbSeq.Text;
            dr["DocName"] = this.tbName.Text;
            dr["Remark"] = this.tbRemark.Text;
            dr["DocCreationTime"] = DateTime.Now.ToString();
            docLibDataSet.Documents.AddDocumentsRow(dr);
        }
    }
}
