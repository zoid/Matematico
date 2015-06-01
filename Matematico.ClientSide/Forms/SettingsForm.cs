using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Matematico.ClientSide.Configuration;

namespace Matematico.ClientSide.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            trackBar_timelimit.Value = Config.TimeLimit;
            lb_timelimit.Text = Config.TimeLimit.ToString();

            tb_host.Text = Config.DefaultHost;
            
            cBox_waitAllTime.Checked = !Config.WaitAllTime;
        }

        private void trackBar_timelimit_ValueChanged(object sender, EventArgs e)
        {
            lb_timelimit.Text = trackBar_timelimit.Value.ToString();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Config.TimeLimit = trackBar_timelimit.Value;
            Config.DefaultHost = tb_host.Text;
            Config.WaitAllTime = !cBox_waitAllTime.Checked;

            this.Close();
        }
    }
}
