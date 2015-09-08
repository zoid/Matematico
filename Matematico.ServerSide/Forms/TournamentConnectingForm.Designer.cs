namespace Matematico.ServerSide.Forms
{
    partial class TournamentConnectingForm
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
            this.lbox_players = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbox_players
            // 
            this.lbox_players.FormattingEnabled = true;
            this.lbox_players.Location = new System.Drawing.Point(13, 26);
            this.lbox_players.Name = "lbox_players";
            this.lbox_players.Size = new System.Drawing.Size(164, 446);
            this.lbox_players.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Připojení uživatelé";
            // 
            // TournamentConnectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_players);
            this.Name = "TournamentConnectingForm";
            this.Text = "Nový turnaj";
            this.Load += new System.EventHandler(this.TournamentConnectingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_players;
        private System.Windows.Forms.Label label1;
    }
}