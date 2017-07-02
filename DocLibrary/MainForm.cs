using System;
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
            
        }


        private void btnConfig_Click(object sender, EventArgs e)
        {
            //if ((new ConfigForm()).ShowDialog() == DialogResult.OK)
            //{
            //    this.docLibDataSet.Configurations.Clear();
            //    this.configurationsTableAdapter.Fill(this.docLibDataSet.Configurations);
            //}
            (new ConfigForm()).ShowDialog();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            (new ArchForm()).ShowDialog();
        }
    }
}
