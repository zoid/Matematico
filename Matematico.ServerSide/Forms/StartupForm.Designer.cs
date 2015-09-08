namespace Matematico.ServerSide.Forms
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen_game = new Matematico.ServerSide.Screens.GameScreen();
            this.screen_startup = new Matematico.ServerSide.Screens.StartupScreen();
            this.SuspendLayout();
            // 
            // screen_game
            // 
            this.screen_game.BackColor = System.Drawing.Color.White;
            this.screen_game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen_game.Form = null;
            this.screen_game.Location = new System.Drawing.Point(20, 60);
            this.screen_game.Name = "screen_game";
            this.screen_game.Size = new System.Drawing.Size(995, 499);
            this.screen_game.TabIndex = 8;
            // 
            // screen_startup
            // 
            this.screen_startup.BackColor = System.Drawing.Color.White;
            this.screen_startup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen_startup.Form = null;
            this.screen_startup.Location = new System.Drawing.Point(20, 60);
            this.screen_startup.Name = "screen_startup";
            this.screen_startup.Size = new System.Drawing.Size(995, 499);
            this.screen_startup.TabIndex = 7;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 579);
            this.Controls.Add(this.screen_game);
            this.Controls.Add(this.screen_startup);
            this.Name = "StartupForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Matematico.ServerSide.Screens.StartupScreen startup_screen;
        public Screens.StartupScreen screen_startup;
        public Screens.GameScreen screen_game;
    }
}
