namespace SelfMonitoringGame
{
    partial class CategorySetForm
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
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            colorTextBox = new TextBox();
            setButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "カテゴリ名";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(33, 52);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 27);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 29);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 2;
            label2.Text = "色";
            // 
            // colorTextBox
            // 
            colorTextBox.BackColor = SystemColors.Window;
            colorTextBox.Location = new Point(210, 52);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.ReadOnly = true;
            colorTextBox.Size = new Size(69, 27);
            colorTextBox.TabIndex = 3;
            colorTextBox.Click += colorTextBox_Click;
            // 
            // setButton
            // 
            setButton.Location = new Point(108, 108);
            setButton.Name = "setButton";
            setButton.Size = new Size(94, 29);
            setButton.TabIndex = 4;
            setButton.Text = "設定";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // CategorySetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 174);
            Controls.Add(setButton);
            Controls.Add(colorTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CategorySetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "カテゴリ設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox colorTextBox;
        private Button setButton;
    }
}