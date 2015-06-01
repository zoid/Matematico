using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matematico.ClientSide.Forms
{
    public partial class StartupForm : Form
    {
        string name;

        public StartupForm()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Length == 0)
            {
                lb_error.Show();
            }
            else
            {
                name = tb_name.Text;

                p_login.Hide();
                p_menu.Show();
            }
        }

        private void bt_singlegame_Click(object sender, EventArgs e)
        {
            LocalGame game = new LocalGame();
            
            game.Username = name;
            game.ShowForm();

            this.Hide();
        }

        private void bt_settings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
            this.Hide();
        }

        private void bt_multiplayer_Click(object sender, EventArgs e)
        {
            LanGame game = new LanGame(name);

            game.ShowForm();
            this.Hide();
        }

        private void tb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login_Click(bt_login, EventArgs.Empty);
            }
        }
    }
}
