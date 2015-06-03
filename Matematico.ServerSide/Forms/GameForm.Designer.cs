namespace Matematico.ServerSide.Forms
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
            this.box_users = new System.Windows.Forms.ListBox();
            this.bar_users = new System.Windows.Forms.GroupBox();
            this.bar_results = new System.Windows.Forms.GroupBox();
            this.box_results = new System.Windows.Forms.ListBox();
            this.lb_generated = new System.Windows.Forms.Label();
            this.bt_end = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bar_time = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.pBar_time = new System.Windows.Forms.ProgressBar();
            this.lb_iplabel = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_actualNumberCount = new System.Windows.Forms.Label();
            this.lb_acutalNumberCountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_connectedUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bar_users.SuspendLayout();
            this.bar_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_time)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_users
            // 
            this.box_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_users.FormattingEnabled = true;
            this.box_users.Location = new System.Drawing.Point(3, 16);
            this.box_users.Name = "box_users";
            this.box_users.Size = new System.Drawing.Size(149, 408);
            this.box_users.Sorted = true;
            this.box_users.TabIndex = 0;
            // 
            // bar_users
            // 
            this.bar_users.Controls.Add(this.box_users);
            this.bar_users.Location = new System.Drawing.Point(12, 131);
            this.bar_users.Name = "bar_users";
            this.bar_users.Size = new System.Drawing.Size(155, 427);
            this.bar_users.TabIndex = 1;
            this.bar_users.TabStop = false;
            this.bar_users.Text = "Připojení uživatelé";
            // 
            // bar_results
            // 
            this.bar_results.Controls.Add(this.box_results);
            this.bar_results.Location = new System.Drawing.Point(173, 131);
            this.bar_results.Name = "bar_results";
            this.bar_results.Size = new System.Drawing.Size(155, 430);
            this.bar_results.TabIndex = 2;
            this.bar_results.TabStop = false;
            this.bar_results.Text = "Výsledky";
            // 
            // box_results
            // 
            this.box_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_results.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_results.FormattingEnabled = true;
            this.box_results.Location = new System.Drawing.Point(3, 16);
            this.box_results.Name = "box_results";
            this.box_results.Size = new System.Drawing.Size(149, 411);
            this.box_results.TabIndex = 0;
            this.box_results.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.box_results_DrawItem);
            // 
            // lb_generated
            // 
            this.lb_generated.AutoSize = true;
            this.lb_generated.Font = new System.Drawing.Font("Microsoft Sans Serif", 220F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_generated.Location = new System.Drawing.Point(341, 29);
            this.lb_generated.Name = "lb_generated";
            this.lb_generated.Size = new System.Drawing.Size(468, 333);
            this.lb_generated.TabIndex = 4;
            this.lb_generated.Text = "10";
            this.lb_generated.Visible = false;
            // 
            // bt_end
            // 
            this.bt_end.Location = new System.Drawing.Point(400, 41);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(75, 23);
            this.bt_end.TabIndex = 5;
            this.bt_end.Text = "Konec";
            this.bt_end.UseVisualStyleBackColor = true;
            this.bt_end.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // bt_start
            // 
            this.bt_start.Enabled = false;
            this.bt_start.Location = new System.Drawing.Point(317, 41);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 6;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bar_time
            // 
            this.bar_time.Location = new System.Drawing.Point(61, 19);
            this.bar_time.Maximum = 20;
            this.bar_time.Minimum = 3;
            this.bar_time.Name = "bar_time";
            this.bar_time.Size = new System.Drawing.Size(244, 45);
            this.bar_time.TabIndex = 7;
            this.bar_time.Value = 5;
            this.bar_time.ValueChanged += new System.EventHandler(this.bar_time_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prodleva";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(287, 54);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(18, 13);
            this.lb_time.TabIndex = 9;
            this.lb_time.Text = "5s";
            // 
            // pBar_time
            // 
            this.pBar_time.Location = new System.Drawing.Point(334, 376);
            this.pBar_time.Name = "pBar_time";
            this.pBar_time.Size = new System.Drawing.Size(478, 23);
            this.pBar_time.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar_time.TabIndex = 10;
            // 
            // lb_iplabel
            // 
            this.lb_iplabel.AutoSize = true;
            this.lb_iplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_iplabel.Location = new System.Drawing.Point(6, 16);
            this.lb_iplabel.Name = "lb_iplabel";
            this.lb_iplabel.Size = new System.Drawing.Size(77, 13);
            this.lb_iplabel.TabIndex = 11;
            this.lb_iplabel.Text = "IP ADRESA:";
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_ip.Location = new System.Drawing.Point(89, 16);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(52, 13);
            this.lb_ip.TabIndex = 12;
            this.lb_ip.Text = "127.0.0.1";
            // 
            // lb_actualNumberCount
            // 
            this.lb_actualNumberCount.AutoSize = true;
            this.lb_actualNumberCount.Location = new System.Drawing.Point(96, 61);
            this.lb_actualNumberCount.Name = "lb_actualNumberCount";
            this.lb_actualNumberCount.Size = new System.Drawing.Size(13, 13);
            this.lb_actualNumberCount.TabIndex = 13;
            this.lb_actualNumberCount.Text = "0";
            this.lb_actualNumberCount.Visible = false;
            // 
            // lb_acutalNumberCountLabel
            // 
            this.lb_acutalNumberCountLabel.AutoSize = true;
            this.lb_acutalNumberCountLabel.Location = new System.Drawing.Point(114, 61);
            this.lb_acutalNumberCountLabel.Name = "lb_acutalNumberCountLabel";
            this.lb_acutalNumberCountLabel.Size = new System.Drawing.Size(27, 13);
            this.lb_acutalNumberCountLabel.TabIndex = 14;
            this.lb_acutalNumberCountLabel.Text = "/ 25";
            this.lb_acutalNumberCountLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_connectedUsers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_iplabel);
            this.groupBox1.Controls.Add(this.lb_acutalNumberCountLabel);
            this.groupBox1.Controls.Add(this.lb_actualNumberCount);
            this.groupBox1.Controls.Add(this.lb_ip);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 112);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Taženo čísel:";
            // 
            // lb_connectedUsers
            // 
            this.lb_connectedUsers.AutoSize = true;
            this.lb_connectedUsers.Location = new System.Drawing.Point(129, 39);
            this.lb_connectedUsers.Name = "lb_connectedUsers";
            this.lb_connectedUsers.Size = new System.Drawing.Size(13, 13);
            this.lb_connectedUsers.TabIndex = 16;
            this.lb_connectedUsers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Aktuálně připojeno:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_end);
            this.groupBox2.Controls.Add(this.bt_start);
            this.groupBox2.Controls.Add(this.lb_time);
            this.groupBox2.Controls.Add(this.bar_time);
            this.groupBox2.Location = new System.Drawing.Point(334, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 82);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nastavení hry";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBar_time);
            this.Controls.Add(this.lb_generated);
            this.Controls.Add(this.bar_results);
            this.Controls.Add(this.bar_users);
            this.Name = "GameForm";
            this.Text = "Matematico - server | Nová hra";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.bar_users.ResumeLayout(false);
            this.bar_results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_time)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bar_users;
        private System.Windows.Forms.ListBox box_users;
        private System.Windows.Forms.GroupBox bar_results;
        private System.Windows.Forms.ListBox box_results;
        private System.Windows.Forms.Label lb_generated;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.TrackBar bar_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.ProgressBar pBar_time;
        private System.Windows.Forms.Label lb_iplabel;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_actualNumberCount;
        private System.Windows.Forms.Label lb_acutalNumberCountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_connectedUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
