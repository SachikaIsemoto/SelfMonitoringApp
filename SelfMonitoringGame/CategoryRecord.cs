using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfMonitoringGame
{
    public class CategoryRecord
    {
        public string? Name {  get; set; }
        public int Color_r { get; set; }
        public int Color_g { get; set; }
        public int Color_b { get; set; }

        public CategoryRecord EasyClone()
        {
            return (CategoryRecord)MemberwiseClone();
        }

    }


}
