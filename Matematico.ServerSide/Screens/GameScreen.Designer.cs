namespace Matematico.ServerSide.Screens
{
    partial class GameScreen
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_end = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.lb_time = new System.Windows.Forms.Label();
            this.bar_time = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_connectedUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_actualNumberCount = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.pBar_time = new System.Windows.Forms.ProgressBar();
            this.lb_generated = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.users = new Matematico.Components.UserList();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_time)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_end);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_start);
            this.groupBox2.Controls.Add(this.lb_time);
            this.groupBox2.Controls.Add(this.bar_time);
            this.groupBox2.Location = new System.Drawing.Point(363, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 82);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nastavení hry";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prodleva";
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
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(287, 54);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(18, 13);
            this.lb_time.TabIndex = 9;
            this.lb_time.Text = "5s";
            // 
            // bar_time
            // 
            this.bar_time.Location = new System.Drawing.Point(61, 19);
            this.bar_time.Maximum = 20;
            this.bar_time.Minimum = 1;
            this.bar_time.Name = "bar_time";
            this.bar_time.Size = new System.Drawing.Size(244, 45);
            this.bar_time.TabIndex = 7;
            this.bar_time.Value = 5;
            this.bar_time.ValueChanged += new System.EventHandler(this.bar_time_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Taženo čísel:";
            // 
            // lb_connectedUsers
            // 
            this.lb_connectedUsers.AutoSize = true;
            this.lb_connectedUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_connectedUsers.Location = new System.Drawing.Point(142, 23);
            this.lb_connectedUsers.Name = "lb_connectedUsers";
            this.lb_connectedUsers.Size = new System.Drawing.Size(115, 13);
            this.lb_connectedUsers.TabIndex = 16;
            this.lb_connectedUsers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Aktuálně připojeno:";
            // 
            // lb_actualNumberCount
            // 
            this.lb_actualNumberCount.AutoSize = true;
            this.lb_actualNumberCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_actualNumberCount.Location = new System.Drawing.Point(142, 47);
            this.lb_actualNumberCount.Name = "lb_actualNumberCount";
            this.lb_actualNumberCount.Size = new System.Drawing.Size(115, 13);
            this.lb_actualNumberCount.TabIndex = 14;
            this.lb_actualNumberCount.Text = "0 / 25";
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_ip.Location = new System.Drawing.Point(142, 0);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(115, 13);
            this.lb_ip.TabIndex = 12;
            this.lb_ip.Text = "127.0.0.1";
            // 
            // pBar_time
            // 
            this.pBar_time.Location = new System.Drawing.Point(366, 360);
            this.pBar_time.Name = "pBar_time";
            this.pBar_time.Size = new System.Drawing.Size(604, 23);
            this.pBar_time.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar_time.TabIndex = 20;
            // 
            // lb_generated
            // 
            this.lb_generated.AutoSize = true;
            this.lb_generated.Font = new System.Drawing.Font("Microsoft Sans Serif", 220F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_generated.Location = new System.Drawing.Point(478, 38);
            this.lb_generated.Name = "lb_generated";
            this.lb_generated.Size = new System.Drawing.Size(468, 333);
            this.lb_generated.TabIndex = 19;
            this.lb_generated.Text = "10";
            this.lb_generated.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tableLayoutPanel1.Controls.Add(this.lb_connectedUsers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_actualNumberCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_ip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 60);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Adresa:";
            // 
            // users
            // 
            this.users.BackgroundColor = System.Drawing.Color.White;
            this.users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.users.GridColor = System.Drawing.Color.White;
            this.users.Location = new System.Drawing.Point(3, 92);
            this.users.Name = "users";
            this.users.RowHeadersVisible = false;
            this.users.Size = new System.Drawing.Size(303, 385);
            this.users.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Jméno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Body";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Chybějící";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Jméno";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // points
            // 
            this.points.HeaderText = "Body";
            this.points.Name = "points";
            this.points.ReadOnly = true;
            // 
            // missing
            // 
            this.missing.HeaderText = "Chybějící";
            this.missing.Name = "missing";
            this.missing.ReadOnly = true;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.users);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pBar_time);
            this.Controls.Add(this.lb_generated);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1000, 480);
            this.VisibleChanged += new System.EventHandler(this.GameScreen_VisibleChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_time)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.TrackBar bar_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_connectedUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_actualNumberCount;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.ProgressBar pBar_time;
        private System.Windows.Forms.Label lb_generated;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private Matematico.Components.UserList users;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.DataGridViewTextBoxColumn missing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
