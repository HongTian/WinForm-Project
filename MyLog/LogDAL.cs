using Microsoft.Practices.EnterpriseLibrary.Data;
using MyLog.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog
{
    public class LogDAL
    {
        public int AddDailyLog(DailyLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DailyLog(");
            strSql.Append("Id,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@Id,@CreateTime)");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Id", DbType.String, model.Id);
            db.AddInParameter(dbCommand, "CreateTime", DbType.DateTime, model.CreateTime);

            return db.ExecuteNonQuery(dbCommand);
        }

        public DailyLog GetDailyLog(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id, CreateTime from DailyLog");
            strSql.Append(" where Id = @Id");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Id", DbType.String, id);

            DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];

            if (dt.Rows.Count > 0)
            {
                DailyLog log = new DailyLog();
                log.Id = dt.Rows[0]["Id"].ToString();
                DateTime CreateTime;
                if (DateTime.TryParse(dt.Rows[0]["CreateTime"].ToString(), out CreateTime))
                {
                    log.CreateTime = CreateTime;
                }
                return log;
            }
            else
            {
                return null;
            }

        }

        public List<TagEvent> GetTagEvents(string dailyLogId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id, DailyLogId, Text, Tag, CreateTime from Event");
            strSql.Append(" where DailyLogId = @DailyLogId");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "DailyLogId", DbType.String, dailyLogId);

            DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Event(");
            strSql.Append("Id, DailyLogId, Text, Tag, CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@Id, @DailyLogId, @Text, @Tag, @CreateTime)");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Id", DbType.String, model.Id);
            db.AddInParameter(dbCommand, "DailyLogId", DbType.String, model.DailyLogId);
            db.AddInParameter(dbCommand, "Text", DbType.String, model.EventText);
            db.AddInParameter(dbCommand, "Tag", DbType.String, model.TagText);
            db.AddInParameter(dbCommand, "CreateTime", DbType.DateTime, model.CreateTime);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int GetEventCount(string dailyLogId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Event");
            strSql.Append(" where DailyLogId = @DailyLogId");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "DailyLogId", DbType.String, dailyLogId);

            return int.Parse(db.ExecuteDataSet(dbCommand).Tables[0].Rows[0][0].ToString());
        }

        public int AddEvent(LogEvent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Event(");
            strSql.Append("Id, DailyLogId, Text, CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@Id, @DailyLogId, @Text, @CreateTime)");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Id", DbType.String, model.Id);
            db.AddInParameter(dbCommand, "DailyLogId", DbType.String, model.DailyLogId);
            db.AddInParameter(dbCommand, "Text", DbType.String, model.Text);
            db.AddInParameter(dbCommand, "CreateTime", DbType.DateTime, model.CreateTime);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int DeleteEvent(string eventId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Event");
            strSql.Append(" where Id = @Id");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Id", DbType.String, eventId);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int AddTag(LogTag model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Tag(");
            strSql.Append("DailyLogId, Text)");
            strSql.Append(" values (");
            strSql.Append("@DailyLogId, @Text)");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "DailyLogId", DbType.String, model.DailyLogId);
            db.AddInParameter(dbCommand, "Text", DbType.String, model.Text);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int DeleteTag(string tagText)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Tag");
            strSql.Append(" where Text = @Text");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Text", DbType.String, tagText);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int AddLog(Model.LogInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Logs(");
            strSql.Append("LogInfo,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@LogInfo,@CreateTime)");

            // Database, DatabaseFactory 需要 Microsoft.Practices.EnterpriseLibrary.Data，用NuGet安装即可。
            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "LogInfo", DbType.String, model.Text);
            db.AddInParameter(dbCommand, "CreateTime", DbType.DateTime, model.CreateTime);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int UpdateLog(Model.LogInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Logs set");
            strSql.Append(" LogInfo = @LogInfo");
            strSql.Append(", ModificationTime = @ModificationTime");
            strSql.Append(" where Id = @Id");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "LogInfo", DbType.String, model.Text);
            db.AddInParameter(dbCommand, "ModificationTime", DbType.DateTime, model.ModificationTime);
            db.AddInParameter(dbCommand, "Id", DbType.Int32, model.Id);

            return db.ExecuteNonQuery(dbCommand);
        }

        public List<Model.LogInfo> GetAllLogs()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id, LogInfo, CreateTime, ModificationTime from Logs");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
            
            DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];
            
            if (dt.Rows.Count > 0)
            {
                List<Model.LogInfo> logs = new List<Model.LogInfo>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Model.LogInfo log = new Model.LogInfo();
                    log.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                    log.Text = dt.Rows[i]["LogInfo"].ToString();
                    DateTime CreateTime;
                    if (DateTime.TryParse(dt.Rows[i]["CreateTime"].ToString(), out CreateTime))
                    {
                        log.CreateTime = CreateTime;
                    }
                    DateTime ModificationTime;
                    if (DateTime.TryParse(dt.Rows[i]["ModificationTime"].ToString(), out ModificationTime))
                    {
                        log.ModificationTime = ModificationTime;
                    }

                    logs.Add(log);
                }
                return logs;
            }
            else
            {
                return null;
            }
        }

        public Model.LogInfo GetLog(int Id)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select Id, LogInfo, CreateTime, ModificationTime from Logs");
                strSql.Append(" where Id = @Id");

                Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
                DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());
                db.AddInParameter(dbCommand, "Id", DbType.Int32, Id);

                DataTable dt = db.ExecuteDataSet(dbCommand).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    Model.LogInfo log = new Model.LogInfo();
                    log.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                    log.Text = dt.Rows[0]["LogInfo"].ToString();
                    DateTime CreateTime;
                    if (DateTime.TryParse(dt.Rows[0]["CreateTime"].ToString(), out CreateTime))
                    {
                        log.CreateTime = CreateTime;
                    }
                    DateTime ModificationTime;
                    if (DateTime.TryParse(dt.Rows[0]["ModificationTime"].ToString(), out ModificationTime))
                    {
                        log.ModificationTime = ModificationTime;
                    }
                    return log;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                
                return null;
            }
        }

        public int UpdateTagEvent(TagEvent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Event set");
            strSql.Append(" Text = @Text");
            strSql.Append(",Tag = @Tag");
            strSql.Append(" where Id = @Id");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Text", DbType.String, model.EventText);
            db.AddInParameter(dbCommand, "Tag", DbType.String, model.TagText);
            db.AddInParameter(dbCommand, "Id", DbType.String, model.Id);

            return db.ExecuteNonQuery(dbCommand);
        }

        public int DeleteTagEvent(TagEvent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Event");
            strSql.Append(" where Id = @Id");

            Database db = DatabaseFactory.CreateDatabase("MYLOGConn");
            DbCommand dbCommand = db.GetSqlStringCommand(strSql.ToString());

            db.AddInParameter(dbCommand, "Id", DbType.String, model.Id);

            return db.ExecuteNonQuery(dbCommand);
        }
    }
}
