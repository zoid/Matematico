namespace Matematico.ClientSide.Forms
{
    partial class GameForm
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
            this.sideBar_number = new System.Windows.Forms.GroupBox();
            this.progBar_time = new System.Windows.Forms.ProgressBar();
            this.lb_time = new System.Windows.Forms.Label();
            this.label_change = new System.Windows.Forms.Label();
            this.lb_actualNumber = new System.Windows.Forms.Label();
            this.sideBar_combinations = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_par = new System.Windows.Forms.Label();
            this.sideBar_points = new System.Windows.Forms.GroupBox();
            this.lb_totalPoints = new System.Windows.Forms.Label();
            this.lb_y_0 = new System.Windows.Forms.Label();
            this.lb_y_1 = new System.Windows.Forms.Label();
            this.lb_y_3 = new System.Windows.Forms.Label();
            this.lb_y_2 = new System.Windows.Forms.Label();
            this.lb_y_4 = new System.Windows.Forms.Label();
            this.lb_x_4 = new System.Windows.Forms.Label();
            this.lb_x_3 = new System.Windows.Forms.Label();
            this.lb_x_2 = new System.Windows.Forms.Label();
            this.lb_x_1 = new System.Windows.Forms.Label();
            this.lb_x_0 = new System.Windows.Forms.Label();
            this.lb_diag_0 = new System.Windows.Forms.Label();
            this.lb_diag_1 = new System.Windows.Forms.Label();
            this.bt_end = new System.Windows.Forms.Button();
            this.sidebar_username = new System.Windows.Forms.GroupBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.p_score = new System.Windows.Forms.Panel();
            this.bt_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.box_status = new System.Windows.Forms.GroupBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.p_localGame = new System.Windows.Forms.Panel();
            this.sideBar_number.SuspendLayout();
            this.sideBar_combinations.SuspendLayout();
            this.sideBar_points.SuspendLayout();
            this.sidebar_username.SuspendLayout();
            this.p_score.SuspendLayout();
            this.panel1.SuspendLayout();
            this.box_status.SuspendLayout();
            this.p_localGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar_number
            // 
            this.sideBar_number.Controls.Add(this.progBar_time);
            this.sideBar_number.Controls.Add(this.lb_time);
            this.sideBar_number.Controls.Add(this.label_change);
            this.sideBar_number.Controls.Add(this.lb_actualNumber);
            this.sideBar_number.Location = new System.Drawing.Point(79, 11);
            this.sideBar_number.Name = "sideBar_number";
            this.sideBar_number.Size = new System.Drawing.Size(222, 128);
            this.sideBar_number.TabIndex = 0;
            this.sideBar_number.TabStop = false;
            this.sideBar_number.Text = "Aktuální číslo";
            // 
            // progBar_time
            // 
            this.progBar_time.Location = new System.Drawing.Point(6, 70);
            this.progBar_time.Name = "progBar_time";
            this.progBar_time.Size = new System.Drawing.Size(210, 24);
            this.progBar_time.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar_time.TabIndex = 4;
            this.progBar_time.Visible = false;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_time.Location = new System.Drawing.Point(83, 100);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(23, 17);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "5s";
            // 
            // label_change
            // 
            this.label_change.AutoSize = true;
            this.label_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_change.Location = new System.Drawing.Point(6, 100);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(71, 17);
            this.label_change.TabIndex = 1;
            this.label_change.Text = "Změna za";
            this.label_change.Visible = false;
            // 
            // lb_actualNumber
            // 
            this.lb_actualNumber.AutoSize = true;
            this.lb_actualNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_actualNumber.Location = new System.Drawing.Point(74, 24);
            this.lb_actualNumber.Name = "lb_actualNumber";
            this.lb_actualNumber.Size = new System.Drawing.Size(55, 39);
            this.lb_actualNumber.TabIndex = 0;
            this.lb_actualNumber.Text = "11";
            // 
            // sideBar_combinations
            // 
            this.sideBar_combinations.Controls.Add(this.label7);
            this.sideBar_combinations.Controls.Add(this.label6);
            this.sideBar_combinations.Controls.Add(this.label5);
            this.sideBar_combinations.Controls.Add(this.label4);
            this.sideBar_combinations.Controls.Add(this.label3);
            this.sideBar_combinations.Controls.Add(this.label2);
            this.sideBar_combinations.Controls.Add(this.label1);
            this.sideBar_combinations.Controls.Add(this.label_par);
            this.sideBar_combinations.Location = new System.Drawing.Point(79, 145);
            this.sideBar_combinations.Name = "sideBar_combinations";
            this.sideBar_combinations.Size = new System.Drawing.Size(222, 137);
            this.sideBar_combinations.TabIndex = 1;
            this.sideBar_combinations.TabStop = false;
            this.sideBar_combinations.Text = "Kombinace";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trojice a dvojice        5 bodů";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Postupka (5)              6 bodů";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Postupka (4)              3 body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postupka (3)              1 bod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Čtveřice                     4 body";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trojice                       2 body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "2 páry                        3 body";
            // 
            // label_par
            // 
            this.label_par.AutoSize = true;
            this.label_par.Location = new System.Drawing.Point(7, 20);
            this.label_par.Name = "label_par";
            this.label_par.Size = new System.Drawing.Size(133, 13);
            this.label_par.TabIndex = 0;
            this.label_par.Text = "1 pár                         1 bod";
            // 
            // sideBar_points
            // 
            this.sideBar_points.Controls.Add(this.lb_totalPoints);
            this.sideBar_points.Location = new System.Drawing.Point(79, 288);
            this.sideBar_points.Name = "sideBar_points";
            this.sideBar_points.Size = new System.Drawing.Size(222, 54);
            this.sideBar_points.TabIndex = 2;
            this.sideBar_points.TabStop = false;
            this.sideBar_points.Text = "Získaný počet bodů";
            // 
            // lb_totalPoints
            // 
            this.lb_totalPoints.AutoSize = true;
            this.lb_totalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_totalPoints.Location = new System.Drawing.Point(91, 16);
            this.lb_totalPoints.Name = "lb_totalPoints";
            this.lb_totalPoints.Size = new System.Drawing.Size(26, 29);
            this.lb_totalPoints.TabIndex = 0;
            this.lb_totalPoints.Text = "0";
            // 
            // lb_y_0
            // 
            this.lb_y_0.AutoSize = true;
            this.lb_y_0.Location = new System.Drawing.Point(293, 35);
            this.lb_y_0.Name = "lb_y_0";
            this.lb_y_0.Size = new System.Drawing.Size(19, 13);
            this.lb_y_0.TabIndex = 3;
            this.lb_y_0.Text = "22";
            // 
            // lb_y_1
            // 
            this.lb_y_1.AutoSize = true;
            this.lb_y_1.Location = new System.Drawing.Point(293, 92);
            this.lb_y_1.Name = "lb_y_1";
            this.lb_y_1.Size = new System.Drawing.Size(19, 13);
            this.lb_y_1.TabIndex = 4;
            this.lb_y_1.Text = "22";
            // 
            // lb_y_3
            // 
            this.lb_y_3.AutoSize = true;
            this.lb_y_3.Location = new System.Drawing.Point(293, 205);
            this.lb_y_3.Name = "lb_y_3";
            this.lb_y_3.Size = new System.Drawing.Size(19, 13);
            this.lb_y_3.TabIndex = 6;
            this.lb_y_3.Text = "22";
            // 
            // lb_y_2
            // 
            this.lb_y_2.AutoSize = true;
            this.lb_y_2.Location = new System.Drawing.Point(293, 145);
            this.lb_y_2.Name = "lb_y_2";
            this.lb_y_2.Size = new System.Drawing.Size(19, 13);
            this.lb_y_2.TabIndex = 5;
            this.lb_y_2.Text = "22";
            // 
            // lb_y_4
            // 
            this.lb_y_4.AutoSize = true;
            this.lb_y_4.Location = new System.Drawing.Point(293, 261);
            this.lb_y_4.Name = "lb_y_4";
            this.lb_y_4.Size = new System.Drawing.Size(19, 13);
            this.lb_y_4.TabIndex = 7;
            this.lb_y_4.Text = "22";
            // 
            // lb_x_4
            // 
            this.lb_x_4.AutoSize = true;
            this.lb_x_4.Location = new System.Drawing.Point(260, 292);
            this.lb_x_4.Name = "lb_x_4";
            this.lb_x_4.Size = new System.Drawing.Size(19, 13);
            this.lb_x_4.TabIndex = 8;
            this.lb_x_4.Text = "22";
            // 
            // lb_x_3
            // 
            this.lb_x_3.AutoSize = true;
            this.lb_x_3.Location = new System.Drawing.Point(201, 292);
            this.lb_x_3.Name = "lb_x_3";
            this.lb_x_3.Size = new System.Drawing.Size(19, 13);
            this.lb_x_3.TabIndex = 9;
            this.lb_x_3.Text = "22";
            // 
            // lb_x_2
            // 
            this.lb_x_2.AutoSize = true;
            this.lb_x_2.Location = new System.Drawing.Point(149, 292);
            this.lb_x_2.Name = "lb_x_2";
            this.lb_x_2.Size = new System.Drawing.Size(19, 13);
            this.lb_x_2.TabIndex = 10;
            this.lb_x_2.Text = "22";
            // 
            // lb_x_1
            // 
            this.lb_x_1.AutoSize = true;
            this.lb_x_1.Location = new System.Drawing.Point(93, 292);
            this.lb_x_1.Name = "lb_x_1";
            this.lb_x_1.Size = new System.Drawing.Size(19, 13);
            this.lb_x_1.TabIndex = 11;
            this.lb_x_1.Text = "22";
            // 
            // lb_x_0
            // 
            this.lb_x_0.AutoSize = true;
            this.lb_x_0.Location = new System.Drawing.Point(34, 292);
            this.lb_x_0.Name = "lb_x_0";
            this.lb_x_0.Size = new System.Drawing.Size(19, 13);
            this.lb_x_0.TabIndex = 12;
            this.lb_x_0.Text = "22";
            // 
            // lb_diag_0
            // 
            this.lb_diag_0.AutoSize = true;
            this.lb_diag_0.Location = new System.Drawing.Point(293, 292);
            this.lb_diag_0.Name = "lb_diag_0";
            this.lb_diag_0.Size = new System.Drawing.Size(19, 13);
            this.lb_diag_0.TabIndex = 13;
            this.lb_diag_0.Text = "22";
            // 
            // lb_diag_1
            // 
            this.lb_diag_1.AutoSize = true;
            this.lb_diag_1.Location = new System.Drawing.Point(293, 5);
            this.lb_diag_1.Name = "lb_diag_1";
            this.lb_diag_1.Size = new System.Drawing.Size(19, 13);
            this.lb_diag_1.TabIndex = 14;
            this.lb_diag_1.Text = "22";
            // 
            // bt_end
            // 
            this.bt_end.Location = new System.Drawing.Point(144, 3);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(62, 23);
            this.bt_end.TabIndex = 15;
            this.bt_end.Text = "Konec";
            this.bt_end.UseVisualStyleBackColor = true;
            this.bt_end.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // sidebar_username
            // 
            this.sidebar_username.Controls.Add(this.lb_name);
            this.sidebar_username.Location = new System.Drawing.Point(79, 350);
            this.sidebar_username.Name = "sidebar_username";
            this.sidebar_username.Size = new System.Drawing.Size(222, 54);
            this.sidebar_username.TabIndex = 3;
            this.sidebar_username.TabStop = false;
            this.sidebar_username.Text = "Hráč";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_name.Location = new System.Drawing.Point(58, 20);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(90, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "David Blažek";
            // 
            // btn_restart
            // 
            this.btn_restart.Enabled = false;
            this.btn_restart.Location = new System.Drawing.Point(70, 3);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(72, 23);
            this.btn_restart.TabIndex = 16;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // p_score
            // 
            this.p_score.BackColor = System.Drawing.Color.Transparent;
            this.p_score.Controls.Add(this.lb_x_0);
            this.p_score.Controls.Add(this.lb_y_0);
            this.p_score.Controls.Add(this.lb_y_1);
            this.p_score.Controls.Add(this.lb_y_2);
            this.p_score.Controls.Add(this.lb_diag_1);
            this.p_score.Controls.Add(this.lb_y_3);
            this.p_score.Controls.Add(this.lb_diag_0);
            this.p_score.Controls.Add(this.lb_y_4);
            this.p_score.Controls.Add(this.lb_x_4);
            this.p_score.Controls.Add(this.lb_x_1);
            this.p_score.Controls.Add(this.lb_x_3);
            this.p_score.Controls.Add(this.lb_x_2);
            this.p_score.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_score.Location = new System.Drawing.Point(0, 0);
            this.p_score.Name = "p_score";
            this.p_score.Size = new System.Drawing.Size(319, 509);
            this.p_score.TabIndex = 17;
            this.p_score.Visible = false;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(3, 3);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(65, 23);
            this.bt_start.TabIndex = 18;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.box_status);
            this.panel1.Controls.Add(this.p_localGame);
            this.panel1.Controls.Add(this.sideBar_number);
            this.panel1.Controls.Add(this.sideBar_combinations);
            this.panel1.Controls.Add(this.sideBar_points);
            this.panel1.Controls.Add(this.sidebar_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 509);
            this.panel1.TabIndex = 19;
            // 
            // box_status
            // 
            this.box_status.Controls.Add(this.lb_status);
            this.box_status.Location = new System.Drawing.Point(76, 410);
            this.box_status.Name = "box_status";
            this.box_status.Size = new System.Drawing.Size(225, 47);
            this.box_status.TabIndex = 24;
            this.box_status.TabStop = false;
            this.box_status.Text = "Status";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_status.ForeColor = System.Drawing.Color.Red;
            this.lb_status.Location = new System.Drawing.Point(61, 16);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(96, 17);
            this.lb_status.TabIndex = 0;
            this.lb_status.Text = "Nepřipojeno";
            // 
            // p_localGame
            // 
            this.p_localGame.Controls.Add(this.bt_end);
            this.p_localGame.Controls.Add(this.bt_start);
            this.p_localGame.Controls.Add(this.btn_restart);
            this.p_localGame.Location = new System.Drawing.Point(76, 460);
            this.p_localGame.Name = "p_localGame";
            this.p_localGame.Size = new System.Drawing.Size(225, 33);
            this.p_localGame.TabIndex = 19;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_score);
            this.MinimumSize = new System.Drawing.Size(590, 450);
            this.Name = "GameForm";
            this.Text = "Matematico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SingleGame_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.sideBar_number.ResumeLayout(false);
            this.sideBar_number.PerformLayout();
            this.sideBar_combinations.ResumeLayout(false);
            this.sideBar_combinations.PerformLayout();
            this.sideBar_points.ResumeLayout(false);
            this.sideBar_points.PerformLayout();
            this.sidebar_username.ResumeLayout(false);
            this.sidebar_username.PerformLayout();
            this.p_score.ResumeLayout(false);
            this.p_score.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.box_status.ResumeLayout(false);
            this.box_status.PerformLayout();
            this.p_localGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sideBar_number;
        private System.Windows.Forms.Label lb_actualNumber;
        private System.Windows.Forms.GroupBox sideBar_combinations;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label label_change;
        private System.Windows.Forms.GroupBox sideBar_points;
        private System.Windows.Forms.Label lb_y_0;
        private System.Windows.Forms.Label lb_y_1;
        private System.Windows.Forms.Label lb_y_3;
        private System.Windows.Forms.Label lb_y_2;
        private System.Windows.Forms.Label lb_y_4;
        private System.Windows.Forms.Label lb_x_4;
        private System.Windows.Forms.Label lb_x_3;
        private System.Windows.Forms.Label lb_x_2;
        private System.Windows.Forms.Label lb_x_1;
        private System.Windows.Forms.Label lb_x_0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_par;
        private System.Windows.Forms.Label lb_totalPoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_diag_0;
        private System.Windows.Forms.Label lb_diag_1;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.GroupBox sidebar_username;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Panel p_score;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progBar_time;
        private System.Windows.Forms.Panel p_localGame;
        private System.Windows.Forms.GroupBox box_status;
        private System.Windows.Forms.Label lb_status;
    }
}
