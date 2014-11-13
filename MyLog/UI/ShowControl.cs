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

namespace MyLog.UI
{
    public partial class ShowControl : UserControl
    {
        private LogDAL db = new LogDAL();

        private string dailyLogId = DateTime.Now.ToString("yyyyMMdd");

        public string DailyLogId
        {
            get
            {
                return dailyLogId;
            }
            set
            {
                dailyLogId = value;
            }
        }

        public ShowControl()
        {
            InitializeComponent();
        }

        private void BT_NewEvent_Click(object sender, EventArgs e)
        {
            EventControl logEvent = new EventControl();
            logEvent.Width = FLP_Events.Width - 30;
            logEvent.Status = EventControl.StatusType.Create;
            FLP_Events.Controls.Add(logEvent);
        }

        public void FillInfo(Model.LogInfo model)
        {
            EventControl logEvent = new EventControl();
            logEvent.Width = FLP_Events.Width - 30;
            logEvent.EventText = model.Text;
            logEvent.EventTime = model.CreateTime.ToShortTimeString();
            logEvent.Status = EventControl.StatusType.Keep;
            FLP_Events.Controls.Add(logEvent);
        }

        private void BT_SaveEvent_Click(object sender, EventArgs e)
        {
            int count = FLP_Events.Controls.Count;
            if (count > 0)
            {
                DailyLog dailyLog;
                dailyLog  = db.GetDailyLog(DateTime.Now.ToShortDateString());

                if (dailyLog == null)
                {
                    dailyLog = new DailyLog();
                    dailyLog.Id = DailyLogId;
                    dailyLog.CreateTime = DateTime.Now;
                    db.AddDailyLog(dailyLog);
                }
                foreach( EventControl item in FLP_Events.Controls)
                {
                    switch (item.Status)
                    {
                        case EventControl.StatusType.Create:
                            CreateEvent(item, dailyLog.Id);
                            break;
                        case EventControl.StatusType.Delete:
                            DeleteEvent(item);
                            break;
                        case EventControl.StatusType.Keep:
                            break;
                        case EventControl.StatusType.Update:
                            UpdateEvent(item);
                            break;
                    }
                }

                MessageBox.Show("已保存");
            }
            else
            {
                // if nothing delete
                return;
            }
        }
    
        private void CreateEvent(EventControl item, string dailyLogId)
        {
            LogEvent logevent = new LogEvent();
            logevent.Id = dailyLogId + "01";
            logevent.DailyLogId = dailyLogId;
            logevent.Text = item.EventText;
            logevent.CreateTime = DateTime.Now;
            db.AddEvent(logevent);

            LogTag logtag = new LogTag();
            logtag.DailyLogId = dailyLogId;
            logtag.Text = item.EventText.Substring(0, 4);
            db.AddTag(logtag);
        }
        private void DeleteEvent(EventControl item)
        {
            db.DeleteEvent(item.EventId);
            db.DeleteTag(item.EventText.Substring(0, 4));
        }
        private void UpdateEvent(EventControl item)
        {

        }
    }
}
