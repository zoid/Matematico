using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lidgren.Network;

namespace Matematico.Comunication
{
    public delegate void UpdateCallback(UpdateType update);
    public delegate void DataCallback(string userId, string data);
    public class Server
    {
        #region DLL Imports
        [StructLayout(LayoutKind.Sequential)]
        public struct PeekMsg
        {
            public IntPtr hWnd;
            public Message msg;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public Point p;
        }

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage(out PeekMsg msg, IntPtr hWnd, uint messageFilterMin, uint messageFilterMax, uint flags);

        public bool AppStillIdle
        {
            get
            {
                PeekMsg msg;
                return !PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            }
        }
        #endregion

        #region Variables
        private NetServer server;
        private bool Started = false;

        private UpdateCallback Update;
        private DataCallback Data;
        #endregion

        public Server(UpdateCallback _update, DataCallback _data)
        {
            Update = _update;
            Data = _data;
        }

        #region Configuration / Start

        public void Configure(short port)
        {
            NetPeerConfiguration config = new NetPeerConfiguration("Matematico");

            config.MaximumConnections = 100;
            config.Port = port;

            server = new NetServer(config);
        }

        public void Start()
        {
            if (server == null) throw new Exception("Server was not configured");

            server.Start();
            Started = true;
        }

        #endregion


        public void WaitForMessage(object sender, EventArgs e)
        {
            while (AppStillIdle && Started)
            {
                NetIncomingMessage im;
                while ((im = server.ReadMessage()) != null)
                {
                    switch (im.MessageType)
                    {
                        case NetIncomingMessageType.DebugMessage:
                        case NetIncomingMessageType.ErrorMessage:
                        case NetIncomingMessageType.WarningMessage:
                        case NetIncomingMessageType.VerboseDebugMessage:
                            break;


                        case NetIncomingMessageType.StatusChanged:
                        case NetIncomingMessageType.UnconnectedData:
                            Update(UpdateType.User);
                            break;
                        
                        case NetIncomingMessageType.Data:
                            Data(NetUtility.ToHexString(im.SenderConnection.RemoteUniqueIdentifier), im.ReadString());
                            Update(UpdateType.Result);
                            Update(UpdateType.User);
                            break;

                        default:
                            break;
                    }
                }

                Thread.Sleep(1);
            }
        }

        public String[] GetConnections()
        {
            String[] users = new String[server.ConnectionsCount];
            users = server.Connections.Select(item => NetUtility.ToHexString(item.RemoteUniqueIdentifier)).ToArray<string>();

            return users;
        }

        public void Send(string message)
        {
            List<NetConnection> all = server.Connections;
            NetOutgoingMessage om = server.CreateMessage();

            om.Write(message);
            server.SendMessage(om, all, NetDeliveryMethod.ReliableOrdered, 0);
        }

        
        public void Shutdown()
        {
            server.Shutdown("Requested by user");
        }
    }
}
