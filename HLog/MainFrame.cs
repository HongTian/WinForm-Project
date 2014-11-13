using HLog.Model;
using HLog.MYUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLog
{
    public partial class MainFrame : Form
    {
        /// <summary>
        /// Context
        /// </summary>
        private LogDAL context = new LogDAL();

        #region 界面移动
        private Point pntMouse; // 鼠标移动位置
        private bool isLeft;  // 标签是否为左键
        #endregion

        public MainFrame()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            lblSearchTime.Text = DateTime.Now.ToString("yyyyMMdd");
        }

        #region 界面美化
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = global::HLog.Properties.Resources.btnExit_Enter;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = global::HLog.Properties.Resources.btnExit_Back;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = global::HLog.Properties.Resources.btnSearch_Enter;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = global::HLog.Properties.Resources.btnSearch_Back;
        }

        private void mcldSearchTime_MouseLeave(object sender, EventArgs e)
        {
            if (!lblSearchTime.Focused)
            {
                mcldSearchTime.Visible = false;
            }
        }
        #endregion

        private void mcldSearchTime_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblSearchTime.Text = e.Start.ToString("yyyyMMdd");
            mcldSearchTime.Visible = false;
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flpContent.Controls.Clear();
            if (!string.IsNullOrEmpty(lblSearchTime.Text))
            {
                List<TagEvent> models = context.GetTagEvents(lblSearchTime.Text);
                if (models != null)
                {
                    foreach (var model in models)
                    {
                        MYUI.EventControl eventcontrol = new MYUI.EventControl();
                        eventcontrol.ShowEvent(model);
                        eventcontrol.Status = MYUI.EventControl.StatusType.Keep;
                        flpContent.Controls.Add(eventcontrol);
                    }
                }
            }
            else
            {
                // 显示错误
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count = flpContent.Controls.Count;
            if (count > 0)
            {
                foreach (MYUI.EventControl item in flpContent.Controls)
                {
                    switch (item.Status)
                    {
                        case MYUI.EventControl.StatusType.Create:
                            CreateEvent(item);
                            break;
                        case MYUI.EventControl.StatusType.Delete:
                            DeleteEvent(item);
                            break;
                        case MYUI.EventControl.StatusType.Keep:
                            break;
                        case MYUI.EventControl.StatusType.Update:
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

        private int CreateEvent(EventControl item)
        {
            TagEvent model = item.GetModel();
            model.Id = GetTagEventId(model.DailyLogId); // 考虑到同时添加多条Event时，EventId要实时更新
            return context.AddTagEvent(model);
        }

        private int UpdateEvent(EventControl item)
        {
            TagEvent model = item.GetModel();
            return context.UpdateTagEvent(model);
        }

        private int DeleteEvent(EventControl item)
        {
            TagEvent model = item.GetModel();
            return context.DeleteTagEvent(model);
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            MYUI.EventControl eventcontrol = new MYUI.EventControl();
            TagEvent model = new TagEvent();
            model.Id = GetTagEventId(lblSearchTime.Text);
            model.DailyLogId = lblSearchTime.Text;
            model.CreateTime = DateTime.Now;
            eventcontrol.Status = MYUI.EventControl.StatusType.Create;
            eventcontrol.ShowEvent(model);
            flpContent.Controls.Add(eventcontrol);
        }

        private string GetTagEventId(string dailyLogId)
        {
            return dailyLogId + context.GetEventCount(dailyLogId).ToString("D4"); //每天最高9999条事件
        }

        private void lblSearchTime_MouseEnter(object sender, EventArgs e)
        {
            mcldSearchTime.Visible = true;
        }

        private void MainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pntMouse = new Point(-e.X, -e.Y);
                isLeft = true;
            }
        }

        private void MainFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLeft)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(pntMouse.X, pntMouse.Y); // 设置移动后的位置
                Location = mouseSet;
            }
        }

        private void MainFrame_MouseUp(object sender, MouseEventArgs e)
        {
            if (isLeft)
            {
                isLeft = false;
            }
        }
    }
}
