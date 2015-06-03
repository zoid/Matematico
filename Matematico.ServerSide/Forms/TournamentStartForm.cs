using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Matematico.Tournaments;

namespace Matematico.ServerSide.Forms
{
    public partial class TournamentStartForm : Form
    {
        public TournamentStartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = int.Parse(textBox1.Text);

            Tournament t = new Tournament(points);
        }

        private void TournamentStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.Show();
        }
    }
}
