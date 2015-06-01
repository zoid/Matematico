using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Dictionary<string, string> Players;
        public List<PlayerResult> Results;

        private GameForm Form;
        public Server server;

        //Timer
        Timer timer;
        int Tick;
        int Index;
        int Timelimit;

        public LanGame(GameType type)
        {
            Type = type;
            Players = new Dictionary<string, string>();

            server = new Server(new UpdateCallback(RecieveUpdate), new DataCallback(RecieveMessage));
            
            //Register server
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

            Tick = Timelimit = Form.TimeBar.Value;
            Index = 0;

            server.Send("/timelimit " + Timelimit.ToString());
            server.Send("/numbers " + String.Join(";", Numbers));
            server.Send("/start");

            Form.DisplayItems();
        }

        public void RecieveMessage(string user, string message)
        {
            CommandType type = CommandParser.GetType(message);
            if (type == CommandType.NaC) return;

            switch (type)
            {
                case CommandType.Name:
                    if (Players.ContainsKey(user))
                    {
                        Players.Remove(user);
                    }

                    Players.Add(user, CommandParser.GetContent(message));
                    break;

                case CommandType.Result:

                    break;
            }


        }

        public void RecieveUpdate(UpdateType type)
        {
            switch (type)
            {
                case UpdateType.User:
                    Form.Users.Items.Clear();
                    string[] arr = Players.Select(item => item.Value).OrderBy(item => item).ToArray();
            
                    foreach(var name in arr)
                        Form.Users.Items.Add(name);

                    if (arr.Length > 0) Form.StartButton.Enabled = true;
                    else Form.StartButton.Enabled = false;

                    break;
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

        }
    }
}
