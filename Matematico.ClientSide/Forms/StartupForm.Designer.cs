namespace Matematico.ClientSide.Forms
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
            this.bt_singlegame = new System.Windows.Forms.Button();
            this.bt_multiplayer = new System.Windows.Forms.Button();
            this.bt_settings = new System.Windows.Forms.Button();
            this.p_menu = new System.Windows.Forms.Panel();
            this.p_login = new System.Windows.Forms.Panel();
            this.lb_error = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.p_menu.SuspendLayout();
            this.p_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_singlegame
            // 
            this.bt_singlegame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_singlegame.Location = new System.Drawing.Point(37, 44);
            this.bt_singlegame.Name = "bt_singlegame";
            this.bt_singlegame.Size = new System.Drawing.Size(157, 29);
            this.bt_singlegame.TabIndex = 0;
            this.bt_singlegame.Text = "Hra pro 1 hráče";
            this.bt_singlegame.UseVisualStyleBackColor = true;
            this.bt_singlegame.Click += new System.EventHandler(this.bt_singlegame_Click);
            // 
            // bt_multiplayer
            // 
            this.bt_multiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_multiplayer.Location = new System.Drawing.Point(37, 79);
            this.bt_multiplayer.Name = "bt_multiplayer";
            this.bt_multiplayer.Size = new System.Drawing.Size(157, 29);
            this.bt_multiplayer.TabIndex = 1;
            this.bt_multiplayer.Text = "Hra po síti";
            this.bt_multiplayer.UseVisualStyleBackColor = true;
            this.bt_multiplayer.Click += new System.EventHandler(this.bt_multiplayer_Click);
            // 
            // bt_settings
            // 
            this.bt_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_settings.Location = new System.Drawing.Point(37, 114);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Size = new System.Drawing.Size(157, 29);
            this.bt_settings.TabIndex = 2;
            this.bt_settings.Text = "Nastavení";
            this.bt_settings.UseVisualStyleBackColor = true;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // p_menu
            // 
            this.p_menu.Controls.Add(this.bt_singlegame);
            this.p_menu.Controls.Add(this.bt_settings);
            this.p_menu.Controls.Add(this.bt_multiplayer);
            this.p_menu.Location = new System.Drawing.Point(12, 12);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(232, 160);
            this.p_menu.TabIndex = 3;
            this.p_menu.Visible = false;
            // 
            // p_login
            // 
            this.p_login.Controls.Add(this.lb_error);
            this.p_login.Controls.Add(this.bt_login);
            this.p_login.Controls.Add(this.tb_name);
            this.p_login.Controls.Add(this.lb_name);
            this.p_login.Location = new System.Drawing.Point(12, 12);
            this.p_login.Name = "p_login";
            this.p_login.Size = new System.Drawing.Size(232, 160);
            this.p_login.TabIndex = 4;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(50, 67);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(122, 13);
            this.lb_error.TabIndex = 3;
            this.lb_error.Text = "Je potřeba vyplnit jméno";
            this.lb_error.Visible = false;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(70, 114);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(81, 23);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "Vstoupit";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(16, 44);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(204, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_name_KeyDown);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_name.Location = new System.Drawing.Point(34, 16);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(160, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Jméno a příjmení";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 201);
            this.Controls.Add(this.p_login);
            this.Controls.Add(this.p_menu);
            this.Name = "StartupForm";
            this.Text = "Matematico";
            this.VisibleChanged += new System.EventHandler(this.StartupForm_VisibleChanged);
            this.p_menu.ResumeLayout(false);
            this.p_login.ResumeLayout(false);
            this.p_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_singlegame;
        private System.Windows.Forms.Button bt_multiplayer;
        private System.Windows.Forms.Button bt_settings;
        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.Panel p_login;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_error;
    }
}
