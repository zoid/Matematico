using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Matematico.Game;

namespace Matematico.ClientSide.Forms
{
    public partial class GameForm : Form
    {
        #region Variables

        IGame Game;
        private bool Local;

        public MatematicoButton[,] Buttons;

        public ProgressBar Progress
        {
            get { return progBar_time; }
            set { progBar_time = value; }
        }

        public Label Status
        {
            get { return lb_status; }
            set { lb_status = value; }
        }

        public Label Time
        {
            get { return lb_time; }
            set { lb_time = value; }
        }

        public Label Number
        {
            get { return lb_actualNumber; }
            set { lb_actualNumber = value; }
        }

        #endregion

        public GameForm(LocalGame game)
        {
            Game = game;
            Local = true;

            CreateBoard();
            InitializeComponent();
        }

        public GameForm(LanGame game)
        {
            Game = game;
            Local = false;

            CreateBoard();
            InitializeComponent();
        }

        private void CreateBoard()
        {
            Buttons = new MatematicoButton[5, 5];

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    MatematicoButton temp = new MatematicoButton(x, y);

                    temp.Size = new Size(50, 50);
                    temp.Location = new Point(55 * x + 20, 55 * y + 20);
                    temp.FlatStyle = FlatStyle.Flat;
                    temp.Font = new Font(temp.Font.FontFamily, 18);
                    temp.Cursor = Cursors.Hand;

                    temp.Click += new EventHandler(button_click);

                    Buttons[x, y] = temp;
                    Controls.Add(temp);
                }
            }
        }


        #region Button Events

        private void bt_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Game.Stop();
            Game.Start();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Game.Start();
        }


        #endregion

 
     
        public void ClearBoard()
        {
            //Board setup
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                    Buttons[x, y].Value = 0;
        }


        public void HideGenerator()
        {
            btn_restart.Enabled = false;

            lb_actualNumber.Hide();
            label_change.Hide();
            lb_time.Hide();

            progBar_time.Hide();
        }

        public void ShowGenerator()
        {
            btn_restart.Enabled = true;

            label_change.Show();
            lb_time.Show();
            lb_actualNumber.Show();

            progBar_time.Show();

        }

        public void ShowResult(PlayerResult result)
        {
            lb_totalPoints.Text = result.Total.ToString();

            for (int i = 0; i < 5; i++)
            {
                this.Controls.Find("lb_y_" + i, true).Single().Text = result.Line[i].ToString();
                this.Controls.Find("lb_x_" + i, true).Single().Text = result.Column[i].ToString();
            }

            lb_diag_0.Text = result.Diagonal[0].ToString();
            lb_diag_1.Text = result.Diagonal[1].ToString();

            p_score.Show();
        }

        public void HideResult()
        {
            p_score.Hide();
        }


        private void button_click(object sender, EventArgs e)
        {
            if (Game.CanPlace)
            {
                MatematicoButton button = (MatematicoButton)sender;
                if (button.Value == 0)
                {
                    Game.Click(sender);
                }
            }
        }

        private void SingleGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.Show();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (Local)
            {
                p_localGame.Location = new Point(p_localGame.Location.X, 410);
                p_localGame.Show();

                box_status.Hide();
            }
            else
            {
                p_localGame.Hide();
                box_status.Show();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game.Disconnect();
        }

    }
}
