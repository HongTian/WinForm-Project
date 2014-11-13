namespace HLog.MYUI
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
            this.lblCreateTime = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCreateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(214)))), ((int)(((byte)(230)))));
            this.lblCreateTime.Location = new System.Drawing.Point(411, 12);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(79, 17);
            this.lblCreateTime.TabIndex = 0;
            this.lblCreateTime.Text = "21:10:53 PM";
            // 
            // txtTag
            // 
            this.txtTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTag.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTag.ForeColor = System.Drawing.Color.White;
            this.txtTag.Location = new System.Drawing.Point(20, 12);
            this.txtTag.Margin = new System.Windows.Forms.Padding(0);
            this.txtTag.MaxLength = 10;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 16);
            this.txtTag.TabIndex = 1;
            this.txtTag.Text = "Tag";
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            this.txtTag.Enter += new System.EventHandler(this.txtTag_Enter);
            this.txtTag.Leave += new System.EventHandler(this.txtTag_Leave);
            this.txtTag.MouseEnter += new System.EventHandler(this.txtTag_MouseEnter);
            this.txtTag.MouseLeave += new System.EventHandler(this.txtTag_MouseLeave);
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.txtEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEvent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(214)))), ((int)(((byte)(230)))));
            this.txtEvent.Location = new System.Drawing.Point(18, 34);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(0);
            this.txtEvent.MaxLength = 100;
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(386, 34);
            this.txtEvent.TabIndex = 2;
            this.txtEvent.Text = "Event";
            this.txtEvent.TextChanged += new System.EventHandler(this.txtEvent_TextChanged);
            this.txtEvent.Enter += new System.EventHandler(this.txtEvent_Enter);
            this.txtEvent.Leave += new System.EventHandler(this.txtEvent_Leave);
            this.txtEvent.MouseEnter += new System.EventHandler(this.txtEvent_MouseEnter);
            this.txtEvent.MouseLeave += new System.EventHandler(this.txtEvent_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::HLog.Properties.Resources.btnDelete_Back;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(465, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.lblCreateTime);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(500, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTime;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button btnDelete;
    }
}
