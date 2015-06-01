using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matematico.Comunication;
using Matematico.ServerSide.Forms;

namespace Matematico.ServerSide
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
