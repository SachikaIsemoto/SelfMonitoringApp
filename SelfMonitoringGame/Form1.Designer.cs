namespace SelfMonitoringGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param categoryNameHeader="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Setting = new TabPage();
            deleteCategoryButton = new Button();
            addCategoryButton = new Button();
            categoryDataGridView = new DataGridView();
            category = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            label3 = new Label();
            Statistics = new TabPage();
            label2 = new Label();
            label1 = new Label();
            ThoughtRecord = new TabPage();
            editButton = new Button();
            DeleteButton = new Button();
            thoughtDataGridView = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            displayButton = new Button();
            inputButton = new Button();
            ActivityRecord = new TabPage();
            nextButton = new Button();
            prevButton = new Button();
            activityDataGridView = new DataGridView();
            Monday = new DataGridViewTextBoxColumn();
            Tuesday = new DataGridViewTextBoxColumn();
            Wednesday = new DataGridViewTextBoxColumn();
            Thursday = new DataGridViewTextBoxColumn();
            Friday = new DataGridViewTextBoxColumn();
            Saturday = new DataGridViewTextBoxColumn();
            Sunday = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            Statistics.SuspendLayout();
            ThoughtRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thoughtDataGridView).BeginInit();
            ActivityRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activityDataGridView).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Setting
            // 
            Setting.Controls.Add(deleteCategoryButton);
            Setting.Controls.Add(addCategoryButton);
            Setting.Controls.Add(categoryDataGridView);
            Setting.Controls.Add(label3);
            Setting.Location = new Point(4, 29);
            Setting.Name = "Setting";
            Setting.Padding = new Padding(3);
            Setting.Size = new Size(906, 468);
            Setting.TabIndex = 3;
            Setting.Text = "設定";
            Setting.UseVisualStyleBackColor = true;
            // 
            // deleteCategoryButton
            // 
            deleteCategoryButton.Location = new Point(538, 136);
            deleteCategoryButton.Name = "deleteCategoryButton";
            deleteCategoryButton.Size = new Size(94, 29);
            deleteCategoryButton.TabIndex = 3;
            deleteCategoryButton.Text = "削除";
            deleteCategoryButton.UseVisualStyleBackColor = true;
            deleteCategoryButton.Click += deleteCategoryButton_Click;
            // 
            // addCategoryButton
            // 
            addCategoryButton.Location = new Point(538, 72);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(94, 29);
            addCategoryButton.TabIndex = 2;
            addCategoryButton.Text = "追加";
            addCategoryButton.UseVisualStyleBackColor = true;
            addCategoryButton.Click += addCategoryButton_Click;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.AllowUserToAddRows = false;
            categoryDataGridView.AllowUserToDeleteRows = false;
            categoryDataGridView.AllowUserToResizeColumns = false;
            categoryDataGridView.AllowUserToResizeRows = false;
            categoryDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { category, color });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            categoryDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            categoryDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            categoryDataGridView.Location = new Point(187, 28);
            categoryDataGridView.MultiSelect = false;
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.ReadOnly = true;
            categoryDataGridView.RowHeadersVisible = false;
            categoryDataGridView.RowHeadersWidth = 51;
            categoryDataGridView.RowTemplate.Height = 29;
            categoryDataGridView.ScrollBars = ScrollBars.Vertical;
            categoryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoryDataGridView.Size = new Size(275, 175);
            categoryDataGridView.TabIndex = 1;
            // 
            // category
            // 
            category.HeaderText = "カテゴリ名";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 200;
            // 
            // color
            // 
            color.HeaderText = "色";
            color.MinimumWidth = 6;
            color.Name = "color";
            color.ReadOnly = true;
            color.Width = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 17);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 0;
            label3.Text = "カテゴリ設定";
            // 
            // Statistics
            // 
            Statistics.AutoScroll = true;
            Statistics.AutoScrollMargin = new Size(0, 30);
            Statistics.Controls.Add(label2);
            Statistics.Controls.Add(label1);
            Statistics.Location = new Point(4, 29);
            Statistics.Name = "Statistics";
            Statistics.Padding = new Padding(3);
            Statistics.Size = new Size(906, 468);
            Statistics.TabIndex = 2;
            Statistics.Text = "統計データ";
            Statistics.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 392);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "今週の活動記録";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "今日の気分の動き";
            // 
            // ThoughtRecord
            // 
            ThoughtRecord.Controls.Add(editButton);
            ThoughtRecord.Controls.Add(DeleteButton);
            ThoughtRecord.Controls.Add(thoughtDataGridView);
            ThoughtRecord.Controls.Add(displayButton);
            ThoughtRecord.Controls.Add(inputButton);
            ThoughtRecord.Location = new Point(4, 29);
            ThoughtRecord.Name = "ThoughtRecord";
            ThoughtRecord.Padding = new Padding(3);
            ThoughtRecord.Size = new Size(906, 468);
            ThoughtRecord.TabIndex = 1;
            ThoughtRecord.Text = "思考記録表";
            ThoughtRecord.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(39, 214);
            editButton.Name = "editButton";
            editButton.Size = new Size(94, 29);
            editButton.TabIndex = 4;
            editButton.Text = "編集";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(39, 287);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "削除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // thoughtDataGridView
            // 
            thoughtDataGridView.AllowUserToAddRows = false;
            thoughtDataGridView.AllowUserToDeleteRows = false;
            thoughtDataGridView.AllowUserToResizeColumns = false;
            thoughtDataGridView.AllowUserToResizeRows = false;
            thoughtDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            thoughtDataGridView.Columns.AddRange(new DataGridViewColumn[] { No, Title, date });
            thoughtDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            thoughtDataGridView.Location = new Point(175, 43);
            thoughtDataGridView.MultiSelect = false;
            thoughtDataGridView.Name = "thoughtDataGridView";
            thoughtDataGridView.ReadOnly = true;
            thoughtDataGridView.RowHeadersVisible = false;
            thoughtDataGridView.RowHeadersWidth = 51;
            thoughtDataGridView.RowTemplate.Height = 29;
            thoughtDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            thoughtDataGridView.Size = new Size(656, 379);
            thoughtDataGridView.TabIndex = 2;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 50;
            // 
            // Title
            // 
            Title.HeaderText = "タイトル";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 457;
            // 
            // date
            // 
            date.HeaderText = "日付";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 125;
            // 
            // displayButton
            // 
            displayButton.Location = new Point(39, 139);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(94, 29);
            displayButton.TabIndex = 1;
            displayButton.Text = "表示";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // inputButton
            // 
            inputButton.Location = new Point(39, 66);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(94, 29);
            inputButton.TabIndex = 0;
            inputButton.Text = "入力";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // ActivityRecord
            // 
            ActivityRecord.Controls.Add(nextButton);
            ActivityRecord.Controls.Add(prevButton);
            ActivityRecord.Controls.Add(activityDataGridView);
            ActivityRecord.Location = new Point(4, 29);
            ActivityRecord.Name = "ActivityRecord";
            ActivityRecord.Padding = new Padding(3);
            ActivityRecord.Size = new Size(906, 468);
            ActivityRecord.TabIndex = 0;
            ActivityRecord.Text = "活動記録表";
            ActivityRecord.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(625, 424);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 2;
            nextButton.Text = "次週";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(185, 424);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(94, 29);
            prevButton.TabIndex = 1;
            prevButton.Text = "前週";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // activityDataGridView
            // 
            activityDataGridView.AllowUserToAddRows = false;
            activityDataGridView.AllowUserToDeleteRows = false;
            activityDataGridView.AllowUserToResizeColumns = false;
            activityDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            activityDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            activityDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            activityDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activityDataGridView.Columns.AddRange(new DataGridViewColumn[] { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            activityDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            activityDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            activityDataGridView.Location = new Point(80, 29);
            activityDataGridView.MultiSelect = false;
            activityDataGridView.Name = "activityDataGridView";
            activityDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            activityDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            activityDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            activityDataGridView.RowTemplate.Height = 29;
            activityDataGridView.ScrollBars = ScrollBars.Vertical;
            activityDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            activityDataGridView.Size = new Size(748, 378);
            activityDataGridView.TabIndex = 0;
            activityDataGridView.CellClick += ActivityDataGridView_CellClick;
            activityDataGridView.CellMouseClick += activityDataGridView_CellMouseClick;
            // 
            // Monday
            // 
            Monday.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Monday.HeaderText = "XX/XX(月)";
            Monday.MinimumWidth = 6;
            Monday.Name = "Monday";
            Monday.ReadOnly = true;
            Monday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Monday.Width = 90;
            // 
            // Tuesday
            // 
            Tuesday.HeaderText = "XX/XX(火)";
            Tuesday.MinimumWidth = 6;
            Tuesday.Name = "Tuesday";
            Tuesday.ReadOnly = true;
            Tuesday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Tuesday.Width = 90;
            // 
            // Wednesday
            // 
            Wednesday.HeaderText = "XX/XX(水)";
            Wednesday.MinimumWidth = 6;
            Wednesday.Name = "Wednesday";
            Wednesday.ReadOnly = true;
            Wednesday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Wednesday.Width = 90;
            // 
            // Thursday
            // 
            Thursday.HeaderText = "XX/XX(木)";
            Thursday.MinimumWidth = 6;
            Thursday.Name = "Thursday";
            Thursday.ReadOnly = true;
            Thursday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Thursday.Width = 90;
            // 
            // Friday
            // 
            Friday.HeaderText = "XX/XX(金)";
            Friday.MinimumWidth = 6;
            Friday.Name = "Friday";
            Friday.ReadOnly = true;
            Friday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Friday.Width = 90;
            // 
            // Saturday
            // 
            Saturday.HeaderText = "XX/XX(土)";
            Saturday.MinimumWidth = 6;
            Saturday.Name = "Saturday";
            Saturday.ReadOnly = true;
            Saturday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Saturday.Width = 90;
            // 
            // Sunday
            // 
            Sunday.HeaderText = "XX/XX(日)";
            Sunday.MinimumWidth = 6;
            Sunday.Name = "Sunday";
            Sunday.ReadOnly = true;
            Sunday.SortMode = DataGridViewColumnSortMode.NotSortable;
            Sunday.Width = 90;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ActivityRecord);
            tabControl1.Controls.Add(ThoughtRecord);
            tabControl1.Controls.Add(Statistics);
            tabControl1.Controls.Add(Setting);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 501);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 525);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "セルフモニタリングゲーム";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Setting.ResumeLayout(false);
            Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            Statistics.ResumeLayout(false);
            Statistics.PerformLayout();
            ThoughtRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)thoughtDataGridView).EndInit();
            ActivityRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)activityDataGridView).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Setting;
        private TabPage Statistics;
        private TabPage ThoughtRecord;
        private TabPage ActivityRecord;
        private DataGridView activityDataGridView;
        private TabControl tabControl1;
        private DataGridView thoughtDataGridView;
        private Button displayButton;
        private Button inputButton;
        private Button prevButton;
        private Button nextButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView categoryDataGridView;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn color;
        private Button deleteCategoryButton;
        private Button addCategoryButton;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn date;
        private Button DeleteButton;
        private Button editButton;
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn Tuesday;
        private DataGridViewTextBoxColumn Wednesday;
        private DataGridViewTextBoxColumn Thursday;
        private DataGridViewTextBoxColumn Friday;
        private DataGridViewTextBoxColumn Saturday;
        private DataGridViewTextBoxColumn Sunday;
    }
}