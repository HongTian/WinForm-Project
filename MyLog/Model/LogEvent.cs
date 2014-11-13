using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.Model
{
    public class LogEvent
    {
        /// <summary>
        /// 12位
        /// </summary>
        public string Id { get; set; }
        public string DailyLogId { get; set; }
        public string Text { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
