using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SelfMonitoringGame
{
    public partial class ThoughtDetailForm : Form
    {
        public ThoughtDetailForm()
        {
            InitializeComponent();
        }

        private void ThoughtDetailForm_Load(object sender, EventArgs e)
        {
            /* 項目の設定 */
            dataGridView1.RowCount = 7;

            dataGridView1[0, 0].Value = FileName.situationHeader + Environment.NewLine +
                                        "　いつ？" + Environment.NewLine +
                                        "　どこで？" + Environment.NewLine +
                                        "　誰と？" + Environment.NewLine +
                                        "　何をしていた？";
            dataGridView1[0, 1].Value = FileName.atThatTimeFeelingHeader;
            dataGridView1[0, 2].Value = FileName.autoThoughtHeader + Environment.NewLine +
                                        "　その時に頭に浮かんでいたことは？";
            dataGridView1[0, 3].Value = FileName.basisHeader + Environment.NewLine +
                                        "　事実を確かめて客観的にそう考える理由は？" + Environment.NewLine +
                                        "　自動思考を裏付ける根拠は？";
            dataGridView1[0, 4].Value = FileName.disproofHeader + Environment.NewLine +
                                        "　自動思考とは矛盾する事実はあるか？";
            dataGridView1[0, 5].Value = FileName.adaptThoughtHeader + Environment.NewLine +
                                        "　根拠と反証から考えられることは？" + Environment.NewLine +
                                        "　最善・最悪のシナリオ、現実的なシナリオは？";
            dataGridView1[0, 6].Value = FileName.nowFeelingHeader;
        }

        public void ReadonlyThoughtData()
        {
            dataGridView1.ReadOnly = true;
        }

        public void SetThoughtDetailData(ThoughtRecord thoughtRecord)
        {
            textBox1.Text = thoughtRecord.title;
            dateTimePicker1.Value = thoughtRecord.date;

            dataGridView1[1, 0].Value = thoughtRecord.situation;
            dataGridView1[1, 1].Value = thoughtRecord.atThatTimeFeeling;
            dataGridView1[1, 2].Value = thoughtRecord.autoThought;
            dataGridView1[1, 3].Value = thoughtRecord.basis;
            dataGridView1[1, 4].Value = thoughtRecord.disproof;
            dataGridView1[1, 5].Value = thoughtRecord.adaptThought;
            dataGridView1[1, 6].Value = thoughtRecord.nowFeeling;

        }

    }
}
