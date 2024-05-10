namespace SelfMonitoringGame
{
    partial class ThoughtDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            text = new DataGridViewTextBoxColumn();
            recordButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item, text });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(52, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(771, 378);
            dataGridView1.TabIndex = 0;
            // 
            // item
            // 
            item.HeaderText = "項目";
            item.MinimumWidth = 6;
            item.Name = "item";
            item.ReadOnly = true;
            item.Width = 300;
            // 
            // text
            // 
            text.HeaderText = "内容";
            text.MinimumWidth = 6;
            text.Name = "text";
            text.Width = 445;
            // 
            // recordButton
            // 
            recordButton.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            recordButton.Location = new Point(391, 496);
            recordButton.Name = "recordButton";
            recordButton.Size = new Size(94, 44);
            recordButton.TabIndex = 1;
            recordButton.Text = "記録";
            recordButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 19);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "タイトル";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(540, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 19);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "日付";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(634, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // ThoughtDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 552);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(recordButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ThoughtDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "思考記録入力";
            Load += ThoughtDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn text;
        private Label label1;
        private Label label2;
        protected Button recordButton;
        protected TextBox textBox1;
        protected DateTimePicker dateTimePicker1;
        protected DataGridView dataGridView1;
    }
}