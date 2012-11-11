using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Oiko
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
            //Application.Run(new Form2_Login());
            Application.Run(new Form1_Splash());
        }
    }
}
