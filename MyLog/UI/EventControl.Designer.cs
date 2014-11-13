namespace MyLog.UI
{
    partial class EventControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Event = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_Tag = new System.Windows.Forms.Label();
            this.L_Time = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TB_Event, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TB_Event
            // 
            this.TB_Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.TB_Event.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Event.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Event.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Event.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(192)))), ((int)(((byte)(206)))));
            this.TB_Event.Location = new System.Drawing.Point(10, 20);
            this.TB_Event.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TB_Event.Multiline = true;
            this.TB_Event.Name = "TB_Event";
            this.TB_Event.Size = new System.Drawing.Size(380, 54);
            this.TB_Event.TabIndex = 0;
            this.TB_Event.MouseEnter += new System.EventHandler(this.TB_Event_MouseEnter);
            this.TB_Event.MouseLeave += new System.EventHandler(this.TB_Event_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.L_Tag);
            this.panel1.Controls.Add(this.L_Time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 20);
            this.panel1.TabIndex = 1;
            // 
            // L_Tag
            // 
            this.L_Tag.AutoSize = true;
            this.L_Tag.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.L_Tag.ForeColor = System.Drawing.Color.White;
            this.L_Tag.Location = new System.Drawing.Point(10, 0);
            this.L_Tag.Margin = new System.Windows.Forms.Padding(0);
            this.L_Tag.Name = "L_Tag";
            this.L_Tag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Tag.Size = new System.Drawing.Size(31, 19);
            this.L_Tag.TabIndex = 1;
            this.L_Tag.Text = "Tag";
            // 
            // L_Time
            // 
            this.L_Time.AutoSize = true;
            this.L_Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.L_Time.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.L_Time.ForeColor = System.Drawing.Color.White;
            this.L_Time.Location = new System.Drawing.Point(362, 0);
            this.L_Time.Name = "L_Time";
            this.L_Time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_Time.Size = new System.Drawing.Size(38, 19);
            this.L_Time.TabIndex = 0;
            this.L_Time.Text = "Time";
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(400, 74);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Event;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Label L_Tag;
    }
}
