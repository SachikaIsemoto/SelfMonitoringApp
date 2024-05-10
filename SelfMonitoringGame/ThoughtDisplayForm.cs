using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMonitoringGame
{
    public partial class ThoughtDisplayForm : ThoughtDetailForm
    {
        public ThoughtDisplayForm()
        {
            InitializeComponent();
        }

        private void ThoughtDisplayForm_Load(object sender, EventArgs e)
        {
            ReadonlyThoughtData();

            /* データ設定 */
            List<ThoughtRecord> thoughtRecords = new List<ThoughtRecord>();
            thoughtRecords = DataControl.GetThoughtRecords();

            SetThoughtDetailData(thoughtRecords[DataControl.thoughtSelectNo]);
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
