using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocLibrary
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Properties.Settings.Default.Properties["DocLibConnectionString"].DefaultValue += @";Jet OLEDB:Database Password=test";
            Properties.Settings.Default.Save();
            //Properties.Settings.Default.Reload();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
