using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wk1Assignment
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

            //Open a New Window - Control Panel
            Application.Run(new ControlPanel());
        }
    }
}
