using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning_language
{
    public partial class french_test : Form
    {
        public french_test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр первой формы form1
            first_french form6 = new first_french();
            // Закрываем текущую (вторую) форму
            this.Close();
            // Отображаем первую форму
            form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (radioButton1.Checked)
            {
                score++;
            }
            if (radioButton6.Checked)
            {
                score++;
            }
            if (radioButton8.Checked)
            {
                score++;
            }
            if (radioButton11.Checked)
            {
                score++;
            }
            if (radioButton15.Checked)
            {
                score++;
            }
            if (score > 0)
            {
                MessageBox.Show($"Правильных ответов: {score} из 5");
            }
            else
            {
                MessageBox.Show("Выберите варианты ответа");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
