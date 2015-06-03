using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matematico.Game;

namespace Matematico.ServerSide.Forms
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void bt_newGame_Click(object sender, EventArgs e)
        {
            LanGame game = new LanGame(GameType.Maximum);
            game.ShowForm();
            this.Hide();
        }

        private void bt_turnaj_Click(object sender, EventArgs e)
        {
            TournamentStartForm form = new TournamentStartForm();
            form.Show();
            this.Hide();
        }
    }
}
