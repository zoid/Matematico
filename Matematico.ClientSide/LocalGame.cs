using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matematico.ClientSide.Configuration;
using Matematico.ClientSide.Forms;
using Matematico.Game;

namespace Matematico.ClientSide
{
    public class LocalGame : IGame
    {
        #region Variables

        //Numbers generating
        private const int MIN_NUMBER_VALUE = 1;
        private const int MAX_NUMBER_VALUE = 13;
        private const int MAX_NUMBERS = 25;
        
        private int[] Numbers;
        private int Index;
        
        //Player information
        public string Username;

        //Game Form
        private GameForm Form;
        
        //Timer
        Timer timer;
        int Tick;

        //Events
        public bool CanPlace { get; set; }

        #endregion

        public LocalGame()
        {
            Form = new GameForm(this);

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = false;

            CanPlace = false;

            Form.HideGenerator();
        }

        public void ShowForm()
        {
            Form.Show();
        }

        public void Start()
        {
            //Numbers generation
            Numbers = GenerateNumbers();
            Index = 0;

            //Variables setup
            Tick = Config.TimeLimit * 10;
            CanPlace = true;

            //Progress bar setup
            Form.Progress.Maximum = Tick;
            Form.Progress.Value = Tick;

            //Form setup
            Form.ClearBoard();
            Form.ShowGenerator();
            Form.HideResult();

            //Timer setup
            timer.Interval = 100;
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

        public void Click(object button)
        {
            MatematicoButton btn = (MatematicoButton)button;

            btn.Value = Numbers[Index];
            CanPlace = false;

            if (Config.WaitAllTime == false)
            {
                Tick = Config.TimeLimit * 10;
                Index++;

                if (Index == MAX_NUMBERS)
                {
                    Stop();
                    return;
                }

                Form.Number.Text = Numbers[Index].ToString();
                CanPlace = true;
            }
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

            Tick = Config.TimeLimit * 10;
            CanPlace = true;

            if (Index == MAX_NUMBERS)
            {
                Stop();
                return;
            }

            Form.Number.Text = Numbers[Index].ToString();
        }

    }
}
