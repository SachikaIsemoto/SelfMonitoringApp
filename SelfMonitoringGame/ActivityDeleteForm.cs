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
    public partial class ActivityDeleteForm : Form
    {
        public ActivityDeleteForm()
        {
            InitializeComponent();
        }

        private void ActivityDeleteForm_Load(object sender, EventArgs e)
        {
            /* 日時の設定 */
            dateLabel.Text = DataControl.activitySelectDate.ToString("MM月dd日");
            startComboBox.SelectedIndex = DataControl.activitySelectDate.Hour;
            endComboBox.SelectedIndex = DataControl.activitySelectDate.Hour;

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            /* データの確認 */
            int start = startComboBox.SelectedIndex;
            int end = endComboBox.SelectedIndex;
            if ((start == -1) || (end == -1))
            {
                MessageBox.Show("時間が未設定です。");
                return;
            }
            end++;
            if (start >= end)
            {
                MessageBox.Show("時間が不正です。");
                return;
            }

            List<ActivityRecord> records = new List<ActivityRecord>(DataControl.GetActivityRecords());

            foreach (ActivityRecord record in records)
            {
                for (int i = start; i < end; i++)
                {
                    if ((record.Day.Day == DataControl.activitySelectDate.Day) && (record.Time == i))
                    {
                        DataControl.RemoveActivityRecord(record);
                    }
                }
            }

            Close();
        }
    }
}
