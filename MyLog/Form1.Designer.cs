namespace MyLog
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_find_id = new System.Windows.Forms.Button();
            this.dtp_start_mod = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_end_mod = new System.Windows.Forms.DateTimePicker();
            this.dtp_end_create = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_start_create = new System.Windows.Forms.DateTimePicker();
            this.bt_find_time = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.p_menu = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_week = new System.Windows.Forms.Label();
            this.P_ClientForm = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.P_Calendar = new System.Windows.Forms.Panel();
            this.bt_save = new MyLog.UI.Button();
            this.bt_create = new MyLog.UI.Button();
            this.p_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.P_ClientForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(12, 14);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 19);
            this.Status.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "编号";
            this.label1.Visible = false;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(51, 68);
            this.tb_id.MaxLength = 10;
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(141, 20);
            this.tb_id.TabIndex = 6;
            this.tb_id.Visible = false;
            // 
            // bt_find_id
            // 
            this.bt_find_id.BackColor = System.Drawing.Color.White;
            this.bt_find_id.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_find_id.FlatAppearance.BorderSize = 2;
            this.bt_find_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.bt_find_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_find_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_find_id.Location = new System.Drawing.Point(198, 67);
            this.bt_find_id.Name = "bt_find_id";
            this.bt_find_id.Size = new System.Drawing.Size(75, 46);
            this.bt_find_id.TabIndex = 7;
            this.bt_find_id.Text = "查询";
            this.bt_find_id.UseVisualStyleBackColor = false;
            this.bt_find_id.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // dtp_start_mod
            // 
            this.dtp_start_mod.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_start_mod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start_mod.Location = new System.Drawing.Point(340, 94);
            this.dtp_start_mod.Name = "dtp_start_mod";
            this.dtp_start_mod.Size = new System.Drawing.Size(160, 20);
            this.dtp_start_mod.TabIndex = 8;
            this.dtp_start_mod.Value = new System.DateTime(2014, 9, 15, 23, 3, 3, 512);
            this.dtp_start_mod.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "修改时间";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "~";
            this.label3.Visible = false;
            // 
            // dtp_end_mod
            // 
            this.dtp_end_mod.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_end_mod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end_mod.Location = new System.Drawing.Point(526, 94);
            this.dtp_end_mod.Name = "dtp_end_mod";
            this.dtp_end_mod.Size = new System.Drawing.Size(160, 20);
            this.dtp_end_mod.TabIndex = 11;
            this.dtp_end_mod.Value = new System.DateTime(2014, 10, 15, 23, 3, 3, 544);
            this.dtp_end_mod.Visible = false;
            // 
            // dtp_end_create
            // 
            this.dtp_end_create.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_end_create.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end_create.Location = new System.Drawing.Point(526, 68);
            this.dtp_end_create.Name = "dtp_end_create";
            this.dtp_end_create.Size = new System.Drawing.Size(160, 20);
            this.dtp_end_create.TabIndex = 15;
            this.dtp_end_create.Value = new System.DateTime(2014, 10, 15, 23, 3, 3, 544);
            this.dtp_end_create.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "~";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "创建时间";
            this.label5.Visible = false;
            // 
            // dtp_start_create
            // 
            this.dtp_start_create.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp_start_create.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp_start_create.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtp_start_create.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start_create.Location = new System.Drawing.Point(340, 68);
            this.dtp_start_create.Name = "dtp_start_create";
            this.dtp_start_create.Size = new System.Drawing.Size(160, 20);
            this.dtp_start_create.TabIndex = 12;
            this.dtp_start_create.Value = new System.DateTime(2014, 9, 15, 23, 3, 3, 575);
            this.dtp_start_create.Visible = false;
            // 
            // bt_find_time
            // 
            this.bt_find_time.BackColor = System.Drawing.Color.White;
            this.bt_find_time.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_find_time.FlatAppearance.BorderSize = 2;
            this.bt_find_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.bt_find_time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_find_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_find_time.Location = new System.Drawing.Point(692, 68);
            this.bt_find_time.Name = "bt_find_time";
            this.bt_find_time.Size = new System.Drawing.Size(75, 46);
            this.bt_find_time.TabIndex = 16;
            this.bt_find_time.Text = "查询";
            this.bt_find_time.UseVisualStyleBackColor = false;
            this.bt_find_time.Click += new System.EventHandler(this.bt_find_time_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.White;
            this.bt_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_delete.FlatAppearance.BorderSize = 2;
            this.bt_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.bt_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Location = new System.Drawing.Point(611, 503);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 46);
            this.bt_delete.TabIndex = 17;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // p_menu
            // 
            this.p_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.p_menu.Controls.Add(this.bt_exit);
            this.p_menu.Controls.Add(this.panel2);
            this.p_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_menu.Location = new System.Drawing.Point(0, 0);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(784, 50);
            this.p_menu.TabIndex = 19;
            this.p_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_menu_MouseDown);
            this.p_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_menu_MouseMove);
            this.p_menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_menu_MouseUp);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.bt_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Location = new System.Drawing.Point(674, 0);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(110, 50);
            this.bt_exit.TabIndex = 20;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 50);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "我的日志";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.Status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 45);
            this.panel1.TabIndex = 20;
            // 
            // l_week
            // 
            this.l_week.AutoSize = true;
            this.l_week.Location = new System.Drawing.Point(14, 100);
            this.l_week.Name = "l_week";
            this.l_week.Size = new System.Drawing.Size(0, 13);
            this.l_week.TabIndex = 21;
            // 
            // P_ClientForm
            // 
            this.P_ClientForm.Controls.Add(this.monthCalendar1);
            this.P_ClientForm.Location = new System.Drawing.Point(17, 172);
            this.P_ClientForm.Name = "P_ClientForm";
            this.P_ClientForm.Size = new System.Drawing.Size(750, 377);
            this.P_ClientForm.TabIndex = 22;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // P_Calendar
            // 
            this.P_Calendar.Location = new System.Drawing.Point(17, 148);
            this.P_Calendar.Margin = new System.Windows.Forms.Padding(0);
            this.P_Calendar.Name = "P_Calendar";
            this.P_Calendar.Size = new System.Drawing.Size(227, 24);
            this.P_Calendar.TabIndex = 23;
            this.P_Calendar.MouseEnter += new System.EventHandler(this.P_Calendar_MouseEnter);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.White;
            this.bt_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_save.FlatAppearance.BorderSize = 2;
            this.bt_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.bt_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Location = new System.Drawing.Point(692, 503);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 46);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "修改";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Visible = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_create
            // 
            this.bt_create.BackColor = System.Drawing.Color.White;
            this.bt_create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_create.FlatAppearance.BorderSize = 2;
            this.bt_create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.bt_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(124)))), ((int)(((byte)(192)))));
            this.bt_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_create.Location = new System.Drawing.Point(17, 503);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(75, 46);
            this.bt_create.TabIndex = 1;
            this.bt_create.Text = "新建";
            this.bt_create.UseVisualStyleBackColor = false;
            this.bt_create.Visible = false;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.P_Calendar);
            this.Controls.Add(this.P_ClientForm);
            this.Controls.Add(this.l_week);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_menu);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_find_time);
            this.Controls.Add(this.dtp_end_create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_start_create);
            this.Controls.Add(this.dtp_end_mod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_start_mod);
            this.Controls.Add(this.bt_find_id);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "我的日志";
            this.p_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.P_ClientForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLog.UI.Button bt_create;
        private System.Windows.Forms.Label Status;
        private MyLog.UI.Button bt_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_find_id;
        private System.Windows.Forms.DateTimePicker dtp_start_mod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_end_mod;
        private System.Windows.Forms.DateTimePicker dtp_end_create;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_start_create;
        private System.Windows.Forms.Button bt_find_time;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_week;
        private System.Windows.Forms.Panel P_ClientForm;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel P_Calendar;

        
    }
}

