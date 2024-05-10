namespace SelfMonitoringGame
{
    partial class ActivityDeleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            dateLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            startComboBox = new ComboBox();
            label3 = new Label();
            endComboBox = new ComboBox();
            setButton = new Button();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(41, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(116, 31);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "XX月XX日";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 31);
            label1.TabIndex = 3;
            label1.Text = "活動記録削除";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "開始時刻";
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
            startComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 121);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "終了時刻";
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
            endComboBox.TabIndex = 7;
            // 
            // setButton
            // 
            setButton.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            setButton.Location = new Point(131, 175);
            setButton.Name = "setButton";
            setButton.Size = new Size(101, 36);
            setButton.TabIndex = 11;
            setButton.Text = "削除";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // ActivityDeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 238);
            Controls.Add(setButton);
            Controls.Add(endComboBox);
            Controls.Add(label3);
            Controls.Add(startComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ActivityDeleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "活動記録削除";
            Load += ActivityDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
        private Label label1;
        private Label label2;
        private ComboBox startComboBox;
        private Label label3;
        private ComboBox endComboBox;
        private Button setButton;
    }
}