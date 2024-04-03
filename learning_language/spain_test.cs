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
    public partial class spain_test : Form
    {
        public spain_test()
        {
            InitializeComponent();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы - form2
            spain_first form9 = new spain_first();
            // Скрываем текущую (первую) форму
            this.Hide();
            // Отображаем вторую форму
            form9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void spain_test_Load(object sender, EventArgs e)
        {

        }
    }
}
