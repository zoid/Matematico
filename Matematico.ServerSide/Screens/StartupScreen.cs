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
    public partial class StartupScreen : UserControl
    {
        private Forms.StartupForm sForm;
        public Forms.StartupForm Form
        {
            get { return sForm; }
            set { sForm = value; }
        }

        private void bt_newGame_click(object sender, EventArgs e)
        {
            if(Form != null) 
                Form.NewGameClicked();
        }

        public StartupScreen()
        {
            InitializeComponent();
        }

        private void bt_turnaj_Click(object sender, EventArgs e)
        {
          //  TournamentStartForm form = new TournamentStartForm();
          //  form.Show();
           // this.Hide();
        }
    }
}
