using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMonitoringGame
{
    public class ActivityRecord
    {
        public DateTime Day {  get; set; }
        public int Time { get; set; }
        public string? Category { get; set; }
        public string? Content { get; set; }
        public string? Feeling {  get; set; }

        public ActivityRecord EasyClone()
        {
            return (ActivityRecord)MemberwiseClone();
        }
    }
}
