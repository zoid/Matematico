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

using MetroFramework.Forms;

namespace Matematico.ServerSide.Forms
{
    public partial class StartupForm : MetroForm
    {
        private LanGame game;

        public StartupForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
            screen_startup.Form = this;
            screen_game.Form = this;

            screen_startup.Visible = true;
            screen_game.Visible = false;

        }
        

        public void NewGameClicked()
        {
            game = new LanGame(screen_game, Game.GameType.Maximum);

            screen_startup.Visible = false;

            screen_game.StartServer(game);
            screen_game.Visible = true;
        }

        public void EndGameClicked()
        {
            if (game.Active)
                game.Stop();

            screen_game.Visible = false;
            screen_startup.Visible = true;
        }



        protected override void OnPaint(PaintEventArgs e) {
            Rectangle rc = new Rectangle(this.ClientSize.Width - 20, this.ClientSize.Height - 20, 20, 20);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            e.Graphics.FillRectangle(Brushes.Transparent, rc);
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x84) {  // Trap WM_NCHITTEST
            
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);

                if (pos.Y < this.ClientSize.Height)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                
                if (pos.X >= this.ClientSize.Width - 20 && pos.Y >= this.ClientSize.Height - 20) {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }


        private void StartupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(game != null) game.server.Shutdown();
        }


    }
}
