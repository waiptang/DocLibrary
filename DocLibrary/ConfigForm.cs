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
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“docLibDataSet.DocumentTypes”中。您可以根据需要移动或删除它。
            this.documentTypesTableAdapter.Fill(this.docLibDataSet.DocumentTypes);
            // TODO: 这行代码将数据加载到表“docLibDataSet.Configurations”中。您可以根据需要移动或删除它。
            this.configurationsTableAdapter.Fill(this.docLibDataSet.Configurations);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.configurationsBindingSource.EndEdit();
                this.configurationsTableAdapter.Update(this.docLibDataSet.Configurations);
                this.documentTypesTableAdapter.Update(this.docLibDataSet.DocumentTypes);
                MessageBox.Show("保存成功");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败: " + ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
