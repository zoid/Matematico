using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matematico.ClientSide.Configuration;
using Matematico.ClientSide.Forms;
using Matematico.Comunication;
using Matematico.Game;



namespace Matematico.ClientSide
{
    public class LanGame : IGame, IDisposable
    {
        #region Variables

        Client client;
        GameForm Form;

        //Numbers
        private int[] Numbers;
        private int Index;

        //Player information
        public string Username;

        private bool Disconnecting;

        //Timer
        Timer timer;
        int Timelimit;
        int Tick;

        //Reconnect
        Timer reconnect;

        public bool CanPlace { get; set; }

        #endregion

        public LanGame(string username)
        {
            Username = username;

            client = new Client(Username, new ConnectionCallback(ConnectionRecieve), new DataRecieveCallback(DataRecieve));
            client.Connect(Config.DefaultHost, 21);

            Form = new GameForm(this);

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = false;

            reconnect = new Timer();
            reconnect.Tick += new EventHandler(reconnect_Tick);
            reconnect.Interval = 500;
            reconnect.Enabled = false;

            Disconnecting = false;
            CanPlace = false;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void ShowForm()
        {
            Form.Show();
        }

        #region Callbacks

        public void ConnectionRecieve(bool connected)
        {
            if (connected)
            {
                Form.Status.ForeColor = Color.Green;
                Form.Status.Text = "Připojeno";

                reconnect.Stop();
            }
            else
            {
                Form.Status.ForeColor = Color.Red;
                Form.Status.Text = "Nepřipojeno";

                if(!Disconnecting)
                    reconnect.Start();
            }
        }

        public void DataRecieve(string message)
        {
            CommandType type = CommandParser.GetType(message);
            if (type == CommandType.NaC) return;

            switch (type)
            {
                case CommandType.Start:
                    if(Numbers == null || Numbers.Length == 0)
                        client.AskForNumbers();
                    else if(Timelimit == 0)
                        client.AskForTimelimit();
                    else
                        Start();

                    break;

                case CommandType.Numbers:
                    Numbers = Array.ConvertAll(CommandParser.GetContent(message).Split(';'), int.Parse);
                    break;
            
                case CommandType.Timelimit:
                    int.TryParse(CommandParser.GetContent(message), out Timelimit);
                    break;
            }
        }

        #endregion

        public void Start()
        {
            Form.Progress.Maximum = Timelimit * 10;
            Form.Progress.Value = Timelimit * 10;

            CanPlace = true;
            Index = 0;

            Form.Number.Text = Numbers[Index].ToString();

            Form.ClearBoard();
            Form.ShowGenerator();
            Form.HideResult();

            Tick = Timelimit * 10;
            timer.Start();
        }

        public void Stop()
        {
            //Stop timer
            timer.Stop();
            CanPlace = false;

            //Copy board values
            int[,] board = new int[5, 5];
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                    board[x, y] = Form.Buttons[x, y].Value;

            //Get result
            PlayerResult result = new PlayerResult(Username, board);

            Form.ShowResult(result);
            Form.HideGenerator();

            //Send result
            string serialized = result.Pack();
            client.Send("/result " + serialized);
        }

        public void Click(object button)
        {
            MatematicoButton btn = (MatematicoButton)button;

            btn.Value = Numbers[Index];
            CanPlace = false;
        }

        public void Disconnect()
        {
            Disconnecting = true;
            client.Disconnect();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Form.Progress.Value = Tick;
            Form.Time.Text = (Tick / 10) + "s";

            if (Tick != 0)
            {
                Tick--;
                return;
            }

            Index++;

            Tick = Timelimit * 10;
            CanPlace = true;

            if (Index == Numbers.Length)
            {
                Stop();
                return;
            }

            Form.Number.Text = Numbers[Index].ToString();
        }

        private void reconnect_Tick(object sender, EventArgs e)
        {
            client.Connect(Config.DefaultHost, 21);
        }

    }
}
