using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using Matematico;

namespace Matematico.ClientSide.Configuration
{
    public static class Config
    {
        public static IniFile File = new IniFile();
       
        
        public static string DefaultHost 
        {
            get 
            { 
                string val = File.Read("connection", "defaultHost");
                if(val == string.Empty) return "127.0.0.1";
    
                return val;
            }
            set {
                File.Write("connection","defaultHost", value);
            }
        }

        public static int TimeLimit
        {
            get
            {
                string val = File.Read("localGame", "timelimit");
                if (val == string.Empty) return 5;

                return int.Parse(val);
            }
            set
            {
                File.Write("localGame", "timelimit", value.ToString());
            }
        }

        public static bool WaitAllTime
        {
            get
            {
                string val = File.Read("localGame", "waitAllTime");
                if (val == string.Empty) return false;

                return bool.Parse(val);
            }
            set
            {
                File.Write("localGame", "waitAllTime", value.ToString());
            }
        }

    }
}
