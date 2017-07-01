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
    public partial class MainForm : Form
    {
        public static string DEFAULT_TYPE { get { return "档案分类"; } }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“docLibDataSet.Configurations”中。您可以根据需要移动或删除它。
            this.configurationsTableAdapter.Fill(this.docLibDataSet.Configurations);
            // TODO: 这行代码将数据加载到表“docLibDataSet.DocumentTypes”中。您可以根据需要移动或删除它。
            this.documentTypesTableAdapter.Fill(this.docLibDataSet.DocumentTypes);
            resetControl(this.cmbDocType, DEFAULT_TYPE);
        }

        #region GUI
        private void resetControl(Control cntl, string txt)
        {
            cntl.ForeColor = Color.LightGray;
            cntl.Text = txt;
        }

        private void cmbDocType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cmbDocType.ForeColor = Color.Black;
        }

        private void cmbDocType_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbDocType.Text.Length < 1)
            {
                resetControl(this.cmbDocType, DEFAULT_TYPE);
            }
        }
        #endregion

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if ((new ConfigForm()).ShowDialog() == DialogResult.OK)
            {
                this.docLibDataSet.Configurations.Clear();
                this.configurationsTableAdapter.Fill(this.docLibDataSet.Configurations);
            }

        }
    }
}
