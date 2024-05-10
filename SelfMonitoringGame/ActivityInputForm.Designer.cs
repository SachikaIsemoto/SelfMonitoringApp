namespace SelfMonitoringGame
{
    partial class ActivityInputForm
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
            label1 = new Label();
            dateLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            startComboBox = new ComboBox();
            endComboBox = new ComboBox();
            label4 = new Label();
            categoryComboBox = new ComboBox();
            label5 = new Label();
            contentTextBox = new TextBox();
            setButton = new Button();
            feelingComboBox = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 31);
            label1.TabIndex = 0;
            label1.Text = "活動記録入力";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(41, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(116, 31);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "XX月XX日";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "開始時刻";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 121);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "終了時刻";
            // 
            // startComboBox
            // 
            startComboBox.DropDownHeight = 100;
            startComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            startComboBox.FormattingEnabled = true;
            startComboBox.IntegralHeight = false;
            startComboBox.Items.AddRange(new object[] { "0:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            startComboBox.Location = new Point(163, 66);
            startComboBox.MaxDropDownItems = 5;
            startComboBox.Name = "startComboBox";
            startComboBox.Size = new Size(134, 28);
            startComboBox.TabIndex = 4;
            // 
            // endComboBox
            // 
            endComboBox.DropDownHeight = 100;
            endComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            endComboBox.FormattingEnabled = true;
            endComboBox.IntegralHeight = false;
            endComboBox.Items.AddRange(new object[] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00" });
            endComboBox.Location = new Point(163, 118);
            endComboBox.MaxDropDownItems = 5;
            endComboBox.Name = "endComboBox";
            endComboBox.Size = new Size(134, 28);
            endComboBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 180);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "カテゴリ";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownHeight = 100;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.IntegralHeight = false;
            categoryComboBox.Location = new Point(57, 213);
            categoryComboBox.MaxDropDownItems = 5;
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(240, 28);
            categoryComboBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 264);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "活動内容";
            // 
            // contentTextBox
            // 
            contentTextBox.Location = new Point(57, 298);
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(240, 27);
            contentTextBox.TabIndex = 9;
            // 
            // setButton
            // 
            setButton.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            setButton.Location = new Point(130, 424);
            setButton.Name = "setButton";
            setButton.Size = new Size(101, 36);
            setButton.TabIndex = 10;
            setButton.Text = "記録";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // feelingComboBox
            // 
            feelingComboBox.DropDownHeight = 100;
            feelingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            feelingComboBox.FormattingEnabled = true;
            feelingComboBox.IntegralHeight = false;
            feelingComboBox.Items.AddRange(new object[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            feelingComboBox.Location = new Point(57, 378);
            feelingComboBox.MaxDropDownItems = 5;
            feelingComboBox.Name = "feelingComboBox";
            feelingComboBox.Size = new Size(240, 28);
            feelingComboBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 345);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 11;
            label6.Text = "気分";
            // 
            // ActivityInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 478);
            Controls.Add(feelingComboBox);
            Controls.Add(label6);
            Controls.Add(setButton);
            Controls.Add(contentTextBox);
            Controls.Add(label5);
            Controls.Add(categoryComboBox);
            Controls.Add(label4);
            Controls.Add(endComboBox);
            Controls.Add(startComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ActivityInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "活動記録入力";
            Load += ActivityInputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label dateLabel;
        private Label label2;
        private Label label3;
        private ComboBox startComboBox;
        private ComboBox endComboBox;
        private Label label4;
        private ComboBox categoryComboBox;
        private Label label5;
        private TextBox contentTextBox;
        private Button setButton;
        private ComboBox feelingComboBox;
        private Label label6;
    }
}