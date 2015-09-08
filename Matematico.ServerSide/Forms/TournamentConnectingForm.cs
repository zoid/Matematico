using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Matematico.Comunication;

namespace Matematico.ServerSide.Forms
{
    public partial class TournamentConnectingForm : Form
    {
        Tournament Game;

        public TournamentConnectingForm(Tournament game)
        {
            Game = game;

            InitializeComponent();
        }

        private void TournamentConnectingForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
