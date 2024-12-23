using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI_Tier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm3_ThiTracNghiem f = new frm3_ThiTracNghiem();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                Application.Run(new frm2_GiaoDienChinh());
            }
            
           
        }
    }
}
