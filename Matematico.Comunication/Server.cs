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
    public delegate void DisconnectedCallback(string UID);
    public delegate void ConnectedCallback(string UID, string Username);
    public delegate void MessageCallback(string UID, string Message);

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

        private ConnectedCallback Connected;
        private DisconnectedCallback Disconnected;
        private MessageCallback Message;
        #endregion

        public Server(ConnectedCallback _connected, DisconnectedCallback _disconnected, MessageCallback _msg)
        {
            Connected = _connected;
            Disconnected = _disconnected;
            Message = _msg;
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
                    if(im.MessageType != NetIncomingMessageType.DebugMessage && im.MessageType != NetIncomingMessageType.WarningMessage) 
                        Message(im.MessageType.ToString(), im.SenderConnection.Status.ToString());
                    
                    switch (im.MessageType)
                    {
                        case NetIncomingMessageType.StatusChanged:
                            if(im.SenderConnection.Status == NetConnectionStatus.Connected) 
                                Connected(NetUtility.ToHexString(im.SenderConnection.RemoteUniqueIdentifier), im.SenderConnection.RemoteHailMessage.ReadString());

                            if(im.SenderConnection.Status == NetConnectionStatus.Disconnected)
                                Disconnected(NetUtility.ToHexString(im.SenderConnection.RemoteUniqueIdentifier));

                            break;
                        
                        case NetIncomingMessageType.Data:
                            Message(NetUtility.ToHexString(im.SenderConnection.RemoteUniqueIdentifier), im.ReadString());
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
            return server.Connections.Select(item => NetUtility.ToHexString(item.RemoteUniqueIdentifier)).ToArray<string>();
        }

        public bool Send(string message)
        {
            List<NetConnection> all = server.Connections;
            NetOutgoingMessage om = server.CreateMessage(message);

            try
            {
                server.SendMessage(om, all, NetDeliveryMethod.ReliableOrdered, 0);
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        public bool SendPrivate(string UID, string message)
        {
            NetOutgoingMessage om = server.CreateMessage(message);

            try
            {
                foreach (var con in server.Connections)
                    if (NetUtility.ToHexString(con.RemoteUniqueIdentifier) == UID)
                    {
                        server.SendMessage(om, con, NetDeliveryMethod.ReliableOrdered, 0);
                        return true;
                    }
            }
            catch(Exception)
            {
                return false;
            }

            return false;
        }
        
        public void Shutdown()
        {
            server.Shutdown("Requested by user");
        }
    }
}
