using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormDemo
{
    static class Program
    {
        /// <summary>
        ///     The main entry point for the application. Creating the form (View Manager) instantiates all the
        ///     other User Controller views which in turn instantiate their own presenters.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ViewManagerView form = new ViewManagerView();
            Application.Run(form);
        }
    }
}
