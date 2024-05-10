using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMonitoringGame
{
    public partial class ActivityInputForm : Form
    {

        public ActivityInputForm()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            ActivityRecord record = new ActivityRecord();

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
            if (categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("カテゴリが未設定です。");
                return;
            }
            if (contentTextBox.Text.Length == 0)
            {
                MessageBox.Show("活動内容が未設定です。");
                return;
            }
            if (feelingComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("気分が未設定です。");
                return;
            }

            for (int i = start; i < end; i++)
            {
                record.Day = DataControl.activitySelectDate;
                record.Time = i;
                record.Category = categoryComboBox.Text;
                record.Content = contentTextBox.Text;
                record.Feeling = feelingComboBox.Text;

                DataControl.AddActivityRecord(record);
            }

            Close();
        }

        private void ActivityInputForm_Load(object sender, EventArgs e)
        {
            /* 日時の設定 */
            dateLabel.Text = DataControl.activitySelectDate.ToString("MM月dd日");
            startComboBox.SelectedIndex = DataControl.activitySelectDate.Hour;
            endComboBox.SelectedIndex = DataControl.activitySelectDate.Hour;

            /* カテゴリの設定 */
            categoryComboBox.Items.Clear();

            List<CategoryRecord> categoryData = DataControl.GetCategoryRecords();
            foreach (CategoryRecord record in categoryData)
            {
                categoryComboBox.Items.Add(record.Name);
            }

        }
    }
}
