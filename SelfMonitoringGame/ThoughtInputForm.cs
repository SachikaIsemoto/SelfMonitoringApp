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
    public partial class ThoughtInputForm : ThoughtDetailForm
    {
        public ThoughtInputForm()
        {
            InitializeComponent();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("タイトルを入力してください。");
                return;
            }

            ThoughtRecord record = new ThoughtRecord();

            record.title = textBox1.Text;
            record.date = dateTimePicker1.Value;

            record.situation = dataGridView1[1, 0].Value?.ToString();
            record.atThatTimeFeeling = dataGridView1[1, 1].Value?.ToString();
            record.autoThought = dataGridView1[1, 2].Value?.ToString();
            record.basis = dataGridView1[1, 3].Value?.ToString();
            record.disproof = dataGridView1[1, 4].Value?.ToString();
            record.adaptThought = dataGridView1[1, 5].Value?.ToString();
            record.nowFeeling = dataGridView1[1, 6].Value?.ToString();

            DataControl.AddThoughtRecord(record);

            Close();
        }
    }
}
