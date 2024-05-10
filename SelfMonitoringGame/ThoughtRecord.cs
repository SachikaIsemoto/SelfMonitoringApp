using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMonitoringGame
{
    public class ThoughtRecord
    {
        public string? title {  get; set; }
        public DateTime date { get; set; }
        public string? situation {  get; set; }
        public string? atThatTimeFeeling { get; set; }
        public string? autoThought {  get; set; }
        public string? basis {  get; set; }
        public string? disproof { get; set; }
        public string? adaptThought { get; set; }
        public string? nowFeeling { get; set; }

        public ThoughtRecord EasyClone()
        {
            return (ThoughtRecord)MemberwiseClone();
        }

    }
}
