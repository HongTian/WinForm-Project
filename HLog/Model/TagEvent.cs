using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLog.Model
{
    public class TagEvent
    {
        /// <summary>
        /// 12位
        /// </summary>
        public string Id { get; set; }
        public string DailyLogId { get; set; }
        public string TagText { get; set; }
        public string EventText { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
