using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UppgraderingAdressBok.DataContext.DataControllers.Model.UI;
using UppgraderingAdressBok.UI;

namespace UppgraderingAdressBok
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
            Application.Run(new FirstApplicationForm());
        } 
    }
}
