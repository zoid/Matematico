using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Matematico.ClientSide.Forms;

namespace Matematico.ClientSide
{
    static class Program
    {
        public static StartupForm MainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new StartupForm();

            Application.Run(MainForm);
        }
    }
}
