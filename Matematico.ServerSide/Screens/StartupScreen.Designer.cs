namespace Matematico.ServerSide.Screens
{
    partial class StartupScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupScreen));
            this.bt_turnaj = new System.Windows.Forms.Button();
            this.bt_newGame = new System.Windows.Forms.Button();
            this.pbox_logo = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_turnaj
            // 
            this.bt_turnaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_turnaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bt_turnaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_turnaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_turnaj.Location = new System.Drawing.Point(832, 264);
            this.bt_turnaj.Name = "bt_turnaj";
            this.bt_turnaj.Size = new System.Drawing.Size(168, 32);
            this.bt_turnaj.TabIndex = 7;
            this.bt_turnaj.Text = "Vytvořit nový turnaj";
            this.bt_turnaj.UseVisualStyleBackColor = true;
            this.bt_turnaj.Click += new System.EventHandler(this.bt_turnaj_Click);
            // 
            // bt_newGame
            // 
            this.bt_newGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_newGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.bt_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_newGame.Location = new System.Drawing.Point(832, 227);
            this.bt_newGame.Name = "bt_newGame";
            this.bt_newGame.Size = new System.Drawing.Size(168, 31);
            this.bt_newGame.TabIndex = 6;
            this.bt_newGame.Text = "Vytvořit novou hru";
            this.bt_newGame.UseVisualStyleBackColor = true;
            this.bt_newGame.Click += new System.EventHandler(this.bt_newGame_click);
            // 
            // pbox_logo
            // 
            this.pbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbox_logo.ErrorImage = null;
            this.pbox_logo.Image = global::Properties.Resources.matematico_logo;
            this.pbox_logo.InitialImage = null;
            this.pbox_logo.Location = new System.Drawing.Point(0, 0);
            this.pbox_logo.Name = "pbox_logo";
            this.pbox_logo.Size = new System.Drawing.Size(490, 268);
            this.pbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_logo.TabIndex = 8;
            this.pbox_logo.TabStop = false;
            this.pbox_logo.WaitOnLoad = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title.Location = new System.Drawing.Point(496, 58);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(275, 32);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "Matematico - Server";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(502, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 130);
            this.label1.TabIndex = 10;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pbox_logo);
            this.Controls.Add(this.bt_turnaj);
            this.Controls.Add(this.bt_newGame);
            this.Name = "StartupScreen";
            this.Size = new System.Drawing.Size(1000, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_logo;
        private System.Windows.Forms.Button bt_turnaj;
        private System.Windows.Forms.Button bt_newGame;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
    }
}
