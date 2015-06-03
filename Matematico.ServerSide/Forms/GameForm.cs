using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matematico.Comunication;
using Matematico.Game;

namespace Matematico.ServerSide.Forms
{
    public partial class GameForm : Form
    {
        #region Variables

        private LanGame Game;

        public ListBox Users
        {
            get { return box_users; }
            set { box_users = value; }
        }

        public ListBox Results
        {
            get { return box_results; }
            set { box_results = value; }
        }

        public Button StartButton
        {
            get { return bt_start; }
            set { bt_start = value; }
        }

        public TrackBar TimeBar
        {
            get { return bar_time; }
            set { bar_time = value; }
        }

        public ProgressBar Progress
        {
            get { return pBar_time; }
            set { pBar_time = value; }
        }

        public Label Number
        {
            get { return lb_generated; }
            set { lb_generated = value; }
        }

        public Label ConnectedUsers
        {
            get { return lb_connectedUsers; }
            set { lb_connectedUsers = value; }
        }

        public Label NumbersCount
        {
            get { return lb_actualNumberCount; }
            set { lb_actualNumberCount = value; }
        }

        

        #endregion


        public GameForm(LanGame _game)
        {
            Game = _game;

            InitializeComponent();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Game.server.Shutdown();
            Program.MainForm.Show();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            Game.server.Start();
        }




        #region Update Actions

        public void UpdateUserBox()
        {
            box_users.Items.Clear();

            foreach(string user in Game.server.GetConnections())
            {
                box_users.Items.Add(Game.Names[user]);
            }
        }



        private void box_results_DrawItem(object sender, DrawItemEventArgs e)
        {
           /* e.DrawBackground();

            Graphics g = e.Graphics;
            ListBox lb = (ListBox)sender;
            Color color;

            string content = lb.Items[e.Index].ToString();
            Result res = results.FirstOrDefault(item => item.username == content);

            content = res.points + "b. - " + content;

            if (res.Missing() > 0)
            {
                color = Color.Red;
                content += " ( " + res.Missing() + " )";
            }
            else
            {
                color = Color.Black;
            }

            g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            g.DrawString(content, e.Font, new SolidBrush(color), new PointF(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();*/
        }

        #endregion

        #region Main Game Methods

        // Start / Restart game
        private void bt_start_Click(object sender, EventArgs e)
        {
            Game.Start();
        }

        public void DisplayItems(bool start = true)
        {
            //Buttons
            bt_start.Enabled = !start;

            //Labels
            lb_ip.Visible = !start;
            lb_iplabel.Visible = !start;
            lb_generated.Visible = start;

            lb_actualNumberCount.Visible = start;
            lb_acutalNumberCountLabel.Visible = start;

            //TrackBars
            bar_time.Enabled = !start;

            // Start only
            if (start)
            {
                lb_generated.Text = Game.Numbers[0].ToString();
                box_results.Items.Clear();
            }
        }



        private void bt_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bar_time_ValueChanged(object sender, EventArgs e)
        {
            lb_time.Text = bar_time.Value.ToString() + "s";
        }

        #endregion

    }
}
