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
            this.bt_newGame = new System.Windows.Forms.Button();
            this.bt_turnaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_newGame
            // 
            this.bt_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_newGame.Location = new System.Drawing.Point(41, 35);
            this.bt_newGame.Name = "bt_newGame";
            this.bt_newGame.Size = new System.Drawing.Size(184, 43);
            this.bt_newGame.TabIndex = 0;
            this.bt_newGame.Text = "Nová hra po síti";
            this.bt_newGame.UseVisualStyleBackColor = true;
            this.bt_newGame.Click += new System.EventHandler(this.bt_newGame_Click);
            // 
            // bt_turnaj
            // 
            this.bt_turnaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_turnaj.Location = new System.Drawing.Point(41, 84);
            this.bt_turnaj.Name = "bt_turnaj";
            this.bt_turnaj.Size = new System.Drawing.Size(184, 43);
            this.bt_turnaj.TabIndex = 3;
            this.bt_turnaj.Text = "Nový Turnaj";
            this.bt_turnaj.UseVisualStyleBackColor = true;
            this.bt_turnaj.Click += new System.EventHandler(this.bt_turnaj_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 150);
            this.Controls.Add(this.bt_turnaj);
            this.Controls.Add(this.bt_newGame);
            this.Name = "StartupForm";
            this.Text = "Matematico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_newGame;
        private System.Windows.Forms.Button bt_turnaj;
    }
}
