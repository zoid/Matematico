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
using Matematico.ServerSide.Screens;

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
        public bool Ended = false;

        //Players informations
        public GameResult Results;

        private GameScreen Screen;
        public Server server;

        //Timer
        Timer timer;
        int Tick;
        int Index;
        int Timelimit;

        //Tournament
        private bool IsTournament;
        private Tournament Tournament;

        public LanGame(GameScreen screen, GameType type)
        {
            Screen = screen;

            IsTournament = false;

            Type = type;          
            Results = new GameResult();

            server = new Server(    new ConnectedCallback(Connected), 
                                    new DisconnectedCallback(Disconnected), 
                                    new MessageCallback(RecieveMessage)
                               );
            
            // Register server event
            Application.Idle += new EventHandler(server.WaitForMessage);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = false;
        }

        public LanGame(GameScreen screen, GameType type, Tournament tournament)
        {
            Screen = screen;
            IsTournament = true;

            Type = type;
            Tournament = tournament;
            
            Results = new GameResult();

            server = new Server(    new ConnectedCallback(Connected),
                                    new DisconnectedCallback(Disconnected),
                                    new MessageCallback(RecieveMessage)
                               );

            // Register server event
            Application.Idle += new EventHandler(server.WaitForMessage);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = false;

        }

        public void StartListening(short port)
        {
            server.Configure(port);
            server.Start();

            Screen.RefreshGUI();
        }

        public void StopListening()
        {
            server.Shutdown();
        }

        public void Start()
        {
            Numbers = GenerateNumbers();
            Timelimit = Screen.TimeBar.Value;
            Tick = Timelimit * 10;
            Index = 0;

            Active = true;

            server.Send("/timelimit " + Timelimit.ToString());
            server.Send("/numbers " + String.Join(";", Numbers));
            server.Send("/start");

            //Show form items
            Screen.RefreshGUI();

            //Setup progress bar
            Screen.Progress.Maximum = Tick;
            Screen.Progress.Value = Tick;

            //Start timer
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
            Active = false;

            Ended = true;
            Screen.StartButton.Text = "Pøipravit";
        }


        public void RecieveMessage(string userId, string message)
        {
            CommandType type = CommandParser.GetType(message);
            if (type == CommandType.NaC) return;

            switch (type)
            {
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

                    Results.Players.Add(result);

                    if (Results.Players.Count == server.GetConnections().Length)
                    {
                        string text;

                        foreach (var item in Results.Players.OrderByDescending(item => item.Total).ToList<PlayerResult>())
                        {
                            text = item.Name;
                            Screen.Users.AddScore(text, item.Total, item.Missing);
                        }

                        if(IsTournament)
                        {
                            Tournament.StopRound(Results);
                        }

                    }

                    break;
            }


        }

        public void Connected(string UID, string Username)
        {
            Screen.Users.AddUser(UID, Username);

            if (Screen.Users.ConnectedUsers > 0) 
               Screen.StartButton.Enabled = true;
        }

        public void Disconnected(string UID)
        {
            Screen.Users.RemoveUser(UID);

            if (Screen.Users.ConnectedUsers == 0) 
                Screen.StartButton.Enabled = false;
        }

        public void RefreshUserList()
        {
            foreach(string uid in server.GetConnections())
            {
                Screen.Users.RemoveScore(uid);
            }
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
            Screen.Progress.Value = Tick;

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

           Screen.Number.Text = Numbers[Index].ToString();
           Screen.NumberCount.Text = (Index + 1).ToString();
        }
    }
}
