using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Lidgren.Network;

namespace Matematico.Comunication
{
    public delegate void ConnectionCallback(bool connected);
    public delegate void DataRecieveCallback(string message);

    public class Client
    {
        private NetClient client;
        private ConnectionCallback Status;
        private DataRecieveCallback Recieve;   
        private string username;

        public Client(string _username, ConnectionCallback _connection, DataRecieveCallback _data)
        {
            NetPeerConfiguration config = new NetPeerConfiguration("Matematico");
            config.AutoFlushSendQueue = false;

            client = new NetClient(config);
            client.RegisterReceivedCallback(new SendOrPostCallback(GotMessage));
            client.Start();

            username = _username;
            Status = _connection;
            Recieve = _data;
        }

        public void Connect(string host, ushort port)
        {          
            client.Connect(host, port);
        }

        public void Disconnect()
        {
            client.Disconnect("Exit");
        }

        public void GotMessage(object peer)
        {
            NetIncomingMessage im;
            while ((im = client.ReadMessage()) != null)
            {
                switch (im.MessageType)
                {
                    case NetIncomingMessageType.DebugMessage:
                    case NetIncomingMessageType.ErrorMessage:
                    case NetIncomingMessageType.WarningMessage:
                    case NetIncomingMessageType.VerboseDebugMessage:
                        break;

                    case NetIncomingMessageType.StatusChanged:
                        NetConnectionStatus status = (NetConnectionStatus)im.ReadByte();

                        if (status == NetConnectionStatus.Connected)
                        {
                            Status(true);
                            Send("/name " + username);
                        }
                        else
                            Status(false);
                        break;

                    case NetIncomingMessageType.Data:
                        Recieve(im.ReadString());
                        break;

                    default:
                        break;
                }
            }
        }

        public void Send(string text)
        {
            NetOutgoingMessage om = client.CreateMessage(text);
            client.SendMessage(om, NetDeliveryMethod.ReliableOrdered);
            client.FlushSendQueue();
        }       
    }
}
