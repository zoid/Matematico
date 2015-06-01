using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematico.ServerSide
{
    public static class CommandParser
    {
        public static CommandType GetType(string message) 
        {
            if(!message.Contains("/")) return CommandType.NaC;

            CommandType cmd;
            string type = message.Remove(message.IndexOf(' '), message.Length - message.IndexOf(' ')).Replace("/", "");
            Enum.TryParse(type, true, out cmd);

            return cmd;
        }

        public static string GetContent(string message) 
        {
            if (!message.Contains("/")) return string.Empty;

            return message.Remove(0, message.IndexOf(' '));
        }
    }
}
