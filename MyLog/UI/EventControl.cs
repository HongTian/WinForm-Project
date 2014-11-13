using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLog.UI
{
    public partial class EventControl : UserControl
    {
        public EventControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文本框内容
        /// </summary>
        public string EventText
        {
            get
            {
                return TB_Event.Text;
            }
            set
            {
                TB_Event.Text = value;
            }
        }

        public string EventTime
        {
            get
            {
                return L_Time.Text;
            }
            set
            {
                L_Time.Text = value;
            }
        }

        public string EventTag
        {
            get
            {
                return L_Tag.Text;
            }
            set
            {
                L_Tag.Text = value;
            }
        }

        public string EventId { get; set; }

        public enum StatusType
        {
            Create,
            Delete,
            Update,
            Keep
        }

        private StatusType status = StatusType.Keep;
        public StatusType Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void TB_Event_MouseEnter(object sender, EventArgs e)
        {
            ChangeBackColor();
        }

        private void ChangeBackColor()
        {
            System.Drawing.Color backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            //panel1.BackColor = backcolor;
            TB_Event.BackColor = backcolor;
            //tableLayoutPanel1.BackColor = backcolor;
        }

        private void ResumeBackColor()
        {
            System.Drawing.Color backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            //panel1.BackColor = backcolor;
            TB_Event.BackColor = backcolor;
            //tableLayoutPanel1.BackColor = backcolor;
        }

        private void TB_Event_MouseLeave(object sender, EventArgs e)
        {
            ResumeBackColor();
        }
    }
}
