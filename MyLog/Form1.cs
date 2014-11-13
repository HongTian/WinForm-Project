using Microsoft.Practices.EnterpriseLibrary.Data;
using MyLog.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLog
{
    public partial class Form1 : Form
    {
        Point mouseOff; // 鼠标移动位置
        bool leftFlag;  // 标签是否为左键

        private LogDAL db = new LogDAL();

        // 自定义控件
        private UI.DataGridViewControl dgv_logInfo = new UI.DataGridViewControl();

        private UI.ShowControl LogDetails = new UI.ShowControl();

        public Form1()
        {
            InitializeComponent();
            InitialFindTime();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            this.P_ClientForm.Controls.Clear();
            this.P_ClientForm.Controls.Add(LogDetails);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string logInfo = "";// tb_logInfo.Text;
            int id = int.Parse(tb_id.Text);

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Logs set");
            strSql.Append(" LogInfo = @LogInfo");
            strSql.Append(", ModificationTime = @ModificationTime");
            strSql.Append(" where Id = @Id");
            SqlParameter[] parameters = {
			            new SqlParameter("@LogInfo", SqlDbType.VarChar),
                        new SqlParameter("@ModificationTime", SqlDbType.DateTime),
                        new SqlParameter("@Id", SqlDbType.Int)
            };

            parameters[0].Value = logInfo;
            parameters[1].Value = System.DateTime.Now;
            parameters[2].Value = id;

            SqlHelper.Execute(strSql.ToString(), parameters);

            this.Status.Text = "保存成功";
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            this.Status.Text = "";

            int id;

            if (int.TryParse(tb_id.Text, out id))
            {

                LogInfo log = db.GetLog(id);
                if (log != null)
                {
                    this.P_ClientForm.Controls.Clear();
                    this.P_ClientForm.Controls.Add(LogDetails);
                    LogDetails.FillInfo(log);
                }
                else
                {
                    this.Status.Text = "无此数据";
                    return;
                }
            }
            else
            {
                this.Status.Text = "输入正确编号";
                return;
            }
        }

        private void bt_find_time_Click(object sender, EventArgs e)
        {
            this.Status.Text = "";

            DateTime cstart = this.dtp_start_create.Value;
            DateTime cend = this.dtp_end_create.Value;
            DateTime mstart = this.dtp_start_mod.Value;
            DateTime mend = this.dtp_end_mod.Value;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("exec sp_find");
            strSql.Append(" @cstart,@cend,@mstart,@mend");
            SqlParameter[] parameters = {
                        new SqlParameter("@cstart", SqlDbType.DateTime),
                        new SqlParameter("@cend", SqlDbType.DateTime),
                        new SqlParameter("@mstart", SqlDbType.DateTime),
                        new SqlParameter("@mend", SqlDbType.DateTime)
            };

            parameters[0].Value = cstart;
            parameters[1].Value = cend;
            parameters[2].Value = mstart;
            parameters[3].Value = mend;

            try
            {
                DataTable dt = SqlHelper.GetDataTable(strSql.ToString(), parameters);
                //StringBuilder text = new StringBuilder();
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    if (dt.Rows[i]["LogInfo"].ToString().Length > 30)
                //        text.Append(dt.Rows[i]["Id"].ToString() + " | " + dt.Rows[i]["LogInfo"].ToString().Substring(0,30) + "......\r\n");
                //    else
                //        text.Append(dt.Rows[i]["Id"].ToString() + " | " + dt.Rows[i]["LogInfo"].ToString() + "\r\n");
                //}
                //this.tb_logInfo.Text = text.ToString();
                P_ClientForm.Controls.Add(dgv_logInfo);
                dgv_logInfo.DataGridView.DataSource = dt;
                dgv_logInfo.DataGridView.CellClick += dgv_logInfo_CellClick;
            }
            catch (Exception ex)
            {
                this.Status.Text = ex.Message;
                return;
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            this.Status.Text = "";

            int id;

            if (int.TryParse(tb_id.Text, out id))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from Logs where");
                strSql.Append(" Id = @Id");
                SqlParameter[] parameters = {
			            new SqlParameter("@Id", SqlDbType.Int)
                };
                parameters[0].Value = id;

                try
                {
                    SqlHelper.Execute(strSql.ToString(), parameters);
                    this.Status.Text = "删除成功";
                }
                catch (Exception)
                {
                    this.Status.Text = "无此数据";
                    return;
                }
            }
            else
            {
                this.Status.Text = "输入正确编号";
                return;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p_menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        private void p_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y); // 设置移动后的位置
                Location = mouseSet;
            }
        }

        private void p_menu_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void InitialFindTime()
        {
            this.dtp_start_create.Value = DateTime.Now.AddMonths(-1);
            this.dtp_start_mod.Value = DateTime.Now.AddMonths(-1);
            this.dtp_end_create.Value = DateTime.Now.AddDays(1);
            this.dtp_end_mod.Value = DateTime.Now.AddDays(1);
        }

        private void dgv_logInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.tb_id.Text = this.dgv_logInfo.DataGridView.Rows[e.RowIndex].Cells["编号"].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void P_Calendar_MouseEnter(object sender, EventArgs e)
        {
            this.monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.monthCalendar1.Visible = false;

            this.P_ClientForm.Controls.Clear();
            LogDetails.DailyLogId = e.Start.ToString("yyyyMMdd");
            this.P_ClientForm.Controls.Add(LogDetails);
        }
    }
}
