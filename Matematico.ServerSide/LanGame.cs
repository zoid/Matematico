using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lidgren.Network;

using Matematico.Comunication;
using Matematico.Game;
using Matematico.ServerSide.Forms;

namespace Matematico.ServerSide
{
    public class LanGame
    {
        //Numbers generating
        private const int MIN_NUMBER_VALUE = 1;
        private const int MAX_NUMBER_VALUE = 13;
        private const int MAX_NUMBERS = 25;

        public int[] Numbers;

        //Game informations
        private GameType Type;
        public bool Active = false;

        //Players informations
        public Dictionary<string, string> Names;
        public List<PlayerResult> Results;

        private GameForm Form;
        public Server server;

        //Timer
        Timer timer;
        int Tick;
        int Index;
        int Timelimit;

        //Tournament
        private bool IsTournament;
        private Tournament Tournament;

        public LanGame(GameType type)
        {
            IsTournament = false;

            Type = type;
            Names = new Dictionary<string, string>();
            Results = new List<PlayerResult>();

            server = new Server(    new ConnectedCallback(Connected), 
                                    new DisconnectedCallback(Disconnected), 
                                    new MessageCallback(RecieveMessage)
                               );
            
            // Register server event
            Application.Idle += new EventHandler(server.WaitForMessage);

            Form = new GameForm(this);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = false;
        }

        public LanGame(GameType type, Tournament tournament)
        {
            IsTournament = true;

            Type = type;
            Tournament = tournament;
            
            Names = new Dictionary<string, string>();
            Results = new List<PlayerResult>();

            server = new Server(new ConnectedCallback(Connected),
                                    new DisconnectedCallback(Disconnected),
                                    new MessageCallback(RecieveMessage)
                               );

            // Register server event
            Application.Idle += new EventHandler(server.WaitForMessage);

            Form = new GameForm(this);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = false;

        }

        public void ShowForm()
        {
            server.Configure(21);
            server.Start();
     
            Form.Show();
            Form.DisplayItems(false);
        }

        public void Start()
        {
            Numbers = GenerateNumbers();
            Timelimit = Form.TimeBar.Value;
            Tick = Timelimit * 10;
            Index = 0;

            server.Send("/timelimit " + Timelimit.ToString());
            server.Send("/numbers " + String.Join(";", Numbers));
            server.Send("/start");

            //Show form items
            Form.DisplayItems();
        
            //Clear result box
            Form.Results.Items.Clear();

            //Setup progress bar
            Form.Progress.Maximum = Tick;
            Form.Progress.Value = Tick;

            //Start timer
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void RecieveMessage(string userId, string message)
        {
            CommandType type = CommandParser.GetType(message);
            if (type == CommandType.NaC) return;

            switch (type)
            {
                case CommandType.Name:
                    if (Names.ContainsKey(userId))
                        Names.Remove(userId);

                    Names.Add(userId, CommandParser.GetContent(message));
                    Form.Users.Invalidate();   
   
                    break;

                case CommandType.Missing:
                    switch (CommandParser.GetContent(message))
                    {
                        case "numbers":
                            server.SendPrivate(userId, "/numbers " + String.Join(";", Numbers));
                            break;

                        case "timelimit":
                            server.SendPrivate(userId, "/timelimit " + Timelimit);
                            break;
                    }

                    server.SendPrivate(userId, "/start");
                    break;

                case CommandType.Result:
                    PlayerResult result = PlayerResult.Unpack(CommandParser.GetContent(message));

                    Results.Add(result);

                    if (Results.Count == server.GetConnections().Length)
                    {
                        Form.Results.Items.Clear();

                        string text;
                        Results = Results.OrderBy(item => item.Total).ToList<PlayerResult>();

                        foreach (var item in Results)
                        {
                            text = item.Total + "b. - " + item.Name;
                            if (item.Missing > 0) text += " (" + item.Missing + ") {MISSING}";

                            Form.Results.Items.Add(text);
                        }
                    }

                    break;
            }


        }

        public void Connected(string UID, string Username)
        {
            if(Names.ContainsKey(UID)) Names.Remove(UID);
            Names.Add(UID, Username);
            
            Form.Users.Items.Add(Names[UID]);
            Form.ConnectedUsers.Text = server.GetConnections().Length.ToString();

            if (server.GetConnections().Length > 0) Form.StartButton.Enabled = true;
        }

        public void Disconnected(string UID)
        {
            if (Names.ContainsKey(UID))
            {
                Form.Users.Items.RemoveAt(Form.Users.FindStringExact(Names[UID]));
                Names.Remove(UID);
            }

            Form.ConnectedUsers.Text = server.GetConnections().Length.ToString();

            if (server.GetConnections().Length == 0) Form.StartButton.Enabled = false;
        }


        private int[] GenerateNumbers()
        {
            Random rand;

            int[] drawn_numbers = new int[MAX_NUMBER_VALUE + 1];
            int[] nums = new int[MAX_NUMBERS];

            for (int i = 0; i < MAX_NUMBERS; i++)
            {
                rand = new Random(Guid.NewGuid().GetHashCode());

                do
                    nums[i] = rand.Next(MIN_NUMBER_VALUE, MAX_NUMBER_VALUE + 1);
                while (drawn_numbers[nums[i]] >= 4);

                drawn_numbers[nums[i]]++; 
            }

            return nums;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Form.Progress.Value = Tick;

            if(Tick > 0)
            {
                Tick--;
                return;
            }

            Index++;
            Tick = Timelimit * 10;

            if(Index == MAX_NUMBERS)
            {
                Stop();
                return;
            }

            Form.Number.Text = Numbers[Index].ToString();
            Form.NumbersCount.Text = (Index + 1).ToString();
        }
    }
}
