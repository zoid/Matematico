using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Matematico.Game;

namespace Matematico.ServerSide.Screens
{
    public partial class GameScreen : UserControl
    {
        private Forms.StartupForm sForm;
        public Forms.StartupForm Form
        {
            get { return sForm; }
            set { sForm = value; }
        }


        public GameScreen()
        {
            InitializeComponent();
        }

        #region Variables


        private LanGame Game;

        public Matematico.Components.UserList Users
        {
            get { return users; }
            set { users = value; }
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

        public Label NumberCount
        {
            get { return lb_actualNumberCount; }
            set { lb_actualNumberCount = value; } 
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

        

        #endregion


        public void StartServer(LanGame game)
        {
            Game = game;
            Game.StartListening(21);
        }


        #region Main Game Methods

        // Start / Restart game
        private void bt_start_Click(object sender, EventArgs e)
        {
            if (Game.Ended)
            {
                Game.Ended = false;
                Game.RefreshUserList();

                StartButton.Text = "Start";
            }
            else
            {
                Game.Start();
            }
        }

        private void bt_end_Click(object sender, EventArgs e)
        {

            CleanGUI();

            Game.StopListening();
            Form.EndGameClicked();
        }        

        private void bar_time_ValueChanged(object sender, EventArgs e)
        {
            lb_time.Text = bar_time.Value.ToString() + "s";
        }


        #endregion

        private void GameScreen_VisibleChanged(object sender, EventArgs e)
        {
            bt_start.Enabled = (bool)(Users.ConnectedUsers > 0);
            ConnectedUsers.Text = Users.ConnectedUsers.ToString();
            lb_actualNumberCount.Text = "0 / 25";
        }


        public void RefreshGUI()
        {
            bt_start.Enabled = (bool)(Users.ConnectedUsers > 0);
            ConnectedUsers.Text = Users.ConnectedUsers.ToString();
        
            if(Game.Active != true)
            {
                lb_generated.Text = "";
                lb_generated.Visible = false;

                lb_actualNumberCount.Text = "0 / 25";
            }
        }

        public void CleanGUI()
        {
            NumberCount.Text = "0";
            ConnectedUsers.Text = "0";
            Number.Text = "0";
            Number.Visible = false;

            TimeBar.Value = 0;

            Users.ClearUsers();
        }

    }
}
