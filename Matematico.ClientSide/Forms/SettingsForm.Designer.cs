namespace Matematico.ClientSide.Forms
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_timelimit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_timelimit = new System.Windows.Forms.TrackBar();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBox_waitAllTime = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_timelimit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_timelimit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_timelimit);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Čas na odehrání";
            // 
            // lb_timelimit
            // 
            this.lb_timelimit.AutoSize = true;
            this.lb_timelimit.Location = new System.Drawing.Point(179, 64);
            this.lb_timelimit.Name = "lb_timelimit";
            this.lb_timelimit.Size = new System.Drawing.Size(13, 13);
            this.lb_timelimit.TabIndex = 2;
            this.lb_timelimit.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "s";
            // 
            // trackBar_timelimit
            // 
            this.trackBar_timelimit.Location = new System.Drawing.Point(6, 20);
            this.trackBar_timelimit.Maximum = 20;
            this.trackBar_timelimit.Minimum = 3;
            this.trackBar_timelimit.Name = "trackBar_timelimit";
            this.trackBar_timelimit.Size = new System.Drawing.Size(204, 45);
            this.trackBar_timelimit.TabIndex = 0;
            this.trackBar_timelimit.Value = 3;
            this.trackBar_timelimit.ValueChanged += new System.EventHandler(this.trackBar_timelimit_ValueChanged);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(314, 209);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Uložit";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(395, 209);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "Konec";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_host);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(65, 23);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(100, 20);
            this.tb_host.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Adresa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBox_waitAllTime);
            this.groupBox3.Location = new System.Drawing.Point(249, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hra";
            // 
            // cBox_waitAllTime
            // 
            this.cBox_waitAllTime.AutoSize = true;
            this.cBox_waitAllTime.Location = new System.Drawing.Point(7, 20);
            this.cBox_waitAllTime.Name = "cBox_waitAllTime";
            this.cBox_waitAllTime.Size = new System.Drawing.Size(197, 17);
            this.cBox_waitAllTime.TabIndex = 0;
            this.cBox_waitAllTime.Text = "Přeskočit po odehrání na další čislo";
            this.cBox_waitAllTime.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 244);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "Nastavení";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_timelimit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_timelimit;
        private System.Windows.Forms.Label lb_timelimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cBox_waitAllTime;
    }
}
