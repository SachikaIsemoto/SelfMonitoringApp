using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;
using Csv;
using System.Text;
using System.Linq;

namespace SelfMonitoringGame
{
    public partial class MainForm : Form
    {
        /* 変数宣言 */
        private Chart dayChart;
        private Chart weekChart;
        private DateTime activityShowDate;


        public MainForm()
        {
            InitializeComponent();

            activityShowDate = DateTime.Now;



            /* ファイル置き場作成 */
            if (!Directory.Exists(FileName.activityDirName))
            {
                Directory.CreateDirectory(FileName.activityDirName);
            }
            if (!Directory.Exists(FileName.thoughtDirName))
            {
                Directory.CreateDirectory(FileName.thoughtDirName);
            }
            if (!Directory.Exists(FileName.categoryDirName))
            {
                Directory.CreateDirectory(FileName.categoryDirName);
            }

            /* 
             * ファイル読み込み 
             */
            /* 活動記録 */
            DataControl.SetActivityRecords();

            /* 思考記録 */
            DataControl.SetThoughtRecords();

            /* カテゴリデータ */
            DataControl.SetCategoryRecords();


            /* 
             * 統計データグラフ設定 
             */
            dayChart = new Chart()
            {
                Width = 730,
                Height = 300,
                Location = new Point(80, 45)
            };

            Statistics.Controls.Add(dayChart);

            weekChart = new Chart()
            {
                Width = 730,
                Height = 300,
                Location = new Point(80, 430)
            };

            Statistics.Controls.Add(weekChart);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            /* 活動記録表の設定 */
            activityDataGridView.RowCount = 24;

            for (int i = 0; i < activityDataGridView.Rows.Count; i++)
            {
                activityDataGridView.Rows[i].HeaderCell.Value = i + ":00";
            }

            ShowActivityRecords();


            /* 思考記録表の設定 */
            thoughtDataGridView.RowCount = FileName.thoughtDataCount;

            ShowThoughtRecords();

            /* 
             * 統計データの設定 
             */

            /* 一日グラフの設定 */
            SetDaychart(DateTime.Now);

            /* 週間グラフの設定 */
            SetWeekchart(DateTime.Now);


            /* カテゴリ設定表の設定 */
            categoryDataGridView.RowCount = FileName.categoryDataCount;

            ShowCategoryRecords();


        }

        private void SetDaychart(DateTime day)
        {
            dayChart.Series.Clear();
            dayChart.Titles.Clear();
            dayChart.Legends.Clear();
            dayChart.ChartAreas.Clear();

            Series daySeries = new Series();
            daySeries.ChartType = SeriesChartType.Line;
            daySeries.MarkerSize = 10;
            daySeries.MarkerColor = Color.Blue;
            daySeries.MarkerStyle = MarkerStyle.Circle;

            dayChart.Series.Add(daySeries);


            /* 軸の設定 */
            dayChart.ChartAreas.Add("");
            Axis dayAxisX = new Axis();
            dayAxisX.Title = "時間";
            dayAxisX.Minimum = 0;
            dayAxisX.Maximum = 24;
            dayAxisX.Interval = 1;
            dayChart.ChartAreas[0].AxisX = dayAxisX;

            Axis dayAxisY = new Axis();
            dayAxisY.Title = "気分";
            dayAxisY.Minimum = 0;
            dayAxisY.Maximum = 100;
            dayAxisY.Interval = 10;
            dayChart.ChartAreas[0].AxisY = dayAxisY;


            /* データ追加(仮) */
            List<Point> data = new List<Point>();
            List<ActivityRecord> records = DataControl.GetActivityRecords();

            foreach (ActivityRecord record in records)
            {
                if (record.Day.Day == DateTime.Today.Day)
                {
                    Point point = new Point(record.Time, int.Parse(record.Feeling ?? ""));
                    data.Add(point);
                }
            }

            var sortData = data.OrderBy(x => x.X);

            if (data.Count == 0)
            {
                daySeries.MarkerSize = 0;
                daySeries.Points.AddXY(0, 0);
            }

            foreach (var item in sortData)
            {
                daySeries.Points.AddXY(item.X, item.Y);
            }
        }

        private void SetWeekchart(DateTime lastday)
        {
            /* 初期化 */
            weekChart.Series.Clear();
            weekChart.Titles.Clear();
            weekChart.Legends.Clear();
            weekChart.ChartAreas.Clear();

            weekChart.ChartAreas.Add("");
            weekChart.Legends.Add("");

            /* 凡例の設定 */
            List<CategoryRecord> categories = DataControl.GetCategoryRecords();

            for (int i = 0; i < categories.Count; i++)
            {
                weekChart.Series.Add(categories[i].Name);
                weekChart.Series[categories[i].Name].ChartType = SeriesChartType.StackedColumn;
                weekChart.Series[categories[i].Name].LegendText = categories[i].Name;
                weekChart.Series[categories[i].Name].Color = Color.FromArgb(categories[i].Color_r, categories[i].Color_g, categories[i].Color_b);
            }

            /* データの設定 */

            DateTime[] xValue = new DateTime[]
            {
                lastday.AddDays(-6),
                lastday.AddDays(-5),
                lastday.AddDays(-4),
                lastday.AddDays(-3),
                lastday.AddDays(-2),
                lastday.AddDays(-1),
                lastday
            };


            int[,] yValue = new int[categories.Count, xValue.Length];

            List<ActivityRecord> activityRecords = DataControl.GetActivityRecords();
            foreach (ActivityRecord activityRecord in activityRecords)
            {
                for (int i = 0; i < xValue.Length; i++)
                {
                    if (activityRecord.Day.Day == lastday.AddDays(-6 + i).Day)
                    {
                        for (int j = 0; j < categories.Count; j++)
                        {
                            if (activityRecord.Category == categories[j].Name)
                            {
                                yValue[j, i]++;
                            }
                        }
                    }
                }

            }


            for (int i = 0; i < xValue.Length; i++)
            {
                for (int j = 0; j < yValue.GetLength(0); j++)
                {
                    DataPoint dataPoint = new DataPoint();

                    dataPoint.SetValueXY(xValue[i].ToString("yyyy/MM/dd"), yValue[j, i]);

                    dataPoint.IsValueShownAsLabel = false;
                    weekChart.Series[categories[j].Name].Points.Add(dataPoint);
                }
            }
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            /* 最大チェック */
            List<ThoughtRecord> thoughtRecords = DataControl.GetThoughtRecords();
            if (thoughtRecords.Count >= FileName.thoughtDataCount)
            {
                MessageBox.Show("データが最大件数に達しています。");
                return;
            }


            ThoughtInputForm thoughtInputForm = new ThoughtInputForm();
            thoughtInputForm.ShowDialog();
            thoughtInputForm.Dispose();
            ShowThoughtRecords();
        }

        private void ActivityDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            if (e.ColumnIndex == -1) { return; }

            /* 選択日時の設定 */
            DateTime time = activityShowDate.AddDays((7 - (int)activityShowDate.DayOfWeek) % 7 - 6);
            time = time.AddDays(e.ColumnIndex);
            time = time.AddHours(e.RowIndex - time.Hour);
            DataControl.activitySelectDate = time;

            ActivityInputForm activityInputForm = new ActivityInputForm();
            activityInputForm.ShowDialog();
            activityInputForm.Dispose();
            ShowActivityRecords();

        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            /* 最大チェック */
            List<CategoryRecord> categories = DataControl.GetCategoryRecords();
            if (categories.Count >= FileName.categoryDataCount)
            {
                MessageBox.Show("データが最大件数に達しています。");
                return;
            }


            CategorySetForm categorySetForm = new CategorySetForm();
            categorySetForm.ShowDialog();
            categorySetForm.Dispose();

            ShowCategoryRecords();
        }

        private void ShowActivityRecords()
        {
            List<ActivityRecord> activityRecords;

            /* 月曜日を取得 */
            DateTime lastMon = activityShowDate.AddDays((7 - (int)activityShowDate.DayOfWeek) % 7 - 6);

            /* ヘッダテキスト設定 */
            for (int i = 0; i < activityDataGridView.ColumnCount; i++)
            {
                activityDataGridView.Columns[i].HeaderText = lastMon.AddDays(i).ToString("MM/dd(ddd)");
            }

            /* いったんクリア */
            for (int i = 0; i < activityDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < activityDataGridView.RowCount; j++)
                {
                    activityDataGridView[i, j].Value = null;
                    activityDataGridView[i, j].Style.BackColor = activityDataGridView.DefaultCellStyle.BackColor;
                    activityDataGridView[i, j].Style.SelectionBackColor = activityDataGridView.DefaultCellStyle.SelectionBackColor;
                    activityDataGridView[i, j].ToolTipText = FileName.cellToolTip;
                }
            }

            activityRecords = DataControl.GetActivityRecords();

            /* 活動データ設定 */
            for (int i = 0; i < activityDataGridView.ColumnCount; i++)
            {
                foreach (var record in activityRecords)
                {
                    /* 日付確認 */
                    if (lastMon.AddDays(i).Date != record.Day.Date)
                    {
                        continue;
                    }

                    /* 表示設定 */
                    activityDataGridView[i, record.Time].Value = record.Content + "(" + record.Feeling + ")";
                    /* 背景色設定 */
                    List<CategoryRecord> categoryRecords = DataControl.GetCategoryRecords();
                    foreach (var categoryRecord in categoryRecords)
                    {
                        if (categoryRecord.Name == record.Category)
                        {
                            activityDataGridView[i, record.Time].Style.BackColor = Color.FromArgb(categoryRecord.Color_r, categoryRecord.Color_g, categoryRecord.Color_b);
                            activityDataGridView[i, record.Time].Style.SelectionBackColor = Color.FromArgb(categoryRecord.Color_r, categoryRecord.Color_g, categoryRecord.Color_b);

                        }
                    }
                    activityDataGridView[i, record.Time].ToolTipText = activityDataGridView[i, record.Time].Value.ToString() + Environment.NewLine + FileName.cellToolTip;

                }
            }

        }

        private void ShowThoughtRecords()
        {
            List<ThoughtRecord> thoughtRecords;

            thoughtRecords = DataControl.GetThoughtRecords();

            /* いったんクリア */
            for (int i = 0; i < FileName.thoughtDataCount; i++)
            {
                thoughtDataGridView[0, i].Value = null;
                thoughtDataGridView[1, i].Value = null;
                thoughtDataGridView[2, i].Value = null;

            }

            /* データ一覧設定 */
            for (int i = 0; i < thoughtRecords.Count; i++)
            {
                thoughtDataGridView[0, i].Value = i + 1;
                thoughtDataGridView[1, i].Value = thoughtRecords[i].title;
                thoughtDataGridView[2, i].Value = thoughtRecords[i].date.ToString("yyyy/MM/dd");
            }

        }

        private void ShowCategoryRecords()
        {
            List<CategoryRecord> categoryRecords;

            categoryRecords = DataControl.GetCategoryRecords();

            /* いったんクリア */
            for (int i = 0; i < FileName.categoryDataCount; i++)
            {
                categoryDataGridView[0, i].Value = null;
                categoryDataGridView[1, i].Style.BackColor = categoryDataGridView.DefaultCellStyle.BackColor;
                categoryDataGridView[1, i].Style.SelectionBackColor = categoryDataGridView.DefaultCellStyle.SelectionBackColor;
            }

            for (int i = 0; i < categoryRecords.Count; i++)
            {
                categoryDataGridView[0, i].Value = categoryRecords[i].Name;
                categoryDataGridView[1, i].Style.BackColor = Color.FromArgb(categoryRecords[i].Color_r, categoryRecords[i].Color_g, categoryRecords[i].Color_b);
                categoryDataGridView[1, i].Style.SelectionBackColor = Color.FromArgb(categoryRecords[i].Color_r, categoryRecords[i].Color_g, categoryRecords[i].Color_b);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* データのファイルへの出力 */
            DataControl.OutputActivityRecords();
            DataControl.OutputThoughtRecoeds();
            DataControl.OutputCategoryRecords();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            List<ThoughtRecord> thoughtRecords;
            thoughtRecords = DataControl.GetThoughtRecords();

            /* 選択行の設定 */
            if ((thoughtDataGridView.SelectedCells[0].RowIndex < 0) || (thoughtRecords.Count <= thoughtDataGridView.SelectedCells[0].RowIndex))
            {
                MessageBox.Show("データを選択してください。");
                return;
            }
            DataControl.thoughtSelectNo = thoughtDataGridView.SelectedCells[0].RowIndex;

            ThoughtDisplayForm thoughtDisplayForm = new ThoughtDisplayForm();
            thoughtDisplayForm.ShowDialog();
            thoughtDisplayForm.Dispose();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<ThoughtRecord> thoughtRecords;
            thoughtRecords = DataControl.GetThoughtRecords();


            /* 選択行の設定 */
            if ((thoughtDataGridView.SelectedCells[0].RowIndex < 0) || (thoughtRecords.Count <= thoughtDataGridView.SelectedCells[0].RowIndex))
            {
                MessageBox.Show("データを選択してください。");
                return;
            }

            ThoughtRecord record = thoughtRecords[thoughtDataGridView.SelectedCells[0].RowIndex];

            DataControl.RemoveThoughtRecord(record);

            ShowThoughtRecords();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            List<ThoughtRecord> thoughtRecords;
            thoughtRecords = DataControl.GetThoughtRecords();

            /* 選択行の設定 */
            if ((thoughtDataGridView.SelectedCells[0].RowIndex < 0) || (thoughtRecords.Count <= thoughtDataGridView.SelectedCells[0].RowIndex))
            {
                MessageBox.Show("データを選択してください。");
                return;
            }
            DataControl.thoughtSelectNo = thoughtDataGridView.SelectedCells[0].RowIndex;

            ThoughtEditForm thoughtEditForm = new ThoughtEditForm();
            thoughtEditForm.ShowDialog();
            thoughtEditForm.Dispose();

            ShowThoughtRecords();
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            List<CategoryRecord> categoryRecords = DataControl.GetCategoryRecords();
            if ((categoryDataGridView.SelectedCells[0].RowIndex < 0) || (categoryRecords.Count <= categoryDataGridView.SelectedCells[0].RowIndex))
            {
                MessageBox.Show("データを選択してください。");
                return;
            }

            DialogResult result = MessageBox.Show("選択したカテゴリ(" + categoryRecords[categoryDataGridView.SelectedCells[0].RowIndex].Name + ")を削除しますか？", "カテゴリ削除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CategoryRecord categoryRecord = categoryRecords[categoryDataGridView.SelectedCells[0].RowIndex];
                DataControl.RemoveCategoryRecord(categoryRecord);
            }

            ShowCategoryRecords();

        }

        private void activityDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* 右クリック？ */
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            if (e.RowIndex == -1) { return; }
            if (e.ColumnIndex == -1) { return; }


            /* 選択日時の設定 */
            DateTime time = activityShowDate.AddDays((7 - (int)activityShowDate.DayOfWeek) % 7 - 6);
            time = time.AddDays(e.ColumnIndex);
            time = time.AddHours(e.RowIndex - time.Hour);
            DataControl.activitySelectDate = time;

            ActivityDeleteForm activityDeleteForm = new ActivityDeleteForm();
            activityDeleteForm.ShowDialog();
            activityDeleteForm.Dispose();

            ShowActivityRecords();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            activityShowDate = activityShowDate.AddDays(-7);

            ShowActivityRecords();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            activityShowDate = activityShowDate.AddDays(7);

            ShowActivityRecords();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == this.ActivityRecord.TabIndex)
            {
                activityShowDate = DateTime.Today;
                ShowActivityRecords();
            }

            if (tabControl1.SelectedIndex == this.ThoughtRecord.TabIndex)
            {
                ShowThoughtRecords();
            }

            if (tabControl1.SelectedIndex == this.Statistics.TabIndex)
            {
                SetDaychart(DateTime.Now);

                SetWeekchart(DateTime.Now);
            }
        }
    }
}