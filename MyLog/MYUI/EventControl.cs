using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLog.Model;

namespace MyLog.MYUI
{
    public partial class EventControl : UserControl
    {
        #region 控件属性
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

        private string dailyLogId;
        private string eventId;
        private DateTime createTime;
        #endregion

        public EventControl()
        {
            InitializeComponent();
        }

        #region 界面调整
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = global::MyLog.Properties.Resources.btnDelete_Enter;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = global::MyLog.Properties.Resources.btnDelete_Back;
        }

        private System.Drawing.Color ResumeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
        private System.Drawing.Color EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));

        private void txtEvent_MouseEnter(object sender, EventArgs e)
        {
            txtEvent.BackColor = EnterColor;
        }

        private void txtEvent_MouseLeave(object sender, EventArgs e)
        {
            txtEvent.BackColor = ResumeColor;
        }

        private void txtTag_MouseEnter(object sender, EventArgs e)
        {
            txtTag.BackColor = EnterColor;
        }

        private void txtTag_MouseLeave(object sender, EventArgs e)
        {
            txtTag.BackColor = ResumeColor;
        }

        private void txtTag_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTag.Text))
            {
                txtTag.Text = "Tag";
            }
        }

        private void txtTag_Enter(object sender, EventArgs e)
        {
            if (txtTag.Text.Equals("Tag"))
            {
                txtTag.Text = "";
            }
        }

        private void txtEvent_Enter(object sender, EventArgs e)
        {
            if (txtEvent.Text.Equals("Event"))
            {
                txtEvent.Text = "";
            }
        }

        private void txtEvent_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEvent.Text))
            {
                txtEvent.Text = "Event";
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (status == StatusType.Create)
            {
                status = StatusType.Keep;
            }
            else
            {
                status = StatusType.Delete;
            }
            Visible = false;
        }

        public void ShowEvent(TagEvent model)
        {
            txtTag.Text = model.TagText ?? "Tag";
            txtEvent.Text = model.EventText ?? "Event";
            dailyLogId = model.DailyLogId;
            eventId = model.Id;
            createTime = model.CreateTime;
            lblCreateTime.Text = model.CreateTime.ToShortTimeString();
        }

        public TagEvent GetModel()
        {
            TagEvent model = new TagEvent();
            model.Id = eventId;
            model.DailyLogId = dailyLogId;
            model.EventText = txtEvent.Text;
            model.TagText = txtTag.Text;
            model.CreateTime = createTime;
            return model;
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            if (status == StatusType.Keep)
                status = StatusType.Update;
        }

        private void txtEvent_TextChanged(object sender, EventArgs e)
        {
            if (status == StatusType.Keep)
                status = StatusType.Update;
        }


    }
}
