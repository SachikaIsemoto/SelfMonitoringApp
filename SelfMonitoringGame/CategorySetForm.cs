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
    public partial class CategorySetForm : Form
    {
        private bool color_selected = false;

        public CategorySetForm()
        {
            InitializeComponent();
        }

        private void colorTextBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorTextBox.BackColor = colorDialog1.Color;
                color_selected = true;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("カテゴリ名が未設定です。");
                return;
            }

            if (color_selected == false)
            {
                MessageBox.Show("色が未設定です。");
                return;
            }

            List<CategoryRecord> list = new List<CategoryRecord>();
            list = DataControl.GetCategoryRecords();
            foreach (CategoryRecord record in list)
            {
                if (record.Name ==  nameTextBox.Text)
                {
                    MessageBox.Show("既に登録されているカテゴリ名です。");
                    return;
                }
            }

            CategoryRecord categoryRecord = new CategoryRecord();
            categoryRecord.Name = nameTextBox.Text;
            categoryRecord.Color_r = colorTextBox.BackColor.R;
            categoryRecord.Color_g = colorTextBox.BackColor.G;
            categoryRecord.Color_b = colorTextBox.BackColor.B;

            DataControl.AddCategoryRecord(categoryRecord);

            Close();

        }
    }
}
