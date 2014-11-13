using HLog.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLog
{
    public class LogDAL
    {
        public LogDAL()
        {
            if (!System.IO.File.Exists(Environment.CurrentDirectory + "\\Sqlite.db"))
            {
                SqliteHelper db = SqliteHelper.CreateDB(Environment.CurrentDirectory + "\\Sqlite.db");
                string sql = "create table Event(Id nvarchar(12) primary key, DailyLogId nvarchar(8), Text nvarchar(100), Tag nvarchar(10), CreateTime datetime)";
                db.ExecuteNonQuery(sql, null);
            }
        }

        public List<TagEvent> GetTagEvents(string dailyLogId)
        {
            SqliteHelper db = SqliteHelper.CreateDB(Environment.CurrentDirectory + "\\Sqlite.db");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id, DailyLogId, Text, Tag, CreateTime from Event");
            strSql.Append(" where DailyLogId = @DailyLogId");

            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@DailyLogId", dailyLogId)
            };

            db.ExecuteDataTable(strSql.ToString(), parameters);

            DataTable dt = db.ExecuteDataTable(strSql.ToString(), parameters);
            if (dt.Rows.Count > 0)
            {
                List<TagEvent> models = new List<TagEvent>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TagEvent model = new TagEvent();
                    model.Id = dt.Rows[i]["Id"].ToString();
                    model.DailyLogId = dt.Rows[i]["DailyLogId"].ToString();
                    model.EventText = dt.Rows[i]["Text"].ToString();
                    model.TagText = dt.Rows[i]["Tag"].ToString();
                    DateTime CreateTime;
                    if (DateTime.TryParse(dt.Rows[i]["CreateTime"].ToString(), out CreateTime))
                    {
                        model.CreateTime = CreateTime;
                    }
                    models.Add(model);
                }
                return models;
            }
            else
            {
                return null;
            }

        }

        public int AddTagEvent(TagEvent model)
        {
            SqliteHelper db = SqliteHelper.CreateDB(Environment.CurrentDirectory + "\\Sqlite.db");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Event(");
            strSql.Append("Id, DailyLogId, Text, Tag, CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@Id, @DailyLogId, @Text, @Tag, @CreateTime)");

            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@Id", model.Id),
                new SQLiteParameter("@DailyLogId", model.DailyLogId),
                new SQLiteParameter("@Text", model.EventText),
                new SQLiteParameter("@Tag", model.TagText),
                new SQLiteParameter("@CreateTime", model.CreateTime),
            };

            return db.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        public int GetEventCount(string dailyLogId)
        {
            SqliteHelper db = SqliteHelper.CreateDB(Environment.CurrentDirectory + "\\Sqlite.db");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Event");
            strSql.Append(" where DailyLogId = @DailyLogId");

            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@DailyLogId", dailyLogId)
            };

            return int.Parse(db.ExecuteDataTable(strSql.ToString(), parameters).Rows[0][0].ToString());
        }

        public int UpdateTagEvent(TagEvent model)
        {
            SqliteHelper db = SqliteHelper.CreateDB(Environment.CurrentDirectory + "\\Sqlite.db");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Event set");
            strSql.Append(" Text = @Text");
            strSql.Append(",Tag = @Tag");
            strSql.Append(" where Id = @Id");

            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@Text", model.EventText),
                new SQLiteParameter("@Tag", model.TagText),
                new SQLiteParameter("@Id", model.Id)
            };

            return db.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        public int DeleteTagEvent(TagEvent model)
        {
            SqliteHelper db = SqliteHelper.CreateDB(Environment.CurrentDirectory + "\\Sqlite.db");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Event");
            strSql.Append(" where Id = @Id");

            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("@Id", model.Id)
            };

            return db.ExecuteNonQuery(strSql.ToString(), parameters);
        }
    }
}
