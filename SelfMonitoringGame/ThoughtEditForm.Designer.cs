namespace SelfMonitoringGame
{
    partial class ThoughtEditForm
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
            SuspendLayout();
            // 
            // recordButton
            // 
            recordButton.Click += recordButton_Click;
            // 
            // ThoughtEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 552);
            Name = "ThoughtEditForm";
            Text = "ThoughtEditForm";
            Load += ThoughtEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}